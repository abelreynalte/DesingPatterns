using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class FechasFactory
    {
        public FechaGenerica obtenerFecha()
        {

            ConfiguracionRegional config = ConfiguracionRegional.getInstancia();

            if (config.getRegion().Equals(ConfiguracionRegional.REGION_EEUU))
            {
                return new FechaEEUU();
            }
            else if (config.getRegion().Equals(ConfiguracionRegional.REGION_EUR))
            {
                return new FechaEUR();
            }
            else
            {
                return new FechaLA();
            }
        }
    }
}
