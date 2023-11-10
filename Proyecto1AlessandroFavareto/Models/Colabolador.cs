using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto1AlessandroFavareto.Models
{
    public class Colabolador
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaRegistro { get; set; }
        public bool estado { get; set; }
        public int cantidadHerramientas { get; set; }
    }
}