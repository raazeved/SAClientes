using System.Collections.Generic;
using ApiClientes.Models;

namespace ApiClientes.Repositorio
{
    public interface IClienteRepository
    {
    void Add(Cliente client);
    IEnumerable<Cliente> GetAll();

    Cliente Find(long id);

    void Remove(long id);

    void Update(Cliente client);

    }
}