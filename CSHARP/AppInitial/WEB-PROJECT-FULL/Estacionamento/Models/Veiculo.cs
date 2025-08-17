namespace Estacionamento.Models
{
    public class Veiculo
    {
        // Propriedades do veículo
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; } // isso se refere ao modelo do veículo, como "Fusca", "Civic", etc.

    }
}
