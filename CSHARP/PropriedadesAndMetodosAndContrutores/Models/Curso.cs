using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAndMetodosAndContrutores.Models
{
    public class Curso
    {
        
        public string? NomeCurso { get; set; }

        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();
        
        public void AdicionarAluno(Pessoa aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno), "O aluno não pode ser nulo.");
            } else
            {
                Alunos.Add(aluno);
                Console.WriteLine($"Aluno {aluno.Nome} adicionado ao curso {NomeCurso} com sucesso.");
            }   
        }

        public int ObterQuantidadeAlunos()
        {
            Console.WriteLine($"Obtendo a quantidade de alunos matriculados no curso {NomeCurso}.");
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno), "O aluno não pode ser nulo.");
            } else
            {
                Alunos.Remove(aluno);
                Console.WriteLine($"Aluno {aluno.Nome} do curso ${NomeCurso} removido com sucesso.");
            }      
        }

        public void ListarAlunos()
        {
            if (Alunos.Count == 0)
            {
                Console.WriteLine($"Nenhum aluno matriculado no curso {NomeCurso}.");
            } else
            {
                Console.WriteLine($"Alunos matriculados no curso {NomeCurso}:");
                foreach (var aluno in Alunos)
                {
                    Console.WriteLine($"- {aluno.Nome}, Idade: {aluno.Idade}");
                }
            }
        }

        // método para obter os alunos matriculados
        public List<Pessoa> ObterAlunos()
        {
            Console.WriteLine($"Obtendo alunos matriculados no curso {NomeCurso}.");
            if (Alunos.Count == 0)
            {
                Console.WriteLine($"Nenhum aluno matriculado no curso {NomeCurso}.");
                return new List<Pessoa>();
            }
            else
            {
                return Alunos;
            }
        }

    }
}
