using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animaux = new List<Animaux>();

            animaux.Add(new Lama { Espece = "Lama", Habitat = "Montagnes", RegimeAlimentaire = "Herbivore" });
            animaux.Add(new Rhinoceros { Espece = "Rhinocéros", Habitat = "Savanes", RegimeAlimentaire = "Herbivore" });
            animaux.Add(new Yack { Espece = "Yack", Habitat = "Plateaux désertiques", RegimeAlimentaire = "Herbivore" });

            PrintAnimals(animaux);

            Console.ReadKey();
        }

        private static void PrintAnimals(IEnumerable<Animaux> animaux)
        {
            foreach (Animaux animal in animaux)
            {
                Console.WriteLine("Voici un {0}, son habitat est : {1}, son régime alimentaire est : {2}, il se trouve dans la zone {3} du zoo.", animal.Espece, animal.Habitat, animal.RegimeAlimentaire, animal.ZoneZoo());
            }
        }
    }
}
