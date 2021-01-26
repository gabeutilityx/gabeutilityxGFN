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

namespace gabeutilityx.Forms.Tabs.Extra
{
    public partial class otcv2 : Form
    {
        public otcv2()
        {
            InitializeComponent();
        }

        private void otcv2_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Download configs for cheat

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755939474915196999/Spinbot_config.cfg", @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\spin.cfg");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755939479700897842/Legit_config.cfg", @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\legit.cfg");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755939472536764471/scout_config.cfg", @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\scout.cfg");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755939883536613488/skins.cfg", @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\skins.cfg");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755941206675947530/legit2.cfg", @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\legit2.cfg");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/755941163449581598/skins2.cfg", @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\skins2.cfg");

        }
    }
}
