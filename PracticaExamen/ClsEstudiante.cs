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
        static int cantidad = 1;
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

         static int buscar()
        {
            Console.WriteLine("Digite la Cedula");
            string cedula = Console.ReadLine();
            bool encontrado = false;
            int indiceEncontrado = -1;
            for (int i = 0; i < cantidad; i++)
            {
                if (cedula.Equals(cedulas[i]))
                {
                    indiceEncontrado = i;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontraron resultados para {cedula}");
            }

            return indiceEncontrado;
        }

        public static void consultar()
        {
            int indice = buscar();

            if(indice >= 0)
            {
                Console.WriteLine($"Nombre: {nombres[indice]}");
                Console.WriteLine($"Cedula: {cedulas[indice]}");
                Console.WriteLine($"Nota: {notas[indice]}");
            }
        }

        public static void modificar() {
            int indice = buscar();

            if (indice >= 0) 
            {
                Console.WriteLine($"Nombre Actual: {nombres[indice]}");
                Console.Write("Digite Nuevo nombre");
                nombres[indice] = Console.ReadLine();
                Console.WriteLine($"Nota Actual: {notas[indice]}");
                Console.Write("Digite nueva nota");
                int.TryParse(Console.ReadLine(), out notas[indice]);
            }
        }

        public static void eliminar()
        {
            int indice = buscar();
            string[] newNombres = new string[cantidad];
            string[] newCedulas = new string[cantidad];
            int[] newNotas = new int[cantidad];

            newCedulas = Enumerable.Repeat(string.Empty, cantidad).ToArray();
            newNombres = Enumerable.Repeat(string.Empty, cantidad).ToArray();
            newNotas = Enumerable.Repeat(0, cantidad).ToArray();

            if (indice >= 0 )
            {
                for(int i = 0; i < cedulas.Length;  i++) 
                {
                    if(cedulas[i] != cedulas[indice])
                    {
                        newNombres[i] = nombres[i];
                        newCedulas[i] = cedulas[i];
                        newNotas[i] = notas[i];
                    }
                }

                nombres = newNombres;
                cedulas = newCedulas;
                notas = newNotas;
            }
        }

        public static void reportePorCondicion(string condicion)
        {
            switch (condicion)
            {
                case "aprobado":
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] > 70)
                        {
                            Console.WriteLine($"Cedula: {cedulas[i]}, Nombre: {nombres[i]}, Nota: {notas[i]}");
                         }
                    }
                    break;
                    
                case "aplazado":
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] < 70 && notas[i] >= 60)
                        {
                            Console.WriteLine($"Cedula: {cedulas[i]}, Nombre: {nombres[i]}, Nota: {notas[i]}");
                        }
                    }
                    break;
                case "reprobado":
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] < 60)
                        {
                            Console.WriteLine($"Cedula: {cedulas[i]}, Nombre: {nombres[i]}, Nota: {notas[i]}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("No existe la condicion");
                    break;
            }
        }

        public static void reportarTodos()
        {
            for (int i = 0;i < notas.Length;i++)
            {
                Console.WriteLine("======================================================================================================");
                Console.WriteLine($"Cedula: {cedulas[i]} Nombres: {nombres[i]} Promedio: {notas[i]} Condicion: {condicion(notas[i])}");
            }

            Console.WriteLine("======================================================================================================");

        }

        public static string condicion(int nota)
        {
            string condicion = "Reprobado";

            if(nota >= 70)
            {
                condicion = "Aprobado";
            }else if (nota >= 60)
            {
                condicion = "Aplazado";
            }

            return condicion;
        }
    }
}
