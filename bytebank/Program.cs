using System;
using bytebank;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "André Silva";
            conta1.conta = "10123-x";
            conta1.numero_agencia = 23;
            conta1.nome_agencia = "Agencia Central";
            conta1.saldo = 100;

            ContaCorrente conta2 = new ContaCorrente();
            conta1.titular = "Amanda Silva";
            conta1.conta = "111999-x";
            conta1.numero_agencia = 58;
            conta1.nome_agencia = "Agencia Central";
            conta1.saldo = 100;

            Roupa roupa1 = new Roupa();
            roupa1.fabricante = "Moda Jeans";
            roupa1.valor = 63.0;

            Roupa roupa2 = roupa1;
            roupa2.valor = roupa2.valor + 1000;
            Console.WriteLine(roupa1.valor);

            Console.ReadKey();
        }
    }
}
