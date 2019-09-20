namespace mvcPractica.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mvcPractica.Models.Practica> Practicas { get; set; }
    }
}