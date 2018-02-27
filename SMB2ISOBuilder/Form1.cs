using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMB2ISOBuilder
{
    public partial class Form1 : Form
    {
        // Combine the base folder with your specific folder....
        string specificFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SMB2ISOBuilder");
        string swappedLevels = "";
        public Form1()
        {
            this.Icon = new Icon("icon.ico");
            InitializeComponent();
            ZIP_textbox.Text = Properties.Settings.Default.ZIP;
            SMB2_ISO_textbox.Text = Properties.Settings.Default.ISO;
            OutputTextBox.Text = Properties.Settings.Default.Output;
            nameBox.Text = Properties.Settings.Default.OutputName;
        }

        private void GCRLabel_Click(object sender, EventArgs e)
        {

        }

        private void GCRBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void SMB2_ISO_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ISO Files|*.iso|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SMB2_ISO_textbox.Text = openFileDialog1.FileName;
                Properties.Settings.Default.ISO = SMB2_ISO_textbox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void OutputBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OutputTextBox.Text = folderBrowserDialog1.SelectedPath.ToString();
                Properties.Settings.Default.Output = OutputTextBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void ZIP_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ZIP Files|*.zip";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ZIP_textbox.Text = openFileDialog1.FileName;
                Properties.Settings.Default.ZIP = ZIP_textbox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            AddToLog("Ready!");
            AddToLog("Opening SMB2 ISO");
            openISO(SMB2_ISO_textbox.Text);
            AddToLog("Copying Stages Over");
            CopyToZip(ZIP_textbox.Text);
            AddToLog("Making new ISO");
            MakeNewISO(Path.Combine(OutputTextBox.Text,nameBox.Text));
            MessageBox.Show("The following levels have been modified: " + Environment.NewLine + swappedLevels);
        }

        private void MakeNewISO(string text)
        {
            // CreateDirectory will check if folder exists and, if not, create it.
            // If folder exists then CreateDirectory will do nothing.
            Directory.CreateDirectory(specificFolder);

            if (!Directory.Exists(OutputTextBox.Text))
            {
                Directory.CreateDirectory(OutputTextBox.Text);
            }
            if (!nameBox.Text.EndsWith(".iso"))
            {
                text += ".iso";
            }

            Directory.CreateDirectory(Path.GetDirectoryName(text));
            string arguments = String.Format("{0} {1}","\"" + Path.Combine(specificFolder,"root")+ "\"" , "\"" + Path.GetFullPath(text)+ "\"" );

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(System.IO.Directory.GetCurrentDirectory(),"resources","gcr.exe");
            startInfo.Arguments = arguments;
            AddToLog(arguments);

            Process gcr = new Process();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            gcr.StartInfo = startInfo;

            gcr.OutputDataReceived += Gcr_OutputDataReceived;

            gcr.Start();
            gcr.BeginOutputReadLine();
            gcr.WaitForExit();

            AddToLog("ISO Rebuilt");
        }

        private void CopyToZip(string zipPath)
        {
            string tempFolder = Path.Combine(specificFolder + "\\stages");
            if (Directory.Exists(tempFolder))
            {
            Directory.Delete(tempFolder,true);

            }

            //ZipFile.ExtractToDirectory(System.IO.Path.GetFullPath(zipPath), tempFolder );

            using (ZipFile zip = ZipFile.Read( System.IO.Path.GetFullPath(zipPath) ))
            {
                zip.ExtractAll(tempFolder);
            }
            
            string[] lzs = System.IO.Directory.GetFiles(tempFolder, "*.lz",SearchOption.AllDirectories);
            string[] gmas = System.IO.Directory.GetFiles(tempFolder, "*.gma", SearchOption.AllDirectories);
            string[] tpls = System.IO.Directory.GetFiles(tempFolder, "*.tpl", SearchOption.AllDirectories);
            string[] dsps = System.IO.Directory.GetFiles(tempFolder, "*.dsp", SearchOption.AllDirectories);
            string[] strs = System.IO.Directory.GetFiles(tempFolder, "*.str", SearchOption.AllDirectories);
            string[] rels = System.IO.Directory.GetFiles(tempFolder, "mkb2.main_loop.rel", SearchOption.AllDirectories);
            String stagesPath = Path.Combine(specificFolder, "root","stage");
            String bgPath = Path.Combine(specificFolder, "root", "bg");
            String sndPath = Path.Combine(specificFolder, "root", "snd","stream");
            String relPath = Path.Combine(specificFolder);
            String stgnamePath = Path.Combine(specificFolder, "root", "stgname");

            foreach (var stg in strs)
            {
                File.Copy(stg, stgnamePath + "\\" + Path.GetFileName(stg),true);
                AddToLog("Copying " + stg);
            }

            foreach (var lz in lzs)
            {
                File.Copy(lz, stagesPath + "\\" + Path.GetFileName(lz), true);
                AddToLog("Copying " + lz);
                swappedLevels += Path.GetFileNameWithoutExtension(lz) + Environment.NewLine;
            }
            foreach (var gma in gmas)
            {
                if (gma.Contains(@"\bg\"))
                {
                    File.Copy(gma, bgPath + "\\" + Path.GetFileName(gma), true);
                }
                else
                {
                File.Copy(gma, stagesPath + "\\" + Path.GetFileName(gma), true);

                }

                AddToLog("Copying " + gma);

            }
            foreach (var tpl in tpls)
            {
                if (tpl.Contains(@"\bg\"))
                {
                    File.Copy(tpl, bgPath + "\\" + Path.GetFileName(tpl), true);
                }
                else
                {
                    File.Copy(tpl, stagesPath + "\\" + Path.GetFileName(tpl), true);

                }
                AddToLog("Copying " + tpl);

            }

            foreach (var rel in rels)
            {
                if (Path.GetFileName(rel).Contains("main_loop") && doubleSpeedCheckbox.Checked)
                {
                    GottaGoFast(rel);
                }
                File.Copy(rel, relPath + "\\root\\" + Path.GetFileName(rel), true);
                AddToLog("Copying " + rel);

            }
            foreach (var dsp in dsps)
            {
                File.Copy(dsp, sndPath + "\\" + Path.GetFileName(dsp), true);
                AddToLog("Copying " + dsp);

            }
        }

        private void GottaGoFast(string rel)
        {
            using (FileStream b = new FileStream(rel,FileMode.Open))
            {
                int length = (int)b.Length;
                int pos = 0x2023BC;

                b.Seek(pos, SeekOrigin.Begin);

                //Somepoint let the user choose the speed
                b.WriteByte(0x3C);
                b.WriteByte(0xA0);
                b.WriteByte(0x90);
                b.WriteByte(0x23);
                b.Flush();
                
            }

        }

        private void openISO(string path)
        {
            String rootPath = Path.Combine(specificFolder);

            string arguments = String.Format("\"{0}\" root e \"{1}\"", path, rootPath );

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "resources", "gcr.exe");
            startInfo.Arguments = arguments;
            AddToLog(arguments);

            Process gcr = new Process();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            gcr.StartInfo = startInfo;
            
            gcr.OutputDataReceived += Gcr_OutputDataReceived;

            gcr.Start();
            gcr.BeginOutputReadLine();
            gcr.WaitForExit();

            AddToLog("ISO Extracted");
        }

        private void Gcr_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
            AddToLog(e.Data.ToString());

            }
        }

        private void AddToLog(string s)
        {
            Invoke(new Action(() => logTextBox.AppendText(s + Environment.NewLine)));
        }

        private void gcr_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputName = nameBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
