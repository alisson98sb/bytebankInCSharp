using System;
using bytebank;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "André Silva";
            conta1.conta = "10123-x";
            conta1.numero_agencia = 23;
            conta1.nome_agencia = "Agencia Central";
            conta1.saldo = 100;

            ContaCorrente conta3 = new ContaCorrente();
            Console.WriteLine("Titular: " + conta3.titular);
            Console.WriteLine("Conta: " + conta3.conta);
            Console.WriteLine("Numero da Agência: " + conta3.numero_agencia);
            Console.WriteLine("Nome da Agência: " + conta3.nome_agencia);
            Console.WriteLine("Saldo: " + conta3.saldo);             

            Console.ReadKey();
        }
    }
}
