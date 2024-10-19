using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Animal
    {
        public string Name { get; set; }
        public int Popularity { get; set; }
        public Zoo Zoo { get; internal set; }
        public Animal(string name, int popularity) 
        {
            Name = name;
            Popularity = popularity;
        }
    }
}
