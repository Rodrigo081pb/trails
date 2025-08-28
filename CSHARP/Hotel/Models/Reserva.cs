using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public reserva() { }

        public reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count) { 
                Console.WriteLine("Mensagem: Não foi possível, a capacidade foi atingida");
            }
            else
            {
                Console.WriteLine("Mensagem: Hóspedes cadastrados com sucesso");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;
            // aplicar o disconto a cada 10 dias
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
                Console.WriteLine($"Mensagem: o valor com desconto foi {valor}");
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
                Console.WriteLine($"Mensagem: o valor foi {valor}");
            }

            return valor;
        }
    }
}
