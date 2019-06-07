using System.Data.Entity;

namespace RepositoryPattern
{
  public class Context : DbContext
  {
    public Context() : base("Context")
    {
    }

    public DbSet<Product> Products { get; set; }
  }
}
