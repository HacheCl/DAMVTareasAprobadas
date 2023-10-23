using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListaTareas
{
    List<Tarea> Tareas { get; set; }


    public ListaTareas()
    {
        Tareas = new List<Tarea>();
    }

    public void AgregarTarea(string descripcion, int año, int mes,int dia)
    {
        Tarea tarea = new Tarea(descripcion, año, mes, dia);
        Tareas.Add(tarea);
    }

    public void ListarTareas()
    {
        foreach (Tarea tarea in Tareas)
        {
            Console.WriteLine(Tareas.IndexOf(tarea) + ". " + tarea.ToString());
        }
    }
    public void ListarTareasIncompletas()
    {
        foreach (Tarea tarea in Tareas)
        {
            if (!tarea.EstaCompletada())
            {
                Console.WriteLine(Tareas.IndexOf(tarea) + ". " + tarea.ToString());
            }
        }
    }
    public void ListarTareasPorFecha()
    {
        Tareas.Sort((x, y) => DateTime.Compare(x.getFecha(), y.getFecha()));
        foreach (Tarea tarea in Tareas)
        {
            Console.WriteLine(Tareas.IndexOf(tarea) + ". " + tarea.ToString());
        }
    }
    public void MarcarTareaComoCompletada(int indice)
    {
        Tareas[indice].MarcarComoCompletada();
    }
    
}
