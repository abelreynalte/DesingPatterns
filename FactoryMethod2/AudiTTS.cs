using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod2
{
    public class AudiTTS: IAuto
    {        
        public String getName()
        {
            return "Audi TTS";
        }
        
        public void turnOn()
        {
            //System.out.println("The Audi TTS is running, but there is an electrical fire.");
            Console.WriteLine("The Audi TTS is running, but there is an electrical fire.");
        }
        
        public void turnOff()
        {
            //System.out.println("The Audi TTS is off, but the dashboard is still smoking.");
            Console.WriteLine("The Audi TTS is off, but the dashboard is still smoking.");
        }
    }
}
