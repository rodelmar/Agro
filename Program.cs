using System;
using System.Net.Http.Headers;

namespace EmpresaAgroalimentaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CongeladosAire producto = new CongeladosAire();
            producto.Nolote = "10";
            producto.FechaCaducidad = "10-11-2020";
            producto.FechaEnvasado = "23-02-2020";
            producto.PaisOrigen = "Mexico";
            producto.TemperaturaRecomendada = "-10";
            producto.PorcentajeNitrogeno = "10";
            producto.PorcentajeOxigeno = "2";
            producto.PorcentajeCO = "24";
            producto.PorcentajeVapor = "-1";

            Console.WriteLine(producto);



            CongeladoAgua producto2 = new CongeladoAgua();
            producto2.Nolote = "11";
            producto2.FechaCaducidad = "08-08-2021";
            producto2.FechaEnvasado = "09-01-2020";
            producto2.PaisOrigen = "Alemania";
            producto2.TemperaturaRecomendada = "-115";
            producto2.SalinidadAgua = "XY";
          

            Console.WriteLine(producto2);


            CongeladoNitrogeno1 producto3 = new CongeladoNitrogeno1();
            producto3.Nolote = "12";
            producto3.FechaCaducidad = "11-11-2030";
            producto3.FechaEnvasado = "17-08-2021";
            producto3.PaisOrigen = "Rusia";
            producto3.TemperaturaRecomendada = "180 grados";
            producto3.MetodoCongelacion = "Ultra";
            producto3.TiempoExposicion = "3 horas";

            Console.WriteLine(producto3);


        }
    }
}
