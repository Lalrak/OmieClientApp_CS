using Newtonsoft.Json;

namespace OmieClientApp.Models.Clientes.Responses;

/// <summary>
/// Resposta da API de status de clientes.
/// </summary>
public class ClientesStatusResponse
{
    /// <summary>
    /// Código do cliente Omie.
    /// </summary>
    [JsonProperty("codigo_cliente_omie")]
    public long CodigoClienteOmie { get; set; }

    /// <summary>
    /// Código do cliente integrado.
    /// </summary>
    [JsonProperty("codigo_cliente_integracao")]
    public string CodigoClienteIntegracao { get; set; }

    /// <summary>
    /// Código do status do processamento.
    /// </summary>
    [JsonProperty("codigo_status")]
    public string CodigoStatus { get; set; }

    /// <summary>
    /// Descrição do status do processamento.
    /// </summary>
    [JsonProperty("descricao_status")]
    public string DescricaoStatus { get; set; }
}