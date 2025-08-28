using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCSHARP.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial) 
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso. Saldo atual: {saldo}");
            }
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso. Saldo atual: {saldo}");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}
