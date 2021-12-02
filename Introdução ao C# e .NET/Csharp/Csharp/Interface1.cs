using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentoCsharp
{
    interface Ianimal
    {

        void Nome(String nome);
        void Dono(String nomeDono);
        void Raca(String raca);

    }



    class Animal : Ianimal {
        public String Nome { get; set; }
        public String Dono { get; set; }
        public String Raca { get; set; }
        
        void Ianimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void Ianimal.Dono(string dono)
        {
            this.Dono = dono;
        }

        void Ianimal.Raca(string raca)
        {
            this.Raca = raca;
        }

    }


   
}


