using Newtonsoft.Json;

namespace OmieClientApp.Models;

/// <summary>
/// Request para a API do Omie.
/// </summary>
public class OmieRequest
{
    /// <summary>
    /// Chama a API do Omie.
    /// </summary>
    [JsonProperty("call")]
    public string Call { get; set; }

    /// <summary>
    /// Chave da aplicação.
    /// </summary>
    [JsonProperty("app_key")]
    public string AppKey { get; set; }

    /// <summary>
    /// Chave secreta da aplicação.
    /// </summary>
    [JsonProperty("app_secret")]
    public string AppSecret { get; set; }

    /// <summary>
    /// Parâmetros da requisição.
    /// </summary>
    [JsonProperty("param")]
    public object[] Param { get; set; }
}
