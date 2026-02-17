using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprofundamento.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; } //lista (coleção) do tipo pessoa

        public void AdicionarAluno (Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQntDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {

            Console.WriteLine($"Alunos do curso de {Nome}: \n");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}