using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class PrimeroApellido: ValidaNombre
    {
        public PrimeroApellido(String nombreCompleto) : base(nombreCompleto)
        {
            //super(nombreCompleto);

            int i = nombreCompleto.IndexOf(",");

            apellido = nombreCompleto.Substring(0, i);
            nombre = nombreCompleto.Substring(i + 1);
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
