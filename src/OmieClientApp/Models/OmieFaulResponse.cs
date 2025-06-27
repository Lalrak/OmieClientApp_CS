using Newtonsoft.Json;

namespace OmieClientApp.Models;

/// <summary>
/// Resposta genérica para erros da API Omie.
/// </summary>
public class OmieFaulResponse
{
    [JsonProperty("faultstring")]
    public string FaultString { get; set; }

    [JsonProperty("faultcode")]
    public string FaultCode { get; set; }
}
