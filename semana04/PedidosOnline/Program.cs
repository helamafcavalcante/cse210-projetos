using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco enderecoEua = new Endereco(
            "50 N W Temple St,",
            "Salt Lake City",
            "Utah",
            "USA");
        Cliente clienteEua = new Cliente("Ana Souza", enderecoEua);

        Pedido pedidoEua = new Pedido(clienteEua);
        pedidoEua.AdicionarProduto(new Produto("Caderno", "C-1", 4.50, 2));
        pedidoEua.AdicionarProduto(new Produto("Caneta", "C-2", 1.25, 4));
        pedidoEua.AdicionarProduto(new Produto("Mochila", "M-1", 28.00, 1));

        Endereco enderecoBrasil = new Endereco(
            "Rua Antonio Fortes, 330",
            "Fortaleza",
            "Ceará",
            "Brasil");
        Cliente clienteBrasil = new Cliente("Carlos Lima", enderecoBrasil);

        Pedido pedidoBrasil = new Pedido(clienteBrasil);
        pedidoBrasil.AdicionarProduto(new Produto("Livro", "L-1", 18.00, 2));
        pedidoBrasil.AdicionarProduto(new Produto("Marcador", "M-2", 2.50, 3));

        ExibirPedido("PEDIDO 1", pedidoEua);
        ExibirPedido("PEDIDO 2", pedidoBrasil);
    }

    static void ExibirPedido(string titulo, Pedido pedido)
    {
        Console.WriteLine();
        Console.WriteLine($"=== {titulo} ===");
        Console.WriteLine("Etiqueta de embalagem:");
        Console.WriteLine(pedido.ObterEtiquetaDeEmbalagem());
        Console.WriteLine("Etiqueta de envio:");
        Console.WriteLine(pedido.ObterEtiquetaDeEnvio());
        Console.WriteLine($"Total do pedido: ${pedido.CalcularCustoTotal():F2}");
        Console.WriteLine();
    }
}
