using System.Net.Http;
using System.Threading.Tasks;

namespace CoinReaderAPIs
{
    class HttpRequester
    {
        public static async Task<string> GetResponseAsync(string uri)
        {
            var client = new HttpClient();
            return await client.GetStringAsync(uri);
        }

    }
}
