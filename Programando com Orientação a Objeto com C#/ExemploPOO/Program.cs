using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        { 
            // valores positivos validos
            //Retangulo r = new Retangulo();
            //r.DefinirMedida(30,30);
            //Console.WriteLine($"Area: {r.ObterArea()}");
             // valores negativo invalidos
             //Retangulo r1 = new Retangulo();
            //r1.DefinirMedida(-30,30);
            //Console.WriteLine($"Area: {r1.ObterArea()}");
           Aluno a1 = new Aluno();
           a1.Nome = "José";
           a1.Idade = 20;
           a1.Apresentar();
           
        }
    }
}
