namespace Mod_Pack_Customizr
{
    partial class Modpack_InstallerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modpack_InstallerUI));
            this.gamePathLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.gameDirGroupBox = new System.Windows.Forms.GroupBox();
            this.modGroupBox = new System.Windows.Forms.GroupBox();
            this.autoAimCheckbox = new System.Windows.Forms.CheckBox();
            this.gunDirectionCheckbox = new System.Windows.Forms.CheckBox();
            this.autoRepairCheckbox = new System.Windows.Forms.CheckBox();
            this.xvmCheckbox = new System.Windows.Forms.CheckBox();
            this.tundraCheckbox = new System.Windows.Forms.CheckBox();
            this.tracersCheckbox = new System.Windows.Forms.CheckBox();
            this.somethingHitCheckbox = new System.Windows.Forms.CheckBox();
            this.shadowsCheckbox = new System.Windows.Forms.CheckBox();
            this.reloadTimerCheckbox = new System.Windows.Forms.CheckBox();
            this.redBallCheckbox = new System.Windows.Forms.CheckBox();
            this.penetrationCalculatorCheckbox = new System.Windows.Forms.CheckBox();
            this.efficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.directionBoxCheckbox = new System.Windows.Forms.CheckBox();
            this.destroyedObjectsCheckbox = new System.Windows.Forms.CheckBox();
            this.damagePanelCheckbox = new System.Windows.Forms.CheckBox();
            this.battleAssistantCheckbox = new System.Windows.Forms.CheckBox();
            this.allInOneWithoutXVMCheckbox = new System.Windows.Forms.CheckBox();
            this.allInOneCheckbox = new System.Windows.Forms.CheckBox();
            this.installButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallAllModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolstripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gameDirGroupBox.SuspendLayout();
            this.modGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePathLabel
            // 
            this.gamePathLabel.AutoSize = true;
            this.gamePathLabel.Location = new System.Drawing.Point(12, 19);
            this.gamePathLabel.Name = "gamePathLabel";
            this.gamePathLabel.Size = new System.Drawing.Size(63, 13);
            this.gamePathLabel.TabIndex = 0;
            this.gamePathLabel.Text = "Game Path:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(352, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(81, 19);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(259, 20);
            this.fileTextBox.TabIndex = 2;
            // 
            // gameDirGroupBox
            // 
            this.gameDirGroupBox.Controls.Add(this.fileTextBox);
            this.gameDirGroupBox.Controls.Add(this.gamePathLabel);
            this.gameDirGroupBox.Controls.Add(this.browseButton);
            this.gameDirGroupBox.Location = new System.Drawing.Point(20, 36);
            this.gameDirGroupBox.Name = "gameDirGroupBox";
            this.gameDirGroupBox.Size = new System.Drawing.Size(433, 57);
            this.gameDirGroupBox.TabIndex = 3;
            this.gameDirGroupBox.TabStop = false;
            this.gameDirGroupBox.Text = "Step 1. Select Game Directory";
            // 
            // modGroupBox
            // 
            this.modGroupBox.Controls.Add(this.autoAimCheckbox);
            this.modGroupBox.Controls.Add(this.gunDirectionCheckbox);
            this.modGroupBox.Controls.Add(this.autoRepairCheckbox);
            this.modGroupBox.Controls.Add(this.xvmCheckbox);
            this.modGroupBox.Controls.Add(this.tundraCheckbox);
            this.modGroupBox.Controls.Add(this.tracersCheckbox);
            this.modGroupBox.Controls.Add(this.somethingHitCheckbox);
            this.modGroupBox.Controls.Add(this.shadowsCheckbox);
            this.modGroupBox.Controls.Add(this.reloadTimerCheckbox);
            this.modGroupBox.Controls.Add(this.redBallCheckbox);
            this.modGroupBox.Controls.Add(this.penetrationCalculatorCheckbox);
            this.modGroupBox.Controls.Add(this.efficiencyCheckbox);
            this.modGroupBox.Controls.Add(this.directionBoxCheckbox);
            this.modGroupBox.Controls.Add(this.destroyedObjectsCheckbox);
            this.modGroupBox.Controls.Add(this.damagePanelCheckbox);
            this.modGroupBox.Controls.Add(this.battleAssistantCheckbox);
            this.modGroupBox.Controls.Add(this.allInOneWithoutXVMCheckbox);
            this.modGroupBox.Controls.Add(this.allInOneCheckbox);
            this.modGroupBox.Location = new System.Drawing.Point(20, 99);
            this.modGroupBox.Name = "modGroupBox";
            this.modGroupBox.Size = new System.Drawing.Size(433, 231);
            this.modGroupBox.TabIndex = 4;
            this.modGroupBox.TabStop = false;
            this.modGroupBox.Text = "Step 2. Choose Mods";
            // 
            // autoAimCheckbox
            // 
            this.autoAimCheckbox.AutoSize = true;
            this.autoAimCheckbox.Enabled = false;
            this.autoAimCheckbox.Location = new System.Drawing.Point(15, 65);
            this.autoAimCheckbox.Name = "autoAimCheckbox";
            this.autoAimCheckbox.Size = new System.Drawing.Size(125, 17);
            this.autoAimCheckbox.TabIndex = 18;
            this.autoAimCheckbox.Text = "Auto Aim by Sae v22";
            this.modToolTip.SetToolTip(this.autoAimCheckbox, resources.GetString("autoAimCheckbox.ToolTip"));
            this.autoAimCheckbox.UseVisualStyleBackColor = true;
            this.autoAimCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // gunDirectionCheckbox
            // 
            this.gunDirectionCheckbox.AutoSize = true;
            this.gunDirectionCheckbox.Enabled = false;
            this.gunDirectionCheckbox.Location = new System.Drawing.Point(248, 19);
            this.gunDirectionCheckbox.Name = "gunDirectionCheckbox";
            this.gunDirectionCheckbox.Size = new System.Drawing.Size(133, 17);
            this.gunDirectionCheckbox.TabIndex = 17;
            this.gunDirectionCheckbox.Text = "Minimap Gun Direction";
            this.modToolTip.SetToolTip(this.gunDirectionCheckbox, "This mod shows the direction in which the enemies are facing on the minImap.");
            this.gunDirectionCheckbox.UseVisualStyleBackColor = true;
            this.gunDirectionCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // autoRepairCheckbox
            // 
            this.autoRepairCheckbox.AutoSize = true;
            this.autoRepairCheckbox.Enabled = false;
            this.autoRepairCheckbox.Location = new System.Drawing.Point(15, 88);
            this.autoRepairCheckbox.Name = "autoRepairCheckbox";
            this.autoRepairCheckbox.Size = new System.Drawing.Size(208, 17);
            this.autoRepairCheckbox.TabIndex = 16;
            this.autoRepairCheckbox.Text = "Auto Repair and Auto Fire Extinguisher";
            this.modToolTip.SetToolTip(this.autoRepairCheckbox, "The Auto Repair and Auto Fire Extinguisher works by instantly activating the part" +
        "icular kits you have available to you.");
            this.autoRepairCheckbox.UseVisualStyleBackColor = true;
            this.autoRepairCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // xvmCheckbox
            // 
            this.xvmCheckbox.AutoSize = true;
            this.xvmCheckbox.Enabled = false;
            this.xvmCheckbox.Location = new System.Drawing.Point(248, 203);
            this.xvmCheckbox.Name = "xvmCheckbox";
            this.xvmCheckbox.Size = new System.Drawing.Size(73, 17);
            this.xvmCheckbox.TabIndex = 15;
            this.xvmCheckbox.Text = "XVM Mod";
            this.modToolTip.SetToolTip(this.xvmCheckbox, "The XVM mod shows a real time view of the statistics of all the players in the lo" +
        "bby.");
            this.xvmCheckbox.UseVisualStyleBackColor = true;
            this.xvmCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // tundraCheckbox
            // 
            this.tundraCheckbox.AutoSize = true;
            this.tundraCheckbox.Enabled = false;
            this.tundraCheckbox.Location = new System.Drawing.Point(248, 180);
            this.tundraCheckbox.Name = "tundraCheckbox";
            this.tundraCheckbox.Size = new System.Drawing.Size(60, 17);
            this.tundraCheckbox.TabIndex = 13;
            this.tundraCheckbox.Text = "Tundra";
            this.modToolTip.SetToolTip(this.tundraCheckbox, "The Tundra mod removes dense forest and shrubs so that you can see your enemies b" +
        "etter.");
            this.tundraCheckbox.UseVisualStyleBackColor = true;
            this.tundraCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // tracersCheckbox
            // 
            this.tracersCheckbox.AutoSize = true;
            this.tracersCheckbox.Enabled = false;
            this.tracersCheckbox.Location = new System.Drawing.Point(248, 157);
            this.tracersCheckbox.Name = "tracersCheckbox";
            this.tracersCheckbox.Size = new System.Drawing.Size(62, 17);
            this.tracersCheckbox.TabIndex = 12;
            this.tracersCheckbox.Text = "Tracers";
            this.modToolTip.SetToolTip(this.tracersCheckbox, "The Tracers mod allows the user to be able to visually see where the enemy shots " +
        "are originating from.");
            this.tracersCheckbox.UseVisualStyleBackColor = true;
            this.tracersCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // somethingHitCheckbox
            // 
            this.somethingHitCheckbox.AutoSize = true;
            this.somethingHitCheckbox.Enabled = false;
            this.somethingHitCheckbox.Location = new System.Drawing.Point(248, 134);
            this.somethingHitCheckbox.Name = "somethingHitCheckbox";
            this.somethingHitCheckbox.Size = new System.Drawing.Size(117, 17);
            this.somethingHitCheckbox.TabIndex = 11;
            this.somethingHitCheckbox.Text = "Something Was Hit";
            this.modToolTip.SetToolTip(this.somethingHitCheckbox, "This mod gives the user a text-based display when they hit a tank that they can n" +
        "o longer see.");
            this.somethingHitCheckbox.UseVisualStyleBackColor = true;
            this.somethingHitCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // shadowsCheckbox
            // 
            this.shadowsCheckbox.AutoSize = true;
            this.shadowsCheckbox.Enabled = false;
            this.shadowsCheckbox.Location = new System.Drawing.Point(248, 111);
            this.shadowsCheckbox.Name = "shadowsCheckbox";
            this.shadowsCheckbox.Size = new System.Drawing.Size(70, 17);
            this.shadowsCheckbox.TabIndex = 10;
            this.shadowsCheckbox.Text = "Shadows";
            this.modToolTip.SetToolTip(this.shadowsCheckbox, "The Shadows mod allows the user to see the last known location of the enemy.");
            this.shadowsCheckbox.UseVisualStyleBackColor = true;
            this.shadowsCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // reloadTimerCheckbox
            // 
            this.reloadTimerCheckbox.AutoSize = true;
            this.reloadTimerCheckbox.Enabled = false;
            this.reloadTimerCheckbox.Location = new System.Drawing.Point(248, 88);
            this.reloadTimerCheckbox.Name = "reloadTimerCheckbox";
            this.reloadTimerCheckbox.Size = new System.Drawing.Size(89, 17);
            this.reloadTimerCheckbox.TabIndex = 9;
            this.reloadTimerCheckbox.Text = "Reload Timer";
            this.modToolTip.SetToolTip(this.reloadTimerCheckbox, "The Reload Timer shows the user the current reload time for all players in the ga" +
        "me.");
            this.reloadTimerCheckbox.UseVisualStyleBackColor = true;
            this.reloadTimerCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // redBallCheckbox
            // 
            this.redBallCheckbox.AutoSize = true;
            this.redBallCheckbox.Enabled = false;
            this.redBallCheckbox.Location = new System.Drawing.Point(248, 65);
            this.redBallCheckbox.Name = "redBallCheckbox";
            this.redBallCheckbox.Size = new System.Drawing.Size(66, 17);
            this.redBallCheckbox.TabIndex = 8;
            this.redBallCheckbox.Text = "Red Ball";
            this.modToolTip.SetToolTip(this.redBallCheckbox, "The Red Ball mod is another wonderful mod for artillery players. When this mod is" +
        " activated, it shows a red ball on the current enemy location after their camouf" +
        "lage has activated.");
            this.redBallCheckbox.UseVisualStyleBackColor = true;
            this.redBallCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // penetrationCalculatorCheckbox
            // 
            this.penetrationCalculatorCheckbox.AutoSize = true;
            this.penetrationCalculatorCheckbox.Enabled = false;
            this.penetrationCalculatorCheckbox.Location = new System.Drawing.Point(248, 42);
            this.penetrationCalculatorCheckbox.Name = "penetrationCalculatorCheckbox";
            this.penetrationCalculatorCheckbox.Size = new System.Drawing.Size(130, 17);
            this.penetrationCalculatorCheckbox.TabIndex = 7;
            this.penetrationCalculatorCheckbox.Text = "Penetration Calculator";
            this.modToolTip.SetToolTip(this.penetrationCalculatorCheckbox, "This mod gives the user a number based on where they are aiming. This number can " +
        "be used to decide if a particular shot will be effective or not.");
            this.penetrationCalculatorCheckbox.UseVisualStyleBackColor = true;
            this.penetrationCalculatorCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // efficiencyCheckbox
            // 
            this.efficiencyCheckbox.AutoSize = true;
            this.efficiencyCheckbox.Enabled = false;
            this.efficiencyCheckbox.Location = new System.Drawing.Point(15, 203);
            this.efficiencyCheckbox.Name = "efficiencyCheckbox";
            this.efficiencyCheckbox.Size = new System.Drawing.Size(172, 17);
            this.efficiencyCheckbox.TabIndex = 6;
            this.efficiencyCheckbox.Text = "Efficiency And WN8 Calculator";
            this.modToolTip.SetToolTip(this.efficiencyCheckbox, "This mod gives the user a panel during gameplay to see their current Efficiency r" +
        "ating as well as their WN8 score for every match.");
            this.efficiencyCheckbox.UseVisualStyleBackColor = true;
            this.efficiencyCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // directionBoxCheckbox
            // 
            this.directionBoxCheckbox.AutoSize = true;
            this.directionBoxCheckbox.Enabled = false;
            this.directionBoxCheckbox.Location = new System.Drawing.Point(15, 180);
            this.directionBoxCheckbox.Name = "directionBoxCheckbox";
            this.directionBoxCheckbox.Size = new System.Drawing.Size(89, 17);
            this.directionBoxCheckbox.TabIndex = 5;
            this.directionBoxCheckbox.Text = "Direction Box";
            this.modToolTip.SetToolTip(this.directionBoxCheckbox, resources.GetString("directionBoxCheckbox.ToolTip"));
            this.directionBoxCheckbox.UseVisualStyleBackColor = true;
            this.directionBoxCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // destroyedObjectsCheckbox
            // 
            this.destroyedObjectsCheckbox.AutoSize = true;
            this.destroyedObjectsCheckbox.Enabled = false;
            this.destroyedObjectsCheckbox.Location = new System.Drawing.Point(15, 157);
            this.destroyedObjectsCheckbox.Name = "destroyedObjectsCheckbox";
            this.destroyedObjectsCheckbox.Size = new System.Drawing.Size(172, 17);
            this.destroyedObjectsCheckbox.TabIndex = 4;
            this.destroyedObjectsCheckbox.Text = "Destroyed Objects On Minimap";
            this.modToolTip.SetToolTip(this.destroyedObjectsCheckbox, "This mod shows the user where all of the destroyed enemies and friendlies are on " +
        "the minimap and in-game.");
            this.destroyedObjectsCheckbox.UseVisualStyleBackColor = true;
            this.destroyedObjectsCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // damagePanelCheckbox
            // 
            this.damagePanelCheckbox.AutoSize = true;
            this.damagePanelCheckbox.Enabled = false;
            this.damagePanelCheckbox.Location = new System.Drawing.Point(15, 134);
            this.damagePanelCheckbox.Name = "damagePanelCheckbox";
            this.damagePanelCheckbox.Size = new System.Drawing.Size(161, 17);
            this.damagePanelCheckbox.TabIndex = 3;
            this.damagePanelCheckbox.Text = "Damage Panel + XVM Hitlog";
            this.modToolTip.SetToolTip(this.damagePanelCheckbox, "This mod shows a panel during gameplay that records the shots you have taken as w" +
        "ell as the shots you have made.");
            this.damagePanelCheckbox.UseVisualStyleBackColor = true;
            this.damagePanelCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // battleAssistantCheckbox
            // 
            this.battleAssistantCheckbox.AutoSize = true;
            this.battleAssistantCheckbox.Enabled = false;
            this.battleAssistantCheckbox.Location = new System.Drawing.Point(15, 111);
            this.battleAssistantCheckbox.Name = "battleAssistantCheckbox";
            this.battleAssistantCheckbox.Size = new System.Drawing.Size(98, 17);
            this.battleAssistantCheckbox.TabIndex = 2;
            this.battleAssistantCheckbox.Text = "Battle Assistant";
            this.modToolTip.SetToolTip(this.battleAssistantCheckbox, "The Battle Assistant mod is especially good for artillery.  This mod gives the us" +
        "er an angled view rather than a top-down view which helps with\r\nplacing shots ov" +
        "er buildings and rocks.");
            this.battleAssistantCheckbox.UseVisualStyleBackColor = true;
            this.battleAssistantCheckbox.CheckedChanged += new System.EventHandler(this.handleChecked);
            // 
            // allInOneWithoutXVMCheckbox
            // 
            this.allInOneWithoutXVMCheckbox.AutoSize = true;
            this.allInOneWithoutXVMCheckbox.Enabled = false;
            this.allInOneWithoutXVMCheckbox.Location = new System.Drawing.Point(15, 42);
            this.allInOneWithoutXVMCheckbox.Name = "allInOneWithoutXVMCheckbox";
            this.allInOneWithoutXVMCheckbox.Size = new System.Drawing.Size(140, 17);
            this.allInOneWithoutXVMCheckbox.TabIndex = 1;
            this.allInOneWithoutXVMCheckbox.Text = "All in One - without XVM";
            this.modToolTip.SetToolTip(this.allInOneWithoutXVMCheckbox, "The All in One mod contains every mod listed here, excluding XVM.");
            this.allInOneWithoutXVMCheckbox.UseVisualStyleBackColor = true;
            this.allInOneWithoutXVMCheckbox.CheckedChanged += new System.EventHandler(this.allInOneWithoutXVMCheckbox_CheckedChanged);
            // 
            // allInOneCheckbox
            // 
            this.allInOneCheckbox.AutoSize = true;
            this.allInOneCheckbox.Enabled = false;
            this.allInOneCheckbox.Location = new System.Drawing.Point(15, 19);
            this.allInOneCheckbox.Name = "allInOneCheckbox";
            this.allInOneCheckbox.Size = new System.Drawing.Size(125, 17);
            this.allInOneCheckbox.TabIndex = 0;
            this.allInOneCheckbox.Text = "All in One - with XVM";
            this.modToolTip.SetToolTip(this.allInOneCheckbox, "The All in One mod contains every mod listed here, including XVM.");
            this.allInOneCheckbox.UseVisualStyleBackColor = true;
            this.allInOneCheckbox.CheckedChanged += new System.EventHandler(this.allInOneCheckbox_CheckedChanged);
            // 
            // installButton
            // 
            this.installButton.Enabled = false;
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.installButton.Location = new System.Drawing.Point(131, 19);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(161, 64);
            this.installButton.TabIndex = 5;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.installButton);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(20, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 96);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 3. Install";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uninstallAllModsToolStripMenuItem,
            this.aboutToolstripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uninstallAllModsToolStripMenuItem
            // 
            this.uninstallAllModsToolStripMenuItem.Name = "uninstallAllModsToolStripMenuItem";
            this.uninstallAllModsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.uninstallAllModsToolStripMenuItem.Text = "Uninstall All Mods";
            this.uninstallAllModsToolStripMenuItem.Click += new System.EventHandler(this.uninstallAllModsToolStripMenuItem_Click);
            // 
            // aboutToolstripMenuItem
            // 
            this.aboutToolstripMenuItem.Name = "aboutToolstripMenuItem";
            this.aboutToolstripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolstripMenuItem.Text = "About";
            this.aboutToolstripMenuItem.Click += new System.EventHandler(this.aboutToolstripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Modpack_InstallerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modGroupBox);
            this.Controls.Add(this.gameDirGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Modpack_InstallerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoT Modpack Customizr - for WoT 9.15.0.1";
            this.gameDirGroupBox.ResumeLayout(false);
            this.gameDirGroupBox.PerformLayout();
            this.modGroupBox.ResumeLayout(false);
            this.modGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gamePathLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.GroupBox gameDirGroupBox;
        private System.Windows.Forms.GroupBox modGroupBox;
        private System.Windows.Forms.CheckBox gunDirectionCheckbox;
        private System.Windows.Forms.CheckBox autoRepairCheckbox;
        private System.Windows.Forms.CheckBox xvmCheckbox;
        private System.Windows.Forms.CheckBox tundraCheckbox;
        private System.Windows.Forms.CheckBox tracersCheckbox;
        private System.Windows.Forms.CheckBox somethingHitCheckbox;
        private System.Windows.Forms.CheckBox shadowsCheckbox;
        private System.Windows.Forms.CheckBox reloadTimerCheckbox;
        private System.Windows.Forms.CheckBox redBallCheckbox;
        private System.Windows.Forms.CheckBox penetrationCalculatorCheckbox;
        private System.Windows.Forms.CheckBox efficiencyCheckbox;
        private System.Windows.Forms.CheckBox directionBoxCheckbox;
        private System.Windows.Forms.CheckBox destroyedObjectsCheckbox;
        private System.Windows.Forms.CheckBox damagePanelCheckbox;
        private System.Windows.Forms.CheckBox battleAssistantCheckbox;
        private System.Windows.Forms.CheckBox allInOneWithoutXVMCheckbox;
        private System.Windows.Forms.CheckBox allInOneCheckbox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox autoAimCheckbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolstripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallAllModsToolStripMenuItem;
        private System.Windows.Forms.ToolTip modToolTip;
    }
}

