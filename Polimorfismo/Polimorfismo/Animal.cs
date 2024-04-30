using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Animal(string tipoAnimal)
    {
        private string tipo = tipoAnimal;
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }

        public virtual void Caracteristicas()
        {

        }
    }
}
