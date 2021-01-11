using Achievement_Domain;
using Achievement_Service.ServiceInterfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AchievementDemo.Controllers
{
    [RoutePrefix("Api/Account")]
    public class AccountController : ApiController
    {
        private IAccountService _AccountService;
        public AccountController(IAccountService accountService)
        {
            _AccountService = accountService;
        }

        #region Badges
        [Route("AddBadge")]
        [HttpPut]
        public IHttpActionResult AddBadge(Badges badges)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AddBadge(badges);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetBadgeById")]
        [HttpGet]
        public IHttpActionResult GetBadgeById(int id)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetBadgeById(id);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetAllBadges")]
        [HttpGet]
        public IHttpActionResult GetAllBadges()
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetAllBadge();
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("DeleteBadgeById")]
        [HttpDelete]
        public IHttpActionResult DeleteBadgeById(int id)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.DeleteBadgeById(id);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("UpdateBadge")]
        [HttpPut]
        public IHttpActionResult UpdateBadge(Badges badges)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.UpdateBadge(badges);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }
        #endregion

        #region HelpingHand
        [Route("AddHelpingHand")]
        [HttpPut]
        public IHttpActionResult AddHelpingHand(HelpingHand helpingHand)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AddHelpingHand(helpingHand);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetHelpingHandById")]
        [HttpGet]
        public IHttpActionResult GetHelpingHandById(int id)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetHelpingHandById(id);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetAllHelpingHand")]
        [HttpGet]
        public IHttpActionResult GetAllHelpingHand()
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetAllHelpingHand();
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }
        #endregion

        #region Voucher
        [Route("AddVoucher")]
        [HttpPut]
        public IHttpActionResult AddVoucher(Voucher voucher)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AddVoucher(voucher);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetVoucherById")]
        [HttpGet]
        public IHttpActionResult GetVoucherById(int id)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetVoucherById(id);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetAllVoucher")]
        [HttpGet]
        public IHttpActionResult GetAllVoucher()
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetAllVoucher();
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }
        #endregion

        #region Employee

        [Route("AddEmployee")]
        [HttpPut]
        public IHttpActionResult AddEmployee(Employee employee)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AddEmployee(employee);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("GetEmployeeById")]
        [HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.GetEmployeeById(id);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("AssignBadge")]
        [HttpPost]
        public IHttpActionResult AssignBadge(AssignBadge assignBadge)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AssignBadge(assignBadge);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("AssignHelpingHand")]
        [HttpPost]
        public IHttpActionResult AssignHelpingHand(AssignHelpingHand assignHelpingHand)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AssignHelpingHand(assignHelpingHand);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }

        [Route("AssignVoucher")]
        [HttpPost]
        public IHttpActionResult AssignVoucher(AssignVoucher assignVoucher)
        {
            try
            {
                ServiceResult serviceViewModel = new ServiceResult();
                serviceViewModel = _AccountService.AssignVoucher(assignVoucher);
                return Ok(serviceViewModel);
            }
            catch (Exception ex)
            {
                Convert.ToString(ex.Message);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.BadRequest, Convert.ToString(ex.Message + " " + ex.InnerException)));
            }
        }
        #endregion

    }
}
