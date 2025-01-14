public abstract class Conta
{
    private string titular;
    private decimal saldo;

    public Conta(string titular, decimal saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public decimal Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }

    public void Depositar(decimal valor)
    {
        if(valor < 0)
            Console.WriteLine("Erro: impossível depositar um valor negativo.");
        else
        {
            saldo += valor;
            Console.WriteLine($"Valor de R$ {valor} depositado com sucesso.\nNovo saldo da conta: {saldo}");
        }

    }

    public void Sacar(decimal valor)
    {
        if(valor < 0)
            Console.WriteLine("Erro: não é possível sacar um valor negativo.");
        else if(valor > saldo)
            Console.WriteLine("Erro: saldo insuficiente.");
        else
            saldo -= valor;
    }

    public void ImprimirConta()
    {
        Console.WriteLine($"Titular da Conta: {titular}\nSaldo Atual: {saldo}");
    }
}
