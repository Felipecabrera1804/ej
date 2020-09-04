using System;

namespace SRP
{
    public class Libro
    {
        private string Titulo { get ; }
        private string Autor { get ; }
        private string Codigo { get ;  }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
    }
    public class AlmacenarLibro
    {
        private string SectorBiblioteca { get ; set; }
        private string EstanteBiblioteca { get ; set; }
        private Libro Book {get ;}
        public AlmacenarLibro(Libro libro,String sector, String estante)
        {
            this.Book = libro;
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
    }
}
