using Achievement_Data.RepositoryInterfaces;
using Achievement_Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Achievement_Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private static int _nextBadgesId = 1;
        private static int _nextEmployeeId = 1;
         private static int _nextHelpingHandId= 1;
         private static int _nextVoucherId= 1;
        static List<Badges> lstbadge = new List<Badges>();
        static List<HelpingHand> lstHelpingHand = new List<HelpingHand>();
        static List<Voucher> lstVoucher = new List<Voucher>();
        static List<Employee> lstemployee = new List<Employee>();

        public AccountRepository()
        {
           
        }

        #region Badge
        public Badges AddBadge(Badges badge)
        {
            badge.BadgeId = _nextBadgesId++;
            lstbadge.Add(badge);
            return badge;
        }

        public IEnumerable<Badges> GetAllBadge()
        {
            return lstbadge;
        }

        public Badges GetBadgeById(int id)
        {
            return lstbadge.Find(p => p.BadgeId == id);
        }

        public bool DeleteBadgeById(int id)
        {
            return lstbadge.RemoveAll(p => p.BadgeId == id) > 0 ? true : false;
        }

        public bool UpdateBadge(Badges badge)
        {
            int index = lstbadge.FindIndex(p => p.BadgeId == badge.BadgeId); 
            lstbadge.RemoveAt(index);
            lstbadge.Add(badge);
            return true;
        }

        #endregion

        #region HelpingHand
        public HelpingHand AddHelpingHand(HelpingHand helpingHand)
        {
            helpingHand.HelpingHandId = _nextHelpingHandId++;
            lstHelpingHand.Add(helpingHand);
            return helpingHand;
        }

        public IEnumerable<HelpingHand> GetAllHelpingHand()
        {
            return lstHelpingHand;
        }

        public HelpingHand GetHelpingHandById(int id)
        {
            return lstHelpingHand.Find(p => p.HelpingHandId == id);
        }
        #endregion

        #region Voucher
        public Voucher AddVoucher(Voucher voucher)
        {
            voucher.VoucherId = _nextVoucherId++;
            lstVoucher.Add(voucher);
            return voucher;
        }

        public IEnumerable<Voucher> GetAllVoucher()
        {
            return lstVoucher;
        }

        public Voucher GetVoucherById(int id)
        {
            return lstVoucher.Find(p => p.VoucherId == id);
        }
        #endregion

        #region Employee
        public Employee AddEmployee(Employee employee)
        {
            employee.EmployeeId = _nextEmployeeId++;
            employee.LstBadges = new List<Badges>();
            employee.LstHelpingHand = new List<HelpingHand>();
            employee.LstVoucher = new List<Voucher>();
            lstemployee.Add(employee);
            return employee;
        }

        public bool AssignBadge(AssignBadge assignBadge)
        {
            var objBadge = lstbadge.Find(p => p.BadgeId == assignBadge.BadgeId);
            lstemployee.Where(e => e.EmployeeId == assignBadge.EmployeeId).FirstOrDefault().LstBadges.Add(objBadge);
            return true;
        }

        public bool AssignHelpingHand(AssignHelpingHand assignHelpingHand)
        {
            var objHelpingHand = lstHelpingHand.Find(p => p.HelpingHandId == assignHelpingHand.HelpingHandId);
            lstemployee.Where(e => e.EmployeeId == assignHelpingHand.EmployeeId).FirstOrDefault().LstHelpingHand.Add(objHelpingHand);
            return true;
        }

        public bool AssignVoucher(AssignVoucher assignVoucher)
        {
            var objVoucher = lstVoucher.Find(p => p.VoucherId == assignVoucher.VoucherId);
            lstemployee.Where(e => e.EmployeeId == assignVoucher.EmployeeId).FirstOrDefault().LstVoucher.Add(objVoucher);
            return true;
        }
        public Employee GetEmployeeById(int id)
        {
            return lstemployee.Find(p => p.EmployeeId == id);
        }

        #endregion
    }
}
