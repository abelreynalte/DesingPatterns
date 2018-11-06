using System;

namespace FactoryMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidaNombre validaNombre = NombreCompletoFactory.obtenerValidador("Juan Pérez");
            //System.out.println("Class Name: " + validaNombre.getClass().getSimpleName());
            Console.WriteLine("Class Name: " + validaNombre.GetType().Name);
            //System.out.println("Nombre: " + validaNombre.obtenerNombre());
            Console.WriteLine("Nombre: " + validaNombre.obtenerNombre());
            //System.out.println("Apellido: " + validaNombre.obtenerApellido());
            Console.WriteLine("Apellido: " + validaNombre.obtenerApellido());

            //System.out.println("***************************************************");
            Console.WriteLine("***************************************************");

            validaNombre = NombreCompletoFactory.obtenerValidador("Pérez, Juan");
            //System.out.println("Class Name: " + validaNombre.getClass().getSimpleName());
            Console.WriteLine("Class Name: " + validaNombre.GetType().Name);
            //System.out.println("Nombre: " + validaNombre.obtenerNombre());
            Console.WriteLine("Nombre: " + validaNombre.obtenerNombre());
            //System.out.println("Apellido: " + validaNombre.obtenerApellido());
            Console.WriteLine("Apellido: " + validaNombre.obtenerApellido());
            Console.ReadKey();
        }
    }
}
