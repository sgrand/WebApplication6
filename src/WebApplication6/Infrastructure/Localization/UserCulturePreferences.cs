using Newtonsoft.Json;

namespace WebApplication6.Infrastructure.Localization
{
    public class UserCulturePreferences
    {
        //[JsonProperty("c")]
        //public string CurrencySymbol { get; set; }
        [JsonProperty("l")]
        public string Language { get; set; }
        //[JsonProperty("ld")]
        //public string LongDateFormat { get; set; }
        //[JsonProperty("sd")]
        //public string ShortDateFormat { get; set; }

    }
}