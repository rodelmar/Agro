using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaAgroalimentaria
{
    public class Productos
    {

        public string Nolote { get; set; }
        public string FechaCaducidad { get; set; }

        public override string ToString()
        {
            return $"Lote: { Nolote}, Fecha: { FechaCaducidad}";
          
        }

    }
  

    }


