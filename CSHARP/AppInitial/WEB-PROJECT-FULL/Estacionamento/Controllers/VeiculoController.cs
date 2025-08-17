using Estacionamento.Models;
using Estacionamento.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers
{
    [ApiController]
    [Route("api/v1/veiculo")]
    public class VeiculoController : ControllerBase
    {
        private readonly VeiculoRepository _repo = new VeiculoRepository();

        [HttpPost("/adicionar")]
        public IActionResult AdicionarVeiculo([FromBody] Veiculo veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Placa) || string.IsNullOrEmpty(veiculo.Modelo))
                return BadRequest(new { mensagem = "Placa e modelo são obrigatórios." });
            if (_repo.BuscarPorPlaca(veiculo.Placa) != null)
                return Conflict(new { mensagem = "Veículo com essa placa já existe." });
            _repo.Adicionar(veiculo);
            return Ok(new { mensagem = "Veículo adicionado com sucesso!" });
        }

        [HttpGet("/listarVeiculo")]
        public IActionResult ListarVeiculos()
        {
            var veiculos = _repo.ListarTodos();
            return Ok(veiculos);
        }

        [HttpGet("buscar/{placa}")]
        public IActionResult BuscarPorPlaca(string placa)
        {
            var veiculo = _repo.BuscarPorPlaca(placa);
            if (veiculo == null)
                return NotFound(new { mensagem = "Veículo não encontrado." });
            return Ok(veiculo);
        }

        [HttpDelete("remover/{placa}")]
        public IActionResult RemoverVeiculo(string placa)
        {
            if (_repo.Remover(placa))
                return Ok(new { mensagem = "Veículo removido com sucesso!" });
            return NotFound(new { mensagem = "Veículo não encontrado." });
        }

        [HttpPut("atualizar")]
        public IActionResult AtualizarVeiculo([FromBody] Veiculo veiculo)
        {
            if (string.IsNullOrEmpty(veiculo.Placa))
                return BadRequest(new { mensagem = "Placa é obrigatória para atualização." });
            if (_repo.Atualizar(veiculo))
                return Ok(new { mensagem = "Veículo atualizado com sucesso!" });
            return NotFound(new { mensagem = "Veículo não encontrado." });
        }
    }
}
