using System;
using bytebank;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

            //ContaCorrente conta1 = new ContaCorrente();
            //conta1.titular = "André Silva";
            //conta1.conta = "10123-x";
            //conta1.numero_agencia = 23;
            //conta1.nome_agencia = "Agencia Central";
            //conta1.saldo = 100;

            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular = "Amanda Silva";
            //conta2.conta = "111999-x";
            //conta2.numero_agencia = 58;
            //conta2.nome_agencia = "Agencia Central";
            //conta2.saldo = 100;

            //Console.WriteLine("Saldo da " + conta2.titular + " pré-saque: " + conta2.saldo);
            //conta2.Sacar(50);
            //Console.WriteLine("Saldo da " + conta2.titular + " pós saque: " + conta2.saldo);

            //conta2.Depositar(60);
            //Console.WriteLine("Saldo da " + conta2.titular + " pós depósito: " +conta2.saldo);

            //Console.WriteLine("Saldo de " + conta1.titular + " pré transferência: " + conta1.saldo);
            //Console.WriteLine("Saldo de " + conta2.titular + " pré transferência: " + conta2.saldo);

            //bool transferencia = conta1.Transferir(20, conta2);

            //if (transferencia)
            //{
            //    Console.WriteLine("TRANSFERÊNCIA REALIZADA COM SUCESSO!");
            //}

            //Console.WriteLine("Saldo de " + conta1.titular + " pós transferência: " + conta1.saldo);
            //Console.WriteLine("Saldo de " + conta2.titular + " pós transferência: " + conta2.saldo);

            //Cliente cliente = new Cliente();
            //cliente.nome = "Andre Silva";
            //cliente.cpf = "10253541263";
            //cliente.profissao = "Programador C#";

            //ContaCorrente conta3 = new ContaCorrente();
            ////conta3.titular = cliente;
            //conta3.conta = "22515215-x";
            //conta3.numero_agencia = 35;
            //conta3.nome_agencia = "Agencia central";

            //Console.WriteLine(conta3.titular.nome);

            //ContaCorrente conta4 = new ContaCorrente();
            ////conta4.SetSaldo(150);
            ////Console.WriteLine(conta4.GetSaldo());

            //conta4.Saldo = 2000;
            //Console.WriteLine(conta4.Saldo);

            Cliente sarah = new Cliente();

            ContaCorrente conta4 = new ContaCorrente();
            conta4.Saldo = 10000;
            conta4.Titular = sarah;
            Console.WriteLine(conta4.Saldo);


            Console.ReadKey();
        }
    }
}
