using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class VolunteerBL
    {
        public static Progect_lEntities1 db = new Progect_lEntities1();
        public static List<Volunteer> getall()
        {
            List<volunteer> volunteer = db.volunteer.ToList();
            return Volunteer.convertvolunteertabletolistvolunteerentity(volunteer);
        }
        public static Volunteer getBtId(string id_volunteer)
        {
            volunteer volunteer = db.volunteer.FirstOrDefault(x => id_volunteer == id_volunteer);
            return Volunteer.convertvolunteertabletovolunteerentity(volunteer);
        }
        public static bool AddVolunteer(Volunteer volunteer)
        {
            try
            {
                db.volunteer.Add(Volunteer.convertvolunteerentitytovolunteertable(volunteer));
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }
        public static List<Volunteer> RemoveVolunteer(string id_volunteer)
        {
            db.volunteer.Remove(db.volunteer.FirstOrDefault(x => x.id_volunteer == id_volunteer));
            db.SaveChanges();
            return Volunteer.convertvolunteertabletolistvolunteerentity(db.volunteer.ToList());
        }
        public static List<Volunteer> EditVolunteer(Volunteer volunteer)
        {   db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).firstName_volunteer = volunteer.firstName_volunteer;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).lastName_volunteer = volunteer.lastName_volunteer;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).date_of_birth = volunteer.date_of_birth;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_gender = volunteer.code_gender;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_language = volunteer.code_language;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_service = volunteer.code_service;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_status = volunteer.code_status;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_training = volunteer.code_training;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_availability = volunteer.code_availability;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_license_car = volunteer.code_license_car;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_license_weapon = volunteer.code_license_weapon;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_volunteering_domain = volunteer.code_volunteering_domain;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_city = volunteer.code_city;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).street = volunteer.street;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).bulding_number = volunteer.bulding_number;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).house_number = volunteer.house_number;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).postal_code = volunteer.postal_code;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).e_mail = volunteer.e_mail;
            db.SaveChanges();
            return Volunteer.convertvolunteertabletolistvolunteerentity(db.volunteer.ToList());
        }
    }
}
