using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace Jansels_SE
{
    class Program
    {
#pragma warning disable IDE0060 // Nicht verwendete Parameter entfernen
        static void Main(string[] args)
#pragma warning restore IDE0060 // Nicht verwendete Parameter entfernen
        {
            Directory.CreateDirectory(@"B:\dl");
            Directory.CreateDirectory(@"B:\JanselSE");
            Console.Title = "Jansel Software Enabler V1.0";
            Console.CursorVisible = false;
            string user = Environment.UserName;
            Console.WriteLine("Current User (User that executed this): " + user);
            ManagementObjectSearcher myGPU = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in myGPU.Get())
            {
                Console.WriteLine("GPU: " + obj["Name"]);
            }
            
            Console.WriteLine("Hit any key to start the Download");
            Console.ReadKey();
            WebClient Hänno = new WebClient();
            //Firefox
            string website1 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213509&authkey=ANQuNQ3BJESrSgk";
            string filename1 = "Firefox.zip";
            //OBS Studio
            //string website21 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213511&authkey=AGAXJys6qw_yo40";
            //string website22 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213508&authkey=AJ_E2NCTGUmsezw";
            //string filename21 = "obsstudio.zip";
            //string filename22 = "obsstarter.bat";
            //Process Hacker
            string website3 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213513&authkey=AF08ZxGxFgehLnw";
            string filename3 = "proshac.exe";
            //VS Code          
            string website4 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213512&authkey=AAgJdnQmo66VXnE";
            string filename4 = "Code.zip";
            //Discord
            string website5 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213510&authkey=AMs9p86afMpAjXk";
            string filename5 = "Discord.zip";
            //Minecraft
            string website7 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213507&authkey=AFAriR68be0-6uI";
            string filename7 = "Minecraft.zip";
            //WinXShell
            string website8 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213500&authkey=AAIJqat_0Iw1MZs";
            string filename8 = "WinXShell.zip";
            //7-Zip
            string website9 = "https://onedrive.live.com/download?cid=5949261A3E41CD1B&resid=5949261A3E41CD1B%213505&authkey=AHXpu0hxXiSYokY";
            string filename9 = "8zip.zip";
            Hänno.DownloadFile(website1, filename1);
            Console.WriteLine("Downloaded Firefox");
            ZipFile.ExtractToDirectory("Firefox.zip", @"B:\dl\");
            Console.WriteLine("Extracted Firefox");
            //Hänno.DownloadFile(website21, filename21);
            //Hänno.DownloadFile(website22, filename22);
            //Console.WriteLine("Downloaded OBS Studio (Method by the GNF&USE Team)");
            //ZipFile.ExtractToDirectory("obsstudio.zip", @"B:\dl\");
            //Console.WriteLine("Extracted OBS Studio");
            Hänno.DownloadFile(website3, filename3);
            Console.WriteLine("Downloaded Process Hacker");
            Hänno.DownloadFile(website4, filename4);
            Console.WriteLine("Downloaded Visual Studio Code");
            ZipFile.ExtractToDirectory("Code.zip", @"B:\dl\");
            Console.WriteLine("Extracted Visual Studio Code");
            Hänno.DownloadFile(website5, filename5);
            Console.WriteLine("Downloaded Discord");
            ZipFile.ExtractToDirectory("Discord.zip", @"B:\dl\");
            Console.WriteLine("Extracted Discord");
            Hänno.DownloadFile(website7, filename7);
            Console.WriteLine("Downloaded Minecraft");
            ZipFile.ExtractToDirectory("Minecraft.zip", @"B:\dl\");
            Console.WriteLine("Extracted Minecraft");
            Hänno.DownloadFile(website9, filename9);
            Console.WriteLine("Downloaded 7-Zip");
            ZipFile.ExtractToDirectory("8zip.zip", @"B:\dl\");
            Console.WriteLine("Extracted 7-Zip");
            Hänno.DownloadFile(website8, filename8);
            Console.WriteLine("Downloaded WinXShell");
            ZipFile.ExtractToDirectory("WinXShell.zip", @"B:\JanselSE\");
            Console.WriteLine("Extracted WinXShell\nStarting WinXShell...");
            Process.Start(@"B:\JanselSE\WinXShell\start.bat");
        }
    }
}
