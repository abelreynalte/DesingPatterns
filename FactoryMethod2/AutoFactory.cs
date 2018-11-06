using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FactoryMethod2
{
    public class AutoFactory
    {
        private static String NAME_PREFIX = "class";
        private Dictionary<String, Type> autos;

        public AutoFactory()
        {
            loadTypesICanReturn();
        }

        private void loadTypesICanReturn()
        {
            //autos = new HashMap<String, Type>();
            //Reflections reflections = new Reflections(this.getClass().getPackage().getName());
            //Set < Class <? extends IAuto >> classes = reflections.getSubTypesOf(IAuto.class);
            //for (Class<? extends IAuto> auto : classes) {
            // String key = auto.getSimpleName();
            //    autos.put(key, auto); //autos.put("BMW335Xi", com.unmsm.patterns.creational.factorymethod1.BMW335Xi)
            //}

        }

        public IAuto createInstance(String carName)
        {
            //Object object = null;
            //Class <?> genericsType = null;
            //Type type = getTypeToCreate(carName);
            //try
            //{
            //    String className = getClassName(type);
            //    genericsType = Class.forName(className);
            //    object = genericsType.newInstance();
            //}
            //catch (Exception ex)
            //{
            //}
            //return (IAuto)object;
            object @object = null;
            Type genericsType = null;
            Type type = getTypeToCreate(carName);
            try
            {
                string className = getClassName(type);
                genericsType = Type.GetType(className);
                @object = System.Activator.CreateInstance(genericsType);
            }
            catch (Exception)
            {
            }
            return (IAuto)@object;

        }

        public Type getTypeToCreate(String carName)
        {
            //for (Map.Entry<String, Type> entry : autos.entrySet())
            //{
            //    String key = entry.getKey();
            //    if (key.contains(carName))
            //    {
            //        Type type = autos.get(key);
            //        return type;
            //    }
            //}
            //return null;
            foreach (KeyValuePair<string, Type> entry in autos)
            {
                string key = entry.Key;
                if (key.Contains(carName))
                {
                    Type type = autos[key];
                    return type;
                }
            }
            return null;

        }

        private static String getClassName(Type type)
        {
            //String fullName = type.toString();
            //if (fullName.startsWith(NAME_PREFIX))
            //{
            //    return fullName.substring(NAME_PREFIX.length() + 1);
            //}
            //return fullName;
            string fullName = type.ToString();
            if (fullName.StartsWith(NAME_PREFIX, StringComparison.Ordinal))
            {
                return fullName.Substring(NAME_PREFIX.Length + 1);
            }
            return fullName;

        }
    }
}
