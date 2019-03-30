namespace BuilderPattern
{
  public class BmwCarBuilder : ICarBuilder
  {
    private readonly Car _car = new Car();
    public Car GetCar() => _car;
    public void SetBrand() => _car.Brand = "BMW";
    public void SetOrigin() => _car.Country = "Germany";
  }
}
