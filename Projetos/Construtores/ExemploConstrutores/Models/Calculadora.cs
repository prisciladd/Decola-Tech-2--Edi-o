namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar (int x, int y)
        {   
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"O resultado da adição é: {x+y}");
                EventoCalculadora();    //EventoCalculadora executa os métodos que se inscreveram
            }
            else
            {
                System.Console.WriteLine("Nenhum Inscrito!");
            }
            
        }

        public static void Subtrair (int x, int y)
        {
            System.Console.WriteLine($"O resultado da subtração é: {x-y}");
        }
    }
}