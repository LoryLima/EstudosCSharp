
using ExercicioBanco;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;

Conta cliente;


Console.Write("Entre o número da conta: ");
int numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine(); 
Console.Write("Haverá depósito inicial (s/n)? ");
char escolha = char.Parse(Console.ReadLine());
if (escolha == 's' || escolha == 'S')
{
    Console.WriteLine("Valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine());
    cliente = new Conta(titular, numeroConta, depositoInicial);
} else
{
    cliente = new Conta(titular, numeroConta);
}
Console.WriteLine();
Console.WriteLine("Deseja realizar alguma operação bancária? (S/N)");
char operacao = char.Parse(Console.ReadLine());
Console.WriteLine();
if (operacao == 's' || operacao == 'S')
{
    Console.WriteLine("Digite 1 para realizar um Depósito\nDigite 2 para realizar um Saque\nDigite 3 para sair.");
    int opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Valor do depósito R$ ");
        int deposito = int.Parse(Console.ReadLine());
        cliente.Deposito(deposito);
        Console.WriteLine("Dados da Conta atualizados: ");
        Console.WriteLine(cliente);
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Digite o valor para saque R$ ");
        int saque = int.Parse(Console.ReadLine());
        cliente.Saque(saque);
        Console.WriteLine("Dados da Conta atualizados: ");
        Console.WriteLine(cliente);
    }
} else
{

    Console.WriteLine("Nenhuma operação a ser feita.");
    Console.WriteLine(cliente);
}



//Console.WriteLine(cliente);


/*Conta cliente = new Conta("Maria", 9999, 1000);

cliente.Saque(200);

Console.WriteLine(cliente);


Console.WriteLine(cliente); */

