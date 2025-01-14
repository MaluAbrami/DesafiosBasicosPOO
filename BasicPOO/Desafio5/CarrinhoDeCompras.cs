using System.Collections;

public class CarrinhoDeCompras
{
    private List<Product> produtos;

    public CarrinhoDeCompras()
    {
        this.produtos = new List<Product>();
    }

    public void AdicionarProduto(Product produto)
    {
        produtos.Add(produto);
    }

    public void ExibirCarrinho()
    {
        decimal soma = 0;

        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{produtos[i].Nome} - R$ {produtos[i].Preco}");
            soma += produtos[i].Preco;
        }
        Console.WriteLine($"Total: R$ {soma}");
    }
}
