using Microsoft.AspNetCore.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> produtos = Produto.ListaProdutos;
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = Produto.ListaProdutos.Count + 1;
            Produto.ListaProdutos.Add(produto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produto? produtoExistente = Produto.ListaProdutos.FirstOrDefault(p => p.Id == id);
            if (produtoExistente == null)
                return NotFound();
            return View(produtoExistente);
        }

        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            Produto? produtoExistente = Produto.ListaProdutos.FirstOrDefault(p => p.Id == produto.Id);
            if (produtoExistente == null)
                return NotFound();

            produtoExistente.Nome = produto.Nome;
            produtoExistente.Preco = produto.Preco;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            Produto? produto = Produto.ListaProdutos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
                return NotFound();
            return View(produto);
        }

        [HttpPost]
        public IActionResult ExcluirConfirmado(int id)
        {
            Produto? produto = Produto.ListaProdutos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                Produto.ListaProdutos.Remove(produto);
            }
            return RedirectToAction("Index");
        }
    }
}