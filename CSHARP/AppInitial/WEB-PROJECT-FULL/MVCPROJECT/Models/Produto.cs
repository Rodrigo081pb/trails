namespace MVCPROJECT.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }


        // método que retorna a lista com os produtos

        public static List<Produto> ListaProdutos = new List<Produto>()
        {
            new Produto() { Id = 1, Nome = "Computador gamer", Preco = 3500.00 },
            new Produto() { Id = 2, Nome = "Notebook da arábia", Preco = 5000.00 },
        };

    }
}
