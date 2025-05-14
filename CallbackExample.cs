using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class FileDownloader
    {
        public delegate void DownloadNotification(string fileName);

        public void DownloadFile(string url, DownloadNotification notification)
        {
            Console.WriteLine("Downloading file ...... " + url);
            System.Threading.Thread.Sleep(2000); // Simulate a delay for the download
            Console.WriteLine("Download complete!");
            notification("file1.txt");
        }
    }
        public class CallbackExample
    {
        public static void Main(string[] args)
        {
            FileDownloader downloader = new FileDownloader();
            downloader.DownloadFile("https://www.google.com", CallbackNotification);
        }

        public static void CallbackNotification(string fileName)
        {
            Console.WriteLine($"Received File with name {fileName}");
        }
    }
}
