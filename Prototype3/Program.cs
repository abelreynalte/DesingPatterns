using System;
using System.Collections.Generic;

namespace Prototype3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Language> list = new List<Language>();
            list.Add(new Language("C++"));
            list.Add(new Language("JAVA"));

            List<Language> shallow = (List<Language>)list;

            //System.out.println("shallow: " + list.equals(shallow));
            Console.WriteLine("shallow: " + list.Equals(shallow));

            for (int i = 0; i < list.Count; i++)
            {
                //System.out.println(" * shallow: " + list.get(i).equals(shallow.get(i))); //true
                Console.WriteLine(" * shallow: " + list[i].Equals(shallow[i]));
            }

            List<Language> deep = new List<Language>();
            foreach (Language language in list)
            {
                deep.Add((Language)language.Clone());
            }

            //System.out.println("deep: " + list.Equals(deep));
            Console.WriteLine("deep: " + list.Equals(deep));

            for (int i = 0; i < list.Count; i++)
            {
                //System.out.println(" * deep: " + list.get(i).equals(deep.get(i))); //false
                Console.WriteLine(" * deep: " + list[i].Equals(deep[i]));
            }

            list[0].name = "PYTHON";
            //System.out.println("Shallow [0]: " + shallow.get(0).getName());
            Console.WriteLine("Shallow [0]: " + shallow[0].getName());
            //System.out.println("Shallow [1]: " + shallow.get(1).getName());
            Console.WriteLine("Shallow [1]: " + shallow[1].getName());
            //System.out.println("Deep: [0]" + deep.get(0).getName());
            Console.WriteLine("Deep: [0]" + deep[0].getName());
            //System.out.println("Deep: [1]" + deep.get(1).getName());
            Console.WriteLine("Deep: [1]" + deep[1].getName());
            Console.ReadKey();
        }
    }
}
