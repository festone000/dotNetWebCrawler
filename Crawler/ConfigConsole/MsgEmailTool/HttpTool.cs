using System.Net.Http;
using System.Threading.Tasks;

namespace ConfigConsole.MsgEmailTool
{
    public class HttpTool
    {
        public Task<HttpResponseMessage> SendAsync(string url, object obj)
        {
            return Task.Factory.StartNew(() =>
            {
                var client = new HttpClient();
                HttpContent content = obj as HttpContent;
                return client.PostAsync(url,content).Result;
            });
        }
    }
}