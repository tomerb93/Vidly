using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Customer(string name) : this()
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}