using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// <para>Parâmetro para filtro por código de cliente.</para>
/// </summary>
public class ClientePorCodigo
{
    /// <summary>
    /// <para>Código interno do cliente no Omie.</para>
    /// </summary>
    [JsonPropertyName("codigo_cliente_omie")]
    public long CodigoClienteOmie { get; set; }

    /// <summary>
    /// <para>Código de integração do cliente.</para>
    /// </summary>
    [JsonPropertyName("codigo_cliente_integracao")]
    [StringLength(60, ErrorMessage = "O campo CodigoClienteIntegracao deve ter no máximo 60 caracteres.")]
    public string CodigoClienteIntegracao { get; set; }
}