using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.App_Data
{
    public class DbSet<T>
    {
        private List<T> _items;

        public DbSet()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public List<T> GetAll()
        {
            return _items;
        }
    }
}
