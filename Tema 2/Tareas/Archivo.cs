using System;
using System.Text.Json;

public class Archivo
{
    public static void GuardarTareas(ListaTareas lista, string ruta)
    {
       string json = JsonSerializer.Serialize(lista);
       System.IO.File.WriteAllText(ruta, json);


    }
    public static ListaTareas CargarTareas(ListaTareas lista, string ruta)
    {
        ListaTareas? json = JsonSerializer.Deserialize<ListaTareas>(System.IO.File.ReadAllText(ruta));
        return json;
    }

}
