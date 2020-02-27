using Newtonsoft.Json;

namespace CoinReaderAPIs.Object_Classes
{
    class Fact
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_url")]
        public string SourceURL { get; set; }

        [JsonProperty("lanugage")]
        public string Language { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }
    }
}
