namespace APIpratica.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIpratica.Models.Practica> Practicas { get; set; }
    }
}