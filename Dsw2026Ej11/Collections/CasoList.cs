using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    public List<Alumno> Alumnos { get; }
    public CasoList()
    {
        Alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        Alumnos.Add(alumno);
    }
    public List<Alumno> RetornarLista()
    {
        return Alumnos;
    }

    internal Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        foreach (Alumno alumno in Alumnos)
        {
            if (alumno.Nombre == nombre)
            {
                return alumno;
            }
            else return null;
            
        }
        return null;
        
    }

    public void eliminarAlumno(Alumno alumno)
    {
       Alumnos.Remove(alumno);
    }

    public void eliminarAlumno(int posicion)
    {
        if (posicion >= 0 && posicion < Alumnos.Count)
        {
            Alumnos.RemoveAt(posicion);
        }
    }
}
