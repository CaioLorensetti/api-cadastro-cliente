using System.Threading.Tasks;

namespace CadastroCliente.Application.UseCases
{
    public interface IUseCase<TRequest>
    {
        void Execute(TRequest request);
    }

    public interface IUseCase<TRequest, TResponse>
    {
        TResponse Execute(TRequest request);
    }

    public interface IUseCaseAsync<TRequest>
    {
        void ExecuteAsync(TRequest request);
    }

    public interface IUseCaseAsync<TRequest, TResponse>
    {
        TResponse ExecuteAsync(TRequest request);
    }
}
