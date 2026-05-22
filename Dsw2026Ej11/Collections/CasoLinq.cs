using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{

    List<Libro> listLibros= new List<Libro>() ;

    public CasoLinq(List<Libro> libros) 
    {
        listLibros = libros ;
    }

    public Libro GetPrimero() {

        return listLibros.First();

    }

    public Libro GetUltimo() { return listLibros.Last(); }

    public decimal GetTotalPrecios()
    {
        return listLibros.Select(Libro => Libro.Precio).Sum();
    }

    public decimal GetPromedioPrecios() 
    {
        return listLibros.Select(Libro => Libro.Precio).Average();
    }

    public List<Libro> GetListByID(int id) 
    {
        return listLibros.Where(Libro => Libro.Id >= id).ToList();
    }
        

    public List<string> GetLibros() 
    {
        return listLibros.Select(Libro => $"{Libro.Titulo} - {Libro.Precio:C}").ToList();

    }
    
    public Libro GetMayorPrecio()
    {
        return listLibros.OrderByDescending(Libro => Libro.Precio).First();
    }
    public Libro GetMenorPrecio()
    {
        return listLibros.OrderBy(Libro => Libro.Precio).First();
    }

    public List<Libro> GetMayorPromedio()
    { 
        return listLibros.Where(Libro => Libro.Precio > GetPromedioPrecios()).ToList();
    }

    public List<Libro> GetLibrosOrdenados()
    {
        return listLibros.OrderByDescending(Libro => Libro.Titulo).ToList();
    }
}
