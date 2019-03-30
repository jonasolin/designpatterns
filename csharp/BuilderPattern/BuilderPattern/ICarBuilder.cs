namespace BuilderPattern
{
  public interface ICarBuilder
  {
    void SetBrand();
    void SetOrigin();
    Car GetCar();
  }
}
