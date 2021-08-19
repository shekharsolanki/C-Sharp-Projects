using System;
using System.Collections.Generic;
using System.Text;

namespace Second_Project
{
    class Address
    {
        public string addressLine;
        public string city;
        public string state;

        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
}
