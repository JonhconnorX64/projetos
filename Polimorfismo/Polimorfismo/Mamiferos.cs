using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Mamiferos(string tipoAnimal) : Animal(tipoAnimal)
    {
        public override void Caracteristicas()
        {
            Console.WriteLine("Bebem leite!");
        }
    }
}
