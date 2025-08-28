using System;
using System.Collections.Generic;
using Hotel.Models;

// Cria uma lista de h�spedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Jo�o", "Silva");
Pessoa p2 = new Pessoa("Maria", "Oliveira");

// Adiciona h�spedes � lista
hospedes.Add(p1);
hospedes.Add(p2);

// Cria uma su�te
Suite suite = new Suite("Premium", 2, 150.00M);

// Cria uma reserva
reserva reserva = new reserva(12);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
reserva.Hospedes = hospedes;

// Exibe informa��es da reserva
Console.WriteLine($"Quantidade de h�spedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Tipo da su�te: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Valor total da di�ria: {reserva.CalcularValorDiaria():C}");
    
