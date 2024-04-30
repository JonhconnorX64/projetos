using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana
{
    public enum Semana
    {
        segunda = 1,
        terca = 2,
        quarta = 3,
        uinta =4,
        sexta = 5,
        sabado = 6,
        domindo = 7,
    }
    internal class Program
    {
        static void Main()
        {
            Semana sem2 = Semana.terca;
            int i2 = (int)Semana.terca;

            System.Console.WriteLine(sem2);
            System.Console.WriteLine(i2);
            Console.Write("Precione a tecla 'Q' para a proxima!");
            Console.ReadKey();
         
            Semana sem4 = Semana.uinta;
            int i4 = (int)Semana.uinta;

            System.Console.WriteLine(sem4);
            System.Console.WriteLine(i4);
            Console.Write("Precione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}
