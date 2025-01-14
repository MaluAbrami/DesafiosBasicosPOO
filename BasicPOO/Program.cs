internal class Program
{
    private static void Main(string[] args)
    {
        int op;

        do
        {
            Console.WriteLine("Desafios Básicos");
            Console.WriteLine("1-Desafio 1");
            Console.WriteLine("2-Desafio 2");
            Console.WriteLine("3-Desafio 3");
            Console.WriteLine("4-Desafio 4");
            Console.WriteLine("5-Desafio 5");
            Console.WriteLine("6-Sair");

            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1: //CADASTRO DE PRODUTOS | Prática de Classes e Métodos
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Cadastro de Produtos");

                        Console.WriteLine("Informe o código do produto: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o preço do produto: ");
                        decimal preco = Convert.ToDecimal(Console.ReadLine());

                        Produto produto = new Produto(codigo, nome, preco);
                        Console.WriteLine($"\nProduto {i + 1}");
                        produto.ExibirInformacoes();
                    }
                    break;
                }
                case 2: //SISTEMA DE FUNCIONÁRIOS | Herança
                {
                    Console.WriteLine("Cadastro de Funcionário Comum");

                    Console.WriteLine("Informe o nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o salário: ");
                    decimal salario = Convert.ToDecimal(Console.ReadLine());
                    Funcionario funcionario = new Funcionario(nome, salario);
                    Console.WriteLine(
                        $"Salário do Funcionário: {funcionario.CalcularSalarioTotal()}"
                    );

                    Console.WriteLine("Cadastro de Gerente");

                    Console.WriteLine("Informe o nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Informe o salário: ");
                    salario = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Informe o bônus salarial do gerente: ");
                    decimal bonus = Convert.ToDecimal(Console.ReadLine());
                    Gerente gerente = new Gerente(nome, salario, bonus);
                    Console.WriteLine($"Salário do Gerente: {gerente.CalcularSalarioTotal()}");

                    break;
                }
                case 3: //BIBLIOTECA DE LIVROS
                {
                    int resp = 1;
                    do
                    {
                        switch (resp)
                        {
                            case 1:
                            {
                                Console.WriteLine("Informe o Titulo: ");
                                string titulo = Console.ReadLine();

                                Console.WriteLine("Informe o Autor: ");
                                string autor = Console.ReadLine();

                                Console.WriteLine("Informe o Preço: ");
                                decimal preco = Convert.ToDecimal(Console.ReadLine());

                                if (preco > 0)
                                {
                                    Livro livro = new Livro(titulo, autor, preco);
                                    Console.WriteLine(
                                        $"Titulo: {livro.Titulo}\nAutor: {livro.Autor}\nPreço: {livro.Preco}"
                                    );
                                }
                                else
                                    Console.WriteLine(
                                        "Erro: impossível cadastrar livro com preço negativo"
                                    );
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("Saindo...");
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Resposta inválida.");
                                break;
                            }
                        }

                        Console.WriteLine("Deseja cadastrar mais algum livro?(1-Sim|2-Não)");
                        resp = Convert.ToInt32(Console.ReadLine());
                    } while (resp == 1);
                    break;
                }
                case 4: //GERENCIAMENTO DE CONTAS BANCÁRIAS | POLIMORFISMO
                {
                    ContaCorrente[] contasCorrentes = new ContaCorrente[2];
                    ContaPoupanca[] contasPoupancas = new ContaPoupanca[2];

                    contasCorrentes[0] = new ContaCorrente("Malu", 1500);
                    contasPoupancas[0] = new ContaPoupanca("Malu A.", 500);

                    contasCorrentes[0].Depositar(300);
                    contasCorrentes[0].ImprimirConta();
                    contasCorrentes[0].Sacar(1600);

                    contasPoupancas[0].AtualizarSaldoMensal();
                    contasPoupancas[0].ImprimirConta();

                    break;
                }
                case 5: //SISTEMA DE LOJA COM CARRINHO DE COMPRAS | EXPLORAR COMPOSIÇÃO
                {
                    int resp = 1;
                    CarrinhoDeCompras carrinhoDeCompras = new CarrinhoDeCompras();

                    do
                    {
                        switch (resp)
                        {
                            case 1:
                            {
                                Console.WriteLine("Nome Produto: ");
                                string nome = Console.ReadLine();

                                Console.WriteLine("Preço Produto: ");
                                decimal preco = Convert.ToDecimal(Console.ReadLine());

                                Product produto = new Product(nome, preco);
                                carrinhoDeCompras.AdicionarProduto(produto);
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("Saindo...");
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Resposta inválida.");
                                break;
                            }
                        }

                        Console.WriteLine("Deseja adicionar mais algum produto? (1-Sim|2-Não)");
                        resp = Convert.ToInt32(Console.ReadLine());
                    } while (resp == 1);

                    carrinhoDeCompras.ExibirCarrinho();
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Bye bye...");
                    break;
                }
                default:
                {
                    Console.WriteLine("Opção inválida.");
                    break;
                }
            }
        } while (op != 6);
    }
}
