using Achievement_Data.RepositoryInterfaces;
using Achievement_Domain;
using Achievement_Service.ServiceInterfaces;
using Achievement_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Achievement_Service.Service
{
   public class AccountService: IAccountService
    {
        private IAccountRepository _AccountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _AccountRepository = accountRepository;
        }

        #region Badge
        public ServiceResult AddBadge(Badges badges)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.BadgeAdded;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AddBadge(badges);
            serviceResult.ResourceType = "Add Badge"; 
            return serviceResult; 
        }

        public ServiceResult GetBadgeById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.BadgeDetail;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetBadgeById(id);
            serviceResult.ResourceType = "Get Badge";
            return serviceResult; 
        }

        public ServiceResult GetAllBadge()
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.BadgeAll;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetAllBadge();
            serviceResult.ResourceType = "Get All Badge";
            return serviceResult; 
        }

        public ServiceResult DeleteBadgeById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.BadgeDeleted;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.DeleteBadgeById(id);
            serviceResult.ResourceType = "Delete Badge";
            return serviceResult; 
        }

        public ServiceResult UpdateBadge(Badges badges)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.BadgeUpdated;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.UpdateBadge(badges);
            serviceResult.ResourceType = "Update Badge";
            return serviceResult;
        }

        #endregion

        #region HelpingHand
        public ServiceResult AddHelpingHand(HelpingHand helpingHand)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.HelpingHandAdded;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AddHelpingHand(helpingHand);
            serviceResult.ResourceType = "Add HelpingHand";
            return serviceResult;
        }

        public ServiceResult GetHelpingHandById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.HelpingHandDetail;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetHelpingHandById(id);
            serviceResult.ResourceType = "Get HelpingHand";
            return serviceResult;
        }

        public ServiceResult GetAllHelpingHand()
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.HelpingHandAll;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetAllHelpingHand();
            serviceResult.ResourceType = "Get All HelpingHand";
            return serviceResult;
        }
        #endregion

        #region Voucher
        public ServiceResult AddVoucher(Voucher voucher)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.VoucherAdded;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AddVoucher(voucher);
            serviceResult.ResourceType = "Add Voucher";
            return serviceResult;
        }

        public ServiceResult GetVoucherById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.VoucherDetail;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetVoucherById(id);
            serviceResult.ResourceType = "Get Voucher";
            return serviceResult;
        }

        public ServiceResult GetAllVoucher()
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.VoucherAll;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetAllVoucher();
            serviceResult.ResourceType = "Get All Voucher";
            return serviceResult;
        }
        #endregion

        #region Employee
        public ServiceResult AddEmployee(Employee employee)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.EmployeeAdded;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AddEmployee(employee);
            serviceResult.ResourceType = "Add Employee";
            return serviceResult;
        }

        public ServiceResult GetEmployeeById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.EmployeeDetail;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.GetEmployeeById(id);
            serviceResult.ResourceType = "Get Employee By Id";
            return serviceResult;
        }

        public ServiceResult AssignBadge(AssignBadge assignBadge)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.AssignedBadge;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AssignBadge(assignBadge);
            serviceResult.ResourceType = "Assign Badge";
            return serviceResult;
        }

        public ServiceResult AssignHelpingHand(AssignHelpingHand assignHelpingHand)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.AssignedHelpingHand;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AssignHelpingHand(assignHelpingHand);
            serviceResult.ResourceType = "Assign HelpingHand";
            return serviceResult;
        }

        public ServiceResult AssignVoucher(AssignVoucher assignVoucher)
        {
            ServiceResult serviceResult = new ServiceResult();
            serviceResult.Message = MessageConfig.AssignedVoucher;
            serviceResult.Status = true;
            serviceResult.StatusCode = HttpStatusCode.OK;
            serviceResult.ResultData = _AccountRepository.AssignVoucher(assignVoucher);
            serviceResult.ResourceType = "Assign Voucher";
            return serviceResult;
        }

        #endregion
    }
}
