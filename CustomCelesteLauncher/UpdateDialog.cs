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
    public partial class UpdateDialog : Form
    {
        //Variable containing the main launcher form
        public launcherWindow mainLauncher;

        public UpdateDialog()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e) //This form will be closed if the no button has been pressed
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e) //The update code will be run and this form will close
        {
            mainLauncher.UpdateCelesteCode();
            this.Close();
        }
    }
}
