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
    public partial class Login : Form
    {
        //Variable containing the main launcher form
        public launcherWindow mainLauncher;

        public Login()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) //When clicking the cancel button
        {
            //Close thie form and no data will be saved
            mainLauncher.loggedIn = false;
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e) //When clicking the login button
        {
            //Store the username and password data
            mainLauncher.email = emailBox.Text;
            mainLauncher.password = passwordBox.Text;
            //Let the launcher window know the player has logged in
            mainLauncher.loggedIn = true;
            //Press play again
            mainLauncher.PlayGame();
            //Close this form
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e) //This will open the official celeste launcher so that the user can sign up if needed
        {
            //Open the official celeste launcher
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Celeste_Launcher_Gui.exe");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
