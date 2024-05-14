using System.Globalization;
namespace Course
{
    class Quarto
    {
        
        private string _nome;
        public string Email { get; set; }
        public double Numero { get; set; }

        public Quarto(string nome, string email, int numero)
        {            
            _nome = nome;
            Email = email;
            Numero = numero;
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

        public override string ToString()
        {
            return Numero.ToString()
            + ": "
            + _nome
            + ", "
            + Email;
        }

    }
}