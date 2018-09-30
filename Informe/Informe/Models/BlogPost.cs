using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Informe.Models
{
    public class BlogPost
    {
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [StringLength(200)]
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
       // public List<Comentario> Comentarios { get; set; }
    }
}