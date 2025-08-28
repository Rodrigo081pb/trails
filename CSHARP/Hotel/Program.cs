using System;
using System.Collections.Generic;
using Hotel.Models;

// Cria uma lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("João", "Silva");
Pessoa p2 = new Pessoa("Maria", "Oliveira");

// Adiciona hóspedes à lista
hospedes.Add(p1);
hospedes.Add(p2);

// Cria uma suíte
Suite suite = new Suite("Premium", 2, 150.00M);

// Cria uma reserva
reserva reserva = new reserva(12);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
reserva.Hospedes = hospedes;

// Exibe informações da reserva
Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Tipo da suíte: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria():C}");
    
