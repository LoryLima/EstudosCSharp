using System.Globalization;
using ExercicioLista;





Console.Write("Quantos funcionários serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> list = new List<Funcionario>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Funcionário #" + i);
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Funcionario(id, nome, salario));
}


Console.WriteLine("Entre com o id do funcionário que irá receber um aumento de salário: ");
int procurarId = int.Parse(Console.ReadLine());
Funcionario employee = list.Find(x => x.Id == procurarId);
if (employee != null)
{
    Console.Write("Insira a porcentagem: ");
    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employee.AumentarSalario(porcentagem);

}
else
{
    Console.WriteLine("ID não encontrado.");
}

Console.WriteLine("---------------------------------------");
Console.WriteLine("Lista de funcionários atualizada: ");
foreach (Funcionario nomes in list)
{
    Console.WriteLine(nomes);
}



