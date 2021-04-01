using AutoMapper;
using CadastroCliente.Application.Models;
using CadastroCliente.Domain.Entities;
using CadastroCliente.Domain.ServiceAbstraction;
using System.Threading.Tasks;

namespace CadastroCliente.Application.UseCases
{
    public class PostClienteUseCaseAsync : IUseCaseAsync<PostClienteRequest, Task<PostClienteResponse>>
    {
        private readonly IClientesService _clientesService;
        private readonly IMapper _mapper;
        public PostClienteUseCaseAsync(IClientesService clientesService,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _clientesService = clientesService;
        }


        public async Task<PostClienteResponse> ExecuteAsync(PostClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            
            return _mapper.Map<PostClienteResponse>(await _clientesService.CreateAsync(cliente));
        }
    }
}
