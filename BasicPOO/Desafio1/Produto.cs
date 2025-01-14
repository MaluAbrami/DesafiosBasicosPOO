public class Produto
{
    private int codigo;
    private string nome;
    private decimal preco;

    public Produto(int codigo, string nome, decimal preco){
        this.codigo = codigo;
        this.nome = nome;
        this.preco = preco;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Código: {this.codigo}\nNome: {this.nome}\nPreço: {this.preco}\n");
    }
}