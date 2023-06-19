using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HangMan2
{
    public class Api
    {
        public string genword()
        {

            string downloadedString;
            WebClient client;
            client = new WebClient();
            downloadedString = client.DownloadString("https://random-word-api.herokuapp.com/word");
            downloadedString = downloadedString.Replace("[", "");
            downloadedString = downloadedString.Replace("]", "");
            downloadedString = downloadedString.Replace("\"", "");

            Console.WriteLine(downloadedString);

            return downloadedString;
        }

    }
}
