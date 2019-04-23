using System.Globalization;

namespace PrimeiroProjeto
{
    class Banco
    {
        public string Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        private double ValorDoSaque = 5.00;

        public Banco(string conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public Banco(string conta, string titular, double depositoInicial) : this(conta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= ValorDoSaque;
        }

        public override string ToString()
        {
            return "Conta " + Conta + 
                ", Titular: " + Titular 
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
