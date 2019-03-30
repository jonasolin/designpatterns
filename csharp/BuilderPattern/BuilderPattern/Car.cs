using System;

namespace BuilderPattern
{
  public class Car
  {
    public string Brand { get; set; }
    public string Country { get; set; }
    public override string ToString() => 
      $"New car with brand {Brand} from country {Country} created!";
    public void WriteToConsole() => Console.WriteLine( this );
  }
}
