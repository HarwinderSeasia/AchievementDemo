using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement_Domain
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
