using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Banco
    {

        public int Conta { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; private set; }


        public Banco(int Numero, string Nome, double Deposito) : this(Numero, Nome)
        {

            Saldo = Deposito;

        }

        public Banco(int Numero, string Nome) {

            Conta = Numero;
            Titular = Nome;
            Saldo = 0;

        }

        public void ValorDeposito(double quantity)
        {

            Saldo = Saldo + quantity;


        }

        public void ValorSaque(double quantity)
        {

            Saldo = Saldo - quantity - 5;


        }

        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
