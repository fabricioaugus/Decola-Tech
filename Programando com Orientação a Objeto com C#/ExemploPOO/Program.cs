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
           
           // ALUNO 
            Aluno a1 = new Aluno();
            a1.Nome = "José";
            a1.Idade = 20;
            a1.Nota = 10;
            a1.Apresentar();

            // PROFESSOR
            Professor p1= new Professor();
            p1.Nome = "Marcos";
            p1.Idade = 20;
            p1.salario = 1100.23;
            p1.Apresentar();

           
        }
    }
}
