using Microsoft.AspNetCore.Mvc;
using SupabassCrud.Models;
using SupabassCrud.Services;

namespace SupabassCrud.Controllers;

public class ClientController : Controller
{
    
    private readonly ClientService _clientService;
    
    // inject the service
    public ClientController(ClientService clientService)
    {
        _clientService = clientService;
    }
    // GET
    public IActionResult Index()
    {
        var clients = _clientService.GetAllClients();
        return View(clients);
    }
    
    // GET
    public IActionResult Create()
    {
        return View();
    }
    
    //delete 
    [HttpPost]
    public IActionResult Delete( int id)
    {
        _clientService.DeleteClient(id);
        return RedirectToAction("Index");
    }
    
    //create
    [HttpPost]
    public IActionResult Create(Client client)
    {
        _clientService.CreateClient(client);
        return RedirectToAction("index");
    }

}