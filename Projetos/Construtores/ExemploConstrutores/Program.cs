using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {  
            Data m3 = new Data();
            m3.Mes = 20;
            m3.ApresentarMes();

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
