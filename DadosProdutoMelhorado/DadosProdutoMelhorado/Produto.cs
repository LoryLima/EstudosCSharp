using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DadosProduto
{
    internal class Produto
    {
        private string _nome;   // atributo

        private double _preco;

        private int _quantidade;

        public Produto() // construtor padrão
        {

        }
        public Produto(string nome, double preco, int quantidade) // construtor com argumentos
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome; 
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

       
          public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
