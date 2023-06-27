using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produto
    {

        private static readonly CultureInfo locale = CultureInfo.InvariantCulture;

        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return $"{Nome}, R$ {Preco}, {Quantidade} unidades, Total R$: {ValorTotalEmEstoque().ToString("F2", locale)}";
        }


    }
}
