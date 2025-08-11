using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projetodois.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        //propriedades para capturar os dados do formulario
        
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public int Idade { get; set; }
    
        public IActionResult OnPost()
        {
            if(Idade <= 0)
            {
                ModelState.AddModelError("Idade", "A idade deve ser maior que zero.");
                return Page();
            }

            // retornar a página com os dados capturados
            return Page();

        }
    }
}
