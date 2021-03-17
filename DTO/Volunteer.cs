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
        public int code_language { get; set; }
        public string e_mail { get; set; }
        public int code_license_car { get; set; }
        public int code_service { get; set; }
        public int code_license_weapon { get; set; }
        public int code_training { get; set; }
        public int code_volunteering_domain { get; set; }
        public int code_availability { get; set; }
        public string phone { get; set; }


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
                code_language = v.code_language,
                e_mail = v.e_mail,
                code_license_car = v.code_license_car,
                code_license_weapon = v.code_license_weapon,
                code_service = v.code_service,
                code_training = v.code_training,
                code_availability = v.code_availability,
                code_volunteering_domain = v.code_volunteering_domain

            };
            return v1;
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
                code_language = v.code_language,
                e_mail = v.e_mail,
                code_license_car = v.code_license_car,
                code_license_weapon = v.code_license_weapon,
                code_service = v.code_service,
                code_training = v.code_training,
                code_availability = v.code_availability,
                code_volunteering_domain = v.code_volunteering_domain
            };
            return v1;
        }
        public static List<Volunteer> convertvolunteertabletolistvolunteerentity(List<volunteer> vl)
        {
            List<Volunteer> v1 = new List<Volunteer>();
            foreach(var item in vl)
            {
                v1.Add(convertvolunteertabletovolunteerentity(item));
            }
            return v1;
        }
        public static List<volunteer> convertvolunteerentitytolistvolunteerentity(List<Volunteer> vl)
        {
            List<volunteer> v1 = new List<volunteer>();
            foreach(var item in vl)
            {
                v1.Add(convertvolunteerentitytovolunteertable(item));
            }
            return v1;
        }

    }
}

