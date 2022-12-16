

/* Métodos de Nullable:
 *  GetValueOrDefault
 *  HasValue
 *  Value  */



double? x = null;
double? y = 10;




double a = x ?? 5;
double b = y ?? 5;

Console.WriteLine(a);
Console.WriteLine(b);















/*

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());
Console.WriteLine();
Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);
Console.WriteLine();
//Console.WriteLine(x.Value);  // Não tem como chamar, precisa ter um valor.
Console.WriteLine(y.Value);

*/

