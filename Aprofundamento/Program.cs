using System.Runtime.Versioning;
using Aprofundamento.Models;

Pessoa p1 = new Pessoa(nome: "Thainá", sobrenome: "Ferreira da Silva");

Pessoa p2 = new Pessoa(nome: "Guilherme", sobrenome: "Barca Nascimento Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>(); //criando uma nova lista de alunos (vazia)

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



























/*
p1.Nome = "Thainá";
p1.Sobrenome = "Ferreira da Silva";
p1.Idade = 20;
p1.Apresentar();
*/

