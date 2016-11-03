using System;
using System.Collections.Generic;
using Portal3API.Interfaces;
using Portal3API.Models;

namespace Portal3API.Repositories
{

    public class LicenseRepository: ILicenseRepository
    {

        public List<LicenseModel> GetLicenses()
        {
            List<LicenseModel> lstReturn = default(List<LicenseModel>);
          
            return lstReturn;
        }

    }

}