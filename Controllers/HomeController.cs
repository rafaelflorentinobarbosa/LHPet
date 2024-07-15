using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet2.Models;

namespace LHPet2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instâncias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "039.618.250-09", "bill@sp.senai.br", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@sp.senai.br", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Trovalds", "933.622.400-03", "torvalds@sp.senai.br", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@sp.senai.br", "Lodoc"); 

        // Lista de clientes, e atribuir clientes a lista
        List<Cliente> listaClientes =  new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
        
        // Instâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet S/A", "14.182.102/0001-80","c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.182.102/0001-57","ctrlp@alt.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BooksPet", "40.182.102/0001-83","boots-pet@pet.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.182.102/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.182.102/0001-37","contato@bff.us");

        // Lista de cliente
        List<Fornecedor> listaFornecedores =  new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores= listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
