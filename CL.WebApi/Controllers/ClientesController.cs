using CL.Core.Domain;
using CL.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace CL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager _clienteManager;

        public ClientesController(IClienteManager clienteManager)
        {
            this._clienteManager = clienteManager;
        }


        [HttpGet("Listar")]
        public async Task<IActionResult> ListarClientes()
        {
            var clientes = await _clienteManager.GetClientesAsync();

            return Ok(clientes);
        }

        [HttpGet("ListarPorId/{id}")]
        public async Task<IActionResult> ListarClientePorId(int id)
        {
            var cliente = await _clienteManager.GetClienteAsync(id);

            return Ok(cliente);
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> AdicionarCliente([FromBody] Cliente cliente)
        {
            var clienteAdd = await _clienteManager.AddClienteAsync(cliente);

            return Ok(clienteAdd);
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> AtualizarPorId([FromBody] Cliente cliente)
        {
            var clienteDeletado = await _clienteManager.UpdateClienteAsync(cliente);

            return Ok(clienteDeletado);

        }

        [HttpDelete("Deletar/{id}")]
        public async Task<IActionResult> DeletarPorId(int id)
        {
            await _clienteManager.DeleteClienteAsync(id);

            return Ok();
        }
    }
}