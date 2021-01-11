using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Achievement_Domain
{
    public class ServiceResult
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public dynamic ResultData { get; set; }
        public string ResourceType { get; set; } 
    }
}
