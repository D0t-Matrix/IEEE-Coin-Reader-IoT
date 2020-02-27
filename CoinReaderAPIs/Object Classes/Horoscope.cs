using Newtonsoft.Json;

namespace CoinReaderAPIs.Object_Classes
{
    class Horoscope
    {
        [JsonProperty("week")]
        public string CurrentDate { get; set; }

        [JsonProperty("sunsign")]
        public string sign { get; set; }

        [JsonProperty("horoscope")]
        public string Description { get; set; }
    }
}
