using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    class Yack : Animaux
    {
        public string Espece { get; set; }
        public string Habitat { get; set; }
        public string RegimeAlimentaire { get; set; }
        public string ZoneZoo()
        {
            return "Asie";
        }
    }
}
