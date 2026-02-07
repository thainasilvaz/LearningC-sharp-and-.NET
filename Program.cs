using fundamentos_.NET_e_C_.Models;

Calculadora calc = new Calculadora(); //instanciando a classe Calculadora -> para utilizar a classe é necessário criar uma variável do tipo da classe (nesse caso, do tipo Calculadora)

/*
calc.Soma(2,2);
calc.Subtracao(2,2);
calc.Divisao(2,2);
calc.Multiplicacao(2,2);
calc.Potenciacao(2,2);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(25);
*/

//Teste menu interativo

string opcao;

while (true)
{
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar programa \n");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrando cliente... \n");
            break;
        case "2":
            Console.WriteLine("Buscando cliente... \n");
            break;
        case "3":
            Console.WriteLine("Apagando cliente... \n");
            break;
        case "4":
            Console.WriteLine("Encerrando programa...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida. \n");
            break;
    }
}



















































// para comentar um bloco de codigo com linhas individuais: ctrl + K + C com o bloco selecionado
// para comentar um bloco de código de uma só vez: alt + shift + A

//DateTime dataAtual = DateTime.Now;

//Console.WriteLine(dataAtual);
