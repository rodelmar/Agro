using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaAgroalimentaria
{
   public class ProductoCongelado : Productos
    {

       
        public string FechaEnvasado { get; set; }
        public string PaisOrigen { get; set; }
        public string TemperaturaRecomendada { get; set; }

        public override string ToString()
        {
            return $"Numero de lote: {Nolote}, Fecha de caducidad{FechaCaducidad}, Fecha de evansado { FechaEnvasado} " +
                $",Pais de origen: { PaisOrigen} Temperatura recomendada{TemperaturaRecomendada},";

        }

    }



}
