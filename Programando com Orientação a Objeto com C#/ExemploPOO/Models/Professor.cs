using System;
namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario{ get;set;}

        public override void Apresentar()
        {
            Console.WriteLine($"ola, meu nome é {Nome}, e ganho R$: {salario} salario");
        }
    }
}