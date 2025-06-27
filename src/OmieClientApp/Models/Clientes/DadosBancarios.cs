using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Dados bancários do cliente ou fornecedor.
/// </summary>
public class DadosBancarios
{
    /// <summary>
    /// Código do Banco. (Até 3 caracteres).
    /// </summary>
    [JsonProperty("codigo_banco")]
    [StringLength(3, ErrorMessage = "O código do banco deve ter até 3 caracteres.")]
    public string CodigoBanco { get; set; }

    /// <summary>
    /// Agência. (Até 10 caracteres).
    /// </summary>
    [JsonProperty("agencia")]
    [StringLength(10, ErrorMessage = "A agência deve ter até 10 caracteres.")]
    public string Agencia { get; set; }

    /// <summary>
    /// Número da Conta Corrente.(Até 25 caracteres).
    /// </summary>
    [JsonProperty("conta_corrente")]
    [StringLength(25, ErrorMessage = "A conta corrente deve ter até 25 caracteres.")]
    public string ContaCorrente { get; set; }

    /// <summary>
    /// CNPJ ou CPF do titular. (Até 25 caracteres).
    /// </summary>
    [JsonProperty("doc_titular")]
    [StringLength(25, ErrorMessage = "O CNPJ ou CPF do titular deve ter até 25 caracteres.")]
    public string DocTitular { get; set; }

    /// <summary>
    /// Nome do titular. (Até 60 caracteres).
    /// </summary>
    [JsonProperty("nome_titular")]
    [StringLength(60, ErrorMessage = "O nome do titular deve ter até 60 caracteres.")]
    public string NomeTitular { get; set; }

    /// <summary>
    /// Definir transferência como forma de pagamento padrão (“S” para SIM, “N” para NÃO). (Até 1 caractere).
    /// </summary>
    [JsonProperty("transf_padrao")]
    [StringLength(1, ErrorMessage = "O campo Transferência Padrão deve ter até 1 caractere.")]
    public string TransfPadrao { get; set; }

    /// <summary>
    /// Chave PIX. (Até 60 caracteres).
    /// </summary>
    [JsonProperty("cChavePix")]
    [StringLength(60, ErrorMessage = "A chave PIX deve ter até 60 caracteres.")]
    public string CChavePix { get; set; }
}
