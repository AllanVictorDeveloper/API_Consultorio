using CL.Core.Domain;
using CL.Core.Shared.ModelViews;

namespace CL.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task<Cliente> GetClienteAsync(int id);

        Task<IEnumerable<Cliente>> GetClientesAsync();

        Task<Cliente> UpdateClienteAsync(Cliente cliente);

        Task DeleteClienteAsync(int id);

        Task<Cliente> AddClienteAsync(NovoCliente novoCliente);
    }
}