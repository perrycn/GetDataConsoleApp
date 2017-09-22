using System.Net;

namespace GetDataConsoleApp
{
    public class RetrieveDataSync
    {
        public string GetDataFromAPI()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:49589/api/Data");
                return result;
            }
        }
    }
}
