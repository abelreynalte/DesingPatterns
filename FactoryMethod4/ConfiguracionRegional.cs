using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class ConfiguracionRegional
    {
        private static ConfiguracionRegional unicaInstancia = null;
        public static String REGION_EEUU = "EEUU";
        public static String REGION_LA = "LA";
        public static String REGION_EUR = "EUR";
    
        private String region = null;

        public String getRegion()
        {
            return region;
        }

        public void setRegion(String region)
        {
            this.region = region;
        }

        public static ConfiguracionRegional getInstancia()
        {
            if (unicaInstancia != null)
            {
                return unicaInstancia;
            }
            lock (typeof(ConfiguracionRegional))
            {
                if (unicaInstancia == null)
                {
                    unicaInstancia = new ConfiguracionRegional();
                }
            }
            return unicaInstancia;            
        }
    }
}
