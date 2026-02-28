using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lê uma linha contendo as tarefas separadas por espaço
        string input = Console.ReadLine();

        // Converte a entrada em uma lista de tarefas
        List<string> tarefas = new List<string>(input.Split(' ')); //o input.Split no final transforma o input em um array de strings
        List<string> resultado = new List<string>();
        
        // TODO: Separe as tarefas realizadas ("feito") das tarefas pendentes,
        //       mantendo a ordem relativa de ambas nas listas.
        
        // Após separar, coloque primeiro as pendentes e depois todas as "feito"
        
        for(int i = 0; i < tarefas.Count; i++){ //count pois a classe list<string< não possui length
          
          if(tarefas[i] != "feito"){
            resultado.Add(tarefas[i]);
          }
        }
        
        for(int i = 0;  i < tarefas.Count; i++){
          
          if(tarefas[i] == "feito"){
            resultado.Add(tarefas[i]);
          }
          
        }
        
        Console.WriteLine(string.Join(" ", resultado)); //o join (pertence a classe string) junta varios elementos em uma unica string, colocando um separador entre eles 
        
    }
}
