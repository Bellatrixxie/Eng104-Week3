using System;

class Program
{
    static void Main(string[] args)
    {
        Customer cust = new Customer("Laura", "Tozer", "Gillingham");
        //cust._firstName = "Sarah";
        //cust.firstName = "Laura";
        //cust.lastName = "Tozer";
        //Console.WriteLine($"{cust.FirstName} {cust.LastName}");
        //cust.SetLastName("Linney");
        //cust.FirstName = "Benedict";
        //cust.LastName = "Cumberbatch";
        cust.Print();

        Employee driver = new Employee("Ansel", "Elgort", "Logistics");
        driver.Print();

        Person person;

        Random rand = new Random();
        int myRandomInt = rand.Next(0,2);
        if (myRandomInt == 0)
        {
            person = new Customer("Maya", "Rudolph", "Los Angeles");
        }
        else
        {
            person = new Employee("Millie Bobby", "Brown", "Security");
        }
        person.Print();
    }
}