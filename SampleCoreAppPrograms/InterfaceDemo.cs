using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Interface are similar to abstract classes in the way that it allows abstract methods. However you cannot have implementation methos,
 All interface are abstract classes but all abstract classes but all abstract classes are not interfaces.
A class can implement muliple interfaces at the same level.
Methods of the interfaces are by default public and will remain public.
The classes that implement the interface must also implement them as public only.
You cant change the access specifer.
Syntax of implementing interface is same as inheritance, However we use a Convention of naming the interface perfixed with I
*/
namespace SampleCoreApp
{
    interface ICustomerManager
    {
        void AddNewCustomer(int id, string name);
        void UpdateCustomer(int id, string name);
        void DeleteCustomer(int id);
        Array GetAllCustomers(string name);
    }
    class SuperMarket : ICustomerManager
    {
        public void AddNewCustomer(int id, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Array GetAllCustomers(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, string name)
        {
            throw new NotImplementedException();
        }
    }
    class InterfaceDemo
    {

    }
}
