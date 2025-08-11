using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using primaryAPI.Model;

namespace primaryAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        // envia as informações do produto
        [HttpPost]
        public IActionResult Post([FromBody] Produto novoProduto) 
        {
            if(novoProduto == null)
            {
                return BadRequest("Produto inválido");
            }
            novoProduto.Id = produtos.Count + 1;

            produtos.Add(novoProduto);

            return Ok("produto criado com sucesso");
        }

        // Realizar um get nos produtos
        [HttpGet("GetAllProdutos")]
        public IActionResult GetAllProdutos() {
            return Ok(produtos);
        }

        // GET: api/produto/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Buscar o produto pelo ID
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null) { return NotFound("Produto não encontrado."); }
            return Ok(produto);
        }

        // Atualizar um produto por id
        [HttpPut("UpdateProduto{id}")]
        public IActionResult UpdateProduto(int id, [FromBody] Produto produtoAtualizado) 
        {
            if (produtoAtualizado == null) 
            {
                return BadRequest("Produto inválido.");
            }
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null) 
            {
                return NotFound("Produto não encontrado.");
            }
            produto.Nome = produtoAtualizado.Nome;
            produto.Preco = produtoAtualizado.Preco;
            return Ok("Produto atualizado com sucesso.");
        }

        // Criando um método de deletar produto por id
        [HttpDelete("DeletProducts{id}")]
        public IActionResult DeleteById(int id) { 
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null) 
            { 
                return NotFound("Produto não encontrado.");
            }
            produtos.Remove(produto);
            return Ok("Produto deletado com sucesso.");
        }
    }
}
