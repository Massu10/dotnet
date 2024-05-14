using System.Globalization;
namespace Course
{
    class Conta
    {
        public int Numero { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }

        public Conta(int numero, string nome, double saldo)
        {
            Numero = numero;
            _nome = nome;
            Saldo = saldo;
        }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            _nome = nome;
            Saldo = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo = Saldo - (valor + 5.0);
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", "
            + "Titular: "
            + _nome
            + ", "
            + "Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}