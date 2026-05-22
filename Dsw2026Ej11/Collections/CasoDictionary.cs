using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, string> dicAlumnos;

    public CasoDictionary()
    {
        dicAlumnos = new Dictionary<int, string>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        dicAlumnos.Add(alumno.Id, alumno.Nombre);
    }

    public KeyValuePair<int, string>? BuscarAlumno(int id)
    {      

        if (dicAlumnos.ContainsKey(id))
        {
            KeyValuePair<int, string> alumno = new KeyValuePair<int, string>(id, dicAlumnos[id]);
            return alumno;
        }
        return null;
    }

    public Dictionary<int, string> RetornarDiccionario()
    {
        return dicAlumnos;
    }

    public void EliminarAlumno(int id)
    {
        dicAlumnos.Remove(id);
    }
}
