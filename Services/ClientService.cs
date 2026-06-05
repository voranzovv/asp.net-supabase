using SupabassCrud.Models;

namespace SupabassCrud.Services;

public class ClientService
{
    private readonly AppDbContext _context;
    public ClientService(AppDbContext context)
    {
        _context = context;
    }
// return all clients
    public List<Client> GetAllClients()
    {
        return _context.Clients.ToList();
    }
    
    //delete client
    public void DeleteClient(int id)
    {
        var client = _context.Clients.Find(id);
        if (client == null) return;
        _context.Clients.Remove(client);
        _context.SaveChanges();
    }
    
    //view client
    public Client GetClient(int id)
    {
        return _context.Clients.Find(id);
    }
    
    //create client
    public void CreateClient(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
    }
}