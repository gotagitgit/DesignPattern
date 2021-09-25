namespace DesignPattern.Builder
{
    public class PersonBuilder
  {
    private string _firstName = null;
    private string _lastName = "";
    private int _age = 0;

    public Person Build() => new Person(_firstName, _lastName, _age);      

    public PersonBuilder WithFirstName(string value)
    {
      _firstName = value;
      return this;
    }

    public PersonBuilder WithLastName(string value)
    {
      _lastName = value;
      return this;
    }

    public PersonBuilder WithAge(int value)
    {
      _age = value;
      return this;
    }
  }
}
