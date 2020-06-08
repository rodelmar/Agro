using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaAgroalimentaria
{
    class CongeladoAgua : ProductoCongelado
    { 

        public string SalinidadAgua { get; set; }


        public override string ToString()
        {
            return
               $"Producto congelado con agua" + System.Environment.NewLine +
               System.Environment.NewLine +
               $"Numero de lote: {Nolote}" + System.Environment.NewLine +
               $"Fecha de caducidad:{FechaCaducidad}" + System.Environment.NewLine +
               $"Fecha de evansado :{FechaEnvasado}" + System.Environment.NewLine +
               $"Pais de origen: { PaisOrigen} " + System.Environment.NewLine +
               $"Temperatura recomendada: {TemperaturaRecomendada}" + System.Environment.NewLine +
               $"Salinidad del agua: {SalinidadAgua}" + System.Environment.NewLine 

               ;

        }


    }
}
