
using System.Globalization;

using DesafioConversor;

Console.WriteLine("Qual é a cotação do dólar?");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantos dólares você vai comprar?");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
