using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {   
            Calculadora calc = new Calculadora();
            int a = calc.Somar(10,20);
            int b = calc.Dividir(20,20);
            int c = calc.Subtrair(20,10);
            int d = calc.Multiplicar(10,10);
            Console.WriteLine($" Dividir 20/20: {b} \nMultiplicação 10*10: {d} \nSomar 10+20: {a} \ndoSubtrair 20-10: {c}");

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
            // Calculadora class
            // Calculadora calculadora = new Calculadora(); 
            // Console.WriteLine($"Primeiro Somar: {calculadora.Somar(1,2)}");
            // Console.WriteLine($"Segundo Somar: {calculadora.Somar(1,2,6)}");
            // valores positivos validos
            //Retangulo r = new Retangulo();
            //r.DefinirMedida(30,30);
            //Console.WriteLine($"Area: {r.ObterArea()}");
             // valores negativo invalidos
             //Retangulo r1 = new Retangulo();
            //r1.DefinirMedida(-30,30);
            //Console.WriteLine($"Area: {r1.ObterArea()}");
           
           // ALUNO 
            // Aluno a1 = new Aluno();
            // a1.Nome = "José";
            // a1.Idade = 20;
            // a1.Nota = 10;
            // a1.Apresentar();

            // // PROFESSOR
            // Professor p1= new Professor();
            // p1.Nome = "Marcos";
            // p1.Idade = 20;
            // p1.salario = 1100.23;
            // p1.Apresentar();

           
        }
    }
}
