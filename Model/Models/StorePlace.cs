using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class StorePlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
