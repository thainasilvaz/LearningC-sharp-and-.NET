
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição nº {i} - {listaString[i]}");
}

/*int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
}

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2]; //array com o dobro do tamanho do outro
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); //copiando os elementos do arrayInteiros para o arrayInteirosDobrado
*/