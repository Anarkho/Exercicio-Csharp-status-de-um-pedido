
using System.Globalization;
using System.Text;

namespace Loja_exercicio_proposto_Csharp.Entidades
{
    class ItensdoPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }


        public ItensdoPedido()
        {
        }

        public ItensdoPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double ValorTotalPedido()
        {
           return Quantidade * Preco;
        }

        public override string ToString()
        {
            StringBuilder saida = new StringBuilder();
            saida.Append(Produto.Nome+", ");
            saida.Append("Quantidade: " + Quantidade+", ");
            saida.Append("Valor Total: " + ValorTotalPedido().ToString("f2", CultureInfo.InvariantCulture));


            return saida.ToString();
        }
    }
}
