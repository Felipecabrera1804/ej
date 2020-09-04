using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            AlmacenarLibro Almacenado1=new AlmacenarLibro(libro1,"A","7");
            AlmacenarLibro Almacenado2=new AlmacenarLibro(libro2,"B","3");

        }
    }
}
