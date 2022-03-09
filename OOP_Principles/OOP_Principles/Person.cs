using System;

public class Person
{
    private string _firstName;
    private string _lastName;
    public Person(string FName, string LName)
    {
        FirstName = FName;
        LastName = LName;
    }

    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }

    public virtual void Print()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
    //public void SetLastName(string NewLastName)
    //{
    //    _lastName = NewLastName;
    //}
}