using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Representa o objeto de cadastro de cliente resumido conforme definido pela API Omie.
/// </summary>
public class ClientesCadastroResumido
{
    /// <summary>
    /// Código interno do cliente / fornecedor no Omie.
    /// </summary>
    [JsonProperty("codigo_cliente")]
    public long CodigoCliente { get; set; }

    /// <summary>
    /// Código de integração atribuído pelo sistema do usuário.
    /// </summary>
    [JsonProperty("codigo_cliente_integracao")]
    [StringLength(60, ErrorMessage = "O campo Código de Integração deve ter no máximo 60 caracteres.")]
    public string CodigoClienteIntegracao { get; set; }

    /// <summary>
    /// Razão Social ou nome completo do cliente.
    /// </summary>
    [JsonProperty("razao_social")]
    [StringLength(60, ErrorMessage = "O campo Razão Social deve ter no máximo 60 caracteres.")]
    public string RazaoSocial { get; set; }

    /// <summary>
    /// Nome fantasia ou apelido comercial do cliente.
    /// </summary>
    [JsonProperty("nome_fantasia")]
    [StringLength(60, ErrorMessage = "O campo Nome Fantasia deve ter no máximo 60 caracteres.")]
    public string NomeFantasia { get; set; }

    /// <summary>
    /// CNPJ ou CPF do cliente (somente números).
    /// </summary>
    [JsonProperty("cnpj_cpf")]
    [StringLength(20, ErrorMessage = "O campo CNPJ / CPF deve ter no máximo 20 caracteres.")]
    public string CnpjCpf { get; set; }
}
