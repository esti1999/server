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
                    List<volunteer_language> vlList = Volunteer.ConvertLanguageEntityListToVolenteerLanguage(volunteer.languages, volunteer.id_volunteer);


                    foreach (volunteer_language l in vlList)
                    {
                        db.volunteer_language.Add(l);
                    }
                    volunteer v1 = Volunteer.convertvolunteerentitytovolunteertable(volunteer);
                    v.bulding_number = v1.bulding_number;
                    v.code_city = v1.code_city;
                    v.code_gender = v1.code_gender;
                    v.code_service = v1.code_service;
                    v.code_status = v1.code_status;
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
                    v.street = v1.street;
                }
                else
                {
                    List<volunteer_language> vlList = Volunteer.ConvertLanguageEntityListToVolenteerLanguage(volunteer.languages, volunteer.id_volunteer);


                    foreach (volunteer_language l in vlList)
                    {
                        db.volunteer_language.Add(l);
                    }
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
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_service = volunteer.code_service;
            db.volunteer.FirstOrDefault(x => x.id_volunteer == volunteer.id_volunteer).code_status = volunteer.code_status;
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
        public static List<Days> GetDays()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Days> list4 = new List<Days>();
            foreach (var item in db.days)
            {
                list4.Add(new Days { code_day = item.code_day, description = item.description});
            }
            return list4;
        }
        public static List<Shift> GetShift()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Shift> list8 = new List<Shift>();
            foreach (var item in db.shifts)
            {
                list8.Add(new Shift { code_shift = item.code_shift, description = item.description });
            }
            return list8;
        }
        public static List<Language> GetLanguageVolunteer(string volunteer_id)
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Language> list5 = new List<Language>();
            List<int> myLanguages = db.volunteer_language.Where(x => x.id_volunteer == volunteer_id).Select(y => y.code_language).ToList();
            foreach (var item in db.language)
            {
                bool isSelected = false;
                if (myLanguages.Contains(item.code_language))
                {
                    isSelected = true;
                }
                list5.Add(new Language { code_language = item.code_language, name_language = item.name_language, IsSelected = isSelected });
            }
            return list5;
        }
        public static List<Language> GetLanguage()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Language> list5 = new List<Language>();
            foreach (var item in db.language)
            {
             
                list5.Add(new Language { code_language = item.code_language, name_language = item.name_language, IsSelected=false });
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
