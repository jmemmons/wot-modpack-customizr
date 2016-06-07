namespace Mod_Pack_Customizr
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contactLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Location = new System.Drawing.Point(187, 93);
            this.licenseTextBox.Multiline = true;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.licenseTextBox.Size = new System.Drawing.Size(398, 127);
            this.licenseTextBox.TabIndex = 1;
            this.licenseTextBox.Text = resources.GetString("licenseTextBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author:  John Emmons, ";
            // 
            // contactLinkLabel
            // 
            this.contactLinkLabel.AutoSize = true;
            this.contactLinkLabel.Location = new System.Drawing.Point(309, 56);
            this.contactLinkLabel.Name = "contactLinkLabel";
            this.contactLinkLabel.Size = new System.Drawing.Size(115, 13);
            this.contactLinkLabel.TabIndex = 3;
            this.contactLinkLabel.TabStop = true;
            this.contactLinkLabel.Text = "johnemmons@acm.org";
            this.contactLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactLinkLabel_LinkClicked);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Mod_Pack_Customizr.Properties.Resources.wot_modpack_customizr_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(164, 172);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(184, 12);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(199, 13);
            this.programNameLabel.TabIndex = 4;
            this.programNameLabel.Text = "Program: WoT Modpack Customizr, v1.0";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(184, 77);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(47, 13);
            this.licenseLabel.TabIndex = 6;
            this.licenseLabel.Text = "License:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(184, 34);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(428, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description: This program supports WoT version 0.9.15 and includes TheManz modpac" +
    "k.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(624, 222);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.contactLinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel contactLinkLabel;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}