using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiClientes.Models;
using ApiClientes.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace apiClientes.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _clienteRepositorio;

        public ClientesController(IClienteRepository clienteRepo)
        {
            _clienteRepositorio = clienteRepo;
        }
        
        [HttpGet]
       public IEnumerable<Cliente> GetAll()
       {
            return _clienteRepositorio.GetAll();
       }

       [HttpGet("{id}", Name = "GetCliente")]
       public IActionResult GetById(long id)
       {
           var cliente = _clienteRepositorio.Find(id);
           if (cliente == null)
           {
                 return NotFound();
           }
          return new ObjectResult(cliente);
       }

        [HttpPost]
        public IActionResult Create([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }

            _clienteRepositorio.Add(cliente);

            return CreatedAtRoute("GetCliente", new { id = cliente.CliId }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Cliente cliente)
        {
            if (cliente == null || cliente.CliId != id)
            {
                // retornar status code 400
                return BadRequest();
            }

            var _cliente = _clienteRepositorio.Find(id);
            if (_cliente == null)
            {
                return NotFound();
            }

            _cliente.email = cliente.email;
            _cliente.Nome = cliente.Nome;
            _cliente.DataNasc = cliente.DataNasc;
            _cliente.CNPJ_CPF = cliente.CNPJ_CPF;
            _cliente.DOC = cliente.DOC;
            _cliente.EndPri= cliente.EndPri;
            _cliente.NumPri = cliente.NumPri;
            _cliente.ComplPri = cliente.ComplPri;
            _cliente.BaiPri = cliente.BaiPri;
            _cliente.CEP  = cliente.CEP;
            _cliente.CidPri =  cliente.CidPri;
            _cliente.UF = cliente.UF;
            _cliente.TelPri= cliente.TelPri;
            _cliente.WhatsApp= cliente.WhatsApp;
            _cliente.email= cliente.email;
            _cliente.Status= cliente.Status;

            // adicionar todos os campos

            _clienteRepositorio.Update(_cliente);
            // retornar status code 204
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var cliente = _clienteRepositorio.Find(id);

            // retornar status code 404 caso nao encontre
            if (cliente == null)
                    return NotFound();

            _clienteRepositorio.Remove(id);
             // retornar status code 204
             return new NoContentResult();
         
        }
    }
}