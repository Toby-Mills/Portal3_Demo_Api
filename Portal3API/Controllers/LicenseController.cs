using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Portal3API.Interfaces;
using Portal3API.Models;

namespace Portal3API.Controllers
{

   [RoutePrefix("api/licenses")]
    public class LicenseController : BaseController
    {

        private ILicenseRepository _LicenseRepository;

        public LicenseController(ILicenseRepository objLicenseRepository)
        {
            _LicenseRepository = objLicenseRepository;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetLicenses()
        {
            List<LicenseModel> lstReturn = default(List<LicenseModel>);

            lstReturn = _LicenseRepository.GetLicenses();

            return Ok(lstReturn);
        }

    }

}
