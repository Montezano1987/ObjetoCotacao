using System.Text.Json.Serialization;

public class Data
{
    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("capacity GB")]
    public int? CapacityGB { get; set; }

    [JsonPropertyName("generation")]
    public string Generation { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [JsonPropertyName("CPU model")]
    public string CPUModel { get; set; }

    [JsonPropertyName("Hard disk size")]
    public string HardDiskSize { get; set; }

    [JsonPropertyName("Strap Colour")]
    public string StrapColour { get; set; }

    [JsonPropertyName("Case Size")]
    public string CaseSize { get; set; }

    [JsonPropertyName("Description")]
    public string Description { get; set; }

    [JsonPropertyName("Capacity")]
    public string Capacity { get; set; }

    [JsonPropertyName("Screen size")]
    public double? ScreenSize { get; set; }

    [JsonPropertyName("price")]
    public double? Price { get; set; }



}

public class ProdutoServiceDTO

{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }

    [JsonPropertyName("price")]
    public double? Price { get; set; }

    [JsonPropertyName("Capacity")]
    public string Capacity { get; set; }
}
