using System;

namespace Exercicio3 {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal;

        public double CalcularNotaFinal() {
            NotaFinal = Nota1 + Nota2 + Nota3;
            return NotaFinal;
        }

        public string Resultado() {
            if (NotaFinal >= 60) {
                return "APROVADO";
            } else {
                return "REPROVADO";
            }
        }

        public void PontosFaltantes() {
            double PontosQueFaltam = 60 - NotaFinal;
            if(Resultado() == "REPROVADO") {
                Console.WriteLine($"FALTARAM {PontosQueFaltam.ToString("F2")} PONTOS");
            }
        }
    }
}
