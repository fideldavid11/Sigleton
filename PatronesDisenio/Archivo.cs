using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDisenio
{
    class Archivo
    {
        private Archivo() { }
        private static Archivo instanciaFile;

        public static Archivo obtenerArchivo()
        {
            if (instanciaFile == null)
            {
                instanciaFile = new Archivo();
            }
            return instanciaFile;

        }

        public void guardarEmpleado(Empleado p)
        {

        }

    }
}
