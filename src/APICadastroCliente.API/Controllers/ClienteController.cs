using CadastroCliente.Application.Models;
using CadastroCliente.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICadastroCliente.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IUseCaseAsync<PostClienteRequest, PostClienteResponse> postClienteUseCase;
        private readonly IUseCaseAsync<GetClienteRequest, GetClienteResponse> getClienteUseCase;
        private readonly IUseCaseAsync<GetClienteRequest, IEnumerable<GetClienteResponse>> getClienteListaUseCase;

        public ClienteController(ILogger<ClienteController> logger,
            IUseCaseAsync<PostClienteRequest, PostClienteResponse> postClienteUseCase)
        {
            this.postClienteUseCase = postClienteUseCase;
            _logger = logger;
        }

        [HttpPost]
        [Route("user")]
        public async Task<ActionResult<PostClienteResponse>> Post([FromBody] PostClienteRequest postRequest)
        {
            var cliente = await postClienteUseCase.ExecuteAsync(postRequest);

            return CreatedAtAction(nameof(PostClienteRequest), cliente);
            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetClienteResponse>>> Get([FromQuery] GetClienteRequest getRequest)
        {
            var clientes = getClienteListaUseCase.ExecuteAsync(getRequest);

            return CreatedAtAction(nameof(GetClienteRequest), clientes);

        }
    }
}
