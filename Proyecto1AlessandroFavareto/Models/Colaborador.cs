using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto1AlessandroFavareto.Models
{
    public class Colaborador
    {
        [Key]
        [Display(Name = "Cédula")]
        public int Cedula { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        public int CantidadHerramientas { get; set; }
    }
}