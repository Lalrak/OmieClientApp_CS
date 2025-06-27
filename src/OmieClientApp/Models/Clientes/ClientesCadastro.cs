using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Representa o objeto de cadastro de cliente conforme definido pela API Omie.
/// </summary>
public class ClientesCadastro
{
    /// <summary>
    /// Código interno do cliente / fornecedor no Omie.
    /// </summary>
    [JsonProperty("codigo_cliente_omie")]
    public long CodigoClienteOmie { get; set; }

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
    /// CNPJ ou CPF do cliente (somente números).
    /// </summary>
    [JsonProperty("cnpj_cpf")]
    [StringLength(20, ErrorMessage = "O campo CNPJ / CPF deve ter no máximo 20 caracteres.")]
    public string CnpjCpf { get; set; }

    /// <summary>
    /// Nome fantasia ou apelido comercial do cliente.
    /// </summary>
    [JsonProperty("nome_fantasia")]
    [StringLength(100, ErrorMessage = "O campo Nome Fantasia deve ter no máximo 100 caracteres.")]
    public string NomeFantasia { get; set; }

    /// <summary>
    /// DDD do telefone principal.
    /// </summary>
    [JsonProperty("telefone1_ddd")]
    [StringLength(5, ErrorMessage = "O campo DDD deve ter no máximo 5 caracteres.")]
    public string Telefone1Ddd { get; set; }

    /// <summary>
    /// Número do telefone principal.
    /// </summary>
    [JsonProperty("telefone1_numero")]
    [StringLength(15, ErrorMessage = "O campo Número deve ter no máximo 15 caracteres.")]
    public string Telefone1Numero { get; set; }

    /// <summary>
    /// Nome da pessoa de contato.
    /// </summary>
    [JsonProperty("contato")]
    [StringLength(100, ErrorMessage = "O campo Contato deve ter no máximo 100 caracteres.")]
    public string Contato { get; set; }

    /// <summary>
    /// Logradouro do endereço principal.
    /// </summary>
    [JsonProperty("endereco")]
    [StringLength(60, ErrorMessage = "O campo Endereço deve ter no máximo 60 caracteres.")]
    public string Endereco { get; set; }

    /// <summary>
    /// Número do endereço principal.
    /// </summary>
    [JsonProperty("endereco_numero")]
    [StringLength(60, ErrorMessage = "O campo Número deve ter no máximo 60 caracteres.")]
    public string EnderecoNumero { get; set; }

    /// <summary>
    /// Bairro do endereço principal.
    /// </summary>
    [JsonProperty("bairro")]
    [StringLength(60, ErrorMessage = "O campo Bairro deve ter no máximo 60 caracteres.")]
    public string Bairro { get; set; }

    /// <summary>
    /// Complemento do endereço principal.
    /// </summary>
    [JsonProperty("complemento")]
    [StringLength(60, ErrorMessage = "O campo Complemento deve ter no máximo 60 caracteres.")]
    public string Complemento { get; set; }

    /// <summary>
    /// Sigla do estado (UF) do endereço principal.
    /// </summary>
    [JsonProperty("estado")]
    [StringLength(2, ErrorMessage = "O campo Estado deve ter no máximo 2 caracteres.")]
    public string Estado { get; set; }

    /// <summary>
    /// Nome da cidade do endereço principal.
    /// </summary>
    [JsonProperty("cidade")]
    [StringLength(40, ErrorMessage = "O campo Cidade deve ter no máximo 40 caracteres.")]
    public string Cidade { get; set; }

    /// <summary>
    /// CEP do endereço principal (somente números).
    /// </summary>
    [JsonProperty("cep")]
    [StringLength(10, ErrorMessage = "O campo CEP deve ter no máximo 10 caracteres.")]
    public string Cep { get; set; }

    /// <summary>
    /// Código do país (normalmente "1058" para Brasil).
    /// <para>
    /// Padrão Brasil: "1058"
    /// </para>
    /// </summary>
    [JsonProperty("codigo_pais")]
    [StringLength(4, ErrorMessage = "O campo Código do País deve ter no máximo 4 caracteres.")]
    public string CodigoPais { get; set; } = "1058";

    /// <summary>
    /// Indica se separa logradouro de número/complemento ("S" ou "N").
    /// <para>
    /// Padrão Não: "N"
    /// </para>
    /// </summary>
    [JsonProperty("separar_endereco")]
    [StringLength(1, ErrorMessage = "O campo Separar Endereço deve ter no máximo 1 caractere.")]
    public string SepararEndereco { get; set; }

