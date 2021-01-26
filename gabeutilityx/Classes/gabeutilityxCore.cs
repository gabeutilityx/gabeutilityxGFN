using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.ComponentModel;
using Microsoft.Win32;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DiscordRPC;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Threading;
using System.Media;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using gabeutilityx.Forms;

namespace gabeutilityx.Classes
{
    public static class JunctionPoint
    {
        private const int ERROR_NOT_A_REPARSE_POINT = 4390;
        private const int ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391;
        private const int ERROR_INVALID_REPARSE_DATA = 4392;
        private const int ERROR_REPARSE_TAG_INVALID = 4393;
        private const int ERROR_REPARSE_TAG_MISMATCH = 4394;
        private const int FSCTL_SET_REPARSE_POINT = 0x000900A4;
        private const int FSCTL_GET_REPARSE_POINT = 0x000900A8;
        private const int FSCTL_DELETE_REPARSE_POINT = 0x000900AC;
        private const uint IO_REPARSE_TAG_MOUNT_POINT = 0xA0000003;
        private const string NonInterpretedPathPrefix = @"\??\";
        [Flags]
        private enum EFileAccess : uint
        {
            GenericRead = 0x80000000,
            GenericWrite = 0x40000000,
            GenericExecute = 0x20000000,
            GenericAll = 0x10000000,
        }
        [Flags]
        private enum EFileShare : uint
        {
            None = 0x00000000,
            Read = 0x00000001,
            Write = 0x00000002,
            Delete = 0x00000004,
        }
        private enum ECreationDisposition : uint
        {
            New = 1,
            CreateAlways = 2,
            OpenExisting = 3,
            OpenAlways = 4,
            TruncateExisting = 5,
        }
        [Flags]
        private enum EFileAttributes : uint
        {
            Readonly = 0x00000001,
            Hidden = 0x00000002,
            System = 0x00000004,
            Directory = 0x00000010,
            Archive = 0x00000020,
            Device = 0x00000040,
            Normal = 0x00000080,
            Temporary = 0x00000100,
            SparseFile = 0x00000200,
            ReparsePoint = 0x00000400,
            Compressed = 0x00000800,
            Offline = 0x00001000,
            NotContentIndexed = 0x00002000,
            Encrypted = 0x00004000,
            Write_Through = 0x80000000,
            Overlapped = 0x40000000,
            NoBuffering = 0x20000000,
            RandomAccess = 0x10000000,
            SequentialScan = 0x08000000,
            DeleteOnClose = 0x04000000,
            BackupSemantics = 0x02000000,
            PosixSemantics = 0x01000000,
            OpenReparsePoint = 0x00200000,
            OpenNoRecall = 0x00100000,
            FirstPipeInstance = 0x00080000
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct REPARSE_DATA_BUFFER
        {
            public uint ReparseTag;
            public ushort ReparseDataLength;
            public ushort Reserved;
            public ushort SubstituteNameOffset;
            public ushort SubstituteNameLength;
            public ushort PrintNameOffset;
            public ushort PrintNameLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x3FF0)]
            public byte[] PathBuffer;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode,
            IntPtr InBuffer, int nInBufferSize,
            IntPtr OutBuffer, int nOutBufferSize,
            out int pBytesReturned, IntPtr lpOverlapped);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            EFileAccess dwDesiredAccess,
            EFileShare dwShareMode,
            IntPtr lpSecurityAttributes,
            ECreationDisposition dwCreationDisposition,
            EFileAttributes dwFlagsAndAttributes,
            IntPtr hTemplateFile);
        public static void Create(string junctionPoint, string targetDir, bool overwrite)
        {
            targetDir = Path.GetFullPath(targetDir);
            if (!Directory.Exists(targetDir))
                throw new IOException("Target path does not exist or is not a directory.");
            if (Directory.Exists(junctionPoint))
            {
                if (!overwrite)
                    throw new IOException("Directory already exists and overwrite parameter is false.");
            }
            else
            {
                Directory.CreateDirectory(junctionPoint);
            }
            using (SafeFileHandle handle = OpenReparsePoint(junctionPoint, EFileAccess.GenericWrite))
            {
                byte[] targetDirBytes = Encoding.Unicode.GetBytes(NonInterpretedPathPrefix + Path.GetFullPath(targetDir));
                REPARSE_DATA_BUFFER reparseDataBuffer = new REPARSE_DATA_BUFFER();
                reparseDataBuffer.ReparseTag = IO_REPARSE_TAG_MOUNT_POINT;
                reparseDataBuffer.ReparseDataLength = (ushort)(targetDirBytes.Length + 12);
                reparseDataBuffer.SubstituteNameOffset = 0;
                reparseDataBuffer.SubstituteNameLength = (ushort)targetDirBytes.Length;
                reparseDataBuffer.PrintNameOffset = (ushort)(targetDirBytes.Length + 2);
                reparseDataBuffer.PrintNameLength = 0;
                reparseDataBuffer.PathBuffer = new byte[0x3ff0];
                Array.Copy(targetDirBytes, reparseDataBuffer.PathBuffer, targetDirBytes.Length);
                int inBufferSize = Marshal.SizeOf(reparseDataBuffer);
                IntPtr inBuffer = Marshal.AllocHGlobal(inBufferSize);
                try
                {
                    Marshal.StructureToPtr(reparseDataBuffer, inBuffer, false);
                    int bytesReturned;
                    bool result = DeviceIoControl(handle.DangerousGetHandle(), FSCTL_SET_REPARSE_POINT,
                        inBuffer, targetDirBytes.Length + 20, IntPtr.Zero, 0, out bytesReturned, IntPtr.Zero);
                    if (!result)
                        ThrowLastWin32Error("Unable to create junction point.");
                }
                finally
                {
                    Marshal.FreeHGlobal(inBuffer);
                }
            }
        }
        private static SafeFileHandle OpenReparsePoint(string reparsePoint, EFileAccess accessMode)
        {
            SafeFileHandle reparsePointHandle = new SafeFileHandle(CreateFile(reparsePoint, accessMode,
                EFileShare.Read | EFileShare.Write | EFileShare.Delete,
                IntPtr.Zero, ECreationDisposition.OpenExisting,
                EFileAttributes.BackupSemantics | EFileAttributes.OpenReparsePoint, IntPtr.Zero), true);
            if (Marshal.GetLastWin32Error() != 0)
                ThrowLastWin32Error("Unable to open reparse point.");
            return reparsePointHandle;
        }
        private static void ThrowLastWin32Error(string message)
        {
            throw new IOException(message, Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error()));
        }
    }

    // gabeutilityxCore
    class gabeutilityxCore
    {

        /// <summary>
        /// Extracts a file.
        /// </summary>
        /// <param name="PathToZip">Path of archived file</param>
        /// <param name="PathExtract">Path to extract the files to</param>
        public static void UnzipFile(string PathToZip, string PathExtract)
        {
            try
            {
                string zPath = @"c:\gabeutilityx\gabegaber2.exe";
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", @PathToZip, @PathExtract);
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch
            {
                // Handle exception here... 
            }
        }

        public static Dashboard dash = new Dashboard();
        WebClient webClient = new WebClient();


        /// <summary>
        /// Downloads archived file, extracts it and runs it.
        /// </summary>
        /// <param name="URLdl">Web address</param>
        /// <param name="PathZip">Path to download .zip file to</param>
        /// <param name="PathExtract">Path to extract the files to</param>
        /// <param name="PathExe">Path of the exe to run when extracted</param>
        public static void DownloadZip(string URLdl, string PathZip, string PathExtract, string PathExe)
        {
            if (File.Exists(@PathExe))
            {
                using (Process Program = new Process())
                {
                    try
                    {
                        Program.StartInfo.FileName = @PathExe;
                        Program.StartInfo.WorkingDirectory = @PathExtract;
                        Program.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Error occurred in gabeutilityxCore: Launch application failed");
                    }
                }
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.Proxy = null;
                try
                {
                    if(!File.Exists(PathZip))
                        webClient.DownloadFile(URLdl, @PathZip);
                }
                catch
                {
                    MessageBox.Show("Error occurred in gabeutilityxCore: Failed to download file");
                }

                try
                {
                    string zPath = @"c:\gabeutilityx\gabegaber2.exe";
                    ProcessStartInfo pro = new ProcessStartInfo();
                    pro.WindowStyle = ProcessWindowStyle.Hidden;
                    pro.FileName = zPath;
                    pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", @PathZip, @PathExtract);
                    Process x = Process.Start(pro);
                    x.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("Error occurred in gabeutilityxCore: Fatal error (Required files corrupted/deleted)");
                }
                File.Delete(@PathZip);
                using (Process Program = new Process())
                {
                    Program.StartInfo.FileName = @PathExe;
                    Program.StartInfo.WorkingDirectory = @PathExtract;
                    Program.Start();
                }
            }
        }

        /// <summary>
        /// Downloads archived file, extracts it and runs it in a certain path
        /// </summary>
        /// <param name="URLdl">Web address</param>
        /// <param name="PathZip">Path to download .zip file to</param>
        /// <param name="PathExtract">Path to extract the files to</param>
        /// <param name="PathExe">Path of the exe to run when extracted</param>
        /// <param name="RuntimePath">The folder to run the executable in</param>
        public static void DownloadZipSpecifyRuntimePath(string URLdl, string PathZip, string PathExtract, string PathExe, string RuntimePath)
        {
            if (File.Exists(@PathExe))
            {
                using (Process Program = new Process())
                {
                    try
                    {
                        Program.StartInfo.FileName = @PathExe;
                        Program.StartInfo.WorkingDirectory = @RuntimePath;
                        Program.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Error occurred in gabeutilityxCore: Launch application failed");
                    }
                }
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.Proxy = null;
                try
                {
                    if (!File.Exists(PathZip))
                        webClient.DownloadFile(URLdl, @PathZip);
                }
                catch
                {
                    MessageBox.Show("Error occurred in gabeutilityxCore: Failed to download file");
                }

                try
                {
                    string zPath = @"c:\gabeutilityx\gabegaber2.exe";
                    ProcessStartInfo pro = new ProcessStartInfo();
                    pro.WindowStyle = ProcessWindowStyle.Hidden;
                    pro.FileName = zPath;
                    pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", @PathZip, @PathExtract);
                    Process x = Process.Start(pro);
                    x.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("Error occurred in gabeutilityxCore: Fatal error (Required files corrupted/deleted)");
                }
                File.Delete(@PathZip);
                using (Process Program = new Process())
                {
                    Program.StartInfo.FileName = @PathExe;
                    Program.StartInfo.WorkingDirectory = @RuntimePath;
                    Program.Start();
                }
            }
        }

        /// <summary>
        /// Downloads an executable file and automatically runs it
        /// </summary>
        /// <param name="URLdl">Web address</param>
        /// <param name="Path">Path or file to overwrite</param>
        public static void DownloadExe(string URLdl, string Path)
        {
            if (File.Exists(Path))
                Process.Start(Path);
            else
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(URLdl, Path);
                    Start(Path);
                }
                catch
                {
                    MessageBox.Show("Error occurred in gabeutilityxCore: Failed to download file & Failed to open file");
                }
            }
        }


        /// <summary>
        /// Start file
        /// </summary>
        /// <param name="Path">Path of executable</param>
        public static void Start(string path)
        { Process.Start(path); }


        /// <summary>
        /// Download file
        /// </summary>
        /// <param name="URLdl">Web address</param>
        /// <param name="Path">Path or file to overwrite</param>
        public static void DownloadFile(string URLdl, string Path)
        {
            if (!File.Exists(@Path))
            {
                WebClient webClient = new WebClient();
                webClient.Proxy = null;
                webClient.DownloadFile(URLdl, @Path);
            }
        }


        // Startup code
        public static void Startup()
        {
            // For save
            File.Create(@"C:\Fake\text.txt");
            Directory.CreateDirectory(@"C:\Gabe\explorer\bin\shell\");
            Directory.CreateDirectory(@"C:\Fake\userdata");

            // Create README
            if(!File.Exists(@"C:\Fake\userdata\README.txt"))
                 File.WriteAllText(@"C:\Fake\userdata\README.txt", "Hey!\n\nDo not attempt to modify or delete these files, doing so will corrupt your gabeutilityx configs.\nThese files are encrypted for security.");
            
            // Apply dark theme and listview shadows
            Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced").SetValue("ListviewShadow", 1, RegistryValueKind.DWord);
            Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize").SetValue("AppsUseLightTheme", 0, RegistryValueKind.DWord);
            
            // Download shortcuts if they don't exist
            if (!File.Exists(@"C:\Users\kiosk\Documents\C.lnk"))
            {
                gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/771740369692000306/C.lnk", @"C:\Users\kiosk\Documents\C.lnk");
                gabeutilityxCore.DownloadFile("https://cdn.discordapp.com/attachments/489891892142669842/771740582137430026/gabeutilityx.lnk", @"C:\Users\kiosk\Documents\gabeutilityx.lnk");
            }
        }

        // Automatically creates directory and makes save.
        // Required for gabeutilityx function in Misc tab
        public static void MakeSave(string atDir, string saveHere)
        {
            Directory.CreateDirectory(@"C:\Fake\" + saveHere);
            JunctionPoint.Create(@atDir, @"C:\Fake\" + saveHere, true);
        }

        public static void CreateSave()
        {
            // Create folders if not already there
            Directory.CreateDirectory(@"C:\Gabe\Firefox\Data\profile");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\.minecraft");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\AnyDesk");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\Caprine");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\Mozilla");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\OBS");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\Parsec");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\Waterfox");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\wexond");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\discord\Local Storage");
            Directory.CreateDirectory(@"C:\Fake\AppData\Local\Mozilla");
            Directory.CreateDirectory(@"C:\Fake\AppData\Local\Waterfox");
            Directory.CreateDirectory(@"C:\Fake\AppData\Local\TeamSpeak 3");
            Directory.CreateDirectory(@"C:\Fake\AppData\LocalLow\Mozilla");
            Directory.CreateDirectory(@"C:\Fake\Saved Games\Mojang Studios");
            Directory.CreateDirectory(@"C:\Fake\AppData\Local\Google");
            Directory.CreateDirectory(@"C:\Fake\AppData\Roaming\Google");

            // Try to make links for saves
            // How this works: "C:/Fake" is always saved.
            // Make a link from "C:/Fake" to desired path. Windows will treat the link as a normal folder but will transfer contents to "C:/Fake"
            try
            {
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\.minecraft", @"C:\Fake\AppData\Roaming\.minecraft", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\Google", @"C:\Fake\AppData\Roaming\Google", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\AnyDesk", @"C:\Fake\AppData\Roaming\AnyDesk", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\Caprine", @"C:\Fake\AppData\Roaming\Caprine", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\Mozilla", @"C:\Fake\AppData\Roaming\Mozilla", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\OBS", @"C:\Fake\AppData\Roaming\OBS", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\Parsec", @"C:\Fake\AppData\Roaming\Parsec", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\discord\Local Storage", @"C:\Fake\AppData\Roaming\discord\Local Storage", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\Waterfox", @"C:\Fake\AppData\Roaming\Waterfox", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Roaming\wexond", @"C:\Fake\AppData\Roaming\wexond", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Local\Waterfox", @"C:\Fake\AppData\Local\Waterfox", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Local\Google", @"C:\Fake\AppData\Local\Google", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\Local\TeamSpeak 3", @"C:\Fake\AppData\Local\TeamSpeak 3", true);
                JunctionPoint.Create(@"C:\Users\kiosk\AppData\LocalLow\Mozilla", @"C:\Fake\AppData\LocalLow\Mozilla", true);
                JunctionPoint.Create(@"C:\Gabe\Firefox\Data\profile", @"C:\Fake\Firefox\Data\profile", true);
                JunctionPoint.Create(@"C:\Users\kiosk\Saved Games\Mojang Studios", @"C:\Fake\Saved Games\Mojang Studios", true);
            }
            catch { // Handle exception here... 
            }
            try
            {
                // Attempt to fix crash
                // Saving .jar assets and some other files cause crash when accessed. Fix by not saving these files at all.
                Directory.Delete(@"C:\Fake\AppData\Roaming\.minecraft\versions");
                Directory.Delete(@"C:\Fake\AppData\Roaming\.minecraft\assets");
                Directory.Delete(@"C:\Fake\AppData\Roaming\.minecraft\bin");
                Directory.Delete(@"C:\Fake\AppData\Roaming\.minecraft\libraries");
                Directory.Delete(@"C:\Fake\AppData\Roaming\.minecraft\versions");
            }
            catch{ // Handle exception here... 
            }
            }


    }
    public static class Global
    {
        public static string userdefine;
        public static string FillColor1Button;
        public static string FillColor2Button;
        public static string FillColorTitlebar;
        public static string ButtonFonts;
        public static string ThemeWallpaper;
        public static string ProfilePicture;
        public static string lastlogin;
        public static string version = "13.3";
        public static string Placeholder = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        public static string FavouriteColor;
    }
}
