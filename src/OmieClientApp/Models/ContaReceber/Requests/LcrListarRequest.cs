using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

public class LcrListarRequest
{
    [JsonProperty("pagina")]
    public int Pagina { get; set; } = 1;

    [JsonProperty("registros_por_pagina")]
    public int RegistrosPorPagina { get; set; } = 20;

    /// <summary>
    /// Apenas importado API.(S/N)
    /// </summary>
    [JsonProperty("apenas_importado_api")]
    public string ApenasImportadoApi { get; set; } = "N";

    /// <summary>
    /// Ordenar o resultado da página por:.
    /// <para>
    /// CODIGO - Código do lançamento do Omie;
    /// CODIGO_INTEGRACAO - lançamento interno do seu sistema;
    /// DATA_EMISSAO - Data de Emissão
    /// DATA_INCLUSAO - Data de Inclusão
    /// DATA_ALTERACAO - Data de Alteração
    /// DATA_VENCIMENTO - Data de Vencimento
    /// DATA_PAGAMENTO - Data de Pagamento
    /// </para>
    /// </summary>
    [JsonProperty("ordenar_por")]
    [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres.")]
    public string OrdenarPor { get; set; }

    /// <summary>
    /// Ordenar em ordem decrescente.(S/N)
    /// </summary>
    [JsonProperty("ordem_descrescente")]
    public string OrdemDescrescente { get; set; }

    /// <summary>
    /// Filtrar por data de. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("filtrar_por_data_de")]
    public string FiltrarPorDataDe { get; set; }

    /// <summary>
    /// Filtrar por data até. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("filtrar_por_data_ate")]
    public string FiltrarPorDataAte { get; set; }

    /// <summary>
    /// Filtrar apenas incluídos.(S/N)
    /// </summary>
    [JsonProperty("filtrar_apenas_inclusao")]
    public string FiltrarApenasInclusao { get; set; }

    /// <summary>
    /// Filtrar apenas alterados.(S/N)
    /// </summary>
    [JsonProperty("filtrar_apenas_alteracao")]
    public string FiltrarApenasAlteracao { get; set; }

    /// <summary>
    /// Filtrar por data de emissão de. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("filtrar_por_emissao_de")]
    public string FiltrarPorEmissaoDe { get; set; }

    /// <summary>
    /// Filtrar por data de registro de. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("filtrar_por_registro_de")]
    public string FiltrarPorRegistroDe { get; set; }

    /// <summary>
    /// Filtrar por data de emissão até. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("filtrar_por_emissao_ate")]
    public string FiltrarPorEmissaoAte { get; set; }

    /// <summary>
    /// Filtrar por data de registro até. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("filtrar_por_registro_ate")]
    public string FiltrarPorRegistroAte { get; set; }

    /// <summary>
    /// Filtrar por conta corrente.
    /// </summary>
    [JsonProperty("filtrar_conta_corrente")]
    public int? FiltrarContaCorrente { get; set; }

    /// <summary>
    /// Filtrar apenas titulos em aberto.(S/N)
    /// </summary>
    [JsonProperty("filtrar_apenas_titulos_em_aberto")]
    public string FiltrarApenasTitulosEmAberto { get; set; }

    /// <summary>
    /// Filtrar por cliente.
    /// </summary>
    [JsonProperty("filtrar_cliente")]
    public int? FiltrarCliente { get; set; }

    /// <summary>
    /// Filtrar por status.
    /// </summary>
    [JsonProperty("filtrar_por_status")]
    public string FiltrarPorStatus { get; set; }

    /// <summary>
    /// Filtrar por CPF/CNPJ.
    /// </summary>
    [JsonProperty("filtrar_por_cpf_cnpj")]
    public string FiltrarPorCpfCnpj { get; set; }

    /// <summary>
    /// Filtrar por projeto.
    /// </summary>
    [JsonProperty("filtrar_por_projeto")]
    public int? FiltrarPorProjeto { get; set; }

    /// <summary>
    /// Filtrar por vendedor.
    /// </summary>
    [JsonProperty("filtrar_por_vendedor")]
    public int? FiltrarPorVendedor { get; set; }

    /// <summary>
    /// Exibir observações.(S/N)
    /// <para>
    /// padrão: N
    /// </para>
    /// </summary>
    [JsonProperty("exibir_obs")]
    public string ExibirObs { get; set; }
}
