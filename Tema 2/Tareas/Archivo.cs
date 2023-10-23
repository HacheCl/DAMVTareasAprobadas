using System;
using System.Text.Json;

public class Archivo
{
    public void GuardarTareas(ListaTareas lista, string ruta)
    {
       string json = JsonSerializer.Serialize(lista);
       System.IO.File.WriteAllText(ruta, json);


    }
    public void CargarTareas(ListaTareas lista, string ruta)
    {
       var json = JsonSerializer.Deserialize<ListaTareas>(System.IO.File.ReadAllText(ruta));

    }

}
