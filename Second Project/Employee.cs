using System;
using System.Collections.Generic;
using System.Text;

namespace Second_Project
{
    class Employee
    {
        private int eId;
        private string name;
        private Address address;

        public Employee(int eId, string name, Address address)
        {
            this.eId = eId;
            this.name = name;
            this.address = address;
        }

        public void display() 
        {
            Console.WriteLine("eId: "+eId+" name: "+name+" addressLine: "+address.addressLine+" city: "+address.city+" state: "+address.state);
        }
    }
}
