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
        public string  Titulo_de_Libro { get; set; }
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

        public void MostrarDetalle()
        {
            Console.WriteLine($"Libro: {Titulo_de_Libro} | ISBN: {Cod_ISBN} | Copias: {Copias_Fisicas.Length} | Prestamos: {Prestamos}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Titulo> miBiblioteca = new List<Titulo>();

            // Carga de los 8 libros iniciales de prueba (Dia 2)
            miBiblioteca.Add(new Titulo("La ultima nota", "1280307471234", 4, 12));
            miBiblioteca.Add(new Titulo("Etéreo", "1280156012345", 7, 25));
            miBiblioteca.Add(new Titulo("El viaje de Darcy", "1286075263456", 9, 8));
            miBiblioteca.Add(new Titulo("La quimica del Amor", "1286071504567", 3, 15));
            miBiblioteca.Add(new Titulo("Perfectos Mentirosos", "1288420415678", 2, 5));
            miBiblioteca.Add(new Titulo("Fleur:Mi desesperada Desición", "1288497596789", 6, 18));
            miBiblioteca.Add(new Titulo("Antes de Diciembre", "1286073228912", 8, 9));
            miBiblioteca.Add(new Titulo("Boulevard", "1289682522341", 4, 11));

            Console.WriteLine("=== Libros Biblioteca Escolar Cátalogo (DIA 2) ===");
            Console.WriteLine();

            foreach (var libro in miBiblioteca)
            {
                libro.MostrarDetalle();
            }

            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}

