using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota{get;set;}

        public override void Apresentar()
        {
            Console.WriteLine($"ola, meu nome é {Nome}, sou um aluno nota: {Nota}");
        }
    }

}