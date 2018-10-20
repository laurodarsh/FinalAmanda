using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAmanda.Classes
{
    public class Product
    {
        private int id;
        private string name;
        private bool active;
        private Category category;
        private float price;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
