using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Interfaces
{
    internal interface IEstacionamento
    {
        // criar um service que calcula o tempo que o veiculo fica no estacionamento e métodos
        // métodos de adicionar veiculo remover e editar onde a gente vai calcular o tempo que aquele veiculo

        public void AdicionarVeiculo(string placa, DateTime entrada);

        public void RemoverVeiculo(string placa, DateTime saida);

        public void EditarVeiculo(string placa, string novoModelo);

        public void ListarVeiculos();

        public void ListarVeiculosPorModelo(string modelo);

        public void ListarVeiculosPorPlaca(string placa);

        public void calcularPreco(DateTime entrada, DateTime saida, double precoPorHora);


    }
}
