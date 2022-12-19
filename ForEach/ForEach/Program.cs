


using System.Net.WebSockets;

string[] vetor = new string[] { "Lorena", "Beatriz", "Pedro" };


for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}

Console.WriteLine("**********************************************");

foreach (string nome in vetor)
{
    Console.WriteLine(nome);
}
