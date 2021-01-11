using Achievement_Domain;
using System.Collections.Generic;

namespace Achievement_Data.RepositoryInterfaces
{
    public interface IAccountRepository
    {
        #region Badge
        IEnumerable<Badges> GetAllBadge();
        Badges GetBadgeById(int id);
        Badges AddBadge(Badges badges);
        bool DeleteBadgeById(int id);
        bool UpdateBadge(Badges badges);
        #endregion

        #region HelpingHand
        IEnumerable<HelpingHand> GetAllHelpingHand();
        HelpingHand GetHelpingHandById(int id);
        HelpingHand AddHelpingHand(HelpingHand helpingHand);
        #endregion

        #region Voucher
        IEnumerable<Voucher> GetAllVoucher();
        Voucher GetVoucherById(int id);
        Voucher AddVoucher(Voucher voucher);
        #endregion

        #region Employee
        Employee AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        bool AssignBadge(AssignBadge assignBadge);
        bool AssignHelpingHand(AssignHelpingHand assignHelpingHand);
        bool AssignVoucher(AssignVoucher assignVoucher);
        #endregion
    }
}
