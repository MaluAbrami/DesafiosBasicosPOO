public class ContaPoupanca : Conta
{
    private decimal rendimentoMensal;

    public ContaPoupanca(string titular, decimal saldo)
        : base(titular, saldo)
    {
        Titular = titular;
        Saldo = saldo;
        this.rendimentoMensal = 0.01m;
    }

    public void AtualizarSaldoMensal()
    {
        decimal valorRendimento = Saldo * rendimentoMensal;
        Saldo += (valorRendimento);
        Console.WriteLine(
            $"O valor total do rendimento foi de R$ {valorRendimento}.\nNovo saldo da conta: {Saldo}"
        );
    }
}
