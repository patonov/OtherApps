using System;
using System.IO;
using System.Diagnostics;

namespace Chrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");

            Random generator = new Random();
            
            string file = "begin.zip";

            string directory = @"D:\Documents\SOFTUNI\algorithms";

            string source = Path.Combine(directory, file);

            string destination = Path.Combine(directory, generator.Next().ToString());

            File.Copy(source, destination);
        }
    }
}
