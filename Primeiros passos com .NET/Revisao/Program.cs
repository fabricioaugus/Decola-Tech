using System;

namespace Revisao
{
    class Program
    {

        static void Main(string [] agrs)
        {

            Aluno[] alunos = new Aluno[5];
            var IndiceAluno = 0;
            string opcaoUsuario =OpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe nome do Aluno: ");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                         Console.WriteLine("Informe nota do Aluno: ");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                           aluno.Nota = nota;
                        }else{

                            throw new ArgumentException("Valor da nota e decimal");
                        }
                        alunos[IndiceAluno] = aluno;
                        IndiceAluno++;
                        break;
                    case "2":
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"ALUNO : {a.Nome}   NOTA: {a.Nota}");
                                Console.WriteLine();
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0 ;
                        var nrAlunos = 0; 
                        for(int i=0 ; i<alunos.Length; i++){
                             if(!string.IsNullOrEmpty(alunos[i].Nome)){
                            notaTotal= notaTotal + alunos[i].Nota; 
                            nrAlunos++; 
                            }

                        }

                        var mediaGeral =  notaTotal/nrAlunos;
                        Econceito conceitoGeral;
                        if(mediaGeral < 2){
                            conceitoGeral = Econceito.E;

                        }
                        else if(mediaGeral < 4){
                            conceitoGeral = Econceito.D;
                        }
                        else if(mediaGeral < 6){
                            conceitoGeral = Econceito.C;
                        }
                        else if(mediaGeral < 8){
                            conceitoGeral = Econceito.B;
                        }
                        else{
                           conceitoGeral = Econceito.A; 
                        }
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} CONCEITO GERAL: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
            
             opcaoUsuario = OpcaoUsuario();
            }
        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir aluno: ");
            Console.WriteLine("2 - Listar alunos: ");
            Console.WriteLine("3 - Calcular a média geral: ");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            var opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}


