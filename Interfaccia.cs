using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public interface IVolante
    {
        void Vola() => Console.WriteLine("ciao volante");
    }

    public interface INuotante
    {
        void Nuota() => Console.WriteLine("ciao nuotante");
    }
}
