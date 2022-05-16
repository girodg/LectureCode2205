using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        #region Fields (data)
        private int _capacity;
        private List<string> _items;
        #endregion

        #region Properties
        public int Capacity
        {
            get { return _capacity; }
            set { 
                if(value > 0)
                    _capacity = value; 
            }
        }

        public int Count
        {
            get { return _items.Count;}
        }

        public List<string> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        #endregion

        #region Constructors
        public Inventory(int capacity, List<string> items)
        {
            Capacity = capacity;
            Items = items.ToList();//clone the list
        }
        #endregion

        #region Methods
        public void AddItem(string itemToAdd)
        {
            if (Count == Capacity) //is backpack full?
                throw new Exception("Backpack is full, fool!");

            _items.Add(itemToAdd);
        }
        #endregion
    }
}
