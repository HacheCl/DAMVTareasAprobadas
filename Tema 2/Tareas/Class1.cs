using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Class1
    {
        public int id;
        public string descripcion;
        public bool completada;
        public Class1(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.completada = false;
        }
    }
}