using AutoMapper;
using CadastroCliente.Application.Models;
using CadastroCliente.Domain.Entities;

namespace CadastroCliente.Application.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Cliente, GetClienteResponse>();
            CreateMap<Cliente, PostClienteResponse>();
        }

    }
}
