using CadastroCliente.Application.Models.Collection;
using System.Collections.Generic;

namespace CadastroCliente.Infrastructure.Services.Abstractions
{
    public interface IClientesService
    {
        List<Cliente> Get();

        Cliente Get(string id);

        Cliente Create(Cliente cliente);

        public void Update(string id, Cliente clienteIn);

        public void Remove(Cliente clienteIn);

        public void Remove(string id);
    }
}
