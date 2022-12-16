

using System.Globalization;

int N;

Console.WriteLine("Qual o números de pessoas para tirar a média de altura?");
N = int.Parse(Console.ReadLine());
double[] vetor = new double[N];

for(int i = 0; i < N; i++)
{
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double soma = 0;

for(int i = 0;i < N; i++)
{
    soma += vetor[i];
}

double media = soma / N;

Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
