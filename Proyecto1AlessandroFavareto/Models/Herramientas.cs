using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto1AlessandroFavareto.Models
{
    public class Herramientas
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaPrestamo{ get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaDevolver { get; set; }

    }
}