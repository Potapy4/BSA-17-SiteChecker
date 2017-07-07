using System.Net;

namespace ConsoleApp.Checker.Concrete
{
    class DOU : IChecker
    {
        public string Url { get => "https://dou.ua"; }

        public string Check()
        {
            string result = null;
            var request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "HEAD"; // For status code only, without body response      

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    result = "DOU.UA IS ONLINE";
                }
            }
            catch (WebException ex)
            {
                result = ex.Message;
            }

            return result;
        }
    }
}
