using AutoUpdaterDotNET;
using System.Reflection;

namespace ConsoleAppAutoUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AutoUpdater.Synchronous = true;
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            //AutoUpdater.Mandatory = true;
            //AutoUpdater.UpdateMode = Mode.Forced; //Mode.ForcedDownload
            //AutoUpdater.HttpUserAgent = "AutoUpdater";
            //AutoUpdater.ReportErrors = true;
            //AutoUpdater.RunUpdateAsAdmin = false;
            //AutoUpdater.OpenDownloadPage = true;
            //AutoUpdater.RunUpdateAsAdmin = false;

            //
            //fonte: https://github.com/ravibpatel/AutoUpdater.NET?tab=readme-ov-file



            AutoUpdater.Start("https://raw.githubusercontent.com/renatolobojr/app-auto-atualizavel/master/ConsoleAppAutoUpdate.exe"); //endereço do xml de verificação de update


            Console.WriteLine("Updated!");

            //AutoUpdater.Start("ftp://rbsoft.org/updates/AutoUpdaterTest.xml", new NetworkCredential("FtpUserName", "FtpPassword"));
            //AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml", myAssembly);
            //AutoUpdater.InstalledVersion = new Version("1.2");

        }
    }
}
