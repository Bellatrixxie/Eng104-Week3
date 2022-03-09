using System;

namespace SafariParkApp
{
    public class Program
    {
        static void Main()
        {

            // Week 3 Day 3
            // creating objects
            // structs vs classes
            // inheritance

            //#region polymorphism

            //List<Object> gameObjects = new List<Object>();
            //{
            //    new Person("Nish", "Mandal") { Age = 32 };
            //    new Airplane(400, 200, "Boeing"),
            //    new Vehicle(12, 20),
            //    new Hunter("Hunter", "McHunty", "Pentax")
            //    }
            //foreach var(gameObj in gameObjects){
            //    Console.WriteLine(gameObj);
            //}
            //Person yolanda = new Person("Yolanda", "Young");
            //SpartaWrite(yolanda);


            //var a = new Person("Nish", "Mandal") { Age = 32 };
            //var b = new Hunter("Hunter", "McHunty", "Pentax");
            //SpartaWrite(a);
            //var c = (Person)b;
            //SpartaWrite(c);
            //var d = a as Hunter;
            //var d = (Hunter)a;
            //SpartaWrite(d); // Can't downcast, can only upcast


            //#endregion


            List<IMoveable> IMoveObjs = new List<IMoveable>();

            foreach (IMoveable moveObj in IMoveObjs)
            {
                Console.WriteLine(moveObj.Move());
            }

        }

        public static void SpartaWrite(Object obj) 
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
            }
        }








            //Person james = new Person("James", "Dickenson", 12);
            //Console.WriteLine(james.GetFullName());

            //Person david = new Person("David", "Cull", 5);
            //Console.WriteLine(david.GetFullName());
            //Console.WriteLine(david.Age);
            //david.Age = 1;

            //Person steven = new Person("Steven");
            //steven.Age = 4;             // Calls the setter method
            //var stevensAge = steven.Age;    // Calls the getter method

            //var arr = new int[] { 1, 2, 3 };
            //var marian = new Person("Marian", "Dumitriu") { Age = 90 }; // Object Initializer (uses the setter) - another eg. of OIs is arrays' { }

            //var myBasket = new ShoppingBasket() {Bread = 2, Milk = 6, Potato = 14};

            //var person = new Person() { FirstName = "Jay", LastName = "Z", Age = 32 };
            //var pt3d = new Point3D(1, 2, 3);
            //DemoMethod(person, pt3d);
            //Console.WriteLine($"Y coord: {pt3d.y}. Jay Z's age: {person.Age}");

            // creating objects > structs vs classes > region inheritance:

            //Hunter h = new Hunter("Gaurav", "Dogra", "Nikon") { Age = 22 };
            //Hunter h2 = new Hunter("Goncalo", "Nunes", "Leica") { Age = 28 };

            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            ////h._firstName;

            //// All classes inherit, eg .GetHashType, .ReferenceEquals, .Equals - from Base Object Class
            //// .Equals is virtual - can be overridden. Virtual - override works on methods and props.

            //Abstract classes are similar to interfaces, except that a class can only inherit from one class.

            // NB: This part is leading into Polymorphism.
            //var rec1 = new Rectangle(10, 10);
            //Rectangle rec2 = new Rectangle(11, 2);
            //Shape rec3 = new Rectangle(11, 2);

            //Object rec1 = new Rectangle(10, 10);
            //Object rec2 = new Rectangle(11, 2);
            //Object rec3 = new Rectangle(11, 2);


            //rec3.CalculateArea();

            //var arrRecs = new Shape[] { rec1, rec2, rec3 };
            //foreach (var item in arrRecs)
            //{
            //    Console.WriteLine(item.CalculateArea());
            //}

        //        Airplane a = new Airplane(200, 100, "JetsRUs") 
        //            { NumPassengers = 150 }; 
        //        a.Ascend(500); 
        //        Console.WriteLine(a.Move(3)); 
        //        Console.WriteLine(a); 
        //        a.Descend(200); 
        //        Console.WriteLine(a.Move()); 
        //        a.Move(); 
        //        Console.WriteLine(a);
        //}
        //static void DemoMethod(Person p, Point3D pt)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}
    }
}