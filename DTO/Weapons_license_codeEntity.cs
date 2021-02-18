using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Weapons_license_codeEntity
    {
        public int code_Weapons_license { get; set; }
        public string name_Weapons_license { get; set; }



        public static Weapons_license_codeEntity ConvertWeapons_license_codeTableToWeapons_license_codeEntity(Weapons_license_code_ weapons_License_Code)
        {
            Weapons_license_codeEntity weapons_License_Code1 = new Weapons_license_codeEntity
            {
                code_Weapons_license = weapons_License_Code.code_Weapons_license,
                name_Weapons_license = weapons_License_Code.name_Weapons_license
            };
            return weapons_License_Code1;
        }



        public static Weapons_license_code_ ConvertWeapons_license_codeEntityToWeapons_license_codeTable(Weapons_license_codeEntity weapons_License_Code)
        {
            Weapons_license_code_ weapons_License_Code1 = new Weapons_license_code_
            {
                code_Weapons_license = weapons_License_Code.code_Weapons_license,
                name_Weapons_license = weapons_License_Code.name_Weapons_license
            };
            return weapons_License_Code1;
        }


        public static List<Weapons_license_codeEntity> ConvertWeapons_license_codeTableToListWeapons_license_codeEntity(List<Weapons_license_code_> weapons_License_Codes)
        {
            List<Weapons_license_codeEntity> weapons_License_Codes1 = new List<Weapons_license_codeEntity>();
            foreach(var item in weapons_License_Codes)
            {
                weapons_License_Codes1.Add(ConvertWeapons_license_codeTableToWeapons_license_codeEntity(item));
            }
            return weapons_License_Codes1;
        }


        public static List<Weapons_license_code_> ConvertWeapons_license_codeEntityToListWeapons_license_codeTable(List<Weapons_license_codeEntity> weapons_License_Codes)
        {
            List<Weapons_license_code_> weapons_License_Codes1 = new List<Weapons_license_code_>();
            foreach (var item in weapons_License_Codes)
            {
                weapons_License_Codes1.Add(ConvertWeapons_license_codeEntityToWeapons_license_codeTable(item));
            }
            return weapons_License_Codes1;
        }
    }
}
