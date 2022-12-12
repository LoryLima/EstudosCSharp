using DadosFuncionario;

Funcionario colaborador = new Funcionario();

Console.WriteLine("*** Dados do funcionário ***");
Console.Write("Nome: ");
colaborador.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
colaborador.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
colaborador.Imposto = double.Parse(Console.ReadLine());
colaborador.SalarioLiquido();

Console.WriteLine($"{colaborador}");

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine());
colaborador.AumentarSalario(porcentagem);

Console.WriteLine($" *****Dados atualizados*****\n{colaborador}");
