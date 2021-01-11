using Achievement_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement_Service.ServiceInterfaces
{
   public interface IAccountService
    {
        #region Badge
        ServiceResult GetAllBadge();
        ServiceResult GetBadgeById(int id);
        ServiceResult AddBadge(Badges badges);
        ServiceResult DeleteBadgeById(int id);
        ServiceResult UpdateBadge(Badges badges);
        #endregion

        #region HelpingHand
        ServiceResult GetAllHelpingHand();
        ServiceResult GetHelpingHandById(int id);
        ServiceResult AddHelpingHand(HelpingHand helpingHand);
        #endregion

        #region Voucher
        ServiceResult GetAllVoucher();
        ServiceResult GetVoucherById(int id);
        ServiceResult AddVoucher(Voucher voucher);
        #endregion

        #region Employee
        ServiceResult AddEmployee(Employee employee);
        ServiceResult GetEmployeeById(int id);
        ServiceResult AssignBadge(AssignBadge assignBadge);
        ServiceResult AssignHelpingHand(AssignHelpingHand assignHelpingHand);
        ServiceResult AssignVoucher(AssignVoucher assignVoucher);
        #endregion
    }
}
