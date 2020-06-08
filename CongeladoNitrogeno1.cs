using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaAgroalimentaria
{
    class CongeladoNitrogeno1 : ProductoCongelado
    {
        public string MetodoCongelacion { get; set; }
        public string TiempoExposicion { get; set; }


        public override string ToString()
        {
            return
                 $"Producto congelado con Nitrogeno" + System.Environment.NewLine +
                System.Environment.NewLine +
                $"Numero de lote: {Nolote}" + System.Environment.NewLine +
                $"Fecha de caducidad:{FechaCaducidad}" + System.Environment.NewLine +
                $"Fecha de evansado :{FechaEnvasado}" + System.Environment.NewLine +
                $"Pais de origen: { PaisOrigen} " + System.Environment.NewLine +
                $"Metodo de congelación: {MetodoCongelacion}" + System.Environment.NewLine +
                $"Tiempo de exposición: {TiempoExposicion} " + System.Environment.NewLine;
        }
    }
}
