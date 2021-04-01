using AutoMapper;
using CadastroCliente.Application.Models;
using CadastroCliente.Domain.Entities;
using CadastroCliente.Domain.ServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Application.UseCases
{
    public class GetClienteUseCaseAsync : IUseCaseAsync<GetClienteRequest, Task<IEnumerable<GetClienteResponse>>>
    {
        private readonly IClientesService _clientesService;
        private readonly IMapper _mapper;
        public GetClienteUseCaseAsync(IClientesService clientesService,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _clientesService = clientesService;
        }

        public async Task<IEnumerable<GetClienteResponse>> ExecuteAsync(GetClienteRequest request)
        {
            var clientes = await _clientesService.GetAsync();
            return _mapper.Map<IEnumerable<GetClienteResponse>>(clientes);
        }
    }
}
