using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Weapons_licenseEntity
    {
        public int code_volunteer { get; set; }
        public int code_license { get; set; }
        public string Valid_license { get; set; }
        public string Knowledge_in { get; set; }



        public static Weapons_licenseEntity ConvertWeapons_licenseTableToWeapons_licenseEntity(weapons_license weapons_License)
        {
            Weapons_licenseEntity weapons_License1 = new Weapons_licenseEntity
            {
                code_volunteer = weapons_License.code_volunteer,
                code_license = weapons_License.code_license,
                Valid_license = weapons_License.Valid_license,
                Knowledge_in = weapons_License.Knowledge_in
            };
            return weapons_License1;
        }



        public static weapons_license ConvertWeapons_licenseEntityToWeapons_licenseTable(Weapons_licenseEntity weapons_License)
        {
            weapons_license weapons_License1 = new weapons_license
            {
                code_volunteer = weapons_License.code_volunteer,
                code_license = weapons_License.code_license,
                Valid_license = weapons_License.Valid_license,
                Knowledge_in = weapons_License.Knowledge_in
            };
            return weapons_License1;
        }


        public static List<Weapons_licenseEntity> ConvertWeapons_licenseTableToListWeapons_licenseEntity(List<weapons_license> weapons_Licenses)
        {
            List<Weapons_licenseEntity> weapons_Licenses1 = new List<Weapons_licenseEntity>();
            foreach(var item in weapons_Licenses)
            {
                weapons_Licenses1.Add(ConvertWeapons_licenseTableToWeapons_licenseEntity(item));
            }
            return weapons_Licenses1;
        }


        public static List<weapons_license> ConvertWeapons_licenseEntityToListWeapons_licenseTable(List<Weapons_licenseEntity> weapons_Licenses)
        {
            List<weapons_license> weapons_Licenses1 = new List<weapons_license>();
            foreach (var item in weapons_Licenses)
            {
                weapons_Licenses1.Add(ConvertWeapons_licenseEntityToWeapons_licenseTable(item));
            }
            return weapons_Licenses1;
        }
    }
}
