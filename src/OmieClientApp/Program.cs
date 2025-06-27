using Microsoft.Extensions.Configuration;
using OmieClientApp.Services;


var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

var appKey = config["Omie:AppKey"];
var appSecret = config["Omie:AppSecret"];

var apiCliente = new ClienteOmieApiService(appKey, appSecret);

//var clientes = await apiCliente.ListarClientes(new ClientesListRequest { RegistrosPorPagina = 5 });
//Console.WriteLine(clientes.TotalDeRegistros);
//foreach (var cliente in clientes.ClientesCadastro)
//{
//    Console.WriteLine($" - ID: {cliente.CodigoClienteOmie}, Nome: {cliente.RazaoSocial}");
//}

var apiContaReceber = new ContaReceberOmieApiService(appKey, appSecret);
Console.WriteLine("2");
var contasReceber = await apiContaReceber.ListarContasReceber(new LcrListarRequest { RegistrosPorPagina = 5 });
Console.WriteLine("");
Console.WriteLine(contasReceber.TotalDeRegistros);
foreach (var contaReceber in contasReceber.ContaReceberCadastro)
{
    Console.WriteLine($" - NF: {contaReceber.NumeroDocumentoFiscal}, Valor: {contaReceber.ValorDocumento}");
}