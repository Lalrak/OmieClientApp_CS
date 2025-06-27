namespace OmieClientApp.Models.Clientes.Requests;

/// <summary>
/// Request para cadastro de clientes em lote
/// </summary>
public class ClientesLoteRequest
{
    /// <summary>
    /// Número do lote
    /// </summary>
    public int Lote { get; set; }

    /// <summary>
    /// Lista de clientes a serem cadastrados
    /// </summary>
    public List<ClientesCadastro> ClientesCadastros { get; set; }
}
