using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)// se encarga de solo crear y mandar a almacenar los libros por lo que cumple con los principios
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");

        }
    }
}
