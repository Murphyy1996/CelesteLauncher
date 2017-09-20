using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCelesteLauncher
{
    public partial class About : Form
    {
        //Variable containing the main launcher form
        public launcherWindow mainLauncher;

        public About()
        {
            InitializeComponent();
        }

        private void openInstallFolder_Click(object sender, EventArgs e) //When clicked the install folder will be opened
        {
            //Open the current install folder for this launcher
            System.Diagnostics.Process.Start("explorer.exe", Environment.CurrentDirectory);
        }

        private void About_Load(object sender, EventArgs e) //Enable or disable the text box depending on whether lan is enabled
        {
            //Set the default state of the window
            if (mainLauncher.lan == false)
            {
                lanCheckBox.Enabled = true;
                ipTextbox.Enabled = false;
                confirmIPButton.Enabled = false;
            }
            else //If lan is enabled, enable the options
            {
                lanCheckBox.CheckState = CheckState.Checked;
                lanCheckBox.Enabled = true;
                ipTextbox.Enabled = true;
                confirmIPButton.Enabled = true;
                //Show the currently used ip
                ipTextbox.Text = mainLauncher.lanIP;
            }
        }

        private void lanCheckBox_CheckedChanged(object sender, EventArgs e) //Enable or disable the lan variable
        {
            //This code will only be run when the check box is enabled
            if (lanCheckBox.Enabled == true)
            {
                if (mainLauncher.lan == false) //Turn lan on
                {
                    mainLauncher.lan = true;
                    ipTextbox.Enabled = true;
                    ipTextbox.Text = mainLauncher.lanIP;
                    confirmIPButton.Enabled = true;
                    //Update the lan label
                    mainLauncher.CheckLanDetails();
                    //Update the config file
                    mainLauncher.SaveConfigFile();
                }
                else //Turn lan off
                {
                    mainLauncher.lan = false;
                    ipTextbox.Text = mainLauncher.lanIP;
                    ipTextbox.Enabled = false;
                    confirmIPButton.Enabled = false;
                    //Update the lan label
                    mainLauncher.CheckLanDetails();
                    //Update the config file
                    mainLauncher.SaveConfigFile();
                }
            }
        }

        private void confirmIPButton_Click(object sender, EventArgs e) //Set the ip to use
        {
            mainLauncher.lanIP = ipTextbox.Text;
            MessageBox.Show(mainLauncher.lanIP + " has been set as the LAN IP", "LAN IP Set");
            mainLauncher.CheckLanDetails();
            //Update the config file
            mainLauncher.SaveConfigFile();
        }
    }
}
