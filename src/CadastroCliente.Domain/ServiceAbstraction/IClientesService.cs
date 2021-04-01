using CadastroCliente.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Domain.ServiceAbstraction
{
    public interface IClientesService
    {
        public IEnumerable<Cliente> Get();
        public Task<IEnumerable<Cliente>> GetAsync();

        public Cliente GetById(string id);
        public Task<Cliente> GetByIdAsync(string id);

        public Cliente Create(Cliente cliente);
        public Task<Cliente> CreateAsync(Cliente cliente);

        public void Update(string id, Cliente clienteIn);
        public Task UpdateAsync(string id, Cliente clienteIn);

        public void Remove(Cliente clienteIn);

        public void Remove(string id);
    }
}
