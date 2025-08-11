using System.Linq;
using System.Web.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            var produtos = Produto.ListaProdutos;
            return View(produtos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            produto.Id = Produto.ListaProdutos.Count + 1;
            Produto.ListaProdutos.Add(produto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var produto = Produto.ListaProdutos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
                return HttpNotFound();
            return View(produto);
        }

        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            var produtoExistente = Produto.ListaProdutos.FirstOrDefault(p => p.Id == produto.Id);
            if (produtoExistente == null)
                return HttpNotFound();
            produtoExistente.Nome = produto.Nome;
            produtoExistente.Preco = produto.Preco;
            return RedirectToAction("Index");
        }
    }
}
