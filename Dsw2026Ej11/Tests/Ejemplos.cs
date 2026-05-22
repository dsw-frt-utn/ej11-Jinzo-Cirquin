using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Diagnostics.CodeAnalysis;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList Alumnos = new CasoList();

        Alumno alumno1 = new Alumno(1234, "Juan", 3.2);
        Alumno alumno2 = new Alumno(5678, "María", 6.8);
        Alumno alumno3 = new Alumno(9012, "Pedro", 8.5);

        Console.WriteLine("Alumnos antes de eliminar a María:");

        Alumnos.AgregarAlumno(alumno1);
        Alumnos.AgregarAlumno(alumno2);
        Alumnos.AgregarAlumno(alumno3);

        foreach (Alumno alumno in Alumnos.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Alumnos.eliminarAlumno(alumno2);

        Console.WriteLine("Alumnos después de eliminar a María:");

        foreach (Alumno alumno in Alumnos.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Alumnos.eliminarAlumno(0);

        Console.WriteLine("Alumnos después de eliminar el primer elemento:");

        foreach (Alumno alumno in Alumnos.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }


    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        List<Alumno> alumnos = new List<Alumno>
        {
            new Alumno(1234, "Juan", 3.2),
            new Alumno(5678, "María", 6.8),
            new Alumno(9012, "Pedro", 8.5)
        };

        CasoDictionary dicAlumnos = new CasoDictionary();

        foreach (Alumno alumno in alumnos)
        {
            dicAlumnos.AgregarAlumno(alumno);
        }

        foreach (KeyValuePair<int, string> elemento in dicAlumnos.RetornarDiccionario())
        {
            Console.WriteLine($"Clave: {elemento.Key}, Valor: {elemento.Value}");
        }

        KeyValuePair<int, string>? alumnoEncontrado = dicAlumnos.BuscarAlumno(9012);

        if (alumnoEncontrado != null)
        {
            int id = alumnoEncontrado.Value.Key;
            string nombre = alumnoEncontrado.Value.Value;
            Console.WriteLine($"Alumno encontrado: ID: {id}, Nombre: {nombre}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        dicAlumnos.EliminarAlumno(9012);

        foreach (KeyValuePair<int, string> elemento in dicAlumnos.RetornarDiccionario())
        {
            Console.WriteLine($"Clave: {elemento.Key}, Valor: {elemento.Value}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq libros = new CasoLinq(Libro.CrearLista());
        
        Libro primerLibro = libros.GetPrimero();

        Console.WriteLine($"Primer libro:ID {primerLibro.Id} - Titulo: {primerLibro.Titulo} - Precio: {primerLibro.Precio}" );

        Libro ultimoLibro = libros.GetUltimo(); 

        Console.WriteLine($"Último libro:ID {ultimoLibro.Id} - Titulo: {ultimoLibro.Titulo} - Precio: {ultimoLibro.Precio}" );

        Console.WriteLine($"Total de precios: {libros.GetTotalPrecios()}");

        Console.WriteLine($"Promedio de precios: {libros.GetPromedioPrecios()}");

        Console.WriteLine($"Libros con ID > {15}:");
        foreach (Libro libro in libros.GetListByID(15))
        {
            Console.WriteLine($"Id {libro.Id} - Titulo: {libro.Titulo} - Precio: {libro.Precio}");
        }

        Console.WriteLine("Libros con Titulo y precio:");
        foreach (string elemento in libros.GetLibros())
        {
            Console.WriteLine(elemento);
        }
        
        Libro libroMasCaro = libros.GetMayorPrecio();
        Console.WriteLine($"Libro con el precio más alto: Id{libroMasCaro.Id} - Titulo: {libroMasCaro.Titulo} - Precio: {libroMasCaro.Precio}");
        
        Libro libroMasBarato = libros.GetMenorPrecio();
        Console.WriteLine($"Libro con el precio más bajo: Id{libroMasBarato.Id} - Titulo: {libroMasBarato.Titulo} - Precio: {libroMasBarato.Precio}");

        Console.WriteLine("Libros con precio mayor al promedio:");
        foreach (Libro libro in libros.GetMayorPromedio())
        {
            Console.WriteLine($"Id{libro.Id} - Titulo: {libro.Titulo} - Precio: {libro.Precio}");
        }

        Console.WriteLine("Libros ordenados por título de forma descendente:");
        foreach (Libro libro in libros.GetLibrosOrdenados())
        {
            Console.WriteLine($"Id: {libro.Id} - Titulo: {libro.Titulo} - Precio: {libro.Precio}");
        } 


    }
}
