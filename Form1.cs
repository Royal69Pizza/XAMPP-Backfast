using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace XAMPP_Backfast
{
    public partial class XAMPP_Backfast : Form
    {
        /*| Initialisation de la tache d'arrière plan |*/
        BackgroundWorker worker = new BackgroundWorker();

        /*| Initialisation du form |*/
        public XAMPP_Backfast()
        {
            InitializeComponent();

            ListboxPresets.Items.Add("XAMPP MySQL");
            ListboxPresets.Items.Add("XAMPP htdocs");
            ListboxPresets.SelectedIndex = 0;

            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;

            /**| Collection des Polices |**/
            PrivateFontCollection AllFonts = new PrivateFontCollection();

            /**| Chemin du projet |**/
            string rootPath = Environment.CurrentDirectory;

            /**| Ajout des polices|**/
            AllFonts.AddFontFile(rootPath + "\\praetorian.ttf");
            AllFonts.AddFontFile(rootPath + "\\omegaflighttitle.ttf");
            AllFonts.AddFontFile(rootPath + "\\omegaflight.ttf");

            /**| Applique les polices|**/
            labelLogo.Font = new Font(AllFonts.Families[2], 13, FontStyle.Regular);

            ButtonClear.Font = new Font(AllFonts.Families[1], 9, FontStyle.Regular);
            ButtonCreate.Font = new Font(AllFonts.Families[1], 9, FontStyle.Regular);
            ButtonExit.Font = new Font(AllFonts.Families[1], 9, FontStyle.Regular);

            copyPasteBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            presetsBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
            workerBox.Font = new Font(AllFonts.Families[0], 9, FontStyle.Regular);
        }

        /*| Copy folder picker |*/
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                inputCopy.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(inputCopy.Text));
            }
        }

        /*| Paste folder picker |*/
        private void ButtonPaste_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                inputPaste.Text = Path.Combine(dialog.SelectedPath, Path.GetFileName(inputPaste.Text));
            }
        }

        /*| Activation du worker |*/
        private void Worker_DoWork(object sender, EventArgs e)
        {
            CopyFile(inputCopy.Text, inputPaste.Text);
        }

        /*| Changement de valeur de la progress bar |*/
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

            if (progressBar.Value == 0)
            {
                textEvents.Text = "Waiting";
                textEvents.ForeColor = Color.FromArgb(255, 255, 255);
                textEvents.BackColor = Color.FromArgb(0, 0, 0);
            }
            if (progressBar.Value > 1 && progressBar.Value < 100)
            {
                textEvents.Text = "Building...";
                textEvents.ForeColor = Color.FromArgb(255, 255, 255);
                textEvents.BackColor = Color.FromArgb(255, 255, 0);
            }
            if (progressBar.Value == 100) {
                textEvents.Text = "Done";
                textEvents.ForeColor = Color.FromArgb(255, 255, 255);
                textEvents.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

        /*| Copie un dossier au même endroit que celui ci |*/
        private void CopyFile(string sourceDirName, string destDirName)
        {
            try
            {
                if (inputCopy.Text != "" || inputPaste.Text != "")
                {
                    if (inputCopy.Text != inputPaste.Text)
                    {
                        worker.ReportProgress((int)(5));

                        Directory.CreateDirectory(destDirName);

                        foreach (string file in Directory.GetFiles(sourceDirName))
                        {
                            string fileName = Path.GetFileName(file);
                            string destFile = Path.Combine(destDirName, fileName);
                            File.Copy(file, destFile, true);
                        }

                        foreach (string subdir in Directory.GetDirectories(sourceDirName))
                        {
                            string subDirName = Path.GetFileName(subdir);
                            string destSubDir = Path.Combine(destDirName, subDirName);
                            CopyFile(subdir, destSubDir);
                        }

                        worker.ReportProgress((int)(100));
                    } else {
                        MessageBox.Show("Inputs have the same path.", "Wrapped Chicken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else {
                    MessageBox.Show("Some inputs are empty.", "Wrapped Chicken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Wrapped Chicken", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        /*| Active la copie |*/
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

        /*| Nettoie les entrées |*/
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            inputCopy.Text = "";
            inputPaste.Text = "";
        }

        /*| Presets |*/
        private void ListboxPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = (string)ListboxPresets.SelectedItem;

            if (selectedOption == "XAMPP MySQL")
            {
                string Date = DateTime.Now.ToString("dd-MM-yyyy");
                inputCopy.Text = "C:\\xampp\\mysql\\data";
                inputPaste.Text = "C:\\xampp\\mysql\\data-backup-" + Date;
            }
            if (selectedOption == "XAMPP htdocs")
            {
                string Date = DateTime.Now.ToString("dd-MM-yyyy");
                inputCopy.Text = "C:\\xampp\\htdocs";
                inputPaste.Text = "C:\\xampp\\htdocs-backup-" + Date;
            }
        }

        /*| Exit |*/
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
