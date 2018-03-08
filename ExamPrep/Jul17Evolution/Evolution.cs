using System;
using System.Collections.Generic;
using System.Linq;

namespace Jul17Evolution
{
    class Evolution
    {
        static void Main(string[] args)
        {
            //var pokePattern = @"([^- >]+) -> ([^- >]+) -> (\d+)";
            var pokemonList = new List<Pokemon>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input== "wubbalubbadubdub")
                {
                    break;
                }

                var splittedInput = input
                    .Split(new char[] { ' ', '>', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (splittedInput.Count==1)
                {
                    var nameToDisplay = splittedInput[0];

                    foreach (var pokemon in pokemonList)
                    {
                        //dslpay given pokemon
                        if (pokemon.Name==nameToDisplay)
                        {
                            Console.WriteLine($"# {nameToDisplay}");                            
                            foreach (var evolutions in pokemon.Evolutions)
                            {
                                Console.WriteLine($"{evolutions.EvolutioType} <-> {evolutions.EvolutionIndex}");
                            }
                            break;
                        }
                    }
                }
                else
                {
                    //creat or add pokemon
                    //check same name same evolution and strength
                    string name = splittedInput[0];
                    string evolutionType = splittedInput[1];
                    int evolutionIndex = int.Parse(splittedInput[2]);

                    var pokeEvolutionWasAdded = false;
                    foreach (var pokemon in pokemonList)
                    {
                        if (pokemon.Name==name)
                        {
                            pokemon.Evolutions.Add(new PokeEvolution(evolutionType,evolutionIndex));
                            pokeEvolutionWasAdded = true;
                        }
                    }
                    if (!pokeEvolutionWasAdded)
                    {
                        //creat new Pokemon
                        pokemonList.Add(new Pokemon(name, evolutionType, evolutionIndex));
                    }

                }

            }

            //print result
            foreach (var pokemon in pokemonList)
            {             
                
                Console.WriteLine($"# {pokemon.Name}");
                var sortedEvolution = pokemon.Evolutions
                    .OrderByDescending(x => x.EvolutionIndex);

                foreach (var evolutions in sortedEvolution)
                {
                    Console.WriteLine($"{evolutions.EvolutioType} <-> {evolutions.EvolutionIndex}");
                }
                                
            }
        }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public List<PokeEvolution> Evolutions { get; set; }

        public Pokemon(string name, string evoType, int evoIndex)
        {
            this.Name = name;
            this.Evolutions = new List<PokeEvolution>() { new PokeEvolution(evoType, evoIndex) };            
        }
    }

    public class PokeEvolution
    {
        public string EvolutioType { get; set; }
        public int EvolutionIndex { get; set; }

        public PokeEvolution(string type, int index)
        {
            this.EvolutioType = type;
            this.EvolutionIndex = index;
        }
    }
}
