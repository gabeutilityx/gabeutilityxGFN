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
    public partial class Programs : UserControl
    {
        public Programs()
        {
            InitializeComponent();
        }

        private void Programs_Load(object sender, EventArgs e)
        {

        }

        // Most of this stuff isnt commented. Self explanatory 

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/558981900337676288/752033255192133762/7z.dll", @"C:\Gabe\7z.dll");
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/558981900337676288/752033254298615848/7zFM.exe", @"C:\Gabe\gabergabe.exe");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://dl.discordapp.net/apps/win/0.0.308/DiscordSetup.exe", @"C:\Gabe\dsicord.exe");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Gabe\Firefox\icefox.exe"))
            {
                // Different method of downloading firefox
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://download.mozilla.org/?product=firefox-latest-ssl&os=win64&lang=en-US", @"C:\Gabe\firefoxIns.exe");
                Process process = Process.Start(@"C:\Gabe\firefoxIns.exe", @"/InstallDirectoryPath=C:\Gabe\Firefox");
                Thread.Sleep(8500);
                foreach (Process proc in Process.GetProcessesByName("setup"))
                {
                    proc.Kill();
                }
                File.Delete(@"C:\Gabe\firefoxIns.exe");
                File.Move(@"C:\Gabe\Firefox\firefox.exe", @"C:\Gabe\Firefox\icefox.exe");
                Process.Start(@"C:\Gabe\Firefox\icefox.exe");
            }
            else
            {
                Process.Start(@"C:\Gabe\Firefox\icefox.exe");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // explora
            foreach (Process proc in Process.GetProcessesByName("gfndesktop"))
            {
                proc.Kill();
            }
            if (!File.Exists(@"C:\Fake\DesktopWallpaper.png"))
                gabeutilityxCore.DownloadFile("https://i.imgur.com/B129d2u.jpeg", @"C:\Fake\DesktopWallpaper.png");
            File.Copy(@"C:\Fake\DesktopWallpaper.png", @"C:\Gabe\explorer\bin\shell\wallpaper.jpg", true);
            gabeutilityxCore.DownloadZipSpecifyRuntimePath("https://cdn.discordapp.com/attachments/489891892142669842/779038626339225600/explorer.zip", @"C:\Gabe\explorer.zip", @"C:\Gabe", @"C:\Gabe\explorer\start.bat", @"C:\Gabe\explorer\");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/741840198492618753/741887348450656296/ph64.exe", @"C:\Gabe\purcasshakor.exe");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/722995919062171698/Notepad2x64.exe", @"c:\gabe\notpade.exe");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/722995893858730066/HxD.exe", @"c:\gabe\haxd.exe");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/489891892142669842/722998499322363914/Explorer.exe", @"C:\Gabe\Exploraae.exe");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/furie9ug2xftk0l/Wexond-5.1.0-win.zip", @"C:\Gabe\Wexond.zip", @"C:\Gabe\Wexond\", @"C:\Gabe\Wexond\Wexond.exe");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://picteon.dev/files/RegCool.exe", @"C:\Gabe\regcool2.exe");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://picteon.dev/files/AnyDesk.exe", @"C:\Gabe\Anydeskk.exe");
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://use.imfast.io/Water.zip", @"C:\Gabe\waterfox.zip", @"C:\Gabe", @"C:\Gabe\Water\sky.exe");
            File.Delete(@"C:\Gabe\Water\updater.exe");
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://download.scdn.co/SpotifySetup.exe", @"C:\Gabe\SyisuyZT7H87hsT78S.exe");
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://picteon.dev/files/SublimeText3.zip", @"C:\Gabe\Sublime.zip", @"C:\Gabe\", @"C:\Gabe\Sublime Text 3\subl.exe");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/8v1pp6znuc38vnj/OBS.zip", @"C:\Gabe\OBS.zip", @"C:\Gabe\", @"C:\Gabe\OBS\64bit\masina.exe");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cdn.discordapp.com/attachments/748202403672883349/748216556084920460/parsec-flat-windows32.zip", @"C:\Gabe\ParseHeck.zip", @"C:\Gabe\Parsec", @"C:\Gabe\Parsec\parsecd.exe");
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/c5sggplb68unu0k/qBittorrent.zip", @"C:\Gabe\BitTorrent.zip", @"C:\Gabe\Biter", @"C:\Gabe\Biter\\Biter.exe");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://picteon.dev/files/shared/VLC%20Media%20Player.zip", "C:\\Gabe\\VLC.zip", "C:\\Gabe", "C:\\Gabe\\VLC\\VLC.exe");
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://picteon.dev/files/shared/GIMP.zip", @"C:\Gabe\GIMP.zip", @"C:\Gabe", @"C:\Gabe\GIMP\bin\gimp-2.10.exe");
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("http://mirror2.internetdownloadmanager.com/idman637build14.exe?b=1&filename=idman637build14.exe", @"C:\Gabe\idm.exe");
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/8kzl8mxywdxwini/Cheat%20Engine%207.0.zip", @"C:\Gabe\CheatEngine.zip", @"C:\Gabe", @"C:\Gabe\Cheat Engine 7.0\Cheat Engine.exe");
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/zwhdx1d0qjs1ag6/caprine-portable-win64-2.48.0-29.7z", @"C:\Gabe\Caprine.zip", @"C:\Gabe\Caprine", @"C:\Gabe\Caprine\App\Caprine.exe");
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/z6ng6a5h8izhxcc/Blender%202.82.zip", @"C:\Gabe\Blender.zip", @"C:\Gabe", @"C:\Gabe\Blender 2.82\blender.exe");

        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/4mh57efujz70dlg/vscode-portable-win64-1.48.2-37.7z", @"C:\Gabe\vscode.zip", @"C:\Gabe\VS Code\", @"C:\Gabe\VS Code\vscode-portable.exe");

        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/z3j6uvllssqxkmj/teamspeak-client-portable-win64-3.5.3-17.7z", @"C:\Gabe\teamspeak.zip", @"C:\Gabe\Teamspeak", @"C:\Gabe\Teamspeak\teamspeak-client-portable.exe");

        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/wqxqipl3td3uls1/handbrake-portable-win64-1.3.3-7.7z", @"C:\Gabe\handbrake.zip", @"C:\Gabe\HandBrake", @"C:\Gabe\HandBrake\handbrake-portable.exe");
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/zujv6g7dldsldi6/intellij-idea-community-portable-2020.2.1-43.7z", @"C:\Gabe\IntelliJidea.zip", @"C:\Gabe\IntelliJ IDEA\", @"C:\Gabe\IntelliJ IDEA\intellij-idea-community-portable-win64.exe");

        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/0a5x26r3n8rhdx4/Vegas.rar", @"C:\Gabe\Vegas.rar", @"C:\Gabe", @"C:\Gabe\Vegas\vegas170.exe");
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/knblbgn6lhoe3td/Cinema%204D%20R21%20IMPORTED%20BY%20MIZUIRO.zip", @"C:\Gabe\Cinema4d.zip", @"C:\Gabe", @"C:\Gabe\Maxon Cinema 4D R21\Cinema 4D.exe");

        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://dl.dropboxusercontent.com/s/guhlj1h589m2sog/Cairo%20Desktop.zip", @"C:\Gabe\Cairo.zip", @"C:\Gabe", @"C:\Gabe\Cairo Shell\CairoDesktop.exe");

        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://usecsharpedition.s3.eu-central-1.amazonaws.com/Dependencies/powershell.exe", @"C:\Gabe\puwrshel.exe");
        }

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadExe("https://cdn.discordapp.com/attachments/745387568752754709/746001333441789992/GAY.exe", @"C:\Gabe\CtrlTab.exe");
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadZip("https://cdn.discordapp.com/attachments/489891892142669842/759853604240097330/Notepad.zip", @"C:\Gabe\NotepadPlusPlus.zip", @"C:\Gabe", @"C:\Gabe\Notepad++\App\noepad\sand.exe");
        }
    }
}
