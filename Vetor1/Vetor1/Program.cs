using System.Globalization;


int pessoas;


Console.Write("Digite o número de pessoas para a ler a altura: ");
pessoas = int.Parse(Console.ReadLine());

double[] vetor = new double[pessoas];

Console.WriteLine("Digite a altura de cada um: ");
for (int i = 0; i < pessoas; i++)
{
    
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
}

double soma = 0;

for (int i = 0; i < pessoas; i++)
{
    soma += vetor[i];
}

double media = soma / pessoas;
Console.WriteLine($"Altura média = {media.ToString("F2",CultureInfo.InvariantCulture)} ");
