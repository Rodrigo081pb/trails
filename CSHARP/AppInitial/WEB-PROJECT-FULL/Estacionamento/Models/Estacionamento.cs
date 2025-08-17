namespace Estacionamento.Models
{
    public class Estacionamento
    {
        // Propriedades do estacionamento
        public int Id { get; set; }
        public string? Nome { get; set; } // Nome do estacionamento, como "Estacionamento Central"
        public string? Endereco { get; set; } // Endereço do estacionamento, como "Rua A, 123"
        public int Capacidade { get; set; } // Capacidade total de veículos que o estacionamento pode acomodar
        public int VeiculosAtuais { get; set; } // Número atual de veículos estacionados
        
    }
}
