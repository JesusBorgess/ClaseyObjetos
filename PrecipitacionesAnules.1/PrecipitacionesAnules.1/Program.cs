using static PrecipitacionesAnules._1.AnulesPrecipitacion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el año:");
        int año = int.Parse(Console.ReadLine());

        ListaDePrecipitaciones listaDePrecipitaciones = new ListaDePrecipitaciones(año);

        Console.WriteLine("Ingrese las precipitaciones promedio mensuales:");
        for (int mes = 1; mes <= 12; mes++)
        {
            Console.WriteLine($"Mes {mes}:");
            double valor = double.Parse(Console.ReadLine());

            Mes mesObj = new Mes(mes, GetMesNombre(mes));
            Precipitacion precipitacion = new Precipitacion(mesObj, valor);
            listaDePrecipitaciones.AgregarPrecipitacion(precipitacion);
        }

        double promedioAnual = listaDePrecipitaciones.CalcularPromedioAnual();
        listaDePrecipitaciones.MostrarVariaciones(promedioAnual);

        Console.ReadKey();
    }

    static string GetMesNombre(int mes)
    {
        switch (mes)
        {
            case 1: return "Enero";
            case 2: return "Febrero";
            case 3: return "Marzo";
            case 4: return "Abril";
            case 5: return "Mayo";
            case 6: return "Junio";
            case 7: return "Julio";
            case 8: return "Agosto";
            case 9: return "Septiembre";
            case 10: return "Octubre";
            case 11: return "Noviembre";
            case 12: return "Diciembre";
            default: return "";
        }
    }
}
