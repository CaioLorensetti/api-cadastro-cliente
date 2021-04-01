using CadastroCliente.Domain.Entities;
using CadastroCliente.Domain.ServiceAbstraction;
using CadastroCliente.Infrastructure.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Infrastructure.Services
{
    public class ClientesService : IClientesService
    {
        private readonly IMongoCollection<Cliente> _clientes;

        public ClientesService(IClientesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _clientes = database.GetCollection<Cliente>(settings.ClientesCollectionName);
        }

        public IEnumerable<Cliente> Get() =>
            _clientes.Find<Cliente>(cliente => true).ToList();

        public async Task<IEnumerable<Cliente>> GetAsync() =>
            await _clientes.Find<Cliente>(cliente => true).ToListAsync();

        public Cliente GetById(string id) =>
            _clientes.Find<Cliente>(cliente => cliente.Id == id).FirstOrDefault();

        public async Task<Cliente> GetByIdAsync(string id) =>
            await _clientes.Find<Cliente>(cliente => cliente.Id == id).FirstOrDefaultAsync();

        public Cliente Create(Cliente cliente)
        {
            _clientes.InsertOne(cliente);
            return cliente;
        }
        public async Task<Cliente> CreateAsync(Cliente cliente)
        {
            await _clientes.InsertOneAsync(cliente);
            return cliente;
        }

        public void Update(string id, Cliente clienteIn) =>
            _clientes.ReplaceOne(cliente => cliente.Id == id, clienteIn);

        public void Remove(Cliente clienteIn) =>
            _clientes.DeleteOne(cliente => cliente.Id == clienteIn.Id);

        public void Remove(string id) =>
            _clientes.DeleteOne(cliente => cliente.Id == id);

        public Task UpdateAsync(string id, Cliente clienteIn)
        {
            throw new NotImplementedException();
        }
    }
}
