using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// <para>Filtros para pesquisa de clientes.</para>
/// </summary>
public class ClientesFiltro
{
    /// <summary>
    /// <para>Código interno do cliente no Omie.</para>
    /// </summary>
    [JsonProperty("codigo_cliente_omie")]
    public long? CodigoClienteOmie { get; set; }

    /// <summary>
    /// <para>Código de integração do cliente.</para>
    /// </summary>
    [JsonProperty("codigo_cliente_integracao")]
    [StringLength(60, ErrorMessage = "O campo CodigoClienteIntegracao deve ter no máximo 60 caracteres.")]
    public string CodigoClienteIntegracao { get; set; }

    /// <summary>
    /// <para>CNPJ ou CPF do cliente.</para>
    /// </summary>
    [JsonProperty("cnpj_cpf")]
    [StringLength(20, ErrorMessage = "O campo CnpjCpf deve ter no máximo 20 caracteres.")]
    public string CnpjCpf { get; set; }

    /// <summary>
    /// <para>Razão Social do cliente.</para>
    /// </summary>
    [JsonProperty("razao_social")]
    [StringLength(60, ErrorMessage = "O campo RazaoSocial deve ter no máximo 60 caracteres.")]
    public string RazaoSocial { get; set; }

    /// <summary>
    /// <para>Nome fantasia do cliente.</para>
    /// </summary>
    [JsonProperty("nome_fantasia")]
    [StringLength(100, ErrorMessage = "O campo NomeFantasia deve ter no máximo 100 caracteres.")]
    public string NomeFantasia { get; set; }

    /// <summary>
    /// <para>Logradouro do cliente.</para>
    /// </summary>
    [JsonProperty("endereco")]
    [StringLength(60, ErrorMessage = "O campo Endereco deve ter no máximo 60 caracteres.")]
    public string Endereco { get; set; }

    /// <summary>
    /// <para>Bairro do cliente.</para>
    /// </summary>
    [JsonProperty("bairro")]
    [StringLength(60, ErrorMessage = "O campo Bairro deve ter no máximo 60 caracteres.")]
    public string Bairro { get; set; }

    /// <summary>
    /// <para>Cidade do cliente.</para>
    /// </summary>
    [JsonProperty("cidade")]
    [StringLength(40, ErrorMessage = "O campo Cidade deve ter no máximo 40 caracteres.")]
    public string Cidade { get; set; }

    /// <summary>
    /// <para>Estado (UF) do cliente.</para>
    /// </summary>
    [JsonProperty("estado")]
    [StringLength(2, ErrorMessage = "O campo Estado deve ter no máximo 2 caracteres.")]
    public string Estado { get; set; }

    /// <summary>
    /// <para>CEP do cliente.</para>
    /// </summary>
    [JsonProperty("cep")]
    [StringLength(10, ErrorMessage = "O campo Cep deve ter no máximo 10 caracteres.")]
    public string Cep { get; set; }

    /// <summary>
    /// <para>Contato do cliente.</para>
    /// </summary>
    [JsonProperty("contato")]
    [StringLength(100, ErrorMessage = "O campo Contato deve ter no máximo 100 caracteres.")]
    public string Contato { get; set; }

    /// <summary>
    /// <para>E-mail do cliente.</para>
    /// </summary>
    [JsonProperty("email")]
    [StringLength(500, ErrorMessage = "O campo Email deve ter no máximo 500 caracteres.")]
    public string Email { get; set; }

    /// <summary>
    /// <para>Homepage do cliente.</para>
    /// </summary>
    [JsonProperty("homepage")]
    [StringLength(100, ErrorMessage = "O campo Homepage deve ter no máximo 100 caracteres.")]
    public string Homepage { get; set; }

    /// <summary>
    /// <para>Inscrição Municipal.</para>
    /// </summary>
    [JsonProperty("inscricao_municipal")]
    [StringLength(20, ErrorMessage = "O campo InscricaoMunicipal deve ter no máximo 20 caracteres.")]
    public string InscricaoMunicipal { get; set; }

    /// <summary>
    /// <para>Inscrição Estadual.</para>
    /// </summary>
    [JsonProperty("inscricao_estadual")]
    [StringLength(20, ErrorMessage = "O campo InscricaoEstadual deve ter no máximo 20 caracteres.")]
    public string InscricaoEstadual { get; set; }

    /// <summary>
    /// <para>Inscrição SUFRAMA.</para>
    /// </summary>
    [JsonProperty("inscricao_suframa")]
    [StringLength(20, ErrorMessage = "O campo InscricaoSuframa deve ter no máximo 20 caracteres.")]
    public string InscricaoSuframa { get; set; }

    /// <summary>
    /// <para>Indica se é pessoa física ("S" ou "N").</para>
    /// </summary>
    [JsonProperty("pessoa_fisica")]
    [StringLength(1, ErrorMessage = "O campo PessoaFisica deve ter no máximo 1 caractere.")]
    public string PessoaFisica { get; set; }

    /// <summary>
    /// <para>Optante do Simples Nacional ("S" ou "N").</para>
    /// </summary>
    [JsonProperty("optante_simples_nacional")]
    [StringLength(1, ErrorMessage = "O campo OptanteSimplesNacional deve ter no máximo 1 caractere.")]
    public string OptanteSimplesNacional { get; set; }

    /// <summary>
    /// <para>Indica se o cliente está inativo ("S" ou "N").</para>
    /// </summary>
    [JsonProperty("inativo")]
    [StringLength(1, ErrorMessage = "O campo Inativo deve ter no máximo 1 caractere.")]
    public string Inativo { get; set; }

    /// <summary>
    /// <para>Tags associadas ao cliente.</para>
    /// </summary>
    [JsonProperty("tags")]
    public List<string> Tags { get; set; }
}
