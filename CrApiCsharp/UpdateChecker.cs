using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrApiCsharp
{
    internal class UpdateChecker
    {
        internal static void Check()
        {
            try
            {
                WebClient wc = new WebClient();
                string json = wc.DownloadString("http://github.com/Mahi-Uddin/blob/master/CrApiCsharp/version.json");
                string latestVersion = JsonConvert.DeserializeObject<WrapperVersion>(json).version;
                string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                if (latestVersion == currentVersion)
                {
                    if(HasConsole)
                        Console.WriteLine("Your app is up-to-date.");
                }
                else
                {
                    if (!HasConsole)
                        Console.WriteLine($"There is a new version available.\nNew version is {latestVersion}.\nWould you like to download?\nY/N");
                    var result = Console.ReadKey();
                    if (result.Key == ConsoleKey.Y)
                    {
                        Process.Start("http://zihad.net78.net/MEmuManager.zip");
                    }
                    else if (result.Key == ConsoleKey.N)
                    {
                        if (HasConsole)
                            Console.WriteLine("It's better to always have the latest version! :)");
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception)
            {
                if (HasConsole)
                    Console.WriteLine("Problem checking for updates.\nPlease check your connection and try again later.");
            }
        }
        private static bool? hasConsole;
        private static bool HasConsole
        {
            get
            {
                if (hasConsole == null)
                {
                    hasConsole = true;
                    try { int window_height = Console.WindowHeight; }
                    catch { hasConsole = false; }
                }
                return hasConsole.Value;
            }
        }
    }
}