    /// <summary>
    /// Habilita pesquisa automática de CEP ("S" ou "N").
    /// <para>
    /// Padrão Não: "N"
    /// </para>
    /// </summary>
    [JsonProperty("pesquisar_cep")]
    [StringLength(1, ErrorMessage = "O campo Pesquisar Cep deve ter no máximo 1 caractere.")]
    public string PesquisarCep { get; set; }

    /// <summary>
    /// DDD do segundo telefone.
    /// </summary>
    [JsonProperty("telefone2_ddd")]
    [StringLength(5, ErrorMessage = "O campo DDD deve ter no máximo 5 caracteres.")]
    public string Telefone2Ddd { get; set; }

    /// <summary>
    /// Número do segundo telefone.
    /// </summary>
    [JsonProperty("telefone2_numero")]
    [StringLength(15, ErrorMessage = "O campo Número deve ter no máximo 15 caracteres.")]
    public string Telefone2Numero { get; set; }

    /// <summary>
    /// DDD do fax.
    /// </summary>
    [JsonProperty("fax_ddd")]
    [StringLength(5, ErrorMessage = "O campo DDD deve ter no máximo 5 caracteres.")]
    public string FaxDdd { get; set; }

    /// <summary>
    /// Número do fax.
    /// </summary>
    [JsonProperty("fax_numero")]
    [StringLength(15, ErrorMessage = "O campo Número deve ter no máximo 15 caracteres.")]
    public string FaxNumero { get; set; }

    /// <summary>
    /// Endereço de e-mail principal.
    /// </summary>
    [JsonProperty("email")]
    [StringLength(500, ErrorMessage = "O campo Email deve ter no máximo 500 caracteres.")]
    public string Email { get; set; }

    /// <summary>
    /// URL do site ou homepage do cliente.
    /// </summary>
    [JsonProperty("homepage")]
    [StringLength(100, ErrorMessage = "O campo Homepage deve ter no máximo 100 caracteres.")]
    public string Homepage { get; set; }

    /// <summary>
    /// Inscrição Estadual.
    /// </summary>
    [JsonProperty("inscricao_estadual")]
    [StringLength(20, ErrorMessage = "O campo Inscrição Estadual deve ter no máximo 20 caracteres.")]
    public string InscricaoEstadual { get; set; }

    /// <summary>
    /// Inscrição Municipal.
    /// </summary>
    [JsonProperty("inscricao_municipal")]
    [StringLength(20, ErrorMessage = "O campo Inscrição Municipal deve ter no máximo 20 caracteres.")]
    public string InscricaoMunicipal { get; set; }

    /// <summary>
    /// Inscrição SUFRAMA.
    /// </summary>
    [JsonProperty("inscricao_suframa")]
    [StringLength(20, ErrorMessage = "O campo Inscrição Suframa deve ter no máximo 20 caracteres.")]
    public string InscricaoSuframa { get; set; }

    /// <summary>
    /// Se é optante do Simples Nacional ("S" ou "N").
    /// </summary>
    [JsonProperty("optante_simples_nacional")]
    [StringLength(1, ErrorMessage = "O campo Optante Simples Nacional deve ter no máximo 1 caractere.")]
    public string OptanteSimplesNacional { get; set; }

    /// <summary>
    /// Tipo de atividade econômica (código).
    /// </summary>
    [JsonProperty("tipo_atividade")]
    [StringLength(1, ErrorMessage = "O campo Tipo de Atividade deve ter no máximo 1 caractere.")]
    public string TipoAtividade { get; set; }

    /// <summary>
    /// Código CNAE principal.
    /// </summary>
    [JsonProperty("cnae")]
    [StringLength(7, ErrorMessage = "O campo CNAE deve ter no máximo 7 caracteres.")]
    public string Cnae { get; set; }

    /// <summary>
    /// Se é produtor rural ("S" ou "N").
    /// </summary>
    [JsonProperty("produtor_rural")]
    [StringLength(1, ErrorMessage = "O campo Produtor Rural deve ter no máximo 1 caractere.")]
    public string ProdutorRural { get; set; }

    /// <summary>
    /// Indicador de contribuinte ICMS ("S" ou "N").
    /// </summary>
    [JsonProperty("contribuinte")]
    [StringLength(1, ErrorMessage = "O campo Contribuinte deve ter no máximo 1 caractere.")]
    public string Contribuinte { get; set; }

    /// <summary>
    /// Observação geral.
    /// </summary>
    [JsonProperty("observacao")]
    [StringLength(255, ErrorMessage = "O campo Observação deve ter no máximo 255 caracteres.")]
    public string Observacao { get; set; }

    /// <summary>
    /// Observações detalhadas.
    /// </summary>
    [JsonProperty("obs_detalhadas")]
    [StringLength(255, ErrorMessage = "O campo Observações Detalhadas deve ter no máximo 255 caracteres.")]
    public string ObsDetalhadas { get; set; }

