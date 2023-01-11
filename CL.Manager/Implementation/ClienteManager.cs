using CL.Core.Domain;
using CL.Manager.Interfaces;

namespace CL.Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _clienteRepository.GetClientesAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await _clienteRepository.GetClienteAsync(id);
        }

        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            return await _clienteRepository.AddClienteAsync(cliente);
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            return await _clienteRepository.UpdateClienteAsync(cliente);
        }

        public async Task DeleteClienteAsync(int id)
        {
             await _clienteRepository.DeleteClienteAsync(id);
        }
    }
}