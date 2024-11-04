using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Teacher : IItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Skill {  get; set; }

        public Teacher()
        {
        }

        public Teacher(int id, string? name, string? skill)
        {
            Id = id;
            Name = name;
            Skill = skill;
        }

        public void Display()
        {
            Console.WriteLine($"Teacher: {Id} - {Name} - {Skill}");
        }
    }
}
