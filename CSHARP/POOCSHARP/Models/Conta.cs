using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    // classe abstrata
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);

        // Método para exibir o saldo
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é {Saldo}");
        }
    }
}
