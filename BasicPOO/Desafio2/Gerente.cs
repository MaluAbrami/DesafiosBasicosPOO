public class Gerente:Funcionario
{
    private decimal bonus;

    public Gerente(string nome, decimal salario, decimal bonus):base(nome, salario)
    {
        this.bonus = bonus;
    }

    public decimal CalcularSalarioTotal()
    {
        return base.CalcularSalarioTotal() + bonus;
    }
}