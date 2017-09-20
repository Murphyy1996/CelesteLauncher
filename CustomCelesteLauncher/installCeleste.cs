using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace CustomCelesteLauncher
{
    public partial class installCeleste : Form
    {
        //Variables
        WebClient webClient;               // Our WebClient that will be doing the downloading for us
        Stopwatch sw = new Stopwatch();    // The stopwatch which we will be using to calculate the download speed
        public launcherWindow mainLauncher;
        //Methods

        public installCeleste()
        {
            InitializeComponent();
        }

        private void installCeleste_Load(object sender, EventArgs e)
        {
            DownloadFile("http://projectceleste.com/static/Celeste_Launcher_Gui.zip", Environment.CurrentDirectory + @"\Celeste_Launcher_Gui.zip");
        } //Upon loading this form the download for Project Celeste will begin

        private void ExtractProjectCeleste()
        {
            //Get the zip file
            ZipArchive downloadedFolder = ZipFile.Open(Environment.CurrentDirectory + @"\Celeste_Launcher_Gui.zip", ZipArchiveMode.Update);

            //Try to extract and replace 
            try
            {
                foreach (ZipArchiveEntry file in downloadedFolder.Entries)
                {
                    string completeFileName = Path.Combine(Environment.CurrentDirectory, file.FullName);
                    if (file.Name == "")
                    {// Assuming Empty for Directory
                        Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                        continue;
                    }
                    file.ExtractToFile(completeFileName, true);
                }
                //If succesful show this dialog
                MessageBox.Show("Succesfully installed Project Celeste! The launcher will now be restarted");
                //Restart as memory usage stays extremely high (In the visual studio editor anyway) I have tried disposing resources but this was the only way that worked
                Application.Restart();
            }
            catch //If an error has occured 
            {
                MessageBox.Show("Error installing Project Celeste");
                Application.Exit();
            }

        } //Will extract project celeste

        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } //When called this will download the file

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
                if (mainLauncher != null)
                {
                    mainLauncher.installCeleste = null;
                }
                this.Close();
            }
            else
            {
                stopDownload.Enabled = false;
                MessageBox.Show("The files have been succesfully downloaded. The launcher will now install Project Celeste");
                ExtractProjectCeleste();
            }
        }

        private void stopDownload_Click(object sender, EventArgs e) //Will cancel the download
        {
            //Stop the download and reset the stopwatch
            webClient.CancelAsync();
            sw.Reset();
        }
    }

}
