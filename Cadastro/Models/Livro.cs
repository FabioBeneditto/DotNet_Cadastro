//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cadastro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Livro
    {
        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public int NumPaginas { get; set; }
        public int Ano { get; set; }
        public string Editora { get; set; }
        public decimal Preco { get; set; }
        public int CodAutor { get; set; }
        public int codGenero { get; set; }
    
        public virtual Autor Autor { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
