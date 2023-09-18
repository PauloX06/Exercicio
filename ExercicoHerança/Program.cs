
using ExercicoHerança.classes;

class program
{
    static void Main(string[] args)
    {

        ContaEmpresa CE = new ContaEmpresa(1, "Banco do Brasil", "Paulo", 2000, 20, 5000);
        ContaEstudante cEstudante = new ContaEstudante(2, "Itau", "Miguel", 1000, 400, "00201824221", "Ifro");

        CE.RealizarEmprestimo(5000);
        cEstudante.Saque(2000);

        Console.WriteLine($"Saldo da conta empresa: R${CE.Saldo}");
        Console.WriteLine($"Saldo da conta estudante: R${cEstudante.Saldo}");
    }
}



