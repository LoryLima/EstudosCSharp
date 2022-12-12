
namespace DesafioConversor
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double totalImposto = quantia * Iof / 100;
            quantia += totalImposto;
            return quantia * cotacao;
            

        }

    }
}
