using Estacionamento.Services;
using System;

// Exemplo de uso do service
class Program
{
    static void Main(string[] args)
    {
        var estacionamentoService = new EstacionamentoService();

        // Adicionando um veículo
        estacionamentoService.AdicionarVeiculo("ABC1234", DateTime.Now);

        // Listando veículos
        estacionamentoService.ListarVeiculos();

        // Editando veículo
        estacionamentoService.EditarVeiculo("ABC1234", "Sedan");

        // Removendo veículo
        estacionamentoService.RemoverVeiculo("ABC1234", DateTime.Now.AddHours(2));

        // Calculando preço
        estacionamentoService.calcularPreco(DateTime.Now, DateTime.Now.AddHours(2), 10.0);
    }
}
