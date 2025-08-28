using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int idade { get; set; }

        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos.");
        }
    }
}
