namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar() //se selar o metodo na classe mãe não consegue sobrescrever
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, sou diretor e recebo {salario}");
        }
    }
}