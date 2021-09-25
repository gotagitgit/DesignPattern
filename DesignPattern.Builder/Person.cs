namespace DesignPattern.Builder
{
    public class Person
    {
        public Person(string firstName, string lastName) : this(firstName, lastName, 0)
        {
        }

        public Person(string firstName) : this(firstName, "", 0)
        {
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }
    }
}
