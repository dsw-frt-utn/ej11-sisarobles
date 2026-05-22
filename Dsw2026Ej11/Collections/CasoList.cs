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
    //creación del campo listaAlumnos 
    List<Alumno> listaAlumnos { get; set; } = new List<Alumno>();

    //creación del método para agregar alumnos a la lista
    public void AgregarAlumno (Alumno alumno)
    {
        listaAlumnos.Add(alumno);
    }

    //creación del método para retornar lista
    public List<Alumno> RetornoLista()
    {
        return listaAlumnos;
    }

    //creación del método para encontrar un alumno por su nombre
    public Alumno BuscarAlumno (string nombre)
    {
        Alumno alumEncontrado = listaAlumnos.Find((Alumno a) => { return a.Nombre == nombre; });
        return alumEncontrado;
    }

    //creación del método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno (Alumno alumno)
    {
        listaAlumnos.Remove(alumno);
    }

    //creación del método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoPorPosicion(int i)
    {
        listaAlumnos.RemoveAt(i);
    }

}
