using System.Globalization;
using System.Runtime.CompilerServices;
using DadosProduto;






Produto product = new Produto("TV", 5, 10);


Console.WriteLine(product);






/*Console.WriteLine("****Entre os dados do produto****");
Console.WriteLine("Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Produto product = new Produto(nome, preco, 5);
//Console.WriteLine("Quantidade no estoque: ");
//int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




Console.WriteLine();
Console.WriteLine(product);
Console.WriteLine();

Console.WriteLine("Caso deseje adicionar um produto digite 1. Caso queira remover um produto digite 2. Se não houver mudança no estoque digite 3.");
int resposta = int.Parse(Console.ReadLine());
if (resposta == 1)
{
    Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
    int qte = int.Parse(Console.ReadLine());
    product.AdicionarProdutos(qte);
}
if (resposta == 2)
{
    Console.WriteLine("Digite o número de produtos que deseja remover do estoque: ");
    int qte = int.Parse(Console.ReadLine());
    product.RemoverProdutos(qte);

}
if (resposta == 3)
{
    Console.WriteLine("Nenhuma alteração a ser realizada no estoque.");
}
else
{
    Console.WriteLine("Número inválido.");
}

Console.WriteLine();

Console.WriteLine($"***Dados atuais do produto***\n{product}"); */
