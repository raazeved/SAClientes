using System.Collections.Generic;
using ApiClientes.Models;
using System.Linq;
using ApiClientes.Repositorio;

namespace ApiClientes.Repositorio{

    public class ClienteRepository : IClienteRepository
    {

        private readonly ClienteDbContext _contexto;

        public ClienteRepository (ClienteDbContext ctx )
        {
        _contexto = ctx; 
        }
        public void Add(Cliente cliente)
        {
             _contexto.Clientes.Add(cliente);
             _contexto.SaveChanges();
        }

        public Cliente Find(long id)
        {
            return _contexto.Clientes.FirstOrDefault(c => c.CliId == id);
            
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _contexto.Clientes.ToList();
        }

        public void Remove(long id)
        {
          var entity = _contexto.Clientes.First (c=>c.CliId == id);
          _contexto.Clientes.Remove(entity);
          _contexto.SaveChanges();

         }

        public void Update(Cliente cliente)
        {
          _contexto.Clientes.Update (cliente);
          _contexto.SaveChanges();
        }
    }
}