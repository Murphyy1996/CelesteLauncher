namespace CustomCelesteLauncher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.appName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openInstallFolder = new System.Windows.Forms.Button();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.lanCheckBox = new System.Windows.Forms.CheckBox();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.iplabel = new System.Windows.Forms.Label();
            this.confirmIPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(70, 9);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(301, 17);
            this.appName.TabIndex = 2;
            this.appName.Text = "Age of Empires Online Custom Launcher";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(419, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // openInstallFolder
            // 
            this.openInstallFolder.Location = new System.Drawing.Point(150, 296);
            this.openInstallFolder.Name = "openInstallFolder";
            this.openInstallFolder.Size = new System.Drawing.Size(140, 36);
            this.openInstallFolder.TabIndex = 4;
            this.openInstallFolder.Text = "Open install folder";
            this.toolTipControl.SetToolTip(this.openInstallFolder, "Open the folder this launcher is installed (Hopefully your AOEO directory)\r\n\r\n\r\n");
            this.openInstallFolder.UseVisualStyleBackColor = true;
            this.openInstallFolder.Click += new System.EventHandler(this.openInstallFolder_Click);
            // 
            // lanCheckBox
            // 
            this.lanCheckBox.AutoSize = true;
            this.lanCheckBox.Enabled = false;
            this.lanCheckBox.Location = new System.Drawing.Point(52, 254);
            this.lanCheckBox.Name = "lanCheckBox";
            this.lanCheckBox.Size = new System.Drawing.Size(54, 21);
            this.lanCheckBox.TabIndex = 1;
            this.lanCheckBox.Text = "Lan";
            this.lanCheckBox.UseVisualStyleBackColor = true;
            this.lanCheckBox.CheckedChanged += new System.EventHandler(this.lanCheckBox_CheckedChanged);
            // 
            // ipTextbox
            // 
            this.ipTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ipTextbox.Enabled = false;
            this.ipTextbox.Location = new System.Drawing.Point(147, 254);
            this.ipTextbox.MaxLength = 20;
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(139, 22);
            this.ipTextbox.TabIndex = 2;
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Location = new System.Drawing.Point(117, 255);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(24, 17);
            this.iplabel.TabIndex = 5;
            this.iplabel.Text = "IP:";
            // 
            // confirmIPButton
            // 
            this.confirmIPButton.Enabled = false;
            this.confirmIPButton.Location = new System.Drawing.Point(294, 250);
            this.confirmIPButton.Name = "confirmIPButton";
            this.confirmIPButton.Size = new System.Drawing.Size(96, 29);
            this.confirmIPButton.TabIndex = 3;
            this.confirmIPButton.Text = "Confirm IP";
            this.confirmIPButton.UseVisualStyleBackColor = true;
            this.confirmIPButton.Click += new System.EventHandler(this.confirmIPButton_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 336);
            this.Controls.Add(this.confirmIPButton);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.lanCheckBox);
            this.Controls.Add(this.openInstallFolder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.appName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "Credits and Options";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button openInstallFolder;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.CheckBox lanCheckBox;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Label iplabel;
        private System.Windows.Forms.Button confirmIPButton;
    }
}