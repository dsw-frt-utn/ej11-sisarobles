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
    //1. Obtener el primer libro (GetPrimero)
    public Libro? GetPrimero(List<Libro> libros)
    {
        return (from l in libros select l).FirstOrDefault();
    }

    //2. Obtener el último libro (GetUltimo)
    public Libro? GetUltimo(List<Libro> libros)
    {
        return (from l in libros select l).LastOrDefault();
    }

    //3. Obtener la suma de precios (GetTotalPrecios)
    public decimal GetTotalPrecios(List<Libro> libros)
    {
        return (from l in libros select l.Precio).Sum();
    }

    //4. Obtener el promedio de precios (GetPromedioPrecios)
    public decimal GetPromedioPrecios(List<Libro> libros)
    {
        return (from l in libros select l.Precio).Average();
    }

    //5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro>? GetListById(List<Libro> libros)
    {
        var consulta = from l in libros where l.Id > 15 select l;
        return consulta.ToList(); //obligo a que se haga lista
    }

    //6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros(List<Libro> libros)
    {
        var consulta = from l in libros select $" - {l.Titulo} | {l.Precio:C}";
        return consulta.ToList();
    }

    //7. Obtener el libro con el precio más alto(GetMayorPrecio)
    public Libro? GetMayorPrecio(List<Libro> libros)
    {
        decimal precioMax = (from l in libros select l.Precio).Max();
        var consulta =  from l in libros where l.Precio == precioMax select l;
        return consulta.FirstOrDefault();
    }

    //8. Obtener el libro con el precio más bajo(GetMenorPrecio)
    public Libro? GetMenorPrecio(List<Libro> libros)
    {
        decimal precioMin = (from l in libros select l.Precio).Min();
        var consulta = from l in libros where l.Precio == precioMin select l;
        return consulta.FirstOrDefault();
    }

    //9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio(List<Libro> libros)
    {
        decimal promedio = (from l in libros select l.Precio).Average();
        var consulta = from l in libros where l.Precio > promedio select l;
        return consulta.ToList();
    }

    //10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> LibrosOrdenDescendente(List<Libro> libros)
    {
        var consulta = from l in libros orderby l.Titulo descending select l;
        return consulta.ToList();
    }

}
