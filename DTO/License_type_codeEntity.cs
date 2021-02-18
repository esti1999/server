using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class License_type_codeEntity
    {
        public int code_type { get; set; }
        public string name_type { get; set; }


        public static License_type_codeEntity CnvertLicense_type_codeTableToLicense_type_codeEnttity(License_type_code_ license_Type_Code)
        {
            License_type_codeEntity license_Type_Code1 = new License_type_codeEntity
            {
                code_type = license_Type_Code.code_type,
                name_type = license_Type_Code.name_type
            };
            return license_Type_Code1;
        }



        public static License_type_code_ CnvertLicense_type_codeEnttityToLicense_type_codeTable(License_type_codeEntity license_Type_Code)
        {
            License_type_code_ license_Type_Code1 = new License_type_code_
            {
                code_type = license_Type_Code.code_type,
                name_type = license_Type_Code.name_type
            };
            return license_Type_Code1;
        }



        public static List<License_type_codeEntity> CnvertLicense_type_codeTableToListLicense_type_codeEnttity(List<License_type_code_> license_Type_Codes)
        {
            List<License_type_codeEntity> license_Type_Codes1 = new List<License_type_codeEntity>();
            foreach(var item in license_Type_Codes)
            {
                license_Type_Codes1.Add(CnvertLicense_type_codeTableToLicense_type_codeEnttity(item));
            }
            return license_Type_Codes1;
        }


        public static List<License_type_code_> CnvertLicense_type_codeEnttityToListLicense_type_codeTable(List<License_type_codeEntity> license_Type_Codes)
        {
            List<License_type_code_> license_Type_Codes1 = new List<License_type_code_>();
            foreach (var item in license_Type_Codes)
            {
                license_Type_Codes1.Add(CnvertLicense_type_codeEnttityToLicense_type_codeTable(item));
            }
            return license_Type_Codes1;
        }
    }
}
