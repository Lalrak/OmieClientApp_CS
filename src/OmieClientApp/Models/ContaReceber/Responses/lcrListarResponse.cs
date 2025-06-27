using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber.Responses;

/// <summary>
/// Resposta da API de listagem de contas a receber.
/// </summary>
public class LcrListarResponse
{
    /// <summary>
    /// Número da página.
    /// </summary>
    [JsonProperty("pagina")]
    public int Pagina { get; set; }

    /// <summary>
    /// Número de registros por página.
    /// </summary>
    [JsonProperty("registros_por_pagina")]
    public int RegistrosPorPagina { get; set; }

    /// <summary>
    /// Total de páginas.
    /// </summary>
    [JsonProperty("total_de_paginas")]
    public int TotalDePaginas { get; set; }

    /// <summary>
    /// Total de registros.
    /// </summary>
    [JsonProperty("total_de_registros")]
    public int TotalDeRegistros { get; set; }

    /// <summary>
    /// Cadastro de contas a receber.

    /// </summary>
    [JsonProperty("conta_receber_cadastro")]
    public List<ContaReceberCadastro> ContaReceberCadastro { get; set; }
}