    /// <summary>
    /// Recomendação de prazo para atraso (código).
    /// </summary>
    [JsonProperty("recomendacao_atraso")]
    [StringLength(2, ErrorMessage = "O campo Recomendação de Atraso deve ter no máximo 2 caracteres.")]
    public string RecomendacaoAtraso { get; set; }

    /// <summary>
    /// Lista de tags associadas ao cliente.
    /// </summary>
    [JsonProperty("tags")]
    public List<Tag> Tags { get; set; }

    /// <summary>
    /// Indicador se é pessoa física ("S" ou "N").
    /// </summary>
    [JsonProperty("pessoa_fisica")]
    [StringLength(1, ErrorMessage = "O campo Pessoa Física deve ter no máximo 1 caractere.")]
    public string PessoaFisica { get; set; }

    /// <summary>
    /// Indicador de cliente no exterior ("S" ou "N").
    /// </summary>
    [JsonProperty("exterior")]
    [StringLength(1, ErrorMessage = "O campo Exterior deve ter no máximo 1 caractere.")]
    public string Exterior { get; set; }

    /// <summary>
    /// Indicador se foi importado via API ("S" ou "N").
    /// </summary>
    [JsonProperty("importado_api")]
    [StringLength(1, ErrorMessage = "O campo Importado Api deve ter no máximo 1 caractere.")]
    public string ImportadoApi { get; set; }

    /// <summary>
    /// Código IBGE da cidade.
    /// </summary>
    [JsonProperty("cidade_ibge")]
    [StringLength(7, ErrorMessage = "O campo Cidade Ibge deve ter no máximo 7 caracteres.")]
    public string CidadeIbge { get; set; }

    /// <summary>
    /// Valor do limite de crédito permitido.
    /// </summary>
    [JsonProperty("valor_limite_credito")]
    public decimal? ValorLimiteCredito { get; set; }

    /// <summary>
    /// Indicador para bloquear faturamento ("S" ou "N").
    /// </summary>
    [JsonProperty("bloquear_faturamento")]
    [StringLength(1, ErrorMessage = "O campo Bloquear Faturamento deve ter no máximo 1 caractere.")]
    public string BloquearFaturamento { get; set; }

    /// <summary>
    /// Recomendações de cobrança e fomento ao cliente.
    /// </summary>
    [JsonProperty("recomendacoes")]
    public Recomendacoes Recomendacoes { get; set; }

    /// <summary>
    /// Dados de entrega alternativos.
    /// </summary>
    [JsonProperty("enderecoEntrega")]
    public EnderecoEntrega EnderecoEntrega { get; set; }

    /// <summary>
    /// Número de identificação fiscal estrangeiro (NIF).
    /// </summary>
    [JsonProperty("nif")]
    [StringLength(100, ErrorMessage = "O campo Nif deve ter no máximo 100 caracteres.")]
    public string Nif { get; set; }

    /// <summary>
    /// Documento do cliente no exterior.
    /// </summary>
    [JsonProperty("documento_exterior")]
    [StringLength(20, ErrorMessage = "O campo Documento Exterior deve ter no máximo 20 caracteres.")]
    public string DocumentoExterior { get; set; }

    /// <summary>
    /// Indicador se o cliente está inativo ("S" ou "N").
    /// </summary>
    [JsonProperty("inativo")]
    [StringLength(1, ErrorMessage = "O campo Inativo deve ter no máximo 1 caractere.")]
    public string Inativo { get; set; }

    /// <summary>
    /// Dados bancários para pagamentos.
    /// </summary>
    [JsonProperty("dadosBancarios")]
    public DadosBancarios DadosBancarios { get; set; }

    /// <summary>
    /// Lista de características adicionais do cliente.
    /// </summary>
    [JsonProperty("caracteristicas")]
    public List<Caracteristica> Caracteristicas { get; set; }

    /// <summary>
    /// Indicador se deve enviar anexos pela API ("S" ou "N").
    /// </summary>
    [JsonProperty("enviar_anexos")]
    [StringLength(1, ErrorMessage = "O campo Enviar Anexos deve ter no máximo 1 caractere.")]
    public string EnviarAnexos { get; set; }

    /// <summary>
    /// Informações de auditoria de criação e alteração.
    /// </summary>
    [JsonProperty("info")]
    public Info Info { get; set; }

    /// <summary>
    /// Indicador para bloquear exclusão do registro ("S" ou "N").
    /// </summary>
    [JsonProperty("bloquear_exclusao")]
    [StringLength(1, ErrorMessage = "O campo Bloquear Exclusão deve ter no máximo 1 caractere.")]
    public string BloquearExclusao { get; set; }
}