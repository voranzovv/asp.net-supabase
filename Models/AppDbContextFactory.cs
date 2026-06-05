using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SupabassCrud.Models;

public class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(
            "Host=aws-1-us-west-2.pooler.supabase.com;Database=postgres;Username=postgres.rhepmqlunysnwgfsbupa;Password=Dandanakka@1234;SSL Mode=Require;Trust Server Certificate=true"
            );
        return new AppDbContext(optionsBuilder.Options);
    }
}