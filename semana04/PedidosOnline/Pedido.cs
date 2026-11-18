using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _produtos = new List<Produto>();
        _cliente = cliente;
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularCustoTotal()
    {
        double custoProdutos = 0;

        foreach (Produto produto in _produtos)
        {
            custoProdutos += produto.CalcularCustoTotal();
        }

        double custoEnvio = 35;
        if (_cliente.MoraNosEua())
        {
            custoEnvio = 5;
        }

        return custoProdutos + custoEnvio;
    }

    public string ObterEtiquetaDeEmbalagem()
    {
        string etiqueta = "";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"{produto.ObterNome()} (ID: {produto.ObterId()})\n";
        }

        return etiqueta;
    }

    public string ObterEtiquetaDeEnvio()
    {
        return $"{_cliente.ObterNome()}\n{_cliente.ObterEnderecoCompleto()}";
    }
}
