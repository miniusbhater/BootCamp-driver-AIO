using System.Diagnostics;
using System.Net;
Console.WriteLine("MAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!!\nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \nMAKE SURE YOU RAN AS ADMINISTRATOR!! \n" + "");
Thread.Sleep(1000);
Console.Clear();
Thread.Sleep(200);
Console.WriteLine("\r\n__________               __   _________                        \r\n\\______   \\ ____   _____/  |_ \\_   ___ \\_____    _____ ______  \r\n |    |  _//  _ \\ /  _ \\   __\\/    \\  \\/\\__  \\  /     \\\\____ \\ \r\n |    |   (  <_> |  <_> )  |  \\     \\____/ __ \\|  Y Y  \\  |_> >\r\n |______  /\\____/ \\____/|__|   \\______  (____  /__|_|  /   __/ \r\n        \\/                            \\/     \\/      \\/|__|    \r\n                     _____  .___________                       \r\n                    /  _  \\ |   \\_____  \\                      \r\n                   /  /_\\  \\|   |/   |   \\                     \r\n                  /    |    \\   /    |    \\                    \r\n                  \\____|__  /___\\_______  /                    \r\n                          \\/            \\/                     \r\n");
Console.WriteLine("Version 1.0.0");
Thread.Sleep(100);
Console.WriteLine("\n \n \n \nWhat era is your Mac from?");
Console.WriteLine("\n1. 2017-2020 \n2. 2014-2016 \n3. 2011-2013 \n4. 2008-2010 \n5. 2006-2007\n \n");
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
    
