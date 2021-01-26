using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gabeutilityx.Classes;
using gabeutilityx.Forms;
using gabeutilityx.Forms.Tabs;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;

namespace gabeutilityx.Forms.Tabs
{
    public partial class Misc : UserControl
    {
        public Misc()
        {
            InitializeComponent();
        }

        private void Programs_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("http://www.qtweb.net/downloads/QtWeb.exe", @"c:\gabe\qtwebb.exe");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://use.imfast.io/kmelon.zip", @"C:\Gabe\kmeleon.zip", @"C:\Gabe", @"c:\Gabe\kmelon\fly.exe");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://github.com/citra-emu/citra-nightly/releases/download/nightly-1601/citra-windows-mingw-20200807-f72be7a.7z", @"C:\Gabe\Citra.zip", @"C:\Gabe\", @"C:\Gabe\nightly-mingw\citra-qt.exe");

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cdn.discordapp.com/attachments/748202403672883349/748208532540882974/cemu_1.20.2.zip", @"C:\Gabe\Cemu.zip", @"C:\Gabe\", @"C:\Gabe\cemu_1.20.2\\Gaymu.exe");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/cp97pbs65u8lfta/RPCS3.zip", @"C:\Gabe\RPCS3.zip", @"C:\Gabe", @"C:\Gabe\RPCS3\rpcs3.exe");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/d7yxfjjsgx0e7es/xenia%20master.zip", @"C:\Gabe\xenia.zip", @"C:\Gabe", @"C:\Gabe\xenia master\xenia_master\masina37.exe");

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/750536118004482158/yuzu_install.exe", @"C:\Gabe\yuzu.exe");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string appdataFolder = Microsoft.VisualBasic.Interaction.InputBox("Specify what folder you want to save. It must not exist already. If it does, delete it.", "Custom save", @"C:\Users\kiosk\AppData\Local\ProgramName");
            string programName = Microsoft.VisualBasic.Interaction.InputBox("Specify the program name.", "Custom save", @"ProgramName");
            try
            {
                gabeutilityxCore.MakeSave(appdataFolder, programName);
                MessageBox.Show("Save created successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error making save. Either the targeted folder already exists, or the program name is unparsable or the targeted folder is unreachable.", "Error while making save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Misc_Load(object sender, EventArgs e)
        {
            textbox.Text = File.ReadAllText(@"C:\Fake\text.txt");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Fake\text.txt", textbox.Text);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.InitialDirectory = @"C:\";
            if (f.ShowDialog() == DialogResult.OK)
            {
                gabeutilityxCore.DownloadFile(downloadlink.Text, f.FileName);
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Wallpaper";
            theDialog.Filter = "JPG Files|*.jpg";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((theDialog.OpenFile()) != null)
                    {
                        var fileName = theDialog.FileName;
                        File.Delete(@"C:\Fake\DesktopWallpaper.png");
                        File.Copy(@fileName, @"C:\Fake\DesktopWallpaper.png");
                    }
                }
                catch
                {

                }
                }
        }






        private void guna2Button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "gabeutilityx script";
            d.Filter = "gbx Files|*.gbx";
            d.InitialDirectory = @"C:\Fake";
            if (d.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((d.OpenFile()) != null)
                    {
                        var fileName = d.FileName;
                        TextReader tr = new StreamReader(@fileName);
                        TextWriter tw = new StreamWriter("gabeutilityxScriptingAPIlog.txt");
                        
                        // Script
                        string line = null;
                        while ((line = tr.ReadLine()) != null)
                        {
                            try
                            {
                                if (line.Contains("Download("))
                                {
                                    string line2 = line.Replace("Download(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string lnk = text[0];
                                    string path = text[1];
                                    gabeutilityxCore.DownloadFile(lnk, path);
                                }
                                if (line.Contains("Extract("))
                                {
                                    string line2 = line.Replace("Extract(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string path = text[0];
                                    string ext = text[1];
                                    gabeutilityxCore.UnzipFile(path, ext);
                                }
                                if (line.Contains("Delete("))
                                {
                                    string line2 = line.Replace("Delete(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string path = text[0];
                                    File.Delete(@path);
                                }
                                if (line.Contains("Run("))
                                {
                                    string line2 = line.Replace("Run(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string path = text[0];
                                    Process.Start(@path);
                                }
                                if (line.Contains("Move("))
                                {
                                    string line2 = line.Replace("Move(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string path = text[0];
                                    string pathfinal = text[1];
                                    try
                                    {
                                        File.Move(@path, @pathfinal);
                                    }
                                    catch
                                    {
                                        File.Delete(@pathfinal);
                                        File.Move(@path, @pathfinal);
                                    }
                                }
                                if (line.Contains("Copy("))
                                {
                                    string line2 = line.Replace("Copy(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string path = text[0];
                                    string pathfinal = text[1];
                                    try
                                    {
                                        File.Copy(@path, @pathfinal);
                                    }
                                    catch
                                    {
                                        File.Delete(@pathfinal);
                                        File.Copy(@path, @pathfinal);
                                    }
                                }
                                if (line.Contains("Message("))
                                {
                                    string line2 = line.Replace("Message(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string tex = text[0];
                                    string titl = text[1];
                                    MessageBox.Show(tex, titl);
                                }
                                if (line.Contains("CreateDirectory("))
                                {
                                    string line2 = line.Replace("CreateDirectory(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string path = text[0];
                                    Directory.CreateDirectory(@path);
                                }
                                if (line.Contains("cmd("))
                                {
                                    string line2 = line.Replace("cmd(", "");
                                    string final = line2.Replace(")", "");
                                    var text = final.Split(',');
                                    string command = text[0];
                                    Process process = new Process
                                    {
                                        StartInfo =
                                            {
                                                 UseShellExecute = false,
                                                 RedirectStandardOutput = true,
                                                 RedirectStandardError = true,
                                                 CreateNoWindow = true,
                                                 FileName = "cmd.exe",
                                                 Arguments = "/C " + command
                                             }
                                    };
                                    process.Start();
                                    process.WaitForExit();
                                }
                            }
                            catch
                            {
                                MessageBox.Show("An error occured on the following line: " + line, "Error in " + fileName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        tw.FlushAsync();
                        tw.Close();
                        tr.Close();
                    }
                }
                catch
                {

                }
            }
        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
