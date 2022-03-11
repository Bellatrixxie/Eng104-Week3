using System;

namespace ObjectComparison_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {

            //# region Collections

            //var bobOne = new Person("Bob", "Builder") { Age = 25 };
            //var bobTwo = bobOne;
            //var artSame = bobOne.Equals(bobTwo);
            //Console.WriteLine(artSame); // Returns *true* as they ref the same dataset.

            //var bobThree = new Person("Bob", "Builder") { Age = 25 };
            //var areSameOneThree = bobOne.Equals(bobThree); // Returns *false* as a new dataset has been created for bobThree.

            //List<Person> personList = new List<Person>
            //{
            //    new Person("Cath", "Cookson"),
            //    new Person("Bob", "Builder"){Age = 25 },
            //    new Person("Dan", "Dare"),
            //    new Person("Amy", "Andrew"){Age = 32},
            //    new Person("Bob", "Andrew"){Age = 32}
            //};

            //var hasBob = personList.Contains(bobOne); // false

            //personList.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine();
            //personList.Sort();

            // personList.ForEach(x => Console.WriteLine(x));

            //personList.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x));

            ////using System.Collections   is legacy, not used anymore.
            //// Involved boxing and unboxing collections. Stored as base objects.
            //// Eg ArrayList - not recommended for new dev

            var helen = new Person("Helen", "Tryp") { Age = 22 };
            var will = new Person("William", "Shakespeare") { Age = 457 };
            List<Person> thePeople = new List<Person> { helen, will };
            thePeople.Add(new Person("Nish", "Mandal"));

            //Person[] arr = thePeople.ToArray();

            //var numList = new List<int> { 5, 4, 3, 9, 0 };
            //numList.Add(8);
            //numList.Sort();
            //numList.RemoveRange(1, 2);
            //numList.Insert(2, 1);
            //numList.Reverse();
            //numList.Remove(9); // numList.IndexOf(9);
            // Console.WriteLine(numList);
            // Console.WriteLine(numList.ToString());

            //foreach (var n in numList)
            //{
            //    Console.WriteLine($"{n} ");     // 8 1 5 0 listed vertically.
            //}
            //Console.WriteLine();

            //LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            //thePeopleLinked.AddFirst(helen);
            //thePeopleLinked.AddFirst(helen);
            //thePeopleLinked.AddLast(new Person("Nish", "Mandal"));

            //foreach (var person in thePeopleLinked)
            //{
            //    Console.WriteLine(person);
            //}

            //// LINQ LISTS are useful for when frequently adding and deleting from middle of Lists.
            //// Reduces chances of memory (fragmentation?)

            // QUEUES

            //var myQueue = new Queue<Person>();
            //myQueue.Enqueue(helen);
            //myQueue.Enqueue(will);
            //myQueue.Enqueue(new Person("Jab", " Khan"));

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //var first = myQueue.Peek();
            //var serve = myQueue.Dequeue();                myNB Enqueue/Dequeue = pushift

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //// STACKS. Useful for undo. Last in, first out.

            //int[] original = new int[] { 1, 2, 3, 4, 5 };
            //int[] reversed = new int[original.Length];
            //var stack = new Stack<int>();

            //foreach (var n in original)
            //{
            //    stack.Push(n);
            //}

            //// Pop off the stack the top chair, which will b fine and continue until our array is full
            //for (int i = 0; i < original.Length; i++)
            //{
            //    reversed[i] = stack.Pop();
            //}

            //var peopleSet = new HashSet<Person>
            //{
            //    helen, new Person(" Jasmin", " Mandal"), new Person(" Andrei", " Aggassi")
            //};

            //// For 2 object to be equal, they must have the same hashcode.
            //// However, having the same hashcode does not necessarily make them equal.

            //var successMartin = peopleSet.Add(new Person("Martin", "Beard"));
            //var successHelen = peopleSet.Add(new Person("Helen", "Troy") { Age = 22});

            //var morePeople = new HashSet<Person> { new Person("Cathy", "French"), new Person("Jasmin", "Mandal") };
            //peopleSet.IntersectWith(morePeople);

            //foreach (var person in peopleSet)
            //{
            //    Console.WriteLine(person);
            //}

            //// Useful to check definition for overload methods.

            var personDictionary = new Dictionary<string, Person>
            {
                { "helen", helen },
                {"sherlock", new Person("Sherlock", "Holmes"){Age = 40 } }
            };

            Person p = personDictionary["sherlock"];

            //// #endregion

            //string input = " The car in the hat comes back";
            //input = input.Trim().ToLower();
            //var countDict = new Dictionary<char, int>();
            //foreach (var c in input)
            //{
            //    if (countDict.ContainsKey(c))
            //    {
            //        countDict[c]++;
            //    }
            //    else
            //    {
            //        countDict.Add(c, 1);
            //    }
            //}
            //Console.WriteLine("Dictionary Problem");

            //foreach (var keyValuePair in countDict)
            //{
            //    Console.WriteLine(keyValuePair.Key);
            //}

            ////[t, 3]
            ////[h, 3]

            var theBeatles = new Dictionary<int, string>() { { 1, "John" }, { 2, "Paul" }, { 3, "Ringo" }, { 4, "George" } };
            var isAdded = theBeatles.TryAdd(3, "Nish") ;
            var c = theBeatles.Remove(1);
            var d = theBeatles.Keys.Where(x => x % 2 == 0).Sum();
            Console.WriteLine(isAdded);
            Console.WriteLine(c);

            foreach (var keyValuePair in theBeatles)
            {
                Console.WriteLine(keyValuePair);
            }

            Console.WriteLine(d);






















            // #endregion
        }
    }
}