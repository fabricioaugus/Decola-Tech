using System;

namespace Dio.Serie
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();
           while(opcaoUsuario.ToUpper()=! "X"){
               switch(opcaoUsuario){
                   case "1":
                   ListarSeries();
                   break;
                   case "2":
                   InserirSeries();
                   break;
                   case "3":
                   AtualizarSeries();
                   break;
                   case "4":
                   ExcluirSeries();
                   break;
                   case "5":
                   VisualizarSeries();
                   break;
                   case "C":
                   Console.Clear();
                   break;
                   
                   default:
                    throw new ArgumentOutOfRangeException();
                    
               }


            opcaoUsuario = ObterOpcaoUsuario();
           }
           System.Console.WriteLine("OBRIGAD POR UTILIZAR NOSSO SERVICO !!!");
            Console.ReadLine();
        }


        private static void ListarSeries(){
            Console.WriteLine("listar Serie");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada. ");
                return;
            }
            foreach(var serie in lista){
                System.Console.WriteLine("#ID {0} : -{1}", serie.retornoId(),serie.retornoTitulo());
            }
        }

        private static void  InserirSeries(){
            System.Console.WriteLine("Inserir nova Série: ");
            foreach(int i in Enum.GetValues(typeof(Genero))){
                System.Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));
            }
            System.Console.WriteLine("Digite o gênero entre a opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

          Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
        }

        private static string ObterOpcaoUsuario(){
            System.Console.WriteLine();
            System.Console.WriteLine("Series ao seu Dispor !!! ");
            System.Console.WriteLine("Informe a sua Opção desejas: ");
            System.Console.WriteLine("1 - Listar Séries");
            System.Console.WriteLine("2 - Inserir nova Série");
            System.Console.WriteLine("3 - Atualizar Série");
            System.Console.WriteLine("4 - Excluir Série");
            System.Console.WriteLine("5 - Visualizar Série");
            System.Console.WriteLine("C -  Limpar Tela");
            System.Console.WriteLine("X - Sair");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
