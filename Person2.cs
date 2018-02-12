using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public partial class Person
    {

        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}.";
            }
        }

        public string Greeting => $"{Name} says hello!";

        public int Age => (int)(System.DateTime.Today.Subtract(DOB).TotalDays / 365.25);

        public string FaveIceCream { get; set; }

        private string favePrimaryColor;
        public string FavePrimaryColor
        {
            get => favePrimaryColor;
            //set => favePrimaryColor = value;
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favePrimaryColor = value;
                        break;

                    default:
                        throw new System.ArgumentException($"{value} is not a primary color. Choose from: red, green, blue.");
                }
            }
        }
    }
}
