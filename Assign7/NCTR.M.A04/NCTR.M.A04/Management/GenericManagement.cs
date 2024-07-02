using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTR.M.A04.Management
{
    internal abstract class GenericManagement<T> where T : class
    {
        internal List<T> Items { get; set; }

        public GenericManagement()
        {
            Items = new List<T>();
        }

        public List<T> GetList()
        {
            return Items;
        }

        public virtual void Add(T item)
        { 
            this.Items.Add(item);
        }

        public virtual void Remove(T item) { this.Items.Remove(item); }

        public virtual void Display() 
        {
            foreach (var item in this.Items)
            {
                Console.WriteLine(item);
            }
        }

        public abstract T FindById(int id);

        public abstract void Update(T item);
    }
}
