using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisasGodTierSPlus
{
    public class Moneda
    {
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public Moneda(string nombre, double valor)
        {
            Nombre = nombre;
            Valor = valor;
        }


        public override string? ToString()
        {
            return Nombre;
        }
        
    }
}
