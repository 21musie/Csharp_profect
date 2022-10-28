using System.Data.Entity;
//using System.ComponentModel;


namespace csharp_pro.model
{
    internal class dbContext : DbContext
    {
       public DbSet<Item> item { get; set; }
       public DbSet<Customer> customer { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Catagory> catagory { get; set; }

    }
}
