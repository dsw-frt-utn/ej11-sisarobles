using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

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
        //Agregar 3 alumnos a la lista
        Alumno alumno1 = new Alumno(123, "Carlos Robles", 7.88);
        Alumno alumno2 = new Alumno(456, "Verónica Páez", 9.82);
        Alumno alumno3 = new Alumno(789, "Elba Aguilar", 8.50);

        CasoList casoListaAlumnos = new CasoList();

        casoListaAlumnos.AgregarAlumno(alumno1);
        casoListaAlumnos.AgregarAlumno(alumno2);
        casoListaAlumnos.AgregarAlumno(alumno3);

        //Listar por consola los alumnos
        Console.WriteLine("\n=== LISTA LUEGO DE LOS ALUMNOS AGREGADOS ===\n");
        foreach (Alumno alu in casoListaAlumnos.RetornoLista())
        {
            Console.WriteLine(alu.ToString());
        }

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\n=== BÚSQUEDA DE ALUMNO (Elba Aguilar) ===\n");
        Console.WriteLine($"ALUMNO ENCONTRADO: {casoListaAlumnos.BuscarAlumno("Elba Aguilar").Nombre}");

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\n=== BÚSQUEDA DE ALUMNO NO EXISTENTE (Sisa Robles) ===\n");
        Alumno alumni = casoListaAlumnos.BuscarAlumno("Sisa Robles");
        if (alumni == null)
        {
            Console.WriteLine("El alumno ingresado no existe");
        } else
        {
            Console.WriteLine($"ALUMNO ENCONTRADO: {casoListaAlumnos.BuscarAlumno("Sisa Robles").Nombre}");
        }

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\n=== LISTA LUEGO DE LOS ALUMNOS PRIMERA ELIMINACIÓN (Veronica Páez) ===");
        casoListaAlumnos.EliminarAlumno(alumno2);
        foreach (var alu in casoListaAlumnos.RetornoLista())
        {
            Console.WriteLine(alu.ToString());
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\n=== LISTA LUEGO DE LOS ALUMNOS SEGUNDA ELIMINACIÓN (Posición 0) ===");
        casoListaAlumnos.EliminarAlumnoPorPosicion(0);
        foreach (var alu in casoListaAlumnos.RetornoLista())
        {
            Console.WriteLine(alu.ToString());
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Alumno alumno1 = new Alumno(123, "Carlos Robles", 7.88);
        Alumno alumno2 = new Alumno(456, "Verónica Páez", 9.82);
        Alumno alumno3 = new Alumno(789, "Elba Aguilar", 8.50);

        CasoDictionary casoDiccionarioAlumnos = new CasoDictionary();

        //Agregar 3 alumnos al diccionario
        casoDiccionarioAlumnos.AgregarAlumno(alumno1);
        casoDiccionarioAlumnos.AgregarAlumno(alumno2);
        casoDiccionarioAlumnos.AgregarAlumno(alumno3);

        //Listar por consola los alumnos
        Console.WriteLine("\n=== LISTA LUEGO DE LOS ALUMNOS AGREGADOS ===\n");
        foreach (Alumno alu in casoDiccionarioAlumnos.RetornoDiccionario().Values)
        {
            Console.WriteLine(alu.ToString());
        }

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\n=== BÚSQUEDA DE ALUMNO (Elba Aguilar) ===\n");
        Alumno? alumBuscado = casoDiccionarioAlumnos.BuscarAlumno(789);
        Console.WriteLine($"El alumno de legajo {alumBuscado?.Id} fue encontrado: Nombre: {alumBuscado?.Nombre} | Promedio {alumBuscado?.Promedio}.");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\n=== BÚSQUEDA DE ALUMNO NO EXISTENTE (Sisa Robles) ===\n");
        Alumno? alumnoBuscado1 = casoDiccionarioAlumnos.BuscarAlumno(111);
        if (alumnoBuscado1 == null)
        {
            Console.WriteLine("El alumno ingresado no existe");
        } else
        {
            Console.WriteLine($"ALUMNO ENCONTRADO: {alumnoBuscado1}");
        }

        //Eliminar un alumno por clave y listar por consola los alumnos

        casoDiccionarioAlumnos.EliminarAlumno(456);
        Console.WriteLine("\n=== LISTA LUEGO DE LOS ALUMNOS ELIMINACIÓN ===");
        foreach (Alumno alu in casoDiccionarioAlumnos.RetornoDiccionario().Values)
        {
            Console.WriteLine(alu.ToString());
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoListaLibros = new CasoLinq();

        //1
        Libro? primerLibro = casoListaLibros.GetPrimero();
        Console.WriteLine($"El primer libro registrado es: {primerLibro?.Titulo} | Id: {primerLibro?.Id}\n");

        //2
        Libro? ultimoLibro = casoListaLibros.GetUltimo();
        Console.WriteLine($"El último libro registrado es: {ultimoLibro?.Titulo} | Id: {ultimoLibro?.Id}\n");

        //3
        decimal total = casoListaLibros.GetTotalPrecios();
        Console.WriteLine($"El total de los precios de los libros es de {total:C}\n");

        //4
        decimal promedio = casoListaLibros.GetPromedioPrecios();
        Console.WriteLine($"El promedio de los precios de los libros es de {promedio:C}\n");

        //5
        List<Libro>? listabyId = casoListaLibros.GetListById();
        Console.WriteLine("\n=== LISTA DE LIBROS CON Id MAYOR A 15 ===\n");
        foreach (Libro libro in listabyId)
        {
            Console.WriteLine(libro.ToString());
        }

        Console.WriteLine("\n");

        //6
        List<string> lista = casoListaLibros.GetLibros();
        Console.WriteLine("\n=== LISTA DE LIBROS CON TITULO Y PRECIO ===\n");
        foreach (string libro in lista)
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n");

        //7
        Libro? libroCaro = casoListaLibros.GetMayorPrecio();
        Console.WriteLine($"El libro de mayor precio es: : {libroCaro?.Titulo} | Id: {libroCaro?.Id}\n");

        //8
        Libro? libroBarato = casoListaLibros.GetMenorPrecio();
        Console.WriteLine($"El libro de menor precio es: : {libroBarato?.Titulo} | Id: {libroBarato?.Id}\n");

        //9
        List<Libro> listaMayorProm = casoListaLibros.GetMayorPromedio();
        Console.WriteLine("\n=== LISTA DE LIBROS CON UN PRECIO MAYOR AL PROMEDIO ===\n");
        foreach (Libro libro in listaMayorProm)
        {
            Console.WriteLine(libro.ToString());
        }

        //10
        List<Libro> listaOrdenDescendente = casoListaLibros.LibrosOrdenDescendente();
        Console.WriteLine("\n=== LISTA DE LIBROS EN ORDEN DESCENDENTE SEGÚN SU TÍTULO ===\n");
        foreach (Libro libro in listaOrdenDescendente)
        {
            Console.WriteLine(libro.ToString());
        }

    }
}
