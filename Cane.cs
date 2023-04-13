using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale, INuotante
    {
        public override void Mangia()
        {
            Console.WriteLine("Cibo per cani");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando");
        }
    }
}
