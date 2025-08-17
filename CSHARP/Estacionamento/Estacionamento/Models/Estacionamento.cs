using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Estacionamento
    {
        private List<string> veiculos = new List<string>();
        // Classe que se refere ao estacionanento tais como capacidade e nome do estacionamento

        public int Id { get; set; }

        public string? Nome { get; set; }

        public int Capacidade { get; set; }

        public double Preco { get; set; }
    }
}

