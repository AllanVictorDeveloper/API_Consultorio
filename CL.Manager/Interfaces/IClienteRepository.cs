using CL.Core.Domain;
using CL.Core.Shared.ModelViews;

namespace CL.Manager.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> AddClienteAsync(Cliente cliente);

        Task<IEnumerable<Cliente>> GetClientesAsync();

        Task<Cliente> GetClienteAsync(int id);

        Task<Cliente> UpdateClienteAsync(Cliente cliente);

        Task DeleteClienteAsync(int id);
    }
}