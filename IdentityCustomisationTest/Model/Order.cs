using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodesCW2.Model
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int NumOfProduct { get; set; }
        public int CustomerId{ get; set; }
        

    }
}
