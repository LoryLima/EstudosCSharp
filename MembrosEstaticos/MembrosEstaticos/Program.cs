using MembrosEstaticos;
using System.Globalization;
using System.Net.Http.Headers;

Console.Write("Entre o valor do raio:");
double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


double circ = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine($"{volume}, {circ}");


