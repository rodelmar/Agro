using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaAgroalimentaria
{
    class CongeladosAire : ProductoCongelado    
    {

        public string PorcentajeNitrogeno { get; set; }
        public string PorcentajeOxigeno { get; set; }
        public string PorcentajeCO { get; set; } // dioxido de carbono
        public string PorcentajeVapor { get; set; }


        public override string ToString()
        {
            return
                $"Producto congelado con Aire" + System.Environment.NewLine +
                System.Environment.NewLine +
                $"Numero de lote: {Nolote}" + System.Environment.NewLine +
                $"Fecha de caducidad:{FechaCaducidad}" + System.Environment.NewLine +
                $"Fecha de evansado :{FechaEnvasado}" + System.Environment.NewLine +
                $"Pais de origen: { PaisOrigen} " + System.Environment.NewLine +
                $"Temperatura recomendada{TemperaturaRecomendada}" + System.Environment.NewLine +
                $"Porcentaje de nigrogeno: % {PorcentajeNitrogeno} " + System.Environment.NewLine +
                $"Porcentaje de Oxigeno: %{PorcentajeOxigeno} " + System.Environment.NewLine +
                $"Porcentaje de CO2: % {PorcentajeCO}" + System.Environment.NewLine +
                $"Porcentaje de vapor: % { PorcentajeVapor}" + System.Environment.NewLine ;

        }   

    }
}
