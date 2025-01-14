using System.Dynamic;

public class Livro
{
    private string titulo;
    private string autor;
    private decimal preco;

    public Livro(string titulo, string autor, decimal preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Erro: preço não pode ser um valor negativo");
                return;
            }
            else
                preco = value;
        }
    }
}
