using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    interface Animaux
    {
        string Espece { get; set; }
        string Habitat { get; set; }
        string RegimeAlimentaire { get; set; }
        string ZoneZoo();
    }
}
