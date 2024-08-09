using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico.Classes;

namespace zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZoologicoClass zoologico = new ZoologicoClass();

            while (true) 
            {
                Console.WriteLine($"selecione a Opçao: ");
                Console.WriteLine($"1. add mamifero ");
                Console.WriteLine($"2. add ave ");
                Console.WriteLine($"3. add reptil ");
                Console.WriteLine($"4. add tratador mamifero ");
                Console.WriteLine($"5. add tratador ave ");
                Console.WriteLine($"6. listar tratadores ");
                Console.WriteLine($"7. listar animais ");
                Console.WriteLine($"8. alimentar animais");
                Console.WriteLine($"9. cuidar animais");
                Console.WriteLine($"10. sair ");

                string opcao = Console.ReadLine();

                if ( opcao == "10" ) { break; }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"digite o nome do mamifero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine($"digite a idade do mamifero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"digite o tipo do pelo: ");
                        string tipoDePelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoDePelo);

                        zoologico.AdicionarAnimal( mamifero );
                        break;

                    case "2": 
                        Console.WriteLine($"digite o nome da ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine($"digite a idade da ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine($"digite a envergadura da asa: ");
                        double envergaduraDaAsa = double.Parse(Console.ReadLine());

                        Ave ave = new Ave(nomeAve, idadeAve, envergaduraDaAsa);

                        zoologico.AdicionarAnimal(ave);
                        break;

                    case "3":
                        Console.WriteLine($"digite o nome do reptil: ");
                        string nomeReptil = Console.ReadLine();

                        Console.WriteLine($"digite a idade da ave: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine($"digite a envergadura da asa: ");
                        string tipoEscama =Console.ReadLine();

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoEscama);

                        zoologico.AdicionarAnimal(reptil);
                        break;

                    case "4":
                        Console.WriteLine($"digite o nome do tratador: ");
                        string nomeTratadorMamifero = Console.ReadLine();

                        Console.WriteLine($"digite a especialidade do tratador: ");
                        string especialidadeTratadorMamifero =Console.ReadLine();

                        TratadorMamiferos tratadorMamifero = new TratadorMamiferos(nomeTratadorMamifero, especialidadeTratadorMamifero);
                        zoologico.AddTratadores(tratadorMamifero);
                        break;

                    case "5":
                        Console.WriteLine($"digite o nome do tratador: ");
                        string nomeTratadorAve = Console.ReadLine();

                        Console.WriteLine($"digite a especialidade do tratador: ");
                        string especialidadeTratadorAve = Console.ReadLine();

                        TratadorAves tratadorAves = new TratadorAves(nomeTratadorAve, especialidadeTratadorAve);
                        zoologico.AddTratadores(tratadorAves);
                        break;

                    case "6":
                        Console.WriteLine($"os tratadores do zoologico são: ");
                        zoologico.ListarTratadores();
                        break;

                    case "7":
                        Console.WriteLine($"os animais do zoologico são: ");
                        zoologico.ListarAnimais();
                        break;

                    case "8":
                        zoologico.AlimentarAnimais();
                        break;

                    case "9":
                        zoologico.Cuidar();
                        break;
                }
            }
        }
    }
}
