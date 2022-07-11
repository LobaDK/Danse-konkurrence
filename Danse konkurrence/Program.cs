using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danse_konkurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string danser1, danser2; //opret 2 string variabler
                int danserpoint1, danserpoint2; //opret 2 int variabler

                Console.Write("Skriv danser 1's navn: ");
                danser1 = Console.ReadLine();
                Console.Write("\nSkriv danser 2's navn: ");
                danser2 = Console.ReadLine();
                do
                {
                    try 
                    {
                        Console.Write("\nSkriv danser 1's points: ");
                        danserpoint1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nSkriv danser 2's points: ");
                        danserpoint2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException) //catch hvis brugeren skriver andet end tal
                    {
                        Console.WriteLine("Points skal være i tal");
                        continue;
                    }
                    catch (Exception ex) //catch hvis det er en anden fejl
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                } while (true);
                DancerPoints dancer1 = new DancerPoints(danser1, danserpoint1); //opret instance af DancerPoints, der heder dancer1 og bruger danser1 og danserpoint1
                DancerPoints dancer2 = new DancerPoints(danser2, danserpoint2); //opret instance af DancerPoints, der heder dancer2 og bruger danser2 og danserpoint2
                DancerPoints dansertotal = dancer1 + dancer2;

                Console.WriteLine($"\n{dansertotal.navn}'s totale points er: {dansertotal.points}\n");
            } while (true);
            

        }
    }
}
