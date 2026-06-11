using SupabassCrud.Models;

namespace SupabassCrud.Services;

public class ServiceService
{
    private readonly AppDbContext _context;
    public ServiceService(AppDbContext context)
    {
        _context = context;
    }
// return all services
    public List<Service> GetAllServices()
    {
        return _context.Services.ToList();
    }
    
    //delete service
    public void DeleteService(int id)
    {
        var service = _context.Services.Find(id);
        _context.Services.Remove(service);
        _context.SaveChanges();
    }
    
    //view service
    public Service GetService(int id)
    {
        return _context.Services.Find(id);
    }
    
    //create service
    public void CreateService(Service service)
    {
        _context.Services.Add(service);
        _context.SaveChanges();
    }
    
    //update service
    public void UpdateService(Service service)
    {
        _context.Update(service);
        _context.SaveChanges();
    }
    



}