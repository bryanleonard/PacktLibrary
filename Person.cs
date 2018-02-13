using PacktLibrary;
using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public partial class Person
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        //methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }

        //methods to 'multiply'
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
    }


    //// Stuff prior to Chapter 6
    //public partial class OldPerson
    //{



    //    //Prior to Chapter 6

    //    public string Name;
    //    public string FavHobby;
    //    public DateTime DOB;
    //    public WondersOfTheAncientWorld FavouriteAncientWonder;
    //    public List<OldPerson> Children = new List<OldPerson>();
    //    public const string Species = "Homo Sapien";
    //    public readonly string HomePlanet = "Earth";

    //    public readonly DateTime Instantiated; // constructors 
    //    public OldPerson()
    //    {
    //        // set default values for fields 
    //        // including read-only fields 
    //        Name = "Unknown";
    //        Instantiated = DateTime.Now;
    //    }


    //    public OldPerson(string initialName)
    //    {
    //        Name = initialName;
    //        Instantiated = DateTime.Now;
    //    }


    //    // methods 
    //    public void WriteToConsole()
    //    {
    //        WriteLine($"{Name} was born on {DOB:dddd, d MMMM yyyy}");
    //    }

    //    public string GetOrigin()
    //    {
    //        return $"{Name} was born on {HomePlanet}";
    //    }

    //    public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
    //    {
    //        return $"command is {command}, number is {number}, active is {active}";
    //    }

    //    public void PassingParameters(int x, ref int y, out int z)
    //    {
    //        // out parameters cannot have a default  
    //        // AND must be initialized inside the method 
    //        z = 99;

    //        // increment each parameter 
    //        x++;
    //        y++;
    //        z++;
    //    }


    //    //***

    //    // old C# 4
    //    public Tuple<string, int> GetFruitCS4()
    //    {
    //        return Tuple.Create("Apples", 5);
    //    }

    //    // new C# 7
    //    public (string, int) GetFruitCS7()
    //    {
    //        return ("Oranges", 6);
    //    }

    //    public (string Name, int Number) GetNamedFruit()
    //    {
    //        return (Name: "Apples", Number: 5);
    //    }
    //}
}
