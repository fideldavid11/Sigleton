using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDisenio
{
    class Singleton { 

        //primera regla el constructir debe ser private
        private Singleton() { 
    
          }
      
        //crear una variable de instancia
        private static Singleton _creaObjeto;


        //metodo publico de accso
        public static Singleton obtenerObjeto()
        {
            //validando si existe un objeto en memoria
            if (_creaObjeto == null)
            {
                _creaObjeto = new Singleton();

            }
            return _creaObjeto;
        }

        public void calcularFactorial()
        {
            Console.WriteLine("\nEstoy calculando el factorial tio NADA PERSONAL\n");
        }

        public void calcularBMI()
        {
            Console.WriteLine("\nEstoy calculando el indice de masa corporal NADA PERSONAL\n");
        }

    }
}
