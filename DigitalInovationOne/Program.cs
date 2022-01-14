using System;
using DigitalInovationOne.exemplos;

//exemplo 1

int numeroDeVezes = 5;

for (int i=0;i<numeroDeVezes;i++){
    Console.WriteLine($"Bem vindo ao curso de .Net {i}");
}

//exemplo 2

namespace DigitalInovationOne.exemplos
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}