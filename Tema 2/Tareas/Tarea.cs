using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tarea
{
    public string Descripcion { get; set;}
    public DateTime FechaVencimiento { get; set; }
    public bool Completada { get; set; }
    public Tarea(string descripcion,int año, int mes, int dia)
    {
        this.Descripcion = descripcion;
        this.FechaVencimiento = new DateTime(año, mes, dia);
        Completada = false;
    }

    
    
    public bool EstaCompletada()
    {
        return Completada;
    }
    public DateTime getFecha()
    {
        return FechaVencimiento;
    }
    public void MarcarComoCompletada()
    {
        Completada = true;
    }

    public override string? ToString()
    {
        return "Descripcion: " + Descripcion + " Fecha: " + FechaVencimiento + " Completada: " + Completada;
    }
}
