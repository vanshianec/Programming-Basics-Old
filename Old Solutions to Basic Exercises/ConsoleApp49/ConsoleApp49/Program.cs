using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, List<Evolution>> dict = new Dictionary<string, List<Evolution>>();

            while (input[0] != "wubbalubbadubdub")
            {
                
                string pokemonName = input[0];
                if(input.Length==1&&dict.ContainsKey(input[0]))
                {
                    Console.WriteLine($"# {pokemonName}");
                    foreach (var item in dict[pokemonName])
                    {
                        Console.WriteLine($"{item.evolutionType} <-> {item.evolutionIndex}");
                    }
                }
                else
                {
                    Evolution ev = new Evolution();
                    string evolutionType = input[1];
                    int evolutionIndex = int.Parse(input[2]);
                   
                    ev.evolutionType = evolutionType;
                    ev.evolutionIndex = evolutionIndex;
                if (dict.ContainsKey(pokemonName))
                {
                    dict[pokemonName].Add(ev);


                }
                else
                {
                    dict.Add(pokemonName, new List<Evolution>());
                    dict[pokemonName].Add(ev);
                }

                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var pokemon in dict)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evolution in pokemon.Value.OrderByDescending(x=> x.evolutionIndex))
                {
                    Console.WriteLine($"{evolution.evolutionType} <-> {evolution.evolutionIndex}");
                }
            }
            }





        }
    }
public class Evolution
{
    public string evolutionType { get; set; }
    public int evolutionIndex { get; set; }

}



