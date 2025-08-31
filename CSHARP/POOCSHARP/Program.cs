using POOCSHARP.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.idade = 25;
p1.apresentar();

ContaCorrente conta = new ContaCorrente(12345, 1000);
conta.Sacar(200);
conta.Depositar(500);
conta.ExibirSaldo();

// Herança
Aluno aluno = new Aluno();
aluno.Nome = "Roberto";
aluno.idade = 12;
aluno.Nota = 10;
aluno.apresentar();

// Polimorfismo

Professor professor = new Professor();
professor.Nome = "Ana";
professor.idade = 30;
professor.Salario = 3000; 
professor.apresentar();
