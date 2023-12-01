using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Class2
    {
        public Class2() {
            Class1 archivo = new Class1(1, "asdasd");
            archivo.completada = true;
            archivo.id = 3;
            Console.WriteLine(archivo.id+" " + archivo.completada);
        }
        
    }
}
