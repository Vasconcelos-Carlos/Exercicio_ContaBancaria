using System;
using Exercicio_ContaBancaria.Exceções;

namespace Exercicio_ContaBancaria.Entities
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public ContaBancaria(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;

        }

        public void Saque(double quantia)
        {
            if (quantia > Saldo)
            {
                throw new ExceçoesDominio("Valor solicitado é superior ao saldo da conta.");
            }
            if (quantia > LimiteSaque)
            {
                throw new ExceçoesDominio("Valor solicitado ultrapassa o limete de saque.");
            }
            Saldo -= quantia;  
        }

    }
}
