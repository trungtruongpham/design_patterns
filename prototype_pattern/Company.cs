using System;

namespace prototype_pattern
{
    public class Company
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public Company(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }

        public void Show(){
            Console.WriteLine("Company : " + this.Name + " from " + this.Country);
        }
    }
}