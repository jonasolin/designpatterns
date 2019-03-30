namespace BuilderPattern
{
  public class CarWorkshop
  {
    private readonly ICarBuilder _builder;
    public CarWorkshop( ICarBuilder builder ) => _builder = builder;
    public CarWorkshop AssembleTheCar()
    {
      _builder.SetBrand();
      _builder.SetOrigin();
      return this;
    }
    public Car RollItOutFromTheWorkshop() => _builder.GetCar();
  }
}
