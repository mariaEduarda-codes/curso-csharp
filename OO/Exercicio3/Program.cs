using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno1 = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            double notaAluno = aluno1.CalcularNotaFinal();
            Console.WriteLine($"NOTA FINAL = {notaAluno.ToString("F2")}");
            string result = aluno1.Resultado();
            Console.WriteLine($"{result}");
            aluno1.PontosFaltantes();
        }
    }
}
