using RepositoryPattern;

namespace ConsoleApp1
{
  class Program
  {
    static void Main( string[] args )
    {
    }

    public static Product FindProduct( int id )
    {
      var productRepository = new ProductRepository();
      return productRepository.FindById( id );
    }
  }
}
