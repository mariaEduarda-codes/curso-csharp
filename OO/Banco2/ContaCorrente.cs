namespace Banco2 {
    class ContaCorrente {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int conta, string nome) {
            NumeroConta = conta;
            NomeTitular = nome;
        }
        public ContaCorrente(int conta, string nome, double saldo) : this(conta, nome) {
            Saldo = saldo;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo = Saldo - quantia - 5.0;
        }

        public override string ToString() {
            return $"Conta {NumeroConta}, Titular: {NomeTitular}, Saldo: ${Saldo.ToString("F2")}";
        }
    }
}
