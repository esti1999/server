using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class langueges_volunteer_codeEntity
    {
        public int id { get; set; }
        public int code_langueges { get; set; }
        public int code_volunteer { get; set; }



        public static langueges_volunteer_codeEntity Convertlangueges_volunteer_codeTableTolangueges_volunteer_codeEntity(langueges_volunteer_code_ langueges_Volunteer_Code)
        {
            langueges_volunteer_codeEntity langueges_Volunteer_Code1 = new langueges_volunteer_codeEntity
            {
                id = langueges_Volunteer_Code.id,
                code_langueges = langueges_Volunteer_Code.code_langueges,
                code_volunteer = langueges_Volunteer_Code.code_volunteer
            };
            return langueges_Volunteer_Code1;
        }




        public static langueges_volunteer_code_ Convertlangueges_volunteer_codeEntityTolangueges_volunteer_codeTable(langueges_volunteer_codeEntity langueges_Volunteer_Code)
        {
            langueges_volunteer_code_ langueges_Volunteer_Code1 = new langueges_volunteer_code_
            {
                id = langueges_Volunteer_Code.id,
                code_langueges = langueges_Volunteer_Code.code_langueges,
                code_volunteer = langueges_Volunteer_Code.code_volunteer
            };
            return langueges_Volunteer_Code1;
        }


        public static List<langueges_volunteer_codeEntity> Convertlangueges_volunteer_codeTableToListlangueges_volunteer_codeEntity(List<langueges_volunteer_code_> langueges_Volunteer_Codes)
        {
            List<langueges_volunteer_codeEntity> langueges_Volunteer_Codes1 = new List<langueges_volunteer_codeEntity>();
            foreach(var item in langueges_Volunteer_Codes)
            {
                langueges_Volunteer_Codes1.Add(Convertlangueges_volunteer_codeTableTolangueges_volunteer_codeEntity(item));
            }
            return langueges_Volunteer_Codes1;
        }


        public static List<langueges_volunteer_code_> Convertlangueges_volunteer_codeEntityToListlangueges_volunteer_codeTable(List<langueges_volunteer_codeEntity> langueges_Volunteer_Codes)
        {
            List<langueges_volunteer_code_> langueges_Volunteer_Codes1 = new List<langueges_volunteer_code_>();
            foreach (var item in langueges_Volunteer_Codes)
            {
                langueges_Volunteer_Codes1.Add(Convertlangueges_volunteer_codeEntityTolangueges_volunteer_codeTable(item));
            }
            return langueges_Volunteer_Codes1;
        }
    }
}
