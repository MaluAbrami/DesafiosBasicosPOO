public class Funcionario
{
    private string nome;
    private decimal salario;
    
    public Funcionario(string nome, decimal salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public decimal CalcularSalarioTotal()
    {
        return this.salario;
    }
}