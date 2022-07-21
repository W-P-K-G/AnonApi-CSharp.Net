
using System.Net;
using Newtonsoft.Json;

namespace AnonApi_CSharp.Net
{
    public class AnonResults
    {
        [JsonProperty("status")] public bool Status { get; set; }
        [JsonProperty("data")] public Data Data { get; set; }
    }
    public class Data
    {
        [JsonProperty("file")] public file file { get; set; }
    }
    public class file
    {
        [JsonProperty("url")] public url url { get; set; }
    }
    public class url 
    {
        [JsonProperty("full")] public string full { get; set; }
    }
    internal class AnonApi
    {
        public AnonApi() { }
        public AnonResults sendFile(string filepath)
        {
            WebClient client = new WebClient();
            return JsonConvert.DeserializeObject<AnonResults>(System.Text.Encoding.ASCII.GetString(client.UploadFile("https://api.anonfiles.com/upload", filepath)));
        }
    }
}
