using CadastroCliente.Application.Models;
using CadastroCliente.Application.UseCases;
using CadastroCliente.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using CadastroCliente.Domain.ServiceAbstraction;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Infrastructure.Extensions
{
    public static class RegisterServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IClientesService, ClientesService>();

            services.AddTransient<IUseCaseAsync<PostClienteRequest, Task<PostClienteResponse>>, PostClienteUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<GetClienteRequest, Task<IEnumerable<GetClienteResponse>>>, GetClienteUseCaseAsync>();
        }
    }
}
