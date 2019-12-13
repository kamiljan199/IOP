using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class StorePlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
