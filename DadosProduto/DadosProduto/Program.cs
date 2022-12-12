using System.Globalization;
using System.Runtime.CompilerServices;
using DadosProduto;


Produto product = new Produto("tv", 500, 10);
/*
Console.WriteLine("****Entre os dados do produto****");
Console.WriteLine("Nome: ");
product.Nome = Console.ReadLine();
Console.WriteLine("Preço: ");
product.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantidade no estoque: ");
product.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Dados do produto: " + product);
Console.WriteLine(); 

Console.WriteLine("Caso deseje adicionar um produto digite 1. Caso queira remover um produto digite 2. Se não houver mudança no estoque digite 3.");
int resposta = int.Parse(Console.ReadLine());
if (resposta == 1)
{
    Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
    int qte = int.Parse(Console.ReadLine());
    product.AdicionarProdutos(qte);
} if (resposta == 2)
{
    Console.WriteLine("Digite o número de produtos que deseja remover do estoque: ");
    int qte = int.Parse(Console.ReadLine());
    product.RemoverProdutos(qte);

} if ( resposta == 3 )
{
    Console.WriteLine("Nenhuma alteração a ser realizada no estoque.");
}
else
{
    Console.WriteLine("Número inválido.");
}
*/
Console.WriteLine();

Console.WriteLine($"***Dados atuais do produto***\n{product}"); 
