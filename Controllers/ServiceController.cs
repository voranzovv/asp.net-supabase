using Microsoft.AspNetCore.Mvc;
using SupabassCrud.Models;
using SupabassCrud.Services;

namespace SupabassCrud.Controllers;

public class ServiceController : Controller
{
    private readonly ServiceService _service;
// inject the service
    public ServiceController(ServiceService service)
    {
        _service = service;
    }
    
    // GET
    public IActionResult Index()
    {
        var services = _service.GetAllServices();
        return View(services);
    }
    
    //show detail
    [HttpGet]
    public IActionResult Detail(int id)
    {
        var service = _service.GetService(id);
        return View(service);
    }
    
    //get create form
    public IActionResult Create()
    {
        return View();
    }
    
    //delete 
    [HttpPost]
    public IActionResult Delete( int id)
    {
        _service.DeleteService(id);
        return RedirectToAction("Index");
    }
    
    //create
    [HttpPost]
    public IActionResult Create(Service service)
    {
        _service.CreateService(service);
        return RedirectToAction("index");
    }
    //show update form
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var service = _service.GetService(id);
        return View(service);
    }
    
    //update
    [HttpPost]
    public IActionResult Edit(Service service)
    {
        _service.UpdateService(service);
        return RedirectToAction("Index");
    }


}