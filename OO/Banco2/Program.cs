using System;

namespace Banco2 {
    class Program {
        static void Main(string[] args) {
            double depositoInicial;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            ContaCorrente conta1;

            if (resposta == 's') {
                Console.Write("Entre o valor do depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine());
                conta1 = new ContaCorrente(numConta, nomeTitular, depositoInicial);

            }
            else {
                conta1 = new ContaCorrente(numConta, nomeTitular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
        }
    }
}
