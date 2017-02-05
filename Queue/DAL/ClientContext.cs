using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Queue.Models;

namespace Queue.DAL
{
    public class ClientContext : DbContext
    {
        public ClientContext() : base("ClientsQueueContext")
        {
            
        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }
     }
}