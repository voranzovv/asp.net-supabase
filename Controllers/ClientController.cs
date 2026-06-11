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
    
  [HttpGet]
  public IActionResult Detail(int id)
  {
      var client = _clientService.GetClient(id);
      Console.WriteLine(client);


      return View(client);
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
    
    //show update form
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var client = _clientService.GetClient(id);

        if (client == null)
        {
            return NotFound();
        }

        return View(client);
    }
    
    //update
    [HttpPost]
    public IActionResult Edit(Client client)
    {
        _clientService.UpdateClient(client);
        return RedirectToAction("Index");
    }
    
    
    
    
    

}