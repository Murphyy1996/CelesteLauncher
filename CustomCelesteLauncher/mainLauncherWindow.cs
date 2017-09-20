using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;

namespace CustomCelesteLauncher
{
    public partial class launcherWindow : Form
    {
        //Variables
        public string email = "default@email.com", password = "password", lanIP = "192.168.1.1";
        private string loginDetailsDirectory = Environment.CurrentDirectory + @"\launcherDetails.txt", celesteDirectory = Environment.CurrentDirectory + @"\Celeste_Launcher_Gui.exe";
        public bool loggedIn = false, lan;
        //Variables for tracking if various windows are open (Stops duplicates)
        public installCeleste installCeleste;
        private About credits;
        private Login login;

        //Methods are below

        public launcherWindow()
        {
            InitializeComponent();
        }

        private void launcherWindow_Load(object sender, EventArgs e) //This code will run on start
        {
            //Load existing details
            GetExistingDetails();

            //Let the player know whether LAN is being used or not
            CheckLanDetails();

            //Get the version number of celeste
            if (File.Exists(celesteDirectory))
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(celesteDirectory);
                string version = versionInfo.ProductVersion;
                versionNumber.Text = version;
                CheckForCelesteUpdates(version);
            }
            else //Open up the dialog about installing the game if celeste is not installed
            {
                versionNumber.Text = "    -";
                //Let the user know the game needs updating
                MessageBox.Show("Project Celeste is not installed, press 'Ok' to install the latest version", "Project Celeste not installed");
                //Open the update screen
                UpdateCelesteCode();
            }
        }

        private void CheckForCelesteUpdates(string currentVersion) //Check for updates for the latest version of Project Celeste
        {
            //Check if connected to the internet before attempting updates
            Ping myPing = new Ping();
            String host = "8.8.8.8";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            //If the user is connect to the internet compare version numbers and check for updates
            if (reply.Status == IPStatus.Success)
            {
                //Download the version text file
                WebClient Client = new WebClient();
                Client.DownloadFile("https://goo.gl/z5j6vg", Environment.CurrentDirectory + @"\latestversion.txt");

                //Read text file and get the latest version number
                string latestVersion = File.ReadLines(Environment.CurrentDirectory + @"\latestversion.txt").Skip(0).Take(1).First();

                //Make versions so that they can be compared
                var version1 = new Version(currentVersion);
                var version2 = new Version(latestVersion);

                //Perform the actual comparison and reduce it into a result (0 = Both values are the same, 1 = v1 is bigger, -1 v2 is bigger)
                var result = version1.CompareTo(version2);

                //If the result value is one it means the game needs updating
                if (result == -1)
                {
                    //Let the user know the game needs updating
                    MessageBox.Show("Project Celeste is out of date, press 'Ok' to update now", "Update required!");
                    //Open the update screen
                    UpdateCelesteCode();
                }
            }
        }

        public void CheckLanDetails() //Check whether lan is enabled and tell the player
        {
            if (lan == true)
            {
                label_lan.Visible = true;
            }
            else
            {
                label_lan.Visible = false;
            }
        }

        public void SaveConfigFile() //When run this will save the email and password to a config file so the user will not have to login in the future
        {
            //Delete existing config file
            if (File.Exists(loginDetailsDirectory))
            {
                File.Delete(loginDetailsDirectory);
            }
            //Create the config file
            using (FileStream fs = File.Create(loginDetailsDirectory)) ;

            //Work out whether lan is enabled and send the options to the config file
            string lanEnabled;
            if (lan == true)
            {
                lanEnabled = "lan=true";
            }
            else
            {
                lanEnabled = "lan=false";
            }

            //Save the details to the config file so future logins don't need the user name or password
            string[] lines = { email, password, lanEnabled, lanIP.ToString() };
            //This line will actuallly write the code down
            File.WriteAllLines(loginDetailsDirectory, lines);

        }

        private void GetExistingDetails() //Will get existing details from the save config file if it exists and check the details are valid
        {
            //Check if the login details are already saved
            if (File.Exists(loginDetailsDirectory))
            {
                //Load the user name, password and lan settings
                try
                {
                    email = File.ReadLines(loginDetailsDirectory).Skip(0).Take(1).First();
                    password = File.ReadLines(loginDetailsDirectory).Skip(1).Take(1).First();
                    string lanValue = File.ReadLines(loginDetailsDirectory).Skip(2).Take(1).First();
                    if (lanValue == "lan=true")
                    {
                        lan = true;
                    }
                    else
                    {
                        lan = false;
                    }
                    lanIP = File.ReadLines(loginDetailsDirectory).Skip(3).Take(1).First();
                    forgetme.Visible = true;
                    loggedIn = true;
                }
                catch
                {
                    MessageBox.Show("Error reading config file!", "Error!");
                }
            }
        }

        private void playimage_Click(object sender, EventArgs e)
        {
            //Notify the user if project celeste is installed or not
            if (!File.Exists(celesteDirectory))
            {
                MessageBox.Show("Project Celeste is not installed! Click 'Ok' to install the latest version", "Project Celeste is not installed!");
                UpdateCelesteCode();
            }
            else //If celeste is already installed, then do proceed as normal
            {
                //If the email and password are still default, then ask the user to login, save details for next time in a config file
                if (loggedIn == false)
                {
                    if (login != null)
                    {
                        login.Close();
                    }
                    //Open up the login form
                    login = new Login();
                    login.mainLauncher = this;
                    login.Owner = this;
                    login.StartPosition = FormStartPosition.CenterScreen;
                    login.Show();
                }
                //Run the rest of the play game code
                PlayGame();
            }

        } //Will allow the user to login and play the game if succesfully logged in

