using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class Repteis(string tipoAnimal) : Animal(tipoAnimal)
    {
        public override void Caracteristicas()
        {
            Console.WriteLine("Troca pele!");
        }
    }
}
