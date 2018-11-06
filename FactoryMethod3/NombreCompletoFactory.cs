using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class NombreCompletoFactory
    {
        public NombreCompletoFactory()
        {
        }

        public static ValidaNombre obtenerValidador(String nombreCompleto)
        {
            int i = nombreCompleto.IndexOf(",");
            if (i > 0)
            {
                return (new PrimeroApellido(nombreCompleto));
            }
            else
            {
                return (new PrimeroNombre(nombreCompleto));
            }
        }
    }
}
