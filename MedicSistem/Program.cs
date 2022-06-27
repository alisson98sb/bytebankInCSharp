using System;

namespace MedicSistem
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Alisson Santana Barbosa";
            pessoa1.idade = 24;
            pessoa1.peso = 86;
            pessoa1.altura = 1.80;

            Console.WriteLine(pessoa1.nome);
            Console.ReadKey();

        }
    }
}
