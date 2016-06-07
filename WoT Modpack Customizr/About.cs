using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_Pack_Customizr
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        /* Opens the users default mail program to send an email. 
         * TODO: An exception will be thrown on Windows 7 PC's if there is no default email application on their system. Needs to be handled. */
        private void contactLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:johnemmons@acm.org");
        }
    }
}
