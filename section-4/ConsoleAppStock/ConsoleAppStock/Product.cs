using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStock
{
    internal class Product
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }

        public void RemoverProdutos(int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return Nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", unidades: "
                + Quantidade
                + ", Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
