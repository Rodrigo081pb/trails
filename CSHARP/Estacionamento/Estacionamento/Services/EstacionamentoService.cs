using Estacionamento.Interfaces;
using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Services
{
    public class EstacionamentoService : IEstacionamento
    {
        public void AdicionarVeiculo(string placa, DateTime entrada)
        {
            if (placa != null)
            {
                Console.WriteLine($"Veículo com placa {placa} adicionado ao estacionamento. Entrada: {entrada}");
            } else
            {
                Console.WriteLine("Placa inválida. Não foi possível adicionar o veículo.");
            }
        }

        public void RemoverVeiculo(string placa, DateTime saida)
        {
            if (placa != null)
            {
                Console.WriteLine($"Veículo com placa {placa} removido do estacionamento. Saída: {saida}");
            } else
            {
                Console.WriteLine("Placa não encontrada. Não foi possível remover o veículo.");
            }
        }

        public void EditarVeiculo(string placa, string novoModelo)
        {
            if (placa != null && novoModelo != null)
            {
                Console.WriteLine($"Veículo com placa {placa} atualizado para o modelo {novoModelo}.");
            } else
            {
                Console.WriteLine("Placa ou modelo inválido. Não foi possível editar o veículo.");
            }
        }

        private List<string> veiculos = new List<string>();
        public void ListarVeiculos()
        {
            Console.WriteLine("Listando todos os veículos no estacionamento:");

            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo no estacionamento.");
                return;
            }

            foreach (var placa in veiculos)
            {
                Console.WriteLine($"- {placa}");
            }
        }

        public void ListarVeiculosPorModelo(string modelo)
        {
            Console.WriteLine($"Listando veículos do modelo {modelo}:");
            var veiculosPorModelo = veiculos.Where(v => v.Contains(modelo)).ToList();
            if (veiculosPorModelo.Count == 0)
            {
                Console.WriteLine("Nenhum veículo encontrado com esse modelo.");
                return;
            }
            foreach (var placa in veiculosPorModelo)
            {
                Console.WriteLine($"- {placa}");
            }
        }

        public void ListarVeiculosPorPlaca(string placa)
        {
            Console.WriteLine($"Listando veículos com a placa {placa}:");
            var veiculosPorPlaca = veiculos.Where(v => v == placa).ToList();
            if (veiculosPorPlaca.Count == 0)
            {
                Console.WriteLine("Nenhum veículo encontrado com essa placa.");
                return;
            }
            foreach (var v in veiculosPorPlaca)
            {
                Console.WriteLine($"- {v}");
            }
        }

        public void calcularPreco(DateTime entrada, DateTime saida, double precoPorHora)
        {
            TimeSpan tempoEstacionado = saida - entrada;
            double horasEstacionadas = Math.Ceiling(tempoEstacionado.TotalHours);
            double precoTotal = horasEstacionadas * precoPorHora;
            Console.WriteLine($"Tempo total estacionado: {horasEstacionadas} horas. Preço total: R$ {precoTotal}");
        }


    }
}
