using System;

namespace DesignPattern.Builder
{
  public class CarBuilder
  {
    private string _name = "";
    private string _model = "";
    private int _year = 0;

    public Car Build() =>
      new Car
      {
        Name = _name,
        Model = _model,
        Year = _year
      };

    public CarBuilder WithName(string value)
    {
      _name = value;
      return this;
    }

    public CarBuilder WithModel(string value)
    {
      _model = value;
      return this;
    }

    public CarBuilder WithYear(int value)
    {
      _year = value;
      return this;
    }
  }
}
