using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo OOP");

            // Criando uma instância da conta
            Conta conta = new Conta();

            conta.AlterarLimite(850);
            conta.Depositar(1000);
           bool sacar = conta.Sacar(50);
            if (sacar)
            {
                double saldo = conta.ConsultaSaldoDisponivel();
                Console.WriteLine("Seu saldo total é: R$ {0}", saldo);
                Console.WriteLine("Seu limite é: R$ {0}", conta.Limite);
            }

            
        }
    }
}
