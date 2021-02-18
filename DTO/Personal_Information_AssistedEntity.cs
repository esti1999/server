using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Personal_Information_AssistedEntity
    {
        public int code_Assisted { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public int code_tytel { get; set; }
        public string code_gender { get; set; }
        public int phone_number { get; set; }
        public string phone_type { get; set; }
        public string adres { get; set; }
        public string personal_status { get; set; }
        public int code_languages { get; set; }


        public static Personal_Information_AssistedEntity ConvertPersonal_Information_Assisted_TableToPersonal_Information_AssistedEntity(Personal_Information_Assisted_ Personal_Information_Assisted)
        {
            Personal_Information_AssistedEntity Personal_Information_Assisted1 = new Personal_Information_AssistedEntity
            {
                code_Assisted = Personal_Information_Assisted.code_Assisted,
                f_name = Personal_Information_Assisted.f_name,
                l_name = Personal_Information_Assisted.l_name,
                code_tytel = Personal_Information_Assisted.code_tytel,
                code_gender = Personal_Information_Assisted.code_gender,
                phone_number = Personal_Information_Assisted.phone_number,
                phone_type = Personal_Information_Assisted.phone_type,
                adres = Personal_Information_Assisted.adres,
                personal_status = Personal_Information_Assisted.personal_status,
                code_languages = Personal_Information_Assisted.code_languages
            };
            return Personal_Information_Assisted1;
        }
        public static Personal_Information_Assisted_ ConvertPersonal_Information_AssistedEntityToPersonal_Information_AssistedTable(Personal_Information_AssistedEntity Personal_Information_Assisted)
        {
            Personal_Information_Assisted_ Personal_Information_Assisted1 = new Personal_Information_Assisted_
            {
                code_Assisted = Personal_Information_Assisted.code_Assisted,
                f_name = Personal_Information_Assisted.f_name,
                l_name = Personal_Information_Assisted.l_name,
                code_tytel = Personal_Information_Assisted.code_tytel,
                code_gender = Personal_Information_Assisted.code_gender,
                phone_number = Personal_Information_Assisted.phone_number,
                phone_type = Personal_Information_Assisted.phone_type,
                adres = Personal_Information_Assisted.adres,
                personal_status = Personal_Information_Assisted.personal_status,
                code_languages = Personal_Information_Assisted.code_languages
            };
            return Personal_Information_Assisted1;
        }


        public static List<Personal_Information_AssistedEntity> ConvertPersonal_Information_Assisted_TableToListPersonal_Information_AssistedEntity(List<Personal_Information_Assisted_> personal_Information_Assisteds)
        {
            List<Personal_Information_AssistedEntity> personal_Information_Assisteds1 = new List<Personal_Information_AssistedEntity>();
            foreach(var item in personal_Information_Assisteds)
            {
                personal_Information_Assisteds1.Add(ConvertPersonal_Information_Assisted_TableToPersonal_Information_AssistedEntity(item));
            }
            return personal_Information_Assisteds1;
        }



        public static List<Personal_Information_Assisted_> ConvertPersonal_Information_AssistedEntityToListPersonal_Information_AssistedTable(List<Personal_Information_AssistedEntity> personal_Information_Assisteds)
        {
            List<Personal_Information_Assisted_> personal_Information_Assisteds1 = new List<Personal_Information_Assisted_>();
            foreach (var item in personal_Information_Assisteds)
            {
                personal_Information_Assisteds1.Add(ConvertPersonal_Information_AssistedEntityToPersonal_Information_AssistedTable(item));
            }
            return personal_Information_Assisteds1;
        }
    }
}

