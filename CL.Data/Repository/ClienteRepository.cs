using CL.Core.Domain;
using CL.Data.Context;
using CL.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CL.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CLContext _CLContext;

        public ClienteRepository(CLContext CLContext)
        {
            this._CLContext = CLContext;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _CLContext.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            var Cliente = await _CLContext.Clientes.FindAsync(id);
            return Cliente;
        }

        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            await _CLContext.Clientes.AddAsync(cliente);

            await _CLContext.SaveChangesAsync(); ;

            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteExiste = await _CLContext.Clientes.FindAsync(cliente.Id);

            if (clienteExiste == null)
            {
                return null;
            }

            _CLContext.Entry(clienteExiste).CurrentValues.SetValues(cliente);
            await _CLContext.SaveChangesAsync();
            return clienteExiste;
        }

        public async Task DeleteClienteAsync(int id)
        {
            var clienteExiste = await _CLContext.Clientes.FindAsync(id);

            _CLContext.Clientes.Remove(clienteExiste);
            await _CLContext.SaveChangesAsync();
        }
    }
}