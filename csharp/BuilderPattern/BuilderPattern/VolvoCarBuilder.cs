namespace BuilderPattern
{
  public class VolvoCarBuilder : ICarBuilder
  {
    private readonly Car _car = new Car();
    public Car GetCar() => _car;
    public void SetBrand() => _car.Brand = "Volvo";
    public void SetOrigin() => _car.Country = "Sweden";
  }
}
