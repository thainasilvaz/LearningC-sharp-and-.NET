using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lê o número de comandos a serem processados
        int n = int.Parse(Console.ReadLine());

        // Inicializa a estrutura para armazenar sugestões únicas
        HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

        for (int i = 0; i < n; i++)
        {
            string linha = Console.ReadLine();

            // Divide o comando em ação (ADD/REMOVE) e sugestão
            int spaceIdx = linha.IndexOf(' '); //procura a posição do primeiro espaço da linha -> ADD xxxx: espaço na posicao 3
            string acao = linha.Substring(0, spaceIdx); //pega uma parte da string -> do indice 0 até o espaço (no caso de ADD, 3)
            string sugestao = linha.Substring(spaceIdx + 1); //pega o restante da string depois do espaço (se o espaço está em 3, essa linha pega do 4 pra frente)

            //tratamento para as ações de adicionar e remover sugestões
            if (acao == "ADD"){
              sugestoes.Add(sugestao);
            }
            else if(acao == "REMOVE"){
              sugestoes.Remove(sugestao);
            }
            else{
              Console.WriteLine("Comando inválido.");
            }
            
        }

        // Ao final, exibe as sugestões em ordem alfabética separadas por espaço,
        // ou "VAZIO" se não houver elementos restantes
        if (sugestoes.Count == 0)
        {
            Console.WriteLine("VAZIO");
        }
        else
        {
            List<string> ordenadas = sugestoes.ToList();
            ordenadas.Sort(StringComparer.Ordinal);
            Console.WriteLine(string.Join(" ", ordenadas));
        }
    }
}
