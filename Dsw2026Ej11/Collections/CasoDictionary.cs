using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        diccionarioAlumnos.Add(alumno.Id, alumno);
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno? BuscarAlumno (int id)
    {
        if (diccionarioAlumnos.TryGetValue(id, out Alumno? alumnoEncontrado))
        {
            return alumnoEncontrado;
        }

        //si  no lo encuentra retorna null.
        Console.WriteLine($"El alumno de legajo: {id}, no fue encontrado.");
        return null;
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> RetornoDiccionario()
    {
        return diccionarioAlumnos;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int id)
    {
        diccionarioAlumnos.Remove(id);
    }
}
