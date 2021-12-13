namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;
        public void DefinirMedida(double comprimento,double largura ){

            if(comprimento>0 && largura>0){
                this.comprimento= comprimento;
                this.largura = largura; 
                valido = true;
                }
                else{

                    System.Console.WriteLine("Valores digitado é inválido !!");
                }
        }

        public double ObterArea(){
            if(valido){
                 return comprimento * largura;
            }else{
                System.Console.WriteLine("Preencher valores válidos !!!!!");
                return 0;
            }
           

        }

    }
}