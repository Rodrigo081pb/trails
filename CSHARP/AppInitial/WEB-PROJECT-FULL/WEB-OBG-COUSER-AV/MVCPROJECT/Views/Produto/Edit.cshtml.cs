using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVCPROJECT.Models;
using System.Linq;

namespace MVCPROJECT.Views.Produto
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = Produto.ListaProdutos.FirstOrDefault(p => p.Id == id);
            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var produtoExistente = Produto.ListaProdutos.FirstOrDefault(p => p.Id == Produto.Id);
            if (produtoExistente == null)
            {
                return NotFound();
            }
            produtoExistente.Nome = Produto.Nome;
            produtoExistente.Preco = Produto.Preco;
            return RedirectToPage("/Produto/Index");
        }
    }
}
