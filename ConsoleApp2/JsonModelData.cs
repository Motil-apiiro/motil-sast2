namespace ConsoleApp2;
using Newtonsoft.Json;


public class JsonModelData
{
    [JsonProperty] 
    public int IdOrName { get; set; }
    
    [JsonProperty] 
    public int Age { get; set; }
}