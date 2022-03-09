﻿namespace SafariParkApp
{
    public class Person : IMoveable
    {
        private string _firstName;
        private string _lastName;

        // Autogenerated property - different from full property.
        // prop, tab, tab - to auto-create property.
        // propfull, tab, tab - to create backing field (private member variable).
        public int Age { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        // ctor, tab, tab
        public Person(string? firstName, string? lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public Person() { }
        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";
        }

        public string FullName => ($"{_firstName} {_lastName}");

        Move(int times)
        {
            return $"Walking along {times} times";
        }
        Move()
        {
            return "Walking along";
        }




        ////can also be written:
        //public string FullName2 { get { return $"{_firstName} {_lastName}"; } }

        //public Person(string firstName, string lastName, int age)
        //{
        //    _firstName = firstName;
        //    _lastName = lastName;
        //    Age = age;
        //}
        //public Person(string firstName)
        //{
        //    _firstName = firstName;
        //}

        //public Person(string firstName, string lastName, int age = 0)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //}

        //public string GetFullName()
        //{
        //    return ($"{_firstName} {_lastName}");
        //}

    }
}
