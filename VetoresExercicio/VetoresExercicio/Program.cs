using System.Numerics;
using VetoresExercicio;



Aluguel[] vetor = new Aluguel[10];

Console.Write("Quantos quartos serão alugados?");
int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Aluguel #{i}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vetor[quarto] = new Aluguel(nome, email);
}

Console.WriteLine();
Console.WriteLine("Quartos ocupados: ");

for (int i = 0; i < 10; i++)
{
    if (vetor[i] != null)
    {
        Console.WriteLine(i + ": " + vetor[i]);
    }
}


