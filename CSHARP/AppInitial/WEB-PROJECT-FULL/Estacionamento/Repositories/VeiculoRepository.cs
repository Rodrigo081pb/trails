using System.Text.Json;
using Estacionamento.Models;

namespace Estacionamento.Repositories
{
    public class VeiculoRepository
    {

        private readonly string _filePath = "veiculos.json"; // Caminho do arquivo JSON
        private List<Veiculo> veiculos; // Lista de veículos carregada do arquivo JSON

        public VeiculoRepository()
        {
            veiculos = CarregarVeiculos(); // Carrega os veículos do arquivo JSON ao inicializar o repositório
        }

        private List<Veiculo> CarregarVeiculos() // Método para carregar a lista de veículos do arquivo JSON
        {
            if (!File.Exists(_filePath)) // Verifica se o arquivo existe
                return new List<Veiculo>(); // Se não existir, retorna uma lista vazia
            var json = File.ReadAllText(_filePath); // Lê o conteúdo do arquivo JSON
            return JsonSerializer.Deserialize<List<Veiculo>>(json) ?? new List<Veiculo>(); // Deserializa o JSON para uma lista de veículos, ou retorna uma lista vazia se falhar
        }

        private void SalvarVeiculos()
        {
            var json = JsonSerializer.Serialize(veiculos); // Serializa a lista de veículos para JSON
            File.WriteAllText(_filePath, json); // Escreve o JSON no arquivo
        }

        public IEnumerable<Veiculo> ListarTodos()
        {
            return veiculos; // Retorna a lista de todos os veículos
        }

        public Veiculo? BuscarPorPlaca(string placa)
        {
            return veiculos.FirstOrDefault(v => v.Placa == placa); // Busca um veículo pelo número da placa
        }

        public void Adicionar(Veiculo veiculo)
        {
            veiculos.Add(veiculo); // Adiciona um novo veículo à lista
            SalvarVeiculos(); // Salva a lista atualizada no arquivo JSON
        }

        public bool Remover(string placa)
        {
            var veiculo = BuscarPorPlaca(placa); // Busca o veículo pelo número da placa
            if (veiculo == null) return false;  // Se não encontrar, retorna falso
            veiculos.Remove(veiculo); // Remove o veículo da lista
            SalvarVeiculos(); // Salva a lista atualizada no arquivo JSON
            return true; // Retorna verdadeiro se a remoção foi bem-sucedida
        }

        public bool Atualizar(Veiculo veiculoAtualizado)
        {
            var veiculo = BuscarPorPlaca(veiculoAtualizado.Placa!); // Busca o veículo pelo número da placa
            if (veiculo == null) return false; // Se não encontrar, retorna falso
            veiculo.Modelo = veiculoAtualizado.Modelo; // Atualiza o modelo do veículo
            SalvarVeiculos(); // Salva a lista atualizada no arquivo JSON
            return true; // Retorna verdadeiro se a atualização foi bem-sucedida
        }
    }
}
