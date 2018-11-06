using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public class LoggerFactory
    {
        public Boolean isFileLoggingEnabled()
        {
            //Properties p = new Properties();
            try
            {
                //p.load(ClassLoader.getSystemResourceAsStream("Logger.properties"));
                String fileLoggingValue = "ON";//p.getProperty("FileLogging");
                if (fileLoggingValue.Equals("ON") == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Factory Method
        public Logger getLogger()
        {
            if (isFileLoggingEnabled())
            {
                return new FileLogger();
            }
            else
            {
                return new ConsoleLogger();
            }
        }
    }
}
