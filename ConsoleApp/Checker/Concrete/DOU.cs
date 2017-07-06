using System.Net;

namespace ConsoleApp.Checker.Concrete
{
    class DOU : IChecker
    {
        public string Url { get => "https://dou.ua"; }

        public string Check()
        {
            var request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "HEAD"; // For status code only, without body response
            var response = (HttpWebResponse)request.GetResponse();

            return (int)response.StatusCode == 200 ? "DOU.UA ONLINE" : "DOU.UA OFFLINE";
        }
    }
}
