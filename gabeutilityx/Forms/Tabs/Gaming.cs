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
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;

namespace gabeutilityx.Forms.Tabs
{
    public partial class Gaming : UserControl
    {
        public Gaming()
        {
            InitializeComponent();
        }

        private void Gaming_Load(object sender, EventArgs e)
        {

        }

        private void Programs_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://picteon.dev/files/TwitchStudioSetup.exe", @"c:\gabe\Twitch-1.exe");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/ptyq550ysldjs9v/Battle.net.zip", @"C:\Gabe\battle.zip", @"C:\Gabe\", @"C:\Gabe\Battle.net\Battle.net.exe");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cloudleague.de/gfn/EGL.zip", @"C:\Gabe\epic.zip", @"C:\Gabe", @"  C:\Gabe\EGL\Launcher\Engine\Binaries\Win64\EpicGamesLauncher.exe");

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://picteon.dev/files/shared/Origin.zip", @"C:\Gabe\Origin.zip", @"C:\Gabe", @"C:\Gabe\Origin\Origin.exe");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/ii6zhxpqh9wb5vo/Minecraft.rar", @"C:\Gabe\mcdungeons.zip", @"C:\Gabe", @"C:\Gabe\mc dungeon\minecraft_server.exe");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZipSpecifyRuntimePath("https://picteon.dev/files/shared/Minecraft.zip", @"c:\gabe\mc.zip", @"C:\gabe\", @"C:\gabe\Minecraft\Minecraft.bat", @"C:\Gabe\Minecraft");

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/726930094676770947/742880083710312489/RobloxPlayerLauncher.exe", @"c:\gabe\Roblox.exe");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://m1.ppy.sh/r/osu!install.exe", @"c:\gabe\osu.exe");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabled because the download stopped working and I dont have a good download link. Torrent it");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The publisher of this game/program has disallowed usage of their software on GeForce Now.", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://use.imfast.io/ZombsRoyaleio.zip", @"C:\Gabe\ZombsRoyale.zip", @"C:\Gabe", @"C:\Gabe\ZombsRoyaleio\content\zombsroyale.exe");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://lol.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.euw.exe", @"C:\Gabe\LoL.exe");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://client2.krunker.io/setup.exe", @"c:\Gabe\krunk.exe");
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cdn.discordapp.com/attachments/741701372277424229/762022453521547274/Among.Us.v2020.9.9s-20201003T183507Z-001.zip", @"C:\Gabe\Among Us.rar", @"C:\Gabe\", @"C:\Gabe\Among.Us.v2020.9.9s\Among Us.exe");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://api.lunarclient.com/site/download?os=windows", @"C:\Gabe\LunarClient.exe");
            MessageBox.Show("Anticheat must be disabled while launching!", "Info");
        }
    }
}
