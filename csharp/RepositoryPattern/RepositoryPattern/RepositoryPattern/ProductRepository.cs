using System.Linq;

namespace RepositoryPattern
{
  public class ProductRepository : IRepository<Product>
  {
    Context _context;

    public ProductRepository() => 
      _context = new Context();

    public Product FindById( int id ) => 
      ( from p in _context.Products where p.Id == id select p ).FirstOrDefault();
  }
}
