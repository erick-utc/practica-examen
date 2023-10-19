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
                Console.WriteLine("1 - Inicializar Vectores");
                Console.WriteLine("2 - Incluir Estudiantes");
                Console.WriteLine("3 - Consultar Estudiante");
                Console.WriteLine("4 - Modificar Esutdiante");
                Console.WriteLine("5 - Eliminar Estudiante");
                Console.WriteLine("6 - Reportes");
                Console.WriteLine("7 - Salir");
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
                        ClsEstudiante.consultar();
                        break;
                    case 4:
                        ClsEstudiante.modificar();
                        break;
                    case 5:
                        ClsEstudiante.eliminar();
                        break;
                    case 6:
                        submenu();
                        break;
                    case 7: break;
                    default: break;
                }
            } while (opcion!=7);

            
        }

        public static void submenu()
        {
            do
            {
                Console.WriteLine("1 - Reporte estudiantes por condicion");
                Console.WriteLine("2 - Reporte general");
                Console.WriteLine("3 - Salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        submenuCondicion();
                        break;
                    case 2:
                        ClsEstudiante.reportarTodos();
                        break;
                    case 3:
                        break;
                    default: break;
                }
            } while (opcion != 3);
        }

        public static void submenuCondicion()
        {
            Console.Clear();
            Console.WriteLine("1 - Aprobado");
            Console.WriteLine("2 - Reprobado");
            Console.WriteLine("3 - Aplazado");
            int.TryParse(Console.ReadLine(), out opcion);

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Aprobados");
                    ClsEstudiante.reportePorCondicion("aprobado");
                    break;
                case 2:
                    Console.WriteLine("Reprobados");
                    ClsEstudiante.reportePorCondicion("reprobado");
                    break;
                case 3:
                    Console.WriteLine("Aplazados");
                    ClsEstudiante.reportePorCondicion("aplazado");
                    break;
                default : break;
            }
           
        }
    }
}
