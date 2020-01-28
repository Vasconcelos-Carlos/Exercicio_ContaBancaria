using System;
using Exercicio_ContaBancaria.Entities;
using Exercicio_ContaBancaria.Exceções;

namespace Exercicio_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da Conta");
            Console.Write("Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Limete de Saque: ");
            double limiteSaque = double.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria(numero, titular, saldo, limiteSaque);

            Console.WriteLine();
            try
            {
                Console.Write("Valor para ser sacado: ");
                double valorSaque = double.Parse(Console.ReadLine());

                conta.Saque(valorSaque);

                Console.Write($"Saldo atualizado R$ {conta.Saldo.ToString("F2")}");
                Console.WriteLine("=-=-=-=-==-=-==-=-=-=-=-=");
            }
            catch(ExceçoesDominio e)
            {
                Console.WriteLine("Erro na operaçao: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }

        }
    }
}
