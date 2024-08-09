using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico.Interfaces;

namespace zoologico.Classes
{
    public class ZoologicoClass
    {
        private List<Animal> animais = new List<Animal>();
        private List<Tratador> tratadores = new List<Tratador>();

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
        }

        public void ListarAnimais()
        {
            if (animais.Count > 0)
            {
                Console.WriteLine("animais no zoologico: ");
                foreach (Animal animal in animais)
                {
                    animal.EmitirSom();
                    Console.WriteLine($"Nome {animal.Nome}, Idade: {animal.Idade}");
                }
            }
            else
            {
                Console.WriteLine("a lista esta vazia");
            }
        }

        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os animais...");
            foreach (Animal animal in animais) 
            {
                if (animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }

        public void Cuidar() 
        {
            Console.WriteLine("cuidando dos animais...");
            foreach(Animal animal in animais)
            {
                if(animal is ICuidavel cuidavel)
                {
                    cuidavel.Cuidar();
                }
            }
        }

        public void AddTratadores(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"{ tratador.Nome} foi adicionado");
        }

        public void ListarTratadores()
        {
            if (tratadores.Count > 0)
            {
                Console.WriteLine("tratadores no zoologico: ");
                foreach (Tratador tratador in tratadores)
                {
                    
                    Console.WriteLine($"Nome {tratador.Nome}, especialidade: {tratador.Especialidade}");
                }
            }
            else
            {
                Console.WriteLine("a lista esta vazia");
            }
        }

    }
}
