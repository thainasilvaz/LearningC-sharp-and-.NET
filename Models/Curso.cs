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

            for (int i = 0; i < Alunos.Count; i++)
            {
                //string texto = "Nº " + i + " - " + Alunos[i].NomeCompleto; //concateação de strings
                string texto = $"Nº {i + 1} -  {Alunos[i].NomeCompleto}"; //interpolação de strubgs
                Console.WriteLine(texto);
            }

        }

    }
}