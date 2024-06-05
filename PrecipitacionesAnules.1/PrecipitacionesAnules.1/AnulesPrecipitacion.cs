using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecipitacionesAnules._1
{
    internal class AnulesPrecipitacion
    {
        public class Mes
        {
            public int Numero { get; set; }
            public string Nombre { get; set; }

            public Mes(int numero, string nombre)
            {
                Numero = numero;
                Nombre = nombre;
            }
        }

        public class Precipitacion
        {
            public Mes Mes { get; set; }
            public double Valor { get; set; }

            public Precipitacion(Mes mes, double valor)
            {
                Mes = mes;
                Valor = valor;
            }
        }

        public class ListaDePrecipitaciones
        {
            public int Año { get; set; }
            public List<Precipitacion> Precipitaciones { get; set; }

            public ListaDePrecipitaciones(int año)
            {
                Año = año;
                Precipitaciones = new List<Precipitacion>();
            }

            public void AgregarPrecipitacion(Precipitacion precipitacion)
            {
                Precipitaciones.Add(precipitacion);
            }

            public double CalcularPromedioAnual()
            {
                double suma = 0;
                foreach (var precipitacion in Precipitaciones)
                {
                    suma += precipitacion.Valor;
                }
                return suma / Precipitaciones.Count;
            }

            public void MostrarVariaciones(double promedioAnual)
            {
                Console.WriteLine($"Precipitación promedio anual: {promedioAnual:F2} mm.");
                Console.WriteLine("Mes\tPromedio\tVariación");
                foreach (var precipitacion in Precipitaciones)
                {
                    double variacion = Math.Abs(precipitacion.Valor - promedioAnual);
                    Console.WriteLine($"{precipitacion.Mes.Nombre}\t{precipitacion.Valor:F2}\t{variacion:F2}");
                }
            }
        }
    }
}
