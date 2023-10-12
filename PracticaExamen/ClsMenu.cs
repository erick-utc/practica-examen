using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen
{
    internal class ClsMenu
    {
        static int opcion = 0;

        public static void desplegar()
        {
            do
            {
                Console.WriteLine("1 - Inicializar");
                Console.WriteLine("2 - Incluir Estudiantes");
                Console.WriteLine("3 - Reportes");
                Console.WriteLine("4 - Salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        ClsEstudiante.inicializar();
                        break;
                    case 2:
                        ClsEstudiante.agregar();
                        break;
                    case 3:
                        submenu();
                        break;
                    case 4: break;
                    default: break;
                }
            } while (opcion!=4);

            
        }

        public static void submenu()
        {
            do
            {
                Console.WriteLine("1 - Reporte estudiante por condicion");
                Console.WriteLine("2 - Reporte general");
                Console.WriteLine("3 - Salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Reporte 1");
                        break;
                    case 2:
                        Console.WriteLine("Reporte 2");
                        break;
                    case 3:
                        break;
                    default: break;
                }
            } while (opcion != 3);
        }
    }
}
