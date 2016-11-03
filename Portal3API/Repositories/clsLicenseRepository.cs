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
            LicenseModel objLicenseModel;

            lstReturn = new List<LicenseModel>();

            objLicenseModel = new LicenseModel();
            objLicenseModel.ID = Guid.NewGuid();
            objLicenseModel.Code = "LC 1";
            lstReturn.Add(objLicenseModel);

            objLicenseModel = new LicenseModel();
            objLicenseModel.ID = Guid.NewGuid();
            objLicenseModel.Code = "LC 2";
            lstReturn.Add(objLicenseModel);

            objLicenseModel = new LicenseModel();
            objLicenseModel.ID = Guid.NewGuid();
            objLicenseModel.Code = "LC 3";
            lstReturn.Add(objLicenseModel);

            return lstReturn;
        }

    }

}