        public void PlayGame() //This is a method that can be called from other forms
        {
            //Don't allow the launcher to play the game if the login details are incorrectly entered / on defaults
            if (email == "default@email.com" && loggedIn == true || email == "" && loggedIn == true)
            {
                MessageBox.Show("Invalid Project Celeste user name and password");
                loggedIn = false;
            }
            else if (loggedIn == true) //In this else is the code that actually launches the game
            {
                //Save the user details in a configuration file
                SaveConfigFile();

                //Start aoe online with logon information required for project celeste to work
                try
                {
                    if (lan == false)
                    {
                        //This will launch project spartan.exe with the correct aguements to sign into the project celeste server
                        System.Diagnostics.Process.Start("Spartan.exe", "--email \"" + email + "\" --password \"" + password + "\"");
                    }
                    else
                    {
                        //This helps break it down else the syntax looks a mess
                        string launcherLanguage = "LauncherLang=en-US";
                        string launcherLocale = "LauncherLocale=1033";
                        //string lanString = "--online-ip " + lanIP + " -–ignore_rest \"" + launcherLanguage + "\" \"" + launcherLocale + "\"";
                        string lanString = "--online-ip " + lanIP;
                        //This will launch project spartan.exe with the correct aguements to sign into a lan server
                        System.Diagnostics.Process.Start("Spartan.exe", "--email \"" + email + "\" --password \"" + password + "\" " + lanString);
                    }


                    //Quit the launcher when the game starts succesfully
                    Application.Exit();
                }
                catch //If there is in an error show a text pop up
                {
                    MessageBox.Show("Failed to launch: Please make sure this launcher is in your Age of Empires Online directory");
                    //Enable the forget me button even if an error is shown
                    forgetme.Visible = true;
                }
            }
        }

        private void forgetme_Click(object sender, EventArgs e)
        {
            //Delete existing config file
            if (File.Exists(loginDetailsDirectory))
            {
                File.Delete(loginDetailsDirectory);
            }
            email = "";
            password = "";
            forgetme.Visible = false;
            loggedIn = false;
        } //Will forget the login details

        private void celestewebsite_Click(object sender, EventArgs e) //Clicking this will open the celeste website
        {
            System.Diagnostics.Process.Start("http://www.projectceleste.com");
        }

        private void updatebutton_Click(object sender, EventArgs e) //Will download and install the latest version of project celeste
        {
            MessageBox.Show("The latest version of Project Celeste will now be downloaded and installed");
            UpdateCelesteCode();
        }

        public void UpdateCelesteCode() //Will download the latest version of Project Celeste
        {
            if (installCeleste == null)
            {
                //Delete any download .zip folders for Project Celeste that have been downloaded in previous updates
                if (File.Exists(Environment.CurrentDirectory + @"\Celeste_Launcher_Gui.zip"))
                {
                    File.Delete(Environment.CurrentDirectory + @"\Celeste_Launcher_Gui.zip");
                }

                //Start the Project Celeste download by opening the celeste download form
                installCeleste = new installCeleste();
                installCeleste.mainLauncher = this;
                installCeleste.Owner = this;
                installCeleste.StartPosition = FormStartPosition.CenterScreen;
                installCeleste.Show();
            }
        }

        private void creditsButton_Click(object sender, EventArgs e) //Will open the credits screen
        {
            if (credits != null)
            {
                credits.Close();
            }
            //Create the options form
            credits = new About();
            credits.mainLauncher = this;
            credits.Owner = this;
            credits.StartPosition = FormStartPosition.CenterScreen;
            credits.Show();
        }

        //For changing sprites of various buttons when the cursors enters or leaves a button

        private void creditsButton_MouseEnter(object sender, EventArgs e)
        {
            creditsButton.Image = Properties.Resources.creditbuttonpressed;
        }

        private void creditsButton_MouseLeave(object sender, EventArgs e)
        {
            creditsButton.Image = Properties.Resources.creditbutton;
        }

        private void updatebutton_MouseEnter(object sender, EventArgs e)
        {
            updatebutton.Image = Properties.Resources.updatebutotnpressed;
        }

        private void updatebutton_MouseLeave(object sender, EventArgs e)
        {
            updatebutton.Image = Properties.Resources.updatebutotn;
        }

        private void celestewebsite_MouseEnter(object sender, EventArgs e)
        {
            celestewebsite.Image = Properties.Resources.celestewebsitepressed;
        }

        private void celestewebsite_MouseLeave(object sender, EventArgs e)
        {
            celestewebsite.Image = Properties.Resources.celestewebsite;
        }

        private void forgetme_MouseLeave(object sender, EventArgs e)
        {
            forgetme.Image = Properties.Resources.forgetme;
        }

        private void forgetme_MouseEnter(object sender, EventArgs e)
        {
            forgetme.Image = Properties.Resources.forgetmepressed;
        }

        private void playimage_MouseLeave(object sender, EventArgs e)
        {
            playimage.Image = Properties.Resources.playbutton;
        }

        private void playimage_MouseEnter(object sender, EventArgs e)
        {
            playimage.Image = Properties.Resources.playbuttonpressed;
        }
    }
}
