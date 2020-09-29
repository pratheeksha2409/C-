using SampleCoreApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCoreApp
{
    class Customer1 : IComparable<Customer1>
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }

        public override string ToString()
        {
            return string.Format($"The Name:{CustomerName}\nAddress: {CustomerCity}\nCustomer ID: {CustomerID}");
        }
        public int CompareTo(Customer1 other)
        {
            //if (this.CustomerID < other.CustomerID)
            //    return -1;
            //else if (this.CustomerID > other.CustomerID)
            //    return 1;
            //else return 0;
            return this.CustomerID.CompareTo(other.CustomerID);
        }
    }

    class Customer1Comparer : IComparer<Customer1>
    {
        private string criteria = string.Empty;

        public Customer1Comparer(string criteria)
        {
            this.criteria = criteria;
        }
        public int Compare(Customer1 x, Customer1 y)
        {
            switch (criteria)
            {
                case "Name":
                    return x.CustomerName.CompareTo(y.CustomerName);
                case "Address":
                    return x.CustomerCity.CompareTo(y.CustomerCity);
                default:
                    return x.CompareTo(y);
            }
        }
    }
    class ComparingObjects
    {
        static void Main(string[] args)
        {
            List<Customer1> customers = new List<Customer1>();
            customers.Add(new Customer1 { CustomerCity = "Bangalore", CustomerID = 143, CustomerName = "Anand P Sharma" });
            customers.Add(new Customer1 { CustomerCity = "Mysore", CustomerID = 184, CustomerName = "Mohit Kumar" });
            customers.Add(new Customer1 { CustomerCity = "Chennai", CustomerID = 125, CustomerName = "Srujjan" });
            customers.Add(new Customer1 { CustomerCity = "Agra", CustomerID = 126, CustomerName = "Sampath" });
            customers.Add(new Customer1 { CustomerCity = "Mumbai", CustomerID = 117, CustomerName = "Antony" });
            customers.Add(new Customer1 { CustomerCity = "Pune", CustomerID = 132, CustomerName = "Siad" });
            customers.Add(new Customer1 { CustomerCity = "Hyderabad", CustomerID = 129, CustomerName = "Joe Biden" });
            customers.Add(new Customer1 { CustomerCity = "Coimbatore", CustomerID = 133, CustomerName = "Sam Jackson" });

            string input = MyConsole1.getString("Enter the criteria of Comparing");
            IComparer<Customer1> comparer = new Customer1Comparer(input);
            customers.Sort(comparer);

            foreach (var cst in customers)
                Console.WriteLine(cst);//cst.ToString();
        }
    }
}