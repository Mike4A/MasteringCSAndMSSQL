using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericRepository<T> where T : class
    {
        private readonly List<T> _items = [];

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        { 
            _items.Remove(item);
        }

        //public T GetById(int id)
        //{
        //    // Assume T has an Id property
        //    return _items.FirstOrDefault(item => (item as dynamic).Id == id);
        //}

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}
