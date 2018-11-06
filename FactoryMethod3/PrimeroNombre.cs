using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class PrimeroNombre: ValidaNombre
    {
        public PrimeroNombre(String nombreCompleto) : base(nombreCompleto)
        {
            //super(nombreCompleto);

            int i = nombreCompleto.IndexOf(" ");

            nombre = nombreCompleto.Substring(0, i);
            apellido = nombreCompleto.Substring(i + 1);
        }

        public override String obtenerApellido()
        {
            return apellido;
        }

        public override String obtenerNombre()
        {
            return nombre;
        }
    }
}
