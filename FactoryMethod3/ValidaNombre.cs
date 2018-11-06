using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public abstract class ValidaNombre
    {
        public String nombreCompleto = null;
        public String apellido = null;
        public String nombre = null;

        public ValidaNombre(String nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }

        public abstract String obtenerNombre();
        public abstract String obtenerApellido();
    }
}
