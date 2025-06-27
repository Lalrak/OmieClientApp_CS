using Newtonsoft.Json;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Tag do cliente ou fornecedor.
/// </summary>
public class Tag
{
    /// <summary>
    /// Tag do cliente ou fornecedor.
    /// </summary>
    [JsonProperty("tag")]
    public string Tags { get; set; }
}
