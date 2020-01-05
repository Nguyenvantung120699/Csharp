using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Cart
    {
        private int Id;
        private string customer;
        private int grandTotal;
        private string city;
        private string country;
        public List<Product> productlist = new List<Product>();

        public int id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public int GrandTotal
        {
            get
            {
                return grandTotal;
            }

            set
            {
                grandTotal = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
    }
}
