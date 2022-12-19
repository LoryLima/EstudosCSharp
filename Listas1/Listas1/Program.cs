


using System.ComponentModel;

List<string> lista = new List<string>();


// Add por padrão adiciona no final da lista;
lista.Add("Lorena");
lista.Add("Beatriz");
lista.Add("Pedro");
lista.Add("Bianca");
lista.Add("Maria");
lista.Add("Marco");
// Insert você indica a posição que quer adicionar.
lista.Insert(2, "Nogueira");
Console.WriteLine("----------------------------------------------");
foreach (string nome in lista)
{
    Console.WriteLine(nome);
}
Console.WriteLine("Tamanho da lista: " + lista.Count);


string procurar = lista.Find(x => x[0] == 'P');
Console.WriteLine("Primeiro nome com A: " + procurar);

string ultimo = lista.FindLast(x => x[0] == 'B');
Console.WriteLine("Último nome da lista com B: " + ultimo);

int posicao1 = lista.FindLastIndex(x => x[0] == 'B');
Console.WriteLine("Posição do último elemento com a letra B: " + posicao1);
Console.WriteLine("----------------------------------------------");
List<string> listafiltrada = lista.FindAll(x => x.Length == 5);

foreach (string filtro in listafiltrada)
{
    Console.WriteLine(filtro);
}

Console.WriteLine("----------------------------------------------");

lista.Remove("Marco");
foreach (string nome in lista)
{
    Console.WriteLine(nome);
}


Console.WriteLine("----------------------------------------------");
lista.RemoveAt(3);

foreach (string nome in lista)
{
    Console.WriteLine(nome);
}

Console.WriteLine("----------------------------------------------");
lista.RemoveRange(3, 1);
foreach (string nome in lista)
{
    Console.WriteLine(nome);
}

