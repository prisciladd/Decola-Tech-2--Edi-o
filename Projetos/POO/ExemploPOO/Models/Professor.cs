namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }

        public override void Apresentar() //se acrescenntar sealed não pode fazer herança na classe Diretor
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, sou professor e recebo {salario}");
        }
    }
}