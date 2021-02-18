using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LicenseEntity
    {
        public int code_license { get; set; }
        public int code_volunteer { get; set; }
        public int license_type { get; set; }


        public static LicenseEntity ConvertLicenseTableToLicenseEntity(license license )
        {
            LicenseEntity license1 = new LicenseEntity
            {
                code_license = license.code_license,
                code_volunteer = license.code_volunteer,
                license_type = license.license_type
            };
            return license1;
        }



        public static license ConvertLicenseEntityToLicenseTable(LicenseEntity license)
        {
            license license1 = new license
            {
                code_license = license.code_license,
                code_volunteer = license.code_volunteer,
                license_type = license.license_type
            };
            return license1;
        }


        public static List<LicenseEntity> ConvertLicenseTableToListLicenseEntity(List<license> licenses)
        {
            List<LicenseEntity> licenses1 = new List<LicenseEntity>();
            foreach(var item in licenses)
            {
                licenses1.Add(ConvertLicenseTableToLicenseEntity(item));
            }
            return licenses1;
        }


        public static List<license> ConvertLicenseEntityToListLicenseTable(List<LicenseEntity> licenses)
        {
            List<license> licenses1 = new List<license>();
            foreach (var item in licenses)
            {
                licenses1.Add(ConvertLicenseEntityToLicenseTable(item));
            }
            return licenses1;
        }
    }
}
