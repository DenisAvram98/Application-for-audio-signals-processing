using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string selectedFilePath = "";
        string selectedFile = "";
        SoundPlayer sound = null;
        SoundPlayer soundFilter = null;

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            var dialog1 = new OpenFileDialog();
            dialog1.Title = "Selectati fisierul audio de tip .wav";
            dialog1.Filter = "Wav Files (*.wav)|*.wav";
            dialog1.InitialDirectory = @"E:\";
            dialog1.FilterIndex = 2;
            //dialog1.RestoreDirectory = true;
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                if (sound != null)
                {
                    sound.Stop();
                }
                pathTB.Text = dialog1.SafeFileName;
                selectedFile = dialog1.SafeFileName;
                selectedFilePath = Path.GetDirectoryName(dialog1.FileName);
                //pathTB.Text = selectedFilePath;
                //SoundPlayer sound = new SoundPlayer(dialog1.FileName);
                //sound.Play();
                //play sound
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (pathTB.Text.Trim() != "")
            {
                sound = new SoundPlayer(selectedFilePath + "\\" + selectedFile);
                sound.Play();
            }
            if (sound == null && pathTB.Text.Trim() == "")
            {
                MessageBox.Show("Nu ati ales fisierul audio!", "Play", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (sound != null)
            {
                sound.Stop();
            }
            if (sound == null && pathTB.Text.Trim() == "")
            {
                MessageBox.Show("Nu ati ales fisierul audio!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void aplicareFiltreBtn_Click(object sender, EventArgs e)
        {
            if (pathTB.Text.Trim() != "")
            {
                if (filtreCB.SelectedIndex >= 0)
                {
                    //daca se sterge valoare sa fie pusa inapoi pentru a nu se lasa ca controlul sa fie gol
                    ordinFnUD.Text = ordinFnUD.Value.ToString();
                    frecventaTnUD.Text = frecventaTnUD.Value.ToString();
                    frecventaT1nUD.Text = frecventaT1nUD.Value.ToString();
                    try
                    {
                        if (filtreCB.Text == "Filtru trece - jos")
                        {
                            MLApp.MLApp matlab = new MLApp.MLApp();
                            matlab.Execute(@"cd E:\FisiereWAV");
                            object result = null;
                            matlab.Feval("MyFunc", 1, out result, selectedFile, "LPF-", selectedFilePath, Int32.Parse(ordinFnUD.Value.ToString()), Double.Parse(frecventaTnUD.Value.ToString()), Double.Parse(frecventaT1nUD.Value.ToString()));

                            rezultatFiltrareTB.Text = "LPF-" + selectedFile;
                            soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "LPF-" + selectedFile);
                            soundFilter.Play();

                            pictureBox1.Visible = true;
                            pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "LPF-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                        }
                        else if (filtreCB.Text == "Filtru trece - sus")
                        {
                            MLApp.MLApp matlab = new MLApp.MLApp();
                            matlab.Execute(@"cd E:\FisiereWAV");
                            object result = null;
                            matlab.Feval("MyFunc", 1, out result, selectedFile, "HPF-", selectedFilePath, Int32.Parse(ordinFnUD.Value.ToString()), Double.Parse(frecventaTnUD.Value.ToString()), Double.Parse(frecventaT1nUD.Value.ToString()));

                            rezultatFiltrareTB.Text = "HPF-" + selectedFile;
                            soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "HPF-" + selectedFile);
                            soundFilter.Play();

                            pictureBox1.Visible = true;
                            pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "HPF-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                        }
                        else if (filtreCB.Text == "Filtru trece - banda")
                        {
                            if (frecventaTnUD.Value < frecventaT1nUD.Value)
                            {
                                MLApp.MLApp matlab = new MLApp.MLApp();
                                matlab.Execute(@"cd E:\FisiereWAV");
                                object result = null;
                                matlab.Feval("MyFunc", 1, out result, selectedFile, "BPF-", selectedFilePath, Int32.Parse(ordinFnUD.Value.ToString()), Double.Parse(frecventaTnUD.Value.ToString()), Double.Parse(frecventaT1nUD.Value.ToString()));

                                rezultatFiltrareTB.Text = "BPF-" + selectedFile;
                                soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "BPF-" + selectedFile);
                                soundFilter.Play();

                                pictureBox1.Visible = true;
                                pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "BPF-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                            }
                            else
                            {
                                MessageBox.Show("Frecventele de taiere sunt invalide! (Wn1 < Wn2)", filtreCB.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (filtreCB.Text == "Filtru opreste banda")
                        {
                            if (frecventaTnUD.Value < frecventaT1nUD.Value)
                            {
                                MLApp.MLApp matlab = new MLApp.MLApp();
                                matlab.Execute(@"cd E:\FisiereWAV");
                                object result = null;
                                matlab.Feval("MyFunc", 1, out result, selectedFile, "BSF-", selectedFilePath, Int32.Parse(ordinFnUD.Value.ToString()), Double.Parse(frecventaTnUD.Value.ToString()), Double.Parse(frecventaT1nUD.Value.ToString()));

                                rezultatFiltrareTB.Text = "BSF-" + selectedFile;
                                soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "BSF-" + selectedFile);
                                soundFilter.Play();

                                pictureBox1.Visible = true;
                                pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "BSF-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                            }
                            else
                            {
                                MessageBox.Show("Frecventele de taiere sunt invalide! (Wn1 < Wn2)", filtreCB.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la conexiunea cu MATLAB: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nu ati ales tipul filtrului!", aplicareFiltreBtn.Text + " filtrul", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nu ati ales fisierul audio!", aplicareFiltreBtn.Text + " filtrul", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void playFilterBtn_Click(object sender, EventArgs e)
        {
            if (soundFilter != null)
            {
                soundFilter.Play();
            }
            if (soundFilter == null && rezultatFiltrareTB.Text.Trim() == "")
            {
                MessageBox.Show("Rezultatul nu este generat!", "Play", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stopFilterBtn_Click(object sender, EventArgs e)
        {
            if (soundFilter != null)
            {
                soundFilter.Stop();
            }
            if (soundFilter == null && rezultatFiltrareTB.Text.Trim() == "")
            {
                MessageBox.Show("Rezultatul nu este generat!", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void filtreCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtreCB.SelectedIndex >= 0)
            {
                if (filtreCB.Text == "Filtru trece - jos")
                {
                    ordinFnUD.Enabled = true;
                    frecventaTnUD.Enabled = true;
                    frecventaT1nUD.Enabled = false;
                    informatieLabel.Visible = true;
                    informatieLabel.Text = "0 < Wn < 1.00";
                    ordinFnUD.Value = 6;
                    frecventaTnUD.Value = 0.80M;
                    frecventaT1nUD.Value = 0.01M;
                }
                else if (filtreCB.Text == "Filtru trece - sus")
                {
                    ordinFnUD.Enabled = true;
                    frecventaTnUD.Enabled = true;
                    frecventaT1nUD.Enabled = false;
                    informatieLabel.Visible = true;
                    informatieLabel.Text = "0 < Wn < 1.00";
                    ordinFnUD.Value = 6;
                    frecventaTnUD.Value = 0.80M;
                    frecventaT1nUD.Value = 0.01M;
                }
                else if (filtreCB.Text == "Filtru trece - banda")
                {
                    ordinFnUD.Enabled = true;
                    frecventaTnUD.Enabled = true;
                    frecventaT1nUD.Enabled = true;
                    informatieLabel.Visible = true;
                    informatieLabel.Text = "Wn1 < Wn2";
                    ordinFnUD.Value = 48;
                    frecventaTnUD.Value = 0.35M;
                    frecventaT1nUD.Value = 0.65M;
                }
                else if (filtreCB.Text == "Filtru opreste banda")
                {
                    ordinFnUD.Enabled = true;
                    frecventaTnUD.Enabled = true;
                    frecventaT1nUD.Enabled = true;
                    informatieLabel.Visible = true;
                    informatieLabel.Text = "Wn1 < Wn2";
                    ordinFnUD.Value = 48;
                    frecventaTnUD.Value = 0.35M;
                    frecventaT1nUD.Value = 0.65M;
                }
            }
            else
            {
                ordinFnUD.Enabled = false;
                frecventaTnUD.Enabled = false;
                frecventaT1nUD.Enabled = false;
                informatieLabel.Visible = false;
                ordinFnUD.Value = 6;
                frecventaTnUD.Value = 0.80M;
                frecventaT1nUD.Value = 0.01M;
            }
        }

        private void adaugareZBtn_Click(object sender, EventArgs e)
        {
            SNRnUD.Text = SNRnUD.Value.ToString();
            if (pathTB.Text.Trim() != "")
            {
                try
                {
                    MLApp.MLApp matlab = new MLApp.MLApp();
                    matlab.Execute(@"cd E:\FisiereWAV");
                    object result = null;
                    matlab.Feval("MyFunc2", 1, out result, selectedFile, "WGN-", selectedFilePath, Double.Parse(SNRnUD.Value.ToString()));

                    rezultatFiltrareTB.Text = "WGN-" + selectedFile;
                    soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "WGN-" + selectedFile);
                    soundFilter.Play();

                    pictureBox1.Visible = true;
                    pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "WGN-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conexiunea cu MATLAB: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nu ati ales fisierul audio!", adaugareZBtn.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creareEBtn_Click(object sender, EventArgs e)
        {
            if (pathTB.Text.Trim() != "")
            {
                try
                {
                    MLApp.MLApp matlab = new MLApp.MLApp();
                    matlab.Execute(@"cd E:\FisiereWAV");
                    object result = null;
                    matlab.Feval("MyFunc3", 1, out result, selectedFile, "Echo-", selectedFilePath);

                    rezultatFiltrareTB.Text = "Echo-" + selectedFile;
                    soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "Echo-" + selectedFile);
                    soundFilter.Play();

                    pictureBox1.Visible = true;
                    pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "Echo-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conexiunea cu MATLAB: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nu ati ales fisierul audio!", creareEBtn.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zaGRB_CheckedChanged(object sender, EventArgs e)
        {
            if (zaGRB.Checked == true)
            {
                zaGGB.Visible = true;
                fGB.Visible = false;
                creareEBtn.Visible = false;
                reducereEBtn.Visible = false;
            }
            else if (fRB.Checked == true)
            {
                fGB.Visible = true;
                zaGGB.Visible = false;
                creareEBtn.Visible = false;
                reducereEBtn.Visible = false;
            }
            else if (cERB.Checked == true)
            {
                creareEBtn.Visible = true;
                zaGGB.Visible = false;
                fGB.Visible = false;
                reducereEBtn.Visible = false;
            }
            else if (reducereERB.Checked == true)
            {
                reducereEBtn.Visible = true;
                creareEBtn.Visible = false;
                zaGGB.Visible = false;
                fGB.Visible = false;
            }
            else
            {
                zaGGB.Visible = false;
                fGB.Visible = false;
                creareEBtn.Visible = false;
                reducereEBtn.Visible = false;
            }
        }

        private void reducereEBtn_Click(object sender, EventArgs e)
        {
            if (pathTB.Text.Trim() != "")
            {
                try
                {
                    MLApp.MLApp matlab = new MLApp.MLApp();
                    matlab.Execute(@"cd E:\FisiereWAV");
                    object result = null;
                    matlab.Feval("MyFunc3", 1, out result, selectedFile, "REcho-", selectedFilePath);

                    rezultatFiltrareTB.Text = "REcho-" + selectedFile;
                    soundFilter = new SoundPlayer(@"E:\FisiereWAV\Workspace\" + "REcho-" + selectedFile);
                    soundFilter.Play();

                    pictureBox1.Visible = true;
                    pictureBox1.ImageLocation = @"E:\FisiereWAV\Workspace\" + "REcho-" + Path.GetFileNameWithoutExtension(selectedFile) + ".jpg";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conexiunea cu MATLAB: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nu ati ales fisierul audio!", reducereEBtn.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clean the Workspace
            string Workspace = @"E:\FisiereWAV\Workspace\";
            string[] files = Directory.GetFiles(Workspace);
            foreach(string file in files)
            {
                File.Delete(file);
            }
        }
    }
}
