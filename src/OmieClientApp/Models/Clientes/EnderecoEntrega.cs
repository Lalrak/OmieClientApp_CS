using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Endereço de entrega do cliente ou fornecedor.
/// </summary>
public class EnderecoEntrega
{
    /// <summary>
    /// Nome / Razão Social do recebedor. (Até 60 caracteres)
    /// </summary>
    [JsonProperty("entRazaoSocial")]
    [StringLength(60, ErrorMessage = "O campo Razão Social deve ter no máximo 60 caracteres.")]
    public string EntRazaoSocial { get; set; }

    /// <summary>
    /// CNPJ / CPF do recebedor. (até 20 caracteres)
    /// </summary>
    [JsonProperty("entCnpjCpf")]
    [StringLength(20, ErrorMessage = "O campo CNPJ / CPF deve ter no máximo 20 caracteres.")]
    public string EntCnpjCpf { get; set; }

    /// <summary>
    /// Logradouro do endereço. (até 60 caracteres)
    /// </summary>
    [JsonProperty("entEndereco")]
    [StringLength(60, ErrorMessage = "O campo Endereço deve ter no máximo 60 caracteres.")]
    public string EntEndereco { get; set; }

    /// <summary>
    /// Número do endereço. (até 60 caracteres)
    /// </summary>
    [JsonProperty("entNumero")]
    [StringLength(60, ErrorMessage = "O campo Número deve ter no máximo 60 caracteres.")]
    public string EntNumero { get; set; }

    /// <summary>
    /// Complemento do endereço. (até 60 caracteres)
    /// </summary>
    [JsonProperty("entComplemento")]
    [StringLength(60, ErrorMessage = "O campo Complemento deve ter no máximo 60 caracteres.")]
    public string EntComplemento { get; set; }

    /// <summary>
    /// Bairro. (até 60 caracteres)
    /// </summary>
    [JsonProperty("entBairro")]
    [StringLength(60, ErrorMessage = "O campo Bairro deve ter no máximo 60 caracteres.")]
    public string EntBairro { get; set; }

    /// <summary>
    /// CEP (formato texto de até 9 caracteres).
    /// </summary>
    [JsonProperty("entCEP")]
    [StringLength(9, ErrorMessage = "O campo CEP deve ter no máximo 9 caracteres.")]
    public string EntCep { get; set; }

    /// <summary>
    /// Sigla do Estado (2 caracteres).
    /// </summary>
    [JsonProperty("entEstado")]
    [StringLength(2, ErrorMessage = "O campo Estado deve ter no máximo 2 caracteres.")]
    public string EntEstado { get; set; }

    /// <summary>
    /// Nome ou código da cidade (até 40 caracteres).
    /// </summary>
    [JsonProperty("entCidade")]
    [StringLength(40, ErrorMessage = "O campo Cidade deve ter no máximo 40 caracteres.")]
    public string EntCidade { get; set; }

    /// <summary>
    /// Indica se o número e complemento devem ser separados do logradouro (“S” ou “N”).
    /// <para>
    /// Padrão Não: "N"
    /// </para>
    /// </summary>
    [JsonProperty("entSepararEndereco")]
    [StringLength(1, ErrorMessage = "O campo Separar Endereço deve ter no máximo 1 caractere.")]
    public string EntSepararEndereco { get; set; }

    /// <summary>
    /// Telefone de contato (até 15 caracteres).
    /// </summary>
    [JsonProperty("entTelefone")]
    [StringLength(15, ErrorMessage = "O Telefone deve ter no máximo 15 caracteres.")]
    public string EntTelefone { get; set; }

    /// <summary>
    /// Inscrição Estadual do recebedor (até 14 caracteres).
    /// </summary>
    [JsonProperty("entIE")]
    [StringLength(14, ErrorMessage = "A Inscrição Estadual deve ter no máximo 14 caracteres.")]
    public string EntIE { get; set; }
}

