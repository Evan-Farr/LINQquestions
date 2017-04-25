using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQquestions
{
    class Shirts : IProduct
    {
        private string name;
        private int capacity;
        private int stock;

        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Stock { get { return stock; } set { stock = value; } }

        public Shirts()
        {
            name = "shirts";
            capacity = 10;
            stock = 8;
        }
    }
