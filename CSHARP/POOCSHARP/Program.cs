using POOCSHARP.Models;

Smartphone samsung = new Samsung("123456789", "Galaxy S21", "123456789012345", "128GB");
samsung.Ligar();
samsung.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", "256GB");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

//Corrente corrente = new Corrente();
//corrente.Creditar(500);
//Console.WriteLine($"Saldo da conta corrente: {corrente.ExibirSaldo}");


//Pessoa p1 = new Pessoa();
//p1.Nome = "João";
//p1.idade = 25;
//p1.apresentar();

//ContaCorrente conta = new ContaCorrente(12345, 1000);
//conta.Sacar(200);
//conta.Depositar(500);
//conta.ExibirSaldo();

//// Herança
//Aluno aluno = new Aluno();
//aluno.Nome = "Roberto";
//aluno.idade = 12;
//aluno.Nota = 10;
//aluno.apresentar();

//// Polimorfismo

//Professor professor = new Professor();
//professor.Nome = "Ana";
//professor.idade = 30;
//professor.Salario = 3000; 
//professor.apresentar();
