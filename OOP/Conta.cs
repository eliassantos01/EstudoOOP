using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta
    {
        public string Nome { get; set; }

        // Somente a classe pode alterar o atributo Saldo (private)
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();
            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saldo insuficente");
                return false;
            }
            else
            {
                this.Saldo -= valor;
                return true;
            }

        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }

        public void AlterarLimite(double valor)
        {
            this.Limite = valor;
        }
    }
}
