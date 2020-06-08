using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaAgroalimentaria
{
    class ProductoRefrigerado : Productos
    {
        public string CodigOrganismo { get; set; }

        public string FechaEnvasado { get; set; }

        public string TempRecomendada { get; set; }
        public string PaisOrigen { get; set; }



        public override string ToString()
        {
            return $"Numero de lote: {Nolote}, Fecha de caducidad{FechaCaducidad},Codigo de organismo{CodigOrganismo}" +
                $" ,Fecha de evansado { FechaEnvasado} , Temperatura recomendada {TempRecomendada}, Pais de origen {PaisOrigen},";

        }
    }

}
