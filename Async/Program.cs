using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Async
{

    class Program
    {
        static void Main(string[] args)
        {
            var webClient = new DownloadHtml();

            webClient.DownloadHtmlAsync("https://www.google.ro/");

            Console.WriteLine("This text ran after function call.");
            Console.ReadLine();
        }
    }
}
