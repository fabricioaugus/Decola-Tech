namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Diretor");
        }
    }
}