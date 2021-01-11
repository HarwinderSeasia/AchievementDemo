using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement_Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public List<Badges> LstBadges { get; set; }
        public List<HelpingHand> LstHelpingHand { get; set; }
        public List<Voucher> LstVoucher { get; set; }

    }
}
