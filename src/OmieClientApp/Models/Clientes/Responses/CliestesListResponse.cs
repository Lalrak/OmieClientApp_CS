using Newtonsoft.Json;

namespace OmieClientApp.Models.Clientes.Responses;

/// <summary>
/// Resposta da API de listagem de clientes.
/// </summary>
public class ClientesListResponse
{
    /// <summary>
    /// Número da página retornada.
    /// </summary>
    [JsonProperty("pagina")]
    public int Pagina { get; set; }

    /// <summary>
    /// Total de páginas retornadas.
    /// </summary>
    [JsonProperty("total_de_paginas")]
    public int TotalDePaginas { get; set; }

    /// <summary>
    /// Total de registros retornados na página.
    /// </summary>
    [JsonProperty("registros")]
    public int Registros { get; set; }

    /// <summary>
    /// Total de registros retornados.
    /// </summary>
    [JsonProperty("total_de_registros")]
    public int TotalDeRegistros { get; set; }

    /// <summary>
    /// Lista de clientes cadastrados.
    /// </summary>
    [JsonProperty("clientes_cadastro")]
    public List<ClientesCadastro> ClientesCadastro { get; set; }
}