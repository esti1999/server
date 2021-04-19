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
        public static Progect_lEntities db = new Progect_lEntities();
        public static List<Volunteer> getall()
        {
            List<volunteer> volunteer = db.volunteer.ToList();
            return Volunteer.convertvolunteertabletolistvolunteerentity(volunteer);
        }
        public static Volunteer getBtId(string id_volunteer)
        {
            volunteer volunteer = db.volunteer.FirstOrDefault(x => x.id_volunteer == id_volunteer);
            return Volunteer.convertvolunteertabletovolunteerentity(volunteer);
        }
        public static bool AddVolunteer(Volunteer volunteer)
        {
            try
            {
                volunteer v = db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer);
                if (v!=null)
                {
                    //v = Volunteer.convertvolunteerentitytovolunteertable(volunteer);
                    volunteer v1 = Volunteer.convertvolunteerentitytovolunteertable(volunteer);

                    v.availability_volunteer = v1.availability_volunteer;
                    v.bulding_number = v1.bulding_number;
                    v.car_license_volunteer = v1.car_license_volunteer;
                    v.code_availability = v1.code_availability;
                    v.code_city = v1.code_city;
                    v.code_gender = v1.code_gender;
                    v.code_language = v1.code_language;
                    v.code_license_car = v1.code_license_car;
                    v.code_license_weapon = v1.code_license_weapon;
                    v.code_service = v1.code_service;
                    v.code_status = v1.code_status;
                    v.code_training = v1.code_training;
                    v.code_volunteering_domain = v1.code_volunteering_domain;
                    v.date_of_birth = v1.date_of_birth;
                    v.e_mail = v1.e_mail;
                    v.firstName_volunteer = v1.firstName_volunteer;
                    v.house_number = v1.house_number;
                    v.id_volunteer = v1.id_volunteer;
                    v.lastName_volunteer = v1.lastName_volunteer;
                    v.number_floor = v1.number_floor;
                    v.password = v1.password;
                    v.phone = v1.phone;
                    v.postal_code = v1.postal_code;
                    v.release_date = v1.release_date;
                    v.services = v1.services;
                    v.street = v1.street;
                    v.training_volunteer = v1.training_volunteer;
                    v.volunteer_domain = v1.volunteer_domain;
                    v.volunteer_language = v1.volunteer_language;
                    v.weapons_license_volunteer = v1.weapons_license_volunteer;
                }
                else
                {
                    db.volunteer.Add(Volunteer.convertvolunteerentitytovolunteertable(volunteer));
                }
                db.SaveChanges();
            }

            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        //public static List<Language> GetLanguages()
        //{
        //    return db.language.ToList();
        //}

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
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).number_floor = volunteer.number_floor;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).postal_code = volunteer.postal_code;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).e_mail = volunteer.e_mail;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).phone = volunteer.phone;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).password = volunteer.password;
            db.SaveChanges();
            return Volunteer.convertvolunteertabletolistvolunteerentity(db.volunteer.ToList());
        }
        public static List<PersonalStatus> GetPersonalStatuses()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<PersonalStatus> list = new List<PersonalStatus>();
            foreach (var item in db.personal_status)
            {
                list.Add(new PersonalStatus { code_status = item.code_status, description = item.description });
            }
            return list;
        }
        public static List<Gender> GetGender()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Gender> list1 = new List<Gender>();
            foreach (var item in db.gender)
            {
                list1.Add(new Gender { code_gender = item.code_gender, description = item.description });
            }
            return list1;
        }
        public static List<CarLicense> GetCarLicense()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<CarLicense> list2 = new List<CarLicense>();
            foreach (var item in db.car_license)
            {
                list2.Add(new CarLicense { code_car_license = item.code_car_license, description = item.description });
            }
            return list2;
        }
        public static List<WeaponsLicense> GetWeaponsLicense()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<WeaponsLicense> list3 = new List<WeaponsLicense>();
            foreach (var item in db.weapons_license)
            {
                list3.Add(new WeaponsLicense { code_weapons_license = item.code_weapons_license, description = item.description });
            }
            return list3;
        }
        public static List<Availability> GetAvailability()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Availability> list4 = new List<Availability>();
            foreach (var item in db.availability)
            {
                list4.Add(new Availability { code_availability = item.code_availability, code_day = item.code_day, code_shift = item.code_shift, description = item.description });
            }
            return list4;
        }
        public static List<Language> GetLanguage()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Language> list5 = new List<Language>();
            foreach (var item in db.language)
            {
                list5.Add(new Language { CodeLanguage = item.code_language, NameLanguage = item.name_language});
            }
            return list5;
        }
        public static List<City> GetCity()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<City> list6 = new List<City>();
            foreach (var item in db.city)
            {
                list6.Add(new City { code_city = item.code_city, name_city = item.name_city });
            }
            return list6;
        }
        public static List<Services> GetServices()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Services> list7 = new List<Services>();
            foreach (var item in db.services)
            {
                list7.Add(new Services { code_service = item.code_service, description = item.description });
            }
            return list7;
        }
    }
}
