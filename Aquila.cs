using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("Mammiferi di taglia piccola");
        }

        public override void Verso()
        {
            Console.WriteLine("Verso Aquila");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando");
        }
    }
}
