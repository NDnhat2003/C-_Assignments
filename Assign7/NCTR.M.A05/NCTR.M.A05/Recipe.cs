using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A05
{
    internal class Recipe
    {
        public static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        //public Recipe(string name)
        //{
        //    Id = ++counter;
        //    Name = name;
        //}
        //public Recipe(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public override string ToString()
        {
            return $"Recipe {Id}: " +
                $"Name: {Name}";
        }
    }
}
