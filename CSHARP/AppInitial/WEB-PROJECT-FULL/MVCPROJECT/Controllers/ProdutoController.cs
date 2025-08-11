using Microsoft.AspNetCore.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    // produto controller é responsável por gerenciar as ações relacionadas aos produtos
    public class ProdutoController : Controller
    {
   
        public IActionResult Index()
        {
            // obter a lista de produtos do model
            List<Produto> produtos = Produto.ListaProdutos;

            // passa a lista de produtos para a view
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Retorna a view para criar um novo produto
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = Produto.ListaProdutos.Count + 1; // Simula a geração de um ID
            Produto.ListaProdutos.Add(produto); // Adiciona o produto à lista
            // Redireciona para a ação Index após a criação do produto
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Busca o produto pelo ID
            Produto produto = Produto.ListaProdutos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound(); // Retorna 404 se o produto não for encontrado
            }
            return View(produto); // Retorna a view de edição com o produto
        }

    }
}
