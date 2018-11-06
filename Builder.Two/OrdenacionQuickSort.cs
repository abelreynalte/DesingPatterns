using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Builder.Two
{
    public class OrdenacionQuickSort: OrdenacionBuilder
    {
        String[] datos = null;

        public override List<String> ordenar(String[] datos)
        {

            this.datos = datos;
            quickSort(0, datos.Length - 1);
            List<String> resp = new List<String>();
            for (int i = 0; i < datos.Length; i++)
            {
                resp.Add(datos[i]);
            }
            return resp;
        }

        public void quickSort(int izq, int der)
        {
            String pivot;
            int sizq, sder;
            int ieq;
            String tmpVal;

            if (izq >= der)
            {
                return;
            }

            pivot = datos[(izq + der) / 2];

            ieq = sizq = izq;
            sder = der;

            while (sizq <= sder)
            {
                if (datos[sder].CompareTo(pivot) > 0)
                {
                    sder--;
                }
                else
                {
                    tmpVal = datos[sizq];
                    datos[sizq] = datos[sder];
                    datos[sder] = tmpVal;
                    if (datos[sizq].CompareTo(pivot) < 0)
                    {
                        tmpVal = datos[ieq];
                        datos[ieq] = datos[sizq];
                        datos[sizq] = tmpVal;
                        ieq++;
                    }
                    sizq++;
                }
            }
            quickSort(izq, ieq - 1);
            quickSort(sder + 1, der);
        }
    }
}
