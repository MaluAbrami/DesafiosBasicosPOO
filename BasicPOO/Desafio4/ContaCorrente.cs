using System.Runtime.CompilerServices;

public class ContaCorrente:Conta
{
    private decimal saqueLimite;

    public ContaCorrente(string titular, decimal saldo):base(titular, saldo)
    {
        Titular = titular;
        Saldo = saldo;
        this.saqueLimite = 1500;
    }

    public void Sacar(decimal valor)
    {
        if(valor > saqueLimite)
            Console.WriteLine("Erro: valor de saque acima do limite permitido.");
        else
        {
            base.Sacar(valor);
            Console.WriteLine($"Valor de R$ {valor} sacado com sucesso.\nNovo saldo da conta: {Saldo}");
        }
    }
}