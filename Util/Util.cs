using System;
using System.IO;
using System.Reflection;

namespace Util
{
    public class Util
    {
        public static String getPropertyValue(String configPropertiesName, String propertyKey)
        {
            String value = "";
            try
            {
                //Properties properties = new Properties();                
                //properties.load(ClassLoader.getSystemResourceAsStream(configPropertiesName));
                //value = properties.getProperty(propertyKey);

                PropertyInfo property = configPropertiesName.GetType().GetProperty(propertyKey);
                value = Convert.ToString(property.GetValue(configPropertiesName));                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return value;
        }
    }
}
