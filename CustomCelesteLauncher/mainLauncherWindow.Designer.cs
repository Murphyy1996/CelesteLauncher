namespace CustomCelesteLauncher
{
    partial class launcherWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(launcherWindow));
            this.playimage = new System.Windows.Forms.PictureBox();
            this.forgetme = new System.Windows.Forms.PictureBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.celestewebsite = new System.Windows.Forms.PictureBox();
            this.updatebutton = new System.Windows.Forms.PictureBox();
            this.creditsButton = new System.Windows.Forms.PictureBox();
            this.versionNumber = new System.Windows.Forms.Label();
            this.label_lan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgetme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celestewebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // playimage
            // 
            this.playimage.BackColor = System.Drawing.Color.Transparent;
            this.playimage.BackgroundImage = global::CustomCelesteLauncher.Properties.Resources.playbutton;
            this.playimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playimage.Location = new System.Drawing.Point(178, 551);
            this.playimage.Name = "playimage";
            this.playimage.Size = new System.Drawing.Size(206, 49);
            this.playimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playimage.TabIndex = 0;
            this.playimage.TabStop = false;
            this.tooltip.SetToolTip(this.playimage, "Play Age of Empires Online!");
            this.playimage.Click += new System.EventHandler(this.playimage_Click);
            this.playimage.MouseEnter += new System.EventHandler(this.playimage_MouseEnter);
            this.playimage.MouseLeave += new System.EventHandler(this.playimage_MouseLeave);
            // 
            // forgetme
            // 
            this.forgetme.BackColor = System.Drawing.Color.Transparent;
            this.forgetme.BackgroundImage = global::CustomCelesteLauncher.Properties.Resources.forgetme;
            this.forgetme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgetme.Location = new System.Drawing.Point(484, 545);
            this.forgetme.Name = "forgetme";
            this.forgetme.Size = new System.Drawing.Size(56, 55);
            this.forgetme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forgetme.TabIndex = 1;
            this.forgetme.TabStop = false;
            this.tooltip.SetToolTip(this.forgetme, "Forget login details");
            this.forgetme.Visible = false;
            this.forgetme.Click += new System.EventHandler(this.forgetme_Click);
            this.forgetme.MouseEnter += new System.EventHandler(this.forgetme_MouseEnter);
            this.forgetme.MouseLeave += new System.EventHandler(this.forgetme_MouseLeave);
            // 
            // celestewebsite
            // 
            this.celestewebsite.BackColor = System.Drawing.Color.Transparent;
            this.celestewebsite.BackgroundImage = global::CustomCelesteLauncher.Properties.Resources.celestewebsite;
            this.celestewebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.celestewebsite.Location = new System.Drawing.Point(-1, 0);
            this.celestewebsite.Name = "celestewebsite";
            this.celestewebsite.Size = new System.Drawing.Size(56, 55);
            this.celestewebsite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.celestewebsite.TabIndex = 2;
            this.celestewebsite.TabStop = false;
            this.tooltip.SetToolTip(this.celestewebsite, "Open the Project Celeste website in the default web browser");
            this.celestewebsite.Click += new System.EventHandler(this.celestewebsite_Click);
            this.celestewebsite.MouseEnter += new System.EventHandler(this.celestewebsite_MouseEnter);
            this.celestewebsite.MouseLeave += new System.EventHandler(this.celestewebsite_MouseLeave);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.updatebutton.BackgroundImage = global::CustomCelesteLauncher.Properties.Resources.updatebutotn;
            this.updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatebutton.Location = new System.Drawing.Point(70, 0);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(56, 55);
            this.updatebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatebutton.TabIndex = 3;
            this.updatebutton.TabStop = false;
            this.tooltip.SetToolTip(this.updatebutton, "Download and Install the latest version of Project Celeste");
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            this.updatebutton.MouseEnter += new System.EventHandler(this.updatebutton_MouseEnter);
            this.updatebutton.MouseLeave += new System.EventHandler(this.updatebutton_MouseLeave);
            // 
            // creditsButton
            // 
            this.creditsButton.BackColor = System.Drawing.Color.Transparent;
            this.creditsButton.BackgroundImage = global::CustomCelesteLauncher.Properties.Resources.creditbutton;
            this.creditsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.creditsButton.Location = new System.Drawing.Point(487, 0);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(56, 55);
            this.creditsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creditsButton.TabIndex = 4;
            this.creditsButton.TabStop = false;
            this.tooltip.SetToolTip(this.creditsButton, "Credits and Options");
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            this.creditsButton.MouseEnter += new System.EventHandler(this.creditsButton_MouseEnter);
            this.creditsButton.MouseLeave += new System.EventHandler(this.creditsButton_MouseLeave);
            // 
            // versionNumber
            // 
            this.versionNumber.AutoSize = true;
            this.versionNumber.BackColor = System.Drawing.Color.Transparent;
            this.versionNumber.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNumber.ForeColor = System.Drawing.Color.White;
            this.versionNumber.Location = new System.Drawing.Point(223, 4);
            this.versionNumber.Name = "versionNumber";
            this.versionNumber.Size = new System.Drawing.Size(94, 29);
            this.versionNumber.TabIndex = 5;
            this.versionNumber.Text = "V1.490";
            this.versionNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tooltip.SetToolTip(this.versionNumber, "Project Celeste version number. If there is a \'-\' Celeste is not installed.\r\n");
            // 
            // label_lan
            // 
            this.label_lan.AutoSize = true;
            this.label_lan.BackColor = System.Drawing.Color.Transparent;
            this.label_lan.Font = new System.Drawing.Font("Maiandra GD", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lan.ForeColor = System.Drawing.Color.Black;
            this.label_lan.Location = new System.Drawing.Point(12, 562);
            this.label_lan.Name = "label_lan";
            this.label_lan.Size = new System.Drawing.Size(131, 27);
            this.label_lan.TabIndex = 6;
            this.label_lan.Text = "LAN Mode";
            this.tooltip.SetToolTip(this.label_lan, "LAN is being used for Project Celeste");
            this.label_lan.Visible = false;
            // 
            // launcherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CustomCelesteLauncher.Properties.Resources.launcherBackgroundv2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 607);
            this.Controls.Add(this.label_lan);
            this.Controls.Add(this.versionNumber);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.celestewebsite);
            this.Controls.Add(this.forgetme);
            this.Controls.Add(this.playimage);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "launcherWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age of Empires Online Launcher";
            this.Load += new System.EventHandler(this.launcherWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgetme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celestewebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playimage;
        private System.Windows.Forms.PictureBox forgetme;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.PictureBox celestewebsite;
        private System.Windows.Forms.PictureBox updatebutton;
        private System.Windows.Forms.PictureBox creditsButton;
        private System.Windows.Forms.Label versionNumber;
        private System.Windows.Forms.Label label_lan;
    }
}

