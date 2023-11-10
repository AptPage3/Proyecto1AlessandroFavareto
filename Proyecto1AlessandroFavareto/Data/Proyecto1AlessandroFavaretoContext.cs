﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto1AlessandroFavareto.Data
{
    public class Proyecto1AlessandroFavaretoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Proyecto1AlessandroFavaretoContext() : base("name=Proyecto1AlessandroFavaretoContext")
        {
        }

        public System.Data.Entity.DbSet<Proyecto1AlessandroFavareto.Models.Colabolador> Colaboladors { get; set; }

        public System.Data.Entity.DbSet<Proyecto1AlessandroFavareto.Models.Herramientas> Herramientas { get; set; }
    }
}