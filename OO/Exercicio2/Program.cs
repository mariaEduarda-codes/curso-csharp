using System;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            Funcionario fulano = new Funcionario();

            Console.Write("Nome: ");
            fulano.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fulano.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            fulano.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(fulano);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            fulano.AumentarSalario(porcent);

            Console.WriteLine($"Dados atualizados: {fulano}");
        }
    }
}
