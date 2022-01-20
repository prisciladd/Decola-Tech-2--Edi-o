namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = default!;
        public int Idade { get; set; }
        public int documento { get; set; }
        
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}