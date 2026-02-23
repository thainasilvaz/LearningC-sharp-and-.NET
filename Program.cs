using DesafioFundamentos.Models;
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



// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("\nDigite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar \n");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida \n");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
