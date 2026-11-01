using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeriaAlvarado_ProyBiblioEsc
{
    // Clase que representa un libro dentro de la biblioteca
    public class Titulo
    {
        public string Titulo_de_Libro { get; set; }
        public string Cod_ISBN { get; set; }
        public int[] Copias_Fisicas { get; set; }
        public int Prestamos { get; set; }

        public Titulo(string nombre, string isbn, int cantidadCopias, int prestamosIniciales)
        {
            Titulo_de_Libro = nombre;
            Cod_ISBN = isbn;
            Prestamos = prestamosIniciales;

            Copias_Fisicas = new int[cantidadCopias];
            for (int i = 0; i < cantidadCopias; i++)
            {
                Copias_Fisicas[i] = 1; // 1 representa copia disponible
            }
        }

        // Cuenta cuántas copias están disponibles (valor 1)
        public int CopiasDisponibles()
        {
            int disponibles = 0;
            foreach (var cop in Copias_Fisicas)
            {
                if (cop == 1) disponibles++;
            }
            return disponibles;
        }

        // Cambia la primera copia disponible (1) a prestada (0)
        public bool PrestarCopia()
        {
            for (int i = 0; i < Copias_Fisicas.Length; i++)
            {
                if (Copias_Fisicas[i] == 1)
                {
                    Copias_Fisicas[i] = 0; // 0 representa copia prestada
                    Prestamos++;
                    return true;
                }
            }
            return false;
        }

        // Cambia la primera copia prestada (0) a disponible (1)
        public bool DevolverCopia()
        {
            for (int i = 0; i < Copias_Fisicas.Length; i++)
            {
                if (Copias_Fisicas[i] == 0)
                {
                    Copias_Fisicas[i] = 1; // Vuelve a estar disponible
                    return true;
                }
            }
            return false;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Libro: {Titulo_de_Libro}");
            Console.WriteLine($"ISBN: {Cod_ISBN}");
            Console.WriteLine($"Copias Totales: {Copias_Fisicas.Length} | Disponibles: {CopiasDisponibles()}");
            Console.WriteLine($"Préstamos Acumulados: {Prestamos}");
            Console.WriteLine(new string('-', 45));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Titulo> miBiblioteca = new List<Titulo>();

            // Carga inicial de libros
            miBiblioteca.Add(new Titulo("La ultima nota", "1280307471234", 4, 12));
            miBiblioteca.Add(new Titulo("Etéreo", "1280156012345", 7, 25));
            miBiblioteca.Add(new Titulo("El viaje de Darcy", "1286075263456", 9, 8));
            miBiblioteca.Add(new Titulo("La quimica del Amor", "1286071504567", 3, 15));
            miBiblioteca.Add(new Titulo("Perfectos Mentirosos", "1288420415678", 2, 5));
            miBiblioteca.Add(new Titulo("Fleur:Mi desesperada Desición", "1288497596789", 6, 18));
            miBiblioteca.Add(new Titulo("Antes de Diciembre", "1286073228912", 8, 9));
            miBiblioteca.Add(new Titulo("Boulevard", "1289682522341", 4, 11));

            bool menuActivo = true;

            while (menuActivo)
            {
                Console.Clear();
                Console.WriteLine("=== GESTIÓN DE BIBLIOTECA ESCOLAR - DÍA 4 ===");
                Console.WriteLine("1. Ver catálogo completo");
                Console.WriteLine("2. Buscar libro por título o ISBN");
                Console.WriteLine("3. Registrar Préstamo de libro");
                Console.WriteLine("4. Registrar Devolución de libro");
                Console.WriteLine("5. Salir");
                Console.Write("\nEscoja una de las opciones: ");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== Catálogo completo de libros ===\n");
                        foreach (var libro in miBiblioteca)
                        {
                            libro.MostrarDetalle();
                        }
                        PausarPantalla();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("=== Búsqueda de títulos ===\n");
                        Console.Write("Escriba el título o ISBN del libro que desee: ");
                        string terminoBusqueda = Console.ReadLine().Trim().ToLower();

                        bool encontrado = false;
                        Console.WriteLine("\n--- Resultados encontrados ---");
                        foreach (var libro in miBiblioteca)
                        {
                            if (libro.Titulo_de_Libro.ToLower().Contains(terminoBusqueda) || libro.Cod_ISBN.Contains(terminoBusqueda))
                            {
                                libro.MostrarDetalle();
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No encontramos ningún libro que coincida con los datos ingresados.");
                        }
                        PausarPantalla();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== REGISTRAR PRÉSTAMO ===\n");
                        Console.Write("Ingrese el ISBN o Título del libro a prestar: ");
                        string busquedaPrestamo = Console.ReadLine().Trim().ToLower();

                        Titulo libroPrestamo = miBiblioteca.FirstOrDefault(l => l.Titulo_de_Libro.ToLower().Contains(busquedaPrestamo) || l.Cod_ISBN.Contains(busquedaPrestamo));

                        if (libroPrestamo != null)
                        {
                            if (libroPrestamo.PrestarCopia())
                            {
                                Console.WriteLine($"\n¡Préstamo exitoso del libro '{libroPrestamo.Titulo_de_Libro}'!");
                            }
                            else
                            {
                                Console.WriteLine("\nLo sentimos, no hay copias disponibles de este libro.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nLibro no encontrado.");
                        }
                        PausarPantalla();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("=== REGISTRAR DEVOLUCIÓN ===\n");
                        Console.Write("Ingrese el ISBN o Título del libro a devolver: ");
                        string busquedaDevolucion = Console.ReadLine().Trim().ToLower();

                        Titulo libroDevolucion = miBiblioteca.FirstOrDefault(l => l.Titulo_de_Libro.ToLower().Contains(busquedaDevolucion) || l.Cod_ISBN.Contains(busquedaDevolucion));

                        if (libroDevolucion != null)
                        {
                            if (libroDevolucion.DevolverCopia())
                            {
                                Console.WriteLine($"\n¡Devolución exitosa del libro '{libroDevolucion.Titulo_de_Libro}'!");
                            }
                            else
                            {
                                Console.WriteLine("\nTodas las copias de este libro ya están en la biblioteca.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nLibro no encontrado.");
                        }
                        PausarPantalla();
                        break;

                    case "5":
                        menuActivo = false;
                        Console.WriteLine("\n¡Saliendo del sistema!");
                        break;

                    default:
                        Console.WriteLine("\nLa opción no es válida. Vuélvalo a intentar.");
                        PausarPantalla();
                        break;
                }
            }
        }

        static void PausarPantalla()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
