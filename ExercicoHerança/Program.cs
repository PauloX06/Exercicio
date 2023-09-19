
using ExercicoHerança.classes;
using System.Threading.Channels;

class program
{
    static void Main(string[] args)
    {
        int Nconta = 1;
        string agencia = "Jipa";

        while (true)
        {
            Console.WriteLine("Digite \n" +
               "1 para conta normal \n" +
               "2 para conta estudante \n" + 
               "3 para conta empresarial \n" +
               "4 sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular");
            string nometitular = Console.ReadLine();
            if (opcao == 1)
            {
                ContaBancaria c = new ContaBancaria(Nconta, agencia, nometitular, 0);
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Deposito(valor);
                        Console.WriteLine($"Novo saldo R$: {c.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Saque(valor);
                        Console.WriteLine($"Novo saldo R$: {c.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }

                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o CPF do estudante");
                string instituicao = Console.ReadLine();

                ContaEstudante ce = new ContaEstudante(Nconta, agencia, nometitular, 0, 100, "002020", "ifro");
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar e 3 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Deposito(valor);
                        Console.WriteLine($"Novo saldo R$: {ce.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Saque(valor);
                        Console.WriteLine($"Novo saldo R$: {ce.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();
                        break;
                    }

                }
            }
            else if (opcao == 3)
            {

                ContaEmpresa cempresa = new ContaEmpresa(1, "004", "Paulo", 5000, 4000, 6000);
                Nconta += 1;
                
                
                while (true)
                {
                    Console.WriteLine("1 para depositar, 2 para sacar, 3 realizar emprestimo e 4 para sair");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.Deposito(valor);
                        Console.WriteLine($"Novo saldo R$: {cempresa.Saldo}");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.Saque(valor);
                        Console.WriteLine($"Novo saldo R$: {cempresa.Saldo}");
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Digite o valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        cempresa.RealizarEmprestimo(valor);
                        Console.WriteLine($"Novo saldo R$: {cempresa.Saldo}");
                    }
                    else if (opcao == 4)
                    {
                        Console.Clear();
                        break;

                    }

                }
            }

        }
       
    }
}



