using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class FechaLA: FechaGenerica
    {
        public override String obtenerFecha()
        {
            DateTime cal = new DateTime();
            int anio = cal.Year;
            int mes = cal.Month + 1;
            int dia = cal.Day;

            return (anio + "/" + mes + "/" + dia);

        }
    }
}
