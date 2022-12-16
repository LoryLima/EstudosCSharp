using System.Globalization;

using VetorPE2;



Console.WriteLine("Digite a quantidade de produtos: ");
int n = int.Parse(Console.ReadLine());

Produto[] vetor = new Produto[n];

for (int i = 0; i < n; i++)
{
    string nomeProduto = Console.ReadLine();
    double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vetor[i] = new Produto { Name = nomeProduto, Price = precoProduto };

}

double soma = 0;

for (int i = 0; i < n; i++)
{
    soma += vetor[i].Price;
}

double media = soma / n;
Console.WriteLine("Média do preço: " + media.ToString("F2", CultureInfo.InvariantCulture));
