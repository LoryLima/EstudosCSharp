
using RefOut;




// A diferença entre os dois é que em ref DEVE ter sido iniciada e out NÃO precisa.
//

int b = 2;

Calculadora.Triplicar(ref b);
Console.WriteLine(b);


int c = 10;
int triplo;

Calculadora.Triple(c, out triplo);
Console.WriteLine(triplo);
