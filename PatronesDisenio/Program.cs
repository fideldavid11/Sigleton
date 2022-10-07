using System;

namespace PatronesDisenio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los patrones de Disenio");
            Singleton objeto1 = Singleton.obtenerObjeto();
            Singleton objeto2 = Singleton.obtenerObjeto();

            if (objeto1 == objeto2)
            {
                Console.WriteLine("Son iguales los objetos llamados\n");
            }
            else {
                Console.WriteLine("No Son iguales los objetos llamados");
            }

            objeto1.calcularFactorial();
            objeto2.calcularBMI();

            Console.WriteLine("\n**********************************************\n");
            BaseDatos db = BaseDatos.obtenerConexionDb();
            db.crearCliente();
            BaseDatos db1 = BaseDatos.obtenerConexionDb();
            db1.modificarCliente();
            db.eliminarCliente();
            if (db == db1) { Console.WriteLine("\nConectado con la misma instancia\n"); }
        }
    }
}
