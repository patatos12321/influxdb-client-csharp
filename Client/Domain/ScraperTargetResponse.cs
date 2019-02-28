using Newtonsoft.Json;

namespace InfluxDB.Client.Domain
{
    public class ScraperTargetResponse: ScraperTarget
    {
        [JsonProperty("organization")]
        public string OrgName { get; set; }
        
        [JsonProperty("bucket")]
        public string BucketName { get; set; }
    }
}