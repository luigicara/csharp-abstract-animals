﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        public override void Mangia()
        {
            Console.WriteLine("Pesci piccoli");
        }

        public override void Verso()
        {
            Console.WriteLine("Verso Delfino");
        }
    }
}