namespace Banco {
    class Conta {
        private int _numero;
        private string _titular;
        private double _saldo;
        
        public string Titular {
            get { return _titular; }
            set { _titular = value; }
        }

        public int Numero {
            get { return _numero; }
        }

        public double Saque {
            set {
                _saldo = _saldo - value - 5.0;
            }
        }

        public double Deposito {
            set {
                _saldo = _saldo + value;
            }
        }

        public Conta(string nome, int numeroConta) {
            _titular = nome;
            _numero = numeroConta;
        }

        public Conta(string nome, int numeroConta, double saldo) : this(nome, numeroConta) {
            _saldo = saldo;
        } 

        public override string ToString() {
            return $"Conta {_numero}, Titular: {_titular}, Saldo: ${_saldo.ToString("F2")}";
        }
    }
}
