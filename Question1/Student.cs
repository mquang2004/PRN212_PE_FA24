using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Student : IItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly Dob { get; set; }

        public Student()
        {
        }

        public Student(int id, string? name, DateOnly dob)
        {
            Id = id;
            Name = name;
            Dob = dob;
        }
        public void Display()
        {
            Console.WriteLine($"Student: {Id} - {Name} - {Dob}");
        }
    }
}
