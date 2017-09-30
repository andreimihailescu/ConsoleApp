using System.Net;
using System.Threading.Tasks;
using System;

namespace Async
{
    public class DownloadHtml
    {
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            Console.WriteLine(html);
        }
    }
}
