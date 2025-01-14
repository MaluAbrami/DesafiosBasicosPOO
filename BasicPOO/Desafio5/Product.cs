using System.Net.WebSockets;

public class Product
{
    private int contador = 1;
    private int codigo;
    private string nome;
    private decimal preco;

    public Product(string nome, decimal preco)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
    }

    public int Codigo
    {
        get { return codigo; }
        set { codigo = contador++; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
                Console.WriteLine("Erro: não é possível atribuir valor negativo a um produto.");
            else
                preco = value;
        }
    }
}
