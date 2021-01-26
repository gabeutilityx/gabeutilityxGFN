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
using gabeutilityx.Forms.Tabs.Extra;
using System.Net;
using System.Net.Http;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Web.UI.Design;

namespace gabeutilityx.Forms.Tabs
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private static Random random = new Random();

        // Gen random string
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        bool isLinked = false;

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load info
            string filename = "158f1753d9f4c2637df5827ebd667301.enc";
            if(File.Exists(@"C:\Fake\userdata\" + filename))
            {
                try
                {
                    label1.Text = "Discord username: " + Cipher.Decrypt(File.ReadAllText(@"C:\Fake\userdata\" + filename), "Sima8UA7D6728ZmaHUA8h7na87NQ87na");
                }
                catch
                {
                    MessageBox.Show("Corruption detected", "Catastrophic failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.GetCurrentProcess().Kill();
                }
                isLinked = true;
                link.Text = "Unlink your Discord account";
            }
            // Stripped code
            label7.Text = "Account runs out at: ";
            label8.Text = "Account level: ";

            // Load pfp
            try
            {

                UserProfile.Image = Image.FromFile("c:\\gabeutilityx\\" + Global.userdefine + ".png");
                UserProfile.SizeMode = PictureBoxSizeMode.Zoom;
                Username.Text = Global.userdefine;
            }
            catch { }
        }

        // Write config to file.
        private void Programs_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(@"C:\Fake\userdata\Config.gbx");

            if (guna2CheckBox2.Checked == true)
                tw.WriteLine("https://gabeutilityx.imfast.io/" + Global.userdefine + ".png");
            else
                tw.WriteLine(guna2TextBox5.Text);
            tw.WriteLine(guna2TextBox1.Text);
            if (guna2CheckBox1.Checked == true)
                tw.WriteLine("true");
            else
                tw.Write("false");
            tw.Close();

            Global.FavouriteColor = guna2TextBox1.Text;

            Dashboard a = new Dashboard();
            a.FillColors();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            new colorlist().Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Mega scuffed way of Discord linking but who cares.

            // Create file to store link info
            string filename = "158f1753d9f4c2637df5827ebd667301.enc";
            if (isLinked == false)
            {
                try
                {
                    // Input discord name
                    string discordName = Microsoft.VisualBasic.Interaction.InputBox("Please enter in your Discord username and tag.", "Link your Discord account", "User#0001");
                    if (discordName != null)
                    {
                        if (discordName.Contains("#"))
                        {
                            // Send info
                            var values = new Dictionary<string, string>
                        {
                             { "content", "`Account linked successfully!`\n**gabeutilityx username:** `" + Global.userdefine + "`\n**Discord username**: `" + discordName },
                             { "username", "Account link successful - " + Global.userdefine },
                             { "avatar_url", Global.ProfilePicture }
                        };
                            var content = new FormUrlEncodedContent(values);
                            HttpClient client = new HttpClient();
                            client.PostAsync("", content);
                            File.WriteAllText(@"C:\Fake\userdata\" + filename, Cipher.Encrypt(discordName, "Sima8UA7D6728ZmaHUA8h7na87NQ87na"));
                            label1.Text = "Discord username: " + discordName;
                            MessageBox.Show("Your Discord account was sucessfully linked.");

                        }
                        else
                            MessageBox.Show("The username you gave was in an invalid format.", "Failed to link Discord account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("The username you gave was in an invalid format.", "Failed to link Discord account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Unexpected error", "Failed to link Discord account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Account unlinked. You are not allowed to link another account for a short period of time.", "Account unlinked successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete(@"C:\Fake\userdata\" + filename);
                link.Enabled = false;
                link.Text = "Link my Discord account to gabeutilityx (disabled)";
                label1.Text = "Discord username: None";
            }
        }
    }
}
