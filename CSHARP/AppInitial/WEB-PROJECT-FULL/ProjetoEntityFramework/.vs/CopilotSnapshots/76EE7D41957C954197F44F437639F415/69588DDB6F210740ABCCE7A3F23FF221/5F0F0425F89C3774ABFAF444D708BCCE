using System;
using System.Linq;
using ProjetoEntityFramework.Model;
using ProjetoEntityFramework.Data;

// ORM - Object Relational Mapping - Mapeamento Objeto Relacional
// Code First - Primeiro o Código depois o Banco de Dados

public class Program
{
    static void Main()
    {
        using (var DataBase = new ApplicationDbContext())
        {
            // Create
            var novoProduto = new Produto
            {
                Nome = "Teclado",
                Preco = 150.00m
            };

            DataBase.Produto.Add(novoProduto);
            DataBase.SaveChanges();
        }
    }
}




