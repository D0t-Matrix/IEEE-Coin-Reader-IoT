using CoinReaderAPIs.Object_Classes;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CoinReaderAPIs
{
    public class Aztro
    {
        private const string uri = @"http://horoscope-api.herokuapp.com/horoscope";

        public async Task<string> GetHoroscopeDescription(string sign, string day="today")
        {
            var _uri = uri + $"/{day}/{sign}";

            var horoscope = JsonConvert.DeserializeObject<Horoscope>(
                await HttpRequester.GetResponseAsync(_uri));

            return horoscope.Description;
        }
    }
}
