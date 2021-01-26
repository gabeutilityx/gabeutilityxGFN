using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using DiscordRPC;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Threading;
using System.Media;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.IO.Compression;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Devices;
using Guna.UI2.WinForms;
using gabeutilityx.Classes;

namespace gabeutilityx.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        static Dashboard _obj;
        public static DiscordRpcClient client;
        
        public static Dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }

        // Fill colors on side
        public void FillColors()
        {
            try
            {
                Color Colors = System.Drawing.Color.FromName(Global.FavouriteColor);
                bar1.FillColor = Colors;
                bar2.FillColor = Colors;
            }
            catch { }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Fill colors
            FillColors();
            
            // Define webclient
            WebClient webClient = new WebClient();

            // Bring scrollwheel to front if it's not for whatever reason
            scroll.BringToFront();

            // Get session type from calculating ram size
            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            string RAM = (mem / (1024 * 1024)).ToString();
            if (RAM == "15351")
            { sessionType.Text = "Session Type: Tesla P40"; }
            if (RAM == "7152")
            {
                sessionType.Text = "Session Type: RTX T10-8";
            }

            // Change version text
            Version.Text = Global.version;


            // Discord RPC
            client = new DiscordRpcClient("746442596880220180");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "GeForce NOW Exploit",
                State = Global.version,
                Assets = new Assets
                {
                    LargeImageKey = "gx",
                    LargeImageText = "shoppy.gg/@gabeutilityx",
                }
            });
            
            // Mega scuffed profile picture download method
            if (!File.Exists(@"C:\gabeutilityx\" + Global.userdefine + ".png"))
            {
                try
                {
                    gabeutilityxCore.DownloadFile(Global.ProfilePicture, @"c:\gabeutilityx\" + Global.userdefine + ".png");
                }
                catch
                {
                    try
                    {
                        gabeutilityxCore.DownloadFile("https://gabeutilityx.imfast.io/" + Global.userdefine + ".png", @"c:\\gabeutilityx\\" + Global.userdefine + ".png");
                        Global.ProfilePicture = "https://gabeutilityx.imfast.io/" + Global.userdefine + ".png";
                    }
                    catch
                    {
                        gabeutilityxCore.DownloadFile("https://gabeutilityx.imfast.io/gabe.png", @"c:\\gabeutilityx\\" + Global.userdefine + ".png");
                        Global.ProfilePicture = "https://gabeutilityx.imfast.io/gabe.png";
                    }
                }
            }

            // Make this dir for later
            Directory.CreateDirectory("c:\\gabeutilityx\\login");


            // Set image
            try
            {
                UserProfile.Image = Image.FromFile("c:\\gabeutilityx\\" + Global.userdefine + ".png");
                UserProfile.SizeMode = PictureBoxSizeMode.Zoom;
                Username.Text = Global.userdefine;
            }
            catch { 
            // handle exception here
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        // Crappy scroll but it works i guess
        private void scroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (programs1.Visible == true)
            {
                programs1.AutoScrollPosition = new Point(0, scroll.Value);
                scroll.Invalidate();
            }
            else if (gaming1.Visible == true)
            {
                gaming1.AutoScrollPosition = new Point(0, scroll.Value);
                scroll.Invalidate();
            }
            else if (cheats1.Visible == true)
            {
                cheats1.AutoScrollPosition = new Point(0, scroll.Value);
                scroll.Invalidate();
            }
            else if (misc1.Visible == true)
            {
                misc1.AutoScrollPosition = new Point(0, scroll.Value);
                scroll.Invalidate();
            }
            else if (settings1.Visible == true)
            {
                settings1.AutoScrollPosition = new Point(0, scroll.Value);
                scroll.Invalidate();
            }
        }


        // Button clicks that show/hide usercontrols for stuff

        private void Programs_Click(object sender, EventArgs e)
        {
            if (programs1.Visible == true)
            {
                programs1.Hide();
                cheats1.Hide();
                gaming1.Hide();
                settings1.Hide();
                misc1.Hide();
                scroll.Maximum = 300;
                scroll.ThumbSize = 10;
            }
            else
            {
                programs1.Show();
                cheats1.Hide();
                gaming1.Hide();
                misc1.Hide();
                settings1.Hide();
                scroll.Maximum = 1900;
                scroll.ThumbSize = 45;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (gaming1.Visible == true)
            {
                programs1.Hide();
                gaming1.Hide();
                cheats1.Hide();
                settings1.Hide();
                misc1.Hide();
                scroll.Maximum = 300;
                scroll.ThumbSize = 10;
            }
            else
            {
                programs1.Hide();
                cheats1.Hide();
                gaming1.Show();
                settings1.Hide();
                misc1.Hide();
                scroll.Maximum = 700;
                scroll.ThumbSize = 45;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (cheats1.Visible == true)
            {
                programs1.Hide();
                gaming1.Hide();
                misc1.Hide();
                settings1.Hide();
                cheats1.Hide();
                scroll.Maximum = 300;
                scroll.ThumbSize = 10;
            }
            else
            {
                programs1.Hide();
                gaming1.Hide();
                cheats1.Show();
                settings1.Hide();
                misc1.Hide();
                scroll.Maximum = 400;
                scroll.ThumbSize = 20;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (misc1.Visible == true)
            {
                programs1.Hide();
                gaming1.Hide();
                settings1.Hide();
                misc1.Hide();
                cheats1.Hide();
                scroll.Maximum = 300;
                scroll.ThumbSize = 10;
            }
            else
            {
                programs1.Hide();
                gaming1.Hide();
                cheats1.Hide();
                settings1.Hide();
                misc1.Show();
                scroll.Maximum = 900;
                scroll.ThumbSize = 30;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (settings1.Visible == true)
            {
                programs1.Hide();
                gaming1.Hide();
                misc1.Hide();
                cheats1.Hide();
                settings1.Hide();
                scroll.Maximum = 300;
                scroll.ThumbSize = 10;
            }
            else
            {
                programs1.Hide();
                gaming1.Hide();
                cheats1.Hide();
                misc1.Hide();
                settings1.Show();
                scroll.Maximum = 100;
                scroll.ThumbSize = 45;
            }
        }


        // USG button
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gabeutilityxCore.DownloadFile("https://t1p.de/SteamUnsupported2020", @"C:\Gabe\unsup.bat");
            using (Process Program = new Process())
            {
                Program.StartInfo.FileName = @"C:\Gabe\unsup.bat";
                Program.StartInfo.WorkingDirectory = @"C:\";
                Program.Start();
                Program.WaitForExit();
                File.Delete(@"C:\Gabe\unsup.bat");
            }

        }
    }
}
