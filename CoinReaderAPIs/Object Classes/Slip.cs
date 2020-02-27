using Newtonsoft.Json;

namespace CoinReaderAPIs.Object_Classes
{
    class AdviceSlip
    {
        [JsonProperty("slip")]
        public Slip slip;

        public class Slip
        {
            [JsonProperty("advice")]
            public string Advice { get; set; }

            [JsonProperty("slip_id")]
            public string SlipID { get; set; }
        }
        
    }
}
