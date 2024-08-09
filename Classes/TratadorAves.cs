using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico.Classes;
using zoologico.Interfaces;

namespace zoologico
{
    public class TratadorAves : Tratador, ICuidavel
    {
        public TratadorAves(string nome, string especialidade) : base(nome, especialidade)
        {

        }

        public void Cuidar()
        {
            Console.WriteLine("o tratador esta cuidando do animal...");
        }
    }
}
