﻿using CL.Core.Domain;

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