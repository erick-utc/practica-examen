using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen
{
    internal class ClsEstudiante
    {
        //atributos
        static int cantidad = 10;
        static public string[] cedulas = new string[cantidad];
        static public string[] nombres = new string[cantidad];
        static public int[] notas = new int[cantidad];

        //metodos
        static public void inicializar()
        {
            cedulas = Enumerable.Repeat(string.Empty, cantidad).ToArray();
            nombres = Enumerable.Repeat(string.Empty, cantidad).ToArray();
            notas = Enumerable.Repeat(0, cantidad).ToArray();

            //foreach (var nota in notas) { 
            //    Console.WriteLine(nota);
            //}
            //for (int i = 0; i < cantidad; i++)
            //{
            //    cedula[i] = string.Empty;
            //    nombre[i] = string.Empty;
            //    nota[i] = 0;
            //}

            Console.WriteLine("Valores inicializados");
        }

        public static void agregar()
        {
               for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                Console.Write("Digite la cedula {0}: ", i+1);
                cedulas[i] = Console.ReadLine();
                Console.Write("Digite el nombre {0}: ", i+1);
                nombres[i] = Console.ReadLine();
                Console.Write("Digite la nota {0}: ", i+1);
                int.TryParse(Console.ReadLine(), out notas[i]);
            }
        }

        public static void consultar()
        {
            Console.WriteLine("Digite la Cedular");
            string cedula = Console.ReadLine();
            bool encontrado = false;
            for(int i = 0;i < cantidad; i++)
            {
                if (cedula.Equals(cedulas[i]))
                {
                    Console.WriteLine($"Nombre: {nombres[i]}");
                    Console.WriteLine($"Cedula: {cedulas[i]}");
                    Console.WriteLine($"Nota: {notas[i]}");
                    encontrado = true;
                    break;
                }
            }

            if ( !encontrado )
            {
                Console.WriteLine($"No se encontraron resultados para {cedula}");
            }
        }
    }
}
