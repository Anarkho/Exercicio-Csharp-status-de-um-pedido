using Loja_exercicio_proposto_Csharp.Entidades;
using Loja_exercicio_proposto_Csharp.Entidades.Enumeracao;
using System;
using System.Globalization;

namespace Loja_exercicio_proposto_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##########################################################\n");
            Console.WriteLine("Entre com os dados do cliente: \n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Aniversario (DD/MM/YYYY): ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome,email,dataAniversario);

            Console.WriteLine("\nEntre com os dados do pedido: ");
            Console.Write("Status: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("\nQuantos itens nesse pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEntre com os dados do item #{i}\n");
                Console.Write("Nome do Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preco do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeProduto, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItensdoPedido itensPedido = new ItensdoPedido(quantidade, preco, produto);

                pedido.AddItens(itensPedido);

                Console.WriteLine("\n"+pedido);
                Console.WriteLine("##########################################################");
            }
        }
    }
}
