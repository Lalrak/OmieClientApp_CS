using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Dados para distribuição de créditos (rateio) por departamento.
/// </summary>
public class RateioCadastro
{
    /// <summary>
    /// Código do Tipo do Crédito, conforme Tabela 4.3.6. (Até 3 caracteres)
    /// </summary>
    [JsonProperty("codigo_tipo_credito")]
    [StringLength(3, ErrorMessage = "O campo deve ter no máximo 3 caracteres.")]
    public string CodigoTipoCredito { get; set; }

    /// <summary>
    /// Conta Financeira. (Até 20 caracteres)
    /// </summary>
    [JsonProperty("conta_financeira")]
    [StringLength(20, ErrorMessage = "O campo deve ter no máximo 20 caracteres.")]
    public string ContaFinanceira { get; set; }

    /// <summary>
    /// Código da Base de Cálculo do Crédito. (Até 2 caracteres)
    /// </summary>
    [JsonProperty("codigo_base_calculo")]
    [StringLength(2, ErrorMessage = "O campo deve ter no máximo 2 caracteres.")]
    public string CodigoBaseCalculo { get; set; }

    /// <summary>
    /// Código da Situação Tributária do COFINS.
    /// </summary>
    [JsonProperty("cst_cofins")]
    public long? CstCofins { get; set; }

    /// <summary>
    /// Código da Situação Tributária do PIS.
    /// </summary>
    [JsonProperty("cst_pis")]
    public long? CstPis { get; set; }

    /// <summary>
    /// Job. (Até 5 caracteres)
    /// </summary>
    [JsonProperty("job")]
    [StringLength(5, ErrorMessage = "O campo deve ter no máximo 5 caracteres.")]
    public string Job { get; set; }

    /// <summary>
    /// Percentual do rateio.
    /// </summary>
    [JsonProperty("percentual_rateio")]
    public decimal PercentualRateio { get; set; }

    /// <summary>
    /// Código do Departamento. (Até 40 caracteres)
    /// </summary>
    [JsonProperty("codigo_departamento")]
    [StringLength(40, ErrorMessage = "O campo deve ter no máximo 40 caracteres.")]
    public string CodigoDepartamento { get; set; }

    /// <summary>
    /// Valor do rateio.
    /// </summary>
    [JsonProperty("valor")]
    public decimal Valor { get; set; }

    /// <summary>
    /// Indica que o valor foi fixado na distribuição do rateio. (S/N)
    /// </summary>
    [JsonProperty("valor_fixado")]
    [StringLength(1, ErrorMessage = "O campo deve ter no máximo 1 caractere.")]
    public string ValorFixado { get; set; }

    /// <summary>
    /// Código da contribuição social apurada no período, conforme a Tabela 4.3.5. (Até 2 caracteres)
    /// </summary>
    [JsonProperty("codigo_contribuicao_social")]
    [StringLength(2, ErrorMessage = "O campo deve ter no máximo 2 caracteres.")]
    public string CodigoContribuicaoSocial { get; set; }

    /// <summary>
    /// Chave do Lançamento na PAGREC.
    /// </summary>
    [JsonProperty("chave_lancamento")]
    public long? ChaveLancamento { get; set; }
}