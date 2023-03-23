using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }

    public class Cane : Animale 
    { 
        public override void Verso()
        {
            Console.WriteLine("Bau bau");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia carne");
        }
    }

    public class Passerotto : Animale 
    {
        public override void Verso()
        {
            Console.WriteLine("Pio pio");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia erba");
        }
    }

    public class Aquila : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("AAAAAAH");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia vermi");
        }
    }

    public class Delfino : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Fischio");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia pesci");
        }
    }

}
