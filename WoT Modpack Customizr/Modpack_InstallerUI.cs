/*
 * Program:     Modpack Installer
 * Description: This program installs modifications, or "mods" for Wargaming's most popular game, World of Tanks. This installer is essentially 
 *              a "copy and paste" executable. Many users have expressed fustration with the installation of mods so I have created an easier way
 *              to do this.
 *
 * Version:     v1.0
 * Notes:       This pack supports World of Tanks version 0.9.15. The modpack that is installed is "the manz modpack 4.0".
 *
 * Programmer(s)/Contributors:  John Emmons, johnemmons@acm.org
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Mod_Pack_Customizr
{
    public partial class Modpack_InstallerUI : Form
    {
        // Global Variables used throughout program.
        public string selectedPath = null;
        private About aboutForm;
        private BusyWindow busyWindow;

        public Modpack_InstallerUI()
        {
            InitializeComponent();
        }


        // This method is the event handler for when the Browse button is clicked. It's main purpose is to allow the user to select the directory they want the mods installed to.
        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the game directory where World of Tanks is located. \n i.e. C:\\Games\\World of Tanks";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowser.SelectedPath;
                fileTextBox.AppendText(selectedPath);
                enableAllCheckboxes();
            }
            
        }


        // This method enables the install button if one or more mods are selected. All checkboxes use this event handler with the exception of the All in One packs.
        private void handleChecked(object sender, EventArgs e)
        {
            // At least one checkbox is checked.
            if (modGroupBox.Controls.OfType<CheckBox>().Any(x => x.Checked))
            {
                installButton.Enabled = true;
            }
            else
            {
                installButton.Enabled = false;
            }
        }


        // This method loops through all the checkboxes and enables them based on some criteria. If a user selects the All in One mod, it's important
        // that we disable all of the other choices to keep from possible crashes. All checkboxes are disabled by default at program runtime so they need
        // to be enabled.
        private void enableAllCheckboxes()
        {
            foreach (var x in modGroupBox.Controls)
            {
                var checkbox = x as CheckBox;

                if ((checkbox.Checked == true) && (checkbox.TabIndex == 0))
                    continue;

                if ((checkbox.Checked == true) && (checkbox.TabIndex == 1))
                {
                    allInOneCheckbox.Enabled = true;
                    continue;
                }

                checkbox.Enabled = true;
            }
        }


        // This method loops through all the checkboxes and disables them based on some criteria. If a user selects the All in One mod, it's important
        // that we disable all of the other choices to keep from possible crashes. All checkboxes are already disabled at program runtime.
        private void disableAllCheckboxes()
        {
            foreach (var x in modGroupBox.Controls)
            {
                var checkbox = x as CheckBox;

                // If "All in One - with XVM" is checked, skip this iteration.
                if ((checkbox.Checked == true) && (checkbox.TabIndex == 0))
                    continue;

                // If "All in One - without XVM" is checked, disable other All in One mod and continue to the next checkbox.
                if ((checkbox.Checked == true) && (checkbox.TabIndex == 1))
                {
                    allInOneCheckbox.Enabled = false;
                    continue;
                }

                checkbox.Enabled = false;
            }
        }


        // This method loops through all the checkboxes and unchecks all of them. This operation is run after the installation is finished.
        private void uncheckAllBoxes()
        {
            foreach (var x in modGroupBox.Controls)
            {
                var checkbox = x as CheckBox;
                if (checkbox.Checked)
                    checkbox.Checked = false;
            }
        }


        // This method disables all other mods from being selected since the All In One essentially contains all of the other mods.
        private void allInOneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (allInOneCheckbox.Checked)
            {
                disableAllCheckboxes();
                installButton.Enabled = true;
            }
            else
            {
                enableAllCheckboxes();
                installButton.Enabled = false;
            }
        }


        // This method disables the ability to check other boxes when this item is selected.
        private void allInOneWithoutXVMCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (allInOneWithoutXVMCheckbox.Checked)
            {
                disableAllCheckboxes();
                installButton.Enabled = true;
            }
            else
            {
                enableAllCheckboxes();
                installButton.Enabled = false;
            }
        }


        // Loops through all the checkboxes in modGroupBox and returns a string for each result that is checked. This is used in the DialogBox when the user clicks Install.
        private string selectedModStrings()
        {
            string str = "";
            foreach (Control c in modGroupBox.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    str += c.Text + "\n";
                }
            }
            return str + "\n";
        }


        // This method gets all the selected mods and creates a path for each one so that it can later be used to copy folders and subdirectories.
        public List<string> getSelectedMods()
        {
            List<string> modList = new List<string>();
            foreach (Control c in modGroupBox.Controls)
            {
                // Creates path names based on selected mods and adds it to the list.
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                {
                    modList.Add(Application.StartupPath + "\\" + c.Text);
                }
            }
            return modList;
        }


        // This method is called when installing and uninstalling mods. It deletes all data in the res_mods folder to ensure that it won't have peices left over from a previous mod install.
        private void deleteAllFiles(string pathToDelete)
        {
            System.IO.DirectoryInfo directoryInfo = new DirectoryInfo(pathToDelete);
            
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }


        // Once the background worker is finished, this method is called.
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Install Completed!");
                busyWindow.Dispose();
                uncheckAllBoxes();
            }
        }


        // This is the method that is where the installation is triggered. It creates a constructor the Install and sends it the necessary parameters to begin the installation.
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Install installMod = new Install();

            // Install class requires two parameters to install mod. Argument 1 = path of selected mods. Argument 2 = path of game directory.
            List<object> argumentList = e.Argument as List<object>;
            List<string> argument1 = (List<string>)argumentList[0];
            string argument2 = (string)argumentList[1];

            // Starts the installation process.
            installMod.startInstall(argument1, argument2);
        }


        // This is the event handler for when the user chooses to install the mods.
        private void installButton_Click(object sender, EventArgs e)
        {
            // Show the user which mods they selected and where it will be installed so they can decide if they want to continue.
            string messageBoxText = "The Mods you have selected:\n\n" + selectedModStrings() +
                "Now going to install the mods in the \"" + selectedPath + "\" directory. Do you want to continue?";
            DialogResult result = MessageBox.Show(messageBoxText, "Mod Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Set up background worker object and connect handlers.
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);

                // Since a BackgroundWorker only takes 1 parameter and our Install function requires 2, I have placed both parameters into a List object.
                // The DoWork method will extract the two arguments when RunWorkerAsync is called.
                List<object> arguments = new List<object>();
                arguments.Add(getSelectedMods());
                arguments.Add(selectedPath);

                // Launch background thread.
                bgWorker.RunWorkerAsync(arguments);
            }

            // Show the user that something is happening. The RunWorkerCompleted method will dispose this window when the installation is complete.
            busyWindow = new BusyWindow();
            busyWindow.ShowDialog();
        }


        // This method uninstalls all previous mods in the res_mods folder.
        private void uninstallAllModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Must have a game path selected.
            if (selectedPath == null)
            {
                string message = "Please select your World Of Tanks game directory.";
                DialogResult uninstallDialog = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Start the uninstall of mods.
            else
            {
                // Make sure this really is the correct folder.
                if (ContainsResModsFolder())
                {
                    string pathToDelete = selectedPath + "\\res_mods";
                    Console.WriteLine(pathToDelete);
                    deleteAllFiles(pathToDelete);

                    // TODO: Let the user know something actually happened.
                    //busyWindow = new BusyWindow();
                    //busyWindow.ShowDialog();
                }
            }
        }


        // Returns true if the selected directory is the actual World Of Tanks directory.
        private bool ContainsResModsFolder()
        {
            DirectoryInfo gamePath = new DirectoryInfo(selectedPath);
            DirectoryInfo[] test = gamePath.GetDirectories();
            if (test.Any(r => r.FullName.Equals(Path.Combine(gamePath.FullName, "res_mods"))))
            {
                return true;
            }
            return false;
        }


        // Exits the application when clicked.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Opens the About form which contains basic information about the program.
        private void aboutToolstripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.Show();
        }
    }
}
