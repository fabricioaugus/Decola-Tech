using System;
using Primeiro;
using Segundo;
using FundamentoCsharp;
using Enum;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var estacao = (Estacao)0;


            Pessoa person = new Pessoa();
            
            person.Nome = "Ronaldinho ";
            person.Sobrenome = "Gaúcho"; 
            person.Idade = 40;

            Pessoa person2 = new Pessoa();
            
            person2.Nome = "Ronaldinho 2";
            person2.Sobrenome = "Gaúcho2";
            person2.Idade = 41;


            Animal animal = new Animal();
            animal.Nome = "REX";
            animal.Dono = "Pedro";
            animal.Raca = "Pastor Alemao";

            var classe = new IntroducaoCsarp();
            var classe2 = new IntroducaoCsarp2();

            Console.WriteLine(person.Nome + person.Sobrenome);
        }
    }
}
