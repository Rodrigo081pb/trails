using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAndMetodosAndContrutores.Models
{
    public class Pessoa
    {
        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string? Nome { get; set; }
    
        public int Idade { get; set; }

        public void Apresentar()
        {
            if(string.IsNullOrEmpty(Nome))
            {
                throw new InvalidOperationException("O nome não pode ser vazio.");
            } else if(Idade < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Idade), "A idade não pode ser negativa.");
            } else
            { 
                Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
            }
        }
    }
}
