using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Recomendações do cliente ou fornecedor.
/// </summary>
public class Recomendacoes
{
    /// <summary>
    /// Número de parcelas.
    /// </summary>
    [JsonProperty("numero_parcelas")]
    [StringLength(3, ErrorMessage = "O número de parcelas deve ter até 3 caractere.")]
    public string NumeroParcelas { get; set; }

    /// <summary>
    /// Código do vendedor.
    /// </summary>
    [JsonProperty("codigo_vendedor")]
    public int CodigoVendedor { get; set; }

    /// <summary>
    /// Email de fatura.
    /// </summary>
    [JsonProperty("email_fatura")]
    [StringLength(200, ErrorMessage = "O Email Fatura deve ter até 200 caractere.")]
    public string EmailFatura { get; set; }

    /// <summary>
    /// Gerar boletos.
    /// </summary>
    [JsonProperty("gerar_boletos")]
    [StringLength(1, ErrorMessage = "O Email Fatura deve ter até 200 caractere.")]
    public string GerarBoletos { get; set; }

    /// <summary>
    /// Código da transportadora.
    /// </summary>
    [JsonProperty("codigo_transportadora")]
    public int CodigoTranportadora { get; set; }

    /// <summary>
    /// Tipo de assinante.
    /// </summary>
    [JsonProperty("tipo_assinante")]
    [StringLength(1, ErrorMessage = "O Email Fatura deve ter até 1 caractere.")]
    public string TipoAssinante { get; set; }
}
