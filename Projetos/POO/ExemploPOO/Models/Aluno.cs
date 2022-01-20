namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, sou aluno nota {nota}");
        }
    }
}