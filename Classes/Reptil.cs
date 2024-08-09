using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico.Classes;

namespace zoologico
{
    public class Reptil : Animal 
    {
        public string TipoEscama { get; set; }

        public Reptil(string nome, int idade, string tipoEscama) : base(nome, idade)
        {
            TipoEscama = tipoEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"o {Nome} emite som de réptil");
        }

        public void Almentar()
        {
            Console.WriteLine($"o {Nome} está sendo alimentado");
        }
    }
}
