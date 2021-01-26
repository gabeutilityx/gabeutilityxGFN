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
using DiscordRPC;
using System.Data.SqlClient;
using System.Net;
using System.Collections.Specialized;
using System.Threading;
using Microsoft.Win32;
using System.Media;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using gabeutilityx;
using gabeutilityx.Classes;
using gabeutilityx.Forms;

namespace gabeutilityx
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        string classicLogin;
        public static DiscordRpcClient client;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

        private void Login_Load(object sender, EventArgs e)
        {
            // GeForce NOW Check
            if (!Debugger.IsAttached)
            {
                if (!File.Exists(@"C:\Windows\gfndesktop.exe"))
                {
                    Process.GetCurrentProcess().Kill();
                }
            }

            // Because for some reason not doing this will fucking break everything
            File.Create("script.txt");

            // Check for corruption
            try
            {
                if(File.Exists(@"C:\Fake\userdata\158f1753d9f4c2637df5827ebd667301.enc"))
                    Cipher.Decrypt(File.ReadAllText(@"C:\Fake\userdata\158f1753d9f4c2637df5827ebd667301.enc"), "Sima8UA7D6728ZmaHUA8h7na87NQ87na");
            }
            catch
            {
                // Exit to avoid issues
                MessageBox.Show("Corruption detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }



            // Define webclient
            WebClient webClient = new WebClient();


            // Filesystem
            Directory.CreateDirectory(@"c:\Gabe");
            Directory.CreateDirectory(@"c:\Gabe\Save");
            Directory.CreateDirectory(@"c:\Gabe2\7-ZipPortable\App\7-Zip64\");
            Directory.CreateDirectory(@"c:\gabeutilityx");
            Directory.CreateDirectory(@"c:\Fake");
            Directory.CreateDirectory(@"c:\gabeutilityx\info");


            // Process management
            // Commented out because it has been patched.

            //if (!File.Exists(@"C:\Gabe\Steam.exe"))
            //         File.Copy(@"C:\Windows\System32\cmd.exe", @"C:\Gabe\Steam.exe");
            //        if (!File.Exists(@"C:\Gabe\hl2.exe"))
            //            File.Copy(@"C:\Windows\System32\cmd.exe", @"C:\Gabe\hl2.exe");
            //        string zPath = "c:\\Gabe\\Steam.exe";
            //        string xPath = "c:\\Gabe\\hl2.exe";
            ///        ProcessStartInfo pro = new ProcessStartInfo();
            //         ProcessStartInfo pro1 = new ProcessStartInfo();
            //      pro.WindowStyle = ProcessWindowStyle.Hidden;
            ////       pro1.WindowStyle = ProcessWindowStyle.Hidden;
            //     pro.FileName = zPath;
            //       pro1.FileName = xPath;
            //      foreach (Process proc in Process.GetProcessesByName("Steam"))
            //     {
            //           proc.Kill();
            //      }
            //      Process x = Process.Start(pro);
            //        Process z = Process.Start(pro1);
            //        foreach (Process proc in Process.GetProcessesByName("team"))
            //       {
            //           proc.Kill();
            ////        }
            //       foreach (Process proc in Process.GetProcessesByName("cmd"))
            //       {
            //              proc.Kill();
            //      }



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

            // Read configuration files
            if (File.Exists(@"C:\Fake\userdata\Config.gbx"))
            {
                TextReader tr = new StreamReader(@"C:\Fake\userdata\Config.gbx");
                Global.ProfilePicture = tr.ReadLine();
                Global.FavouriteColor = tr.ReadLine();
                classicLogin = tr.ReadLine();
                tr.Close();
            }
            else
            { }


            // Extracting files
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/558981900337676288/752033255192133762/7z.dll", @"c:\gabeutilityx\7z.dll");
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/558981900337676288/752033249617903726/7z.exe", @"c:\gabeutilityx\gabegaber2.exe");
            if(File.Exists(@"C:\Fake\userdata\username.gbx"))
                Username.Text = File.ReadAllText(@"C:\Fake\userdata\username.gbx");
            Username.CharacterCasing = CharacterCasing.Lower;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get response and login/logout
            // This code is stripped. Login system has been removed.
            bool response = true;
            if (response == true)
                {
                // Create links
                gabeutilityxCore.CreateSave();

                // Do startup script
                gabeutilityxCore.Startup();

                // Set global username
                Global.userdefine = Username.Text;

                // Save name for next time
                File.WriteAllText(@"C:\Fake\userdata\username.gbx", Username.Text);
                
                    this.Hide();
                   new Dashboard().Show();
               }
              if (response == false)
                {
                if (!String.IsNullOrEmpty(Username.Text))
                    if (!String.IsNullOrEmpty(Password.Text))
                        MessageBox.Show("Invalid login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }

        // Perform click if pressed enter

        private void Username_KeyUp(object sender, KeyEventArgs e)
        {if (e.KeyValue == 13)loginbutton.PerformClick();}

        private void Password_KeyUp(object sender, KeyEventArgs e)
        {if (e.KeyValue == 13)loginbutton.PerformClick();}
    }
}
