using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($"Olá me chamo {Nome} e sou um aluno nota {Nota}.");
        }

    }
}
