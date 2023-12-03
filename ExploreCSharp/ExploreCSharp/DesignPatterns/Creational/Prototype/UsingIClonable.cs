using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.DesignPatterns.Creational.Prototype
{
    public class Address : ICloneable
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }

        public object Clone()
        {
            return new Address(StreetName, HouseNumber);
        }
    }

    public class Person : ICloneable
    {
        public readonly string[] Names;
        public readonly Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Address)}: {Address}";
        }

        public object Clone()
        {
            return new Person(Names, (Address)Address.Clone());
        }
    }

    /// <summary>
    /// Deep copy cannot be completely achieved using IClonable
    /// </summary>
    public static class UsingIClonable
    {
        public static void Starter()
        {
            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));

            var jane = (Person)john.Clone();
            jane.Address.HouseNumber = 321; // oops, John is now at 321

            // this doesn't work
            //var jane = john;

            // but clone is typically shallow copy
            jane.Names[0] = "Jane";
            jane.Address.StreetName = "Jane road";
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
