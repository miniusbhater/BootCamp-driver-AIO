using System.Diagnostics;
using System.Net;
using System.Management;
using System;
using Microsoft.VisualBasic;
using System.Security.Principal;

Thread.Sleep(400);
Console.WriteLine("Version: 0.1.0.0");
Thread.Sleep(75);
Console.WriteLine("Build date: 02/01/2025");
Thread.Sleep(1000);
Console.WriteLine("Getting computer information...");
Thread.Sleep(500);
string mani = "error!"; 
string mode = "error!"; 
string osversion = "error!";
string machnam = "error!";




try
{

    System.Management.SelectQuery query = new System.Management.SelectQuery(@"Select * from Win32_ComputerSystem");

    using (System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query))
    {
        foreach (System.Management.ManagementObject process in searcher.Get())
        {
            process.Get();
            Console.WriteLine("{0}{1}", "System Manufacturer:", process["Manufacturer"]);
            Console.WriteLine("{0}{1}", " System Model:", process["Model"]);

            mani = process["Manufacturer"] as string;
            mode = process["Model"] as string;
        }
    }

    System.Management.ManagementObjectSearcher searcher1 = new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
    System.Management.ManagementObjectCollection collection = searcher1.Get();

    foreach (ManagementObject obj in collection)
    {
        if (((string[])obj["BIOSVersion"]).Length > 1)
            Console.WriteLine("BIOS VERSION: " + ((string[])obj["BIOSVersion"])[0] + " - " + ((string[])obj["BIOSVersion"])[1]);
        else
            Console.WriteLine("BIOS VERSION: " + ((string[])obj["BIOSVersion"])[0]);
    }
}

catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("FAILED TO GET COMPUTER INFORMATION");
    Console.ResetColor();
}
try
{
    Thread.Sleep(100);
    osversion = System.Environment.OSVersion.ToString();
}
catch 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Failed to obtain windows version");
    Console.ResetColor();
}


Console.WriteLine("Manufacturer: " + mani);
Console.WriteLine("Model: " + mode);
Thread.Sleep(100);
Console.WriteLine("Operating System: " + osversion);
Thread.Sleep(136);
Console.WriteLine("Machine Name: " + Environment.MachineName); // realised there was a better way of doing this
Thread.Sleep(300);

try
{

    if (IsRunningAsAdmin())
    {
        Console.WriteLine("Running as administrator");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("WARNING YOU ARE NOT RUNNING AS ADMINISTRATOR!");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Starting with administrator privilages will avoid crashes");
    }
    static bool IsRunningAsAdmin()
    {
        WindowsIdentity admin = WindowsIdentity.GetCurrent();
        if (admin == null)
        {
            return false;
        }
        WindowsPrincipal principal = new WindowsPrincipal(admin);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }
}

catch
{
    Console.WriteLine("An error occured checking for admin");
}

Thread.Sleep(3000);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Welcome to BootCamp AIO by miniusbhater");
Console.ResetColor();

Thread.Sleep(1500);
Console.Clear();
Thread.Sleep(200);
Console.WriteLine("\r\n__________               __   _________                        \r\n\\______   \\ ____   _____/  |_ \\_   ___ \\_____    _____ ______  \r\n |    |  _//  _ \\ /  _ \\   __\\/    \\  \\/\\__  \\  /     \\\\____ \\ \r\n |    |   (  <_> |  <_> )  |  \\     \\____/ __ \\|  Y Y  \\  |_> >\r\n |______  /\\____/ \\____/|__|   \\______  (____  /__|_|  /   __/ \r\n        \\/                            \\/     \\/      \\/|__|    \r\n                     _____  .___________                       \r\n                    /  _  \\ |   \\_____  \\                      \r\n                   /  /_\\  \\|   |/   |   \\                     \r\n                  /    |    \\   /    |    \\                    \r\n                  \\____|__  /___\\_______  /                    \r\n                          \\/            \\/                     \r\n");
Console.WriteLine("              Made with love by miniusbhater <3");
Console.WriteLine("                   Detected Model: " + mode);
Thread.Sleep(100);
Console.WriteLine("\n \n \n \nWhat BootCamp version do you want?");
Console.WriteLine("\n1. null \n2. null \n3. BootCamp5.0.5033 \n4. null \n5. null\n \n");
string? input = Console.ReadLine()?.ToLower();


