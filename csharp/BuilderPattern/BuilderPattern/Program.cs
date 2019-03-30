using System;

namespace BuilderPattern
{
  class Program
  {
    static void Main( string[] args )
    {
      // Volvo
      var volvoCarBuilder = new CarWorkshop( new VolvoCarBuilder() );

      volvoCarBuilder.
        AssembleTheCar().
        RollItOutFromTheWorkshop().
        WriteToConsole();

      // BMW
      var bmwCarBuilder = new CarWorkshop( new BmwCarBuilder() );

      bmwCarBuilder.
        AssembleTheCar().
        RollItOutFromTheWorkshop().
        WriteToConsole();

      Console.ReadLine();
    }
  }
}
