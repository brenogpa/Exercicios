using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public override string ToString()
        {
            return " Conta " + Numero + 
                ", Titular: " + Titular + 
                ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public double Deposito(double deposito)
        {
            return Saldo += deposito;
        }

        public double Saque(double saque)
        {
            return Saldo -= saque + 5.00;
        }
    }
}
