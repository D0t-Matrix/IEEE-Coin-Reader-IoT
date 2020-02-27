using CoinReaderAPIs.Object_Classes;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CoinReaderAPIs
{
    public class Advice
    {
        private const string uri = @"https://api.adviceslip.com/advice";

        public async Task<string> GetAdvice()
        {
            var advice = JsonConvert.DeserializeObject<AdviceSlip>(
                await HttpRequester.GetResponseAsync(uri));

            return advice.slip.Advice;
        }
    }
}
