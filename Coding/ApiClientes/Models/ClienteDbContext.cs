using Microsoft.EntityFrameworkCore;

namespace ApiClientes.Models 
{ 
public class ClienteDbContext: DbContext 
{

public ClienteDbContext(DbContextOptions<ClienteDbContext> Options )
: base(Options)
{ }

public DbSet<Cliente> Clientes { get; set; }

}


}