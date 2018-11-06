using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class FechaEEUU: FechaGenerica
    {
        public override String obtenerFecha()
        {
            DateTime cal = new DateTime();
            int anio = cal.Year;
            int mes = cal.Month + 1;
            int dia = cal.Day;

            return (mes + "/" + dia + "/" + anio);
        }
    }
}
