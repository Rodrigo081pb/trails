
// Instanciar a classe pessoa
using PropriedadesAndMetodosAndContrutores.Models;

Pessoa pessoa1 = new Pessoa("Rodrigo",12);
Pessoa pessoa2 = new Pessoa("Ana", 15);

Curso cursoDeGeografia = new Curso();
cursoDeGeografia.NomeCurso = "Geografia";
cursoDeGeografia.AdicionarAluno(pessoa1);
cursoDeGeografia.AdicionarAluno(pessoa2);
cursoDeGeografia.RemoverAluno(pessoa1);
cursoDeGeografia.ObterQuantidadeAlunos();
cursoDeGeografia.ListarAlunos();