if (input == "1")
{ 
    Thread.Sleep(200);
    Console.WriteLine("What version of Windows are you running?\n");
    Console.WriteLine("1. Windows 11 \n2. Windows 10\n\n");
    string? input1 = Console.ReadLine()?.ToLower();

    if (input1 == "1")
    {
        Thread.Sleep(200);
        Console.WriteLine("please make sure your Mac is one of the models displayed in the following list, then press any key to continue...");
        
        Console.ReadKey();
    }

    if (input1 == "2") 
        {
        Thread.Sleep(200);
        Console.WriteLine("please make sure your Mac is one of the models displayed in the following list, then press any key to continue...");

        Console.ReadKey();
    }

    if (input == "2")
    {
        Thread.Sleep(200);
    }

}
if (input == "3")
{
    Thread.Sleep(200);
        Thread.Sleep(200);
        Console.WriteLine("MacBook Air (Mid 2011) and (Mid 2012)\r\n\r\nMacBook Pro (Mid 2010)\r\n\r\n* MacBook Pro 13 inch-Mid 2010 is not supported\r\n\r\nMacBook Pro (Early 2011)\r\n\r\nMacBook Pro (Late 2011)\r\n\r\nMacBook Pro (Mid 2012)\r\n\r\nMacBook Pro (Retina, Mid 2012)\r\n\r\nMacBook Pro (Retina, Late 2012)\r\n\r\nMac Pro (Early 2009)\r\n\r\nMac Pro (Mid 2010)\r\n\r\nMac mini (Mid 2011)\r\n\r\nMac mini (Late 2012)\r\n\r\niMac (Mid 2011)\r\n\r\niMac (Late 2011)\r\n\r\niMac (Late 2012)");
        Thread.Sleep(200);
        Console.WriteLine("please make sure your Mac is one of the models displayed in the above list, then press any key to continue...");
        Console.ReadKey();
        Console.WriteLine("Downloading BootCamp 5.0.5033 drivers...");
        string bootcamp = "https://download.info.apple.com/Mac_OS_X/041-9675.20130314.f8Ji7/BootCamp5.0.5033.zip";
        string directoryPath = "C:\\";
        string fileName = "BootCamp5.0.5033.zip";
        string fullPath = Path.Combine(directoryPath, fileName);
        string downloadpercent = "NUL";

        var tcs = new TaskCompletionSource<bool>();

        using (WebClient webClient = new WebClient())
        {
            webClient.DownloadProgressChanged += (s, ev) =>
            {
                downloadpercent = $"Downloading... {ev.ProgressPercentage}%";
                Console.WriteLine(downloadpercent);
            };

            webClient.DownloadFileCompleted += (s, ev) =>
            {
                if (ev.Error != null)
                {
                    Console.WriteLine($"Error: {ev.Error.Message}");
                    Thread.Sleep(2500);
                }
                else
                {
                    Console.WriteLine("Download completed!");
                    Thread.Sleep(800);
                    Console.Clear();
                    Console.WriteLine("Made with love by miniusbhater <3");
                    Thread.Sleep(2000);
                    string downdirec = @"C:\BootCamp5.0.5033.zip";
                    Process.Start("explorer.exe", downdirec);
                   

                }
                tcs.SetResult(true);
            };

            webClient.DownloadFileAsync(new Uri(bootcamp), fullPath);
            Console.WriteLine("Download started...");
            await tcs.Task; 
        }
    }
    
