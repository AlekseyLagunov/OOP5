using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    class Person
    {
        public string name;
        public string surname;

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void PShow()
        {
            Console.WriteLine(name + " " + surname);
        }
    }

    class Employee : Person
    {
        public string Company;
        public Employee(string name, string surname, string company) : base(name, surname)
        {
          Company = company;
        }

        public void EShow()
        {
            Console.WriteLine(name + " " + surname + " " + Company);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Tom", "Smith");
            Employee employee1 = new Employee("Bill", "Gates", "Microsoft");
            person1.PShow();
            employee1.EShow();

            Console.ReadKey();
        }
    }
}
