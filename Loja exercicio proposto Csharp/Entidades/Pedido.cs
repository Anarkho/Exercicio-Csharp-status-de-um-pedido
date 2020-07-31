using Loja_exercicio_proposto_Csharp.Entidades.Enumeracao;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Loja_exercicio_proposto_Csharp.Entidades
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }

        public Cliente Cliente { get; set; }

        public List<ItensdoPedido> Itens { get; set; } = new List<ItensdoPedido>();

        public Pedido() { }

        public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItens(ItensdoPedido i)
        {
            Itens.Add(i);
        }
        public void RemoveItens(ItensdoPedido i)
        {
            Itens.Remove(i);
        }

        public double Total()
        {
            double Soma = 0.0;
            foreach (ItensdoPedido item in Itens)
            {
                Soma += item.ValorTotalPedido();
            }
            return Soma;
        }

        public override string ToString()
        {
            StringBuilder saida = new StringBuilder();
            saida.AppendLine("RESUMO DO PEDIDO");
            saida.AppendLine("Momento da encomenda: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            saida.AppendLine("Status do Pedido: " + Status);
            saida.AppendLine("Cliente: " + Cliente);
            saida.AppendLine("Itens do Pedido: ");
            foreach (ItensdoPedido item in Itens)
            {
                saida.AppendLine(item.ToString());
            }
            saida.AppendLine("\nValor Total do Pedido: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return saida.ToString();
        }

    }
}
