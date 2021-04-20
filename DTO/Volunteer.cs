using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Volunteer
    {
        public string id_volunteer { get; set; }
        public string firstName_volunteer { get; set; }
        public string lastName_volunteer { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public int code_gender { get; set; }
        public int code_status { get; set; }
        public int code_city { get; set; }
        public string street { get; set; }
        public string postal_code { get; set; }
        public int house_number { get; set; }
        public int bulding_number { get; set; }
        public int number_floor { get; set; }
        public string e_mail { get; set; }
        public int code_service { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> release_date { get; set; }
        public List<Language> languages { get; set; }



        public static Volunteer convertvolunteertabletovolunteerentity(volunteer v)
        {
            Volunteer v1 = new Volunteer()
            {

                id_volunteer = v.id_volunteer,
                firstName_volunteer = v.firstName_volunteer,
                lastName_volunteer = v.lastName_volunteer,
                date_of_birth = v.date_of_birth,
                code_gender = v.code_gender,
                code_status = v.code_status,
                code_city = v.code_city,
                street = v.street,
                house_number = v.house_number,
                bulding_number = v.bulding_number,
                postal_code = v.postal_code,
                e_mail = v.e_mail,
                code_service = v.code_service,
                number_floor = v.number_floor,
                phone = v.phone,
                password = v.password,
                release_date = v.release_date

            };
            return v1;
        }

        public  static List<volunteer_language> convertLanguageEntityListToVolenteerLanguage(List<Language> languages,string volunteerId)
        {
            List<volunteer_language> vlList = new List<volunteer_language>();
            foreach(Language l in languages)
            {
                if (l.IsSelected == true)
                {
                    volunteer_language vl = new volunteer_language();
                    vl.id_volunteer = volunteerId;
                    vl.code_language = l.code_language;
                    vlList.Add(vl);

                }
            }
            return vlList;

        }

        public static volunteer convertvolunteerentitytovolunteertable(Volunteer v)
        {

            volunteer v1 = new volunteer()
            {
                id_volunteer = v.id_volunteer,
                firstName_volunteer = v.firstName_volunteer,
                lastName_volunteer = v.lastName_volunteer,
                date_of_birth = v.date_of_birth,
                code_gender = v.code_gender,
                code_status = v.code_status,
                code_city = v.code_city,
                street = v.street,
                house_number = v.house_number,
                bulding_number = v.bulding_number,
                postal_code = v.postal_code,
                e_mail = v.e_mail,
                code_service = v.code_service,
                number_floor = v.number_floor,
                phone = v.phone,
                password = v.password,
                release_date = v.release_date
            };
            return v1;
        }
        public static List<Volunteer> convertvolunteertabletolistvolunteerentity(List<volunteer> vl)
        {
            List<Volunteer> v1 = new List<Volunteer>();
            foreach (var item in vl)
            {
                v1.Add(convertvolunteertabletovolunteerentity(item));
            }
            return v1;
        }
        public static List<volunteer> convertvolunteerentitytolistvolunteertable(List<Volunteer> vl)
        {
            List<volunteer> v1 = new List<volunteer>();
            foreach (var item in vl)
            {
                v1.Add(convertvolunteerentitytovolunteertable(item));
            }
            return v1;
        }
    }
}
        
    


