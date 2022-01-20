using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao (int x,int y);
        static void Main(string[] args)
        {  
            Matematica mat = new Matematica(10,20);
            mat.Somar();

            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(10,10);   //invoke chama os métodos, neste caso o Somar e o Subtrair
            

            // Operacao op2 = Calculadora.Subtrair;
            // op2(10,10);

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Data m3 = new Data();
            // m3.Mes = 20;
            // m3.ApresentarMes();

            // Data m1 = new Data();
            // m1.SetMes(2);
            // m1.ApresentarMes();

            // Data m2 = new Data();
            // m2.SetMes(13);
            // m2.ApresentarMes();

            // Aluno a1 = new Aluno("Priscila", "Da Dalt", ".Net");
            // a1.Apresentar();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste de Instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);


            // Pessoa p1 = new Pessoa("Priscila","Da Dalt");
            // p1.Apresentar();

        }
    }
    
}
