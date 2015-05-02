using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleMVCApp.Models {
    public class ContextEntities : DbContext{
        public ContextEntities(): base() {
            
        }

        public DbSet<Person> People { get; set; }
    }
}