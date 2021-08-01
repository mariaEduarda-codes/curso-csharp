using System;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            double area = ret.Area();
            double perimetro = ret.Perimetro();
            double diagonal = ret.Diagonal();

            Console.WriteLine($"ÁREA = {area.ToString("F2")}");
            Console.WriteLine($"PERÍMETRO = {perimetro.ToString("F2")}");
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F2")}");
        }
    }
}
