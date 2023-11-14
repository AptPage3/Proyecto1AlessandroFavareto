using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto1AlessandroFavareto.Models
{
    public class Herramientas
    {
        [Display(Name = "Id")]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaPrestamo{ get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaDevolver { get; set; }

    }
}