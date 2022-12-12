using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DadosProduto
{
    internal class Produto
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return ($"Produto: {Nome.ToUpper()}, {Quantidade} unidades. Valor da unidade: ${Preco}. Valor total em Estoque: ${ValorTotalEmEstoque()}");
        }
    }
}
