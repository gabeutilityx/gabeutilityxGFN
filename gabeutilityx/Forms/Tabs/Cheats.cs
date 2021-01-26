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
using gabeutilityx.Forms.Tabs.Extra;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;

namespace gabeutilityx.Forms.Tabs
{
    public partial class Cheats : UserControl
    {
        public Cheats()
        {
            InitializeComponent();
        }



        private void Cheats_Load(object sender, EventArgs e)
        {

        }

        private void Programs_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Users\kiosk\AppData\Roaming\.minecraft\versions\Sigma5\");
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/750561003863015484/Sigma5.jar", @"C:\Users\kiosk\AppData\Roaming\.minecraft\versions\Sigma5\Sigma5.jar");
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/750561003489460264/Sigma5.json", @"C:\Users\kiosk\AppData\Roaming\.minecraft\versions\Sigma5\Sigma5.json");


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/723012148325908480/Sentinel.exe", @"c:\gabe\Sentineldl2.exe");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/723008462291730503/Xenos64.exe", @"c:\gabe\Xeanos32.exe");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/755939486562648129/Xenos64_DLL_Injector.exe", @"c:\gabe\Xeanos64.exe");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755939486667636816/Onetap.dll", @"c:\gabe\OTCv2.dll");
            MessageBox.Show("Downloaded in C:/Gabe");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/732010927091613797/755910795312758834/onetap.dll", @"c:\gabe\OTCv3.dll");
            MessageBox.Show("Downloaded in C:/Gabe");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/723550395846230066/Synapse_X.exe", @"c:\gabe\synapseXbootstrap.exe");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/723552035441475625/SirHurt_V4_Bootstrapper.exe", @"c:\gabe\sirhurtbootstrap.exe");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            gabeutilityxCore.DownloadExe("https://impactclient.net/ImpactInstaller.exe", @"C:\Gabe\Impact.exe");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cdn.discordapp.com/attachments/726930094676770947/750651217272635392/skin.zip", @"C:\Gabe\skin.zip", @"c:\Gabe\SkinChangerLeague\", @"c:\Gabe\SkinChangerLeague\LOLPRO 10.16.2.exe");

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(@"C:\Program Files (x86)\Steam\crashhandler.dll", @"C:\Program Files (x86)\Steam\crashhandler2.dll");
            }
            catch { }
            try
            {
                File.Delete(@"C:\Program Files (x86)\Steam\crashhandler.dll");
            }
            catch { }
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Inject";
            theDialog.Filter = "DLL Files|*.dll";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((theDialog.OpenFile()) != null)
                    {
                        var fileName = theDialog.FileName;
                        File.Copy(@theDialog.FileName, @"C:\Program Files (x86)\Steam\crashhandler.dll");
                        MessageBox.Show("You can now launch your game!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/741701372277424229/758782573316145182/tlmj0lxq.exe", @"C:\Gabe\tlmj0lxq.exe");

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/741701372277424229/758783516174975016/ExternalModuleBypasser.exe", @"C:\Gabe\ExternalModuleBypS78sS8haSJ7a7yAY8.exe");

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/741701372277424229/758783793636179988/IC_unknowncheats.me_.dll", @"C:\Gabe\ic.dll");
            MessageBox.Show("Downloaded in C:/Gabe");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/741701372277424229/758805530901741578/CSGhost_v2.4.exe", @"C:\Gabe\csghost.exe");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dontr work");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new otcv2().Show();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cdn.discordapp.com/attachments/751782134603186249/771723485470654464/Azoth.zip", @"C:\Gabe\Azoth.zip", @"C:\Gabe\Azoth", @"C:\Gabe\Azoth\Azoth.exe");
        }
    }
}
