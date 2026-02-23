using System.Runtime.Versioning;
using Aprofundamento.Models;

decimal valorMonetario = 1582.40M; //para valores decimais, é necessário colocar o M no final para o reconhecimento

Console.WriteLine($"{valorMonetario:C}"); //formatando o valor em uma moeda específica

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P")); //34,21%

DateTime data = DateTime.Now;

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

/*
//DEPOIS DO CONSTRUTOR
Pessoa p1 = new Pessoa(nome: "Thainá", sobrenome: "Ferreira da Silva");

Pessoa p2 = new Pessoa(nome: "Guilherme", sobrenome: "Barca Nascimento Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>(); //criando uma nova lista de alunos (vazia)

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/


/*
//ANTES DO CONSTRUTOR
p1.Nome = "Thainá";
p1.Sobrenome = "Ferreira da Silva";
p1.Idade = 20;
p1.Apresentar();
*/

