using CoinReaderAPIs.Object_Classes;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CoinReaderAPIs
{
    public class Facts
    {
        private const string uri = @"https://uselessfacts.jsph.pl/random.json?language=en";

        public async Task<string> GetFact()
        {
            var fact = JsonConvert.DeserializeObject<Fact>(
                await HttpRequester.GetResponseAsync(uri));

            return fact.Text;
        }
    }
}
