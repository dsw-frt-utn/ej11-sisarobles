using Dsw2026Ej11.Domain;
using System.Linq;
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
    List<Libro> listaLibros = Libro.CrearLista();

    //1. Obtener el primer libro (GetPrimero)  
    public Libro? GetPrimero()
    {
        return listaLibros.FirstOrDefault();
    }

    //2. Obtener el último libro (GetUltimo)
    public Libro? GetUltimo()
    {
        return listaLibros.LastOrDefault();
    }

    //3. Obtener la suma de precios (GetTotalPrecios)
    public decimal GetTotalPrecios()
    {
        IEnumerable<decimal> preciosSuma = listaLibros.Select(libro => libro.Precio);
        return preciosSuma.Sum();
    }

    //4. Obtener el promedio de precios (GetPromedioPrecios)
    public decimal GetPromedioPrecios()
    {
        IEnumerable<decimal> precios = listaLibros.Select(libro => libro.Precio);
        return precios.Average();
    }

    //5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro>? GetListById()
    {
        IEnumerable<Libro> libros = listaLibros.Where(libro => libro.Id > 15);
        return libros.ToList(); //obligo a que se haga lista
    }

    //6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        IEnumerable<string> libros = listaLibros.Select(libro => $" - {libro.Titulo} | {libro.Precio:C}"); 
        return libros.ToList();
    }

    //7. Obtener el libro con el precio más alto(GetMayorPrecio)
    public Libro? GetMayorPrecio()
    {
        decimal precioMax = listaLibros.Max(libro => libro.Precio);
        IEnumerable<Libro> libro = listaLibros.Where(libro => libro.Precio == precioMax);
        return libro.FirstOrDefault();
    }

    //8. Obtener el libro con el precio más bajo(GetMenorPrecio)
    public Libro? GetMenorPrecio()
    {
        decimal precioMin = listaLibros.Min(libro => libro.Precio);
        IEnumerable<Libro> libro = listaLibros.Where(libro => libro.Precio == precioMin);
        return libro.FirstOrDefault();
    }

    //9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = listaLibros.Average(prom => prom.Precio);
        IEnumerable<Libro> librosMayorProm = listaLibros.Where(libro => libro.Precio > promedio);
        return librosMayorProm.ToList();
    }

    //10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> LibrosOrdenDescendente()
    {
        IEnumerable<Libro> librosOrdenados = listaLibros.OrderByDescending(libro => libro.Titulo);
        return librosOrdenados.ToList();
    }

}
