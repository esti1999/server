﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BL
{ 
    public class AssistedBL
    {
        public static Progect_lEntities db = new Progect_lEntities();
        public static List<Assisted> getall()
        {
            List<assisted> assisted = db.assisted.ToList();
            return Assisted.convertassistedtabletolistassistedentity(assisted);
        }
        public static Assisted getById(string id_assisted)
        {
            assisted assisted = db.assisted.FirstOrDefault(x => x.id_assisted == id_assisted);
            return Assisted.convertassistedtabletoassistedentity(assisted);
        }
        public static bool AddAssisted(Assisted assisted)
        {
            try
            {
                assisted a = db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted);
                if (a != null)
                {
                    if (assisted.languages != null)
                    {
                        List<assisted_language> lList = new List<assisted_language>();
                        List<assisted_language> alList = db.assisted_language.Where(x => x.id_assisted == assisted.id_assisted).ToList();
                        foreach (Language item in assisted.languages)
                        {
                            if (item.IsSelected == true)
                            {
                                assisted_language temp = alList.FirstOrDefault(x => x.id_assisted == assisted.id_assisted && x.code_language == item.code_language);
                                if (temp == null)
                                {
                                    assisted_language al = new assisted_language();
                                    al.id_assisted = assisted.id_assisted;
                                    al.code_language = item.code_language;
                                    lList.Add(al);
                                }
                                else
                                    alList.Remove(temp);
                            }
                        }
                        foreach (assisted_language item in lList)
                        {
                            db.assisted_language.Add(item);
                        }
                        foreach (assisted_language item in alList)
                        {
                            db.assisted_language.Remove(item);
                        }
                    }

                    List<assisted_domain> dList = new List<assisted_domain>();
                    List<assisted_domain> adList = db.assisted_domain.Where(x => x.id_assisted == assisted.id_assisted).ToList();
                    if (assisted.volunteeringdomains != null)
                    {
                        foreach (VolunteeringDomain item in assisted.volunteeringdomains)
                        {
                            assisted_domain temp = adList.FirstOrDefault(x => x.id_assisted == assisted.id_assisted && x.code_volunteering == item.code_volunteering);
                            if (temp == null)
                            {
                                assisted_domain ad = new assisted_domain();
                                ad.id_assisted = assisted.id_assisted;
                                ad.code_volunteering = item.code_volunteering;
                                dList.Add(ad);
                            }
                            else
                                adList.Remove(temp);
                        }
                        foreach (assisted_domain item in dList)
                        {
                            db.assisted_domain.Add(item);
                        }
                        foreach (assisted_domain item in adList)
                        {
                            db.assisted_domain.Remove(item);
                        }
                    }
                    if (assisted.availabilitys != null)
                    {
                        List<assisted_availability> aList = new List<assisted_availability>();
                        List<assisted_availability> aaList = db.assisted_availability.Where(x => x.id_assisted == assisted.id_assisted).ToList();
                        foreach (Availability item in assisted.availabilitys)
                        {
                            if (item.IsSelected == true)
                            {
                                assisted_availability temp = aaList.FirstOrDefault(x => x.id_assisted == assisted.id_assisted && x.code_availability == item.code_availability);
                                if (temp == null)
                                {
                                    assisted_availability av = new assisted_availability();
                                    av.id_assisted = assisted.id_assisted;
                                    av.code_availability = item.code_availability;
                                    aList.Add(av);
                                }
                                else
                                    aaList.Remove(temp);
                            }
                        }
                        foreach (assisted_availability item in aList)
                        {
                            db.assisted_availability.Add(item);
                        }
                        foreach (assisted_availability item in aaList)
                        {
                            db.assisted_availability.Remove(item);
                        }
                    }
                    assisted a1 = Assisted.convertassistedentitytoassistedtable(assisted);      
                    a.id_assisted = a1.id_assisted;
                    a.first_name = a1.first_name;
                    a.last_name = a1.last_name;
                    a.date_birth = a1.date_birth;
                    a.code_gender = a1.code_gender;
                    a.code_city = a1.code_city;
                    a.code_status = a1.code_status;
                    a.e_mail = a1.e_mail;
                    a.first_name = a1.first_name;
                    a.id_assisted = a1.id_assisted;
                    a.last_name = a1.last_name;
                    a.street = a1.street;
                    a.number_building = a1.number_building;
                    a.number_floor = a1.number_floor;
                    a.number_house = a1.number_house;
                    a.password = a1.password;
                    a.phone = a1.phone;
                    a.postal_code = a1.postal_code;
                }
                else
                {
                    db.assisted.Add(Assisted.convertassistedentitytoassistedtable(assisted));
                    db.SaveChanges();

                    List<assisted_language> alList = Assisted.ConvertLanguageEntityListToAssistedLanguage(assisted.languages, assisted.id_assisted);
                    foreach (assisted_language l in alList)
                    {
                        db.assisted_language.Add(l);
                    }

                    List<assisted_availability> AvailabilityList = Assisted.ConvertAvailabilityEntityListToAssistedAvailability(assisted.availabilitys, assisted.id_assisted);
                    foreach (assisted_availability al in AvailabilityList)
                    {
                        db.assisted_availability.Add(al);
                    }

                    if (assisted.volunteeringdomains != null)
                    {
                        List<assisted_domain> dList = new List<assisted_domain>();
                        foreach (VolunteeringDomain item in assisted.volunteeringdomains)
                        {
                            assisted_domain ad = new assisted_domain();
                            ad.id_assisted = assisted.id_assisted;
                            ad.code_volunteering = item.code_volunteering;
                            dList.Add(ad);
                        }
                        foreach (assisted_domain item in dList)
                        {
                            db.assisted_domain.Add(item);
                        }
                    }
                }

                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        //פונקציית שיבוץ
        public static List<Assisted> EmbededAssisteds(Volunteer volunteer)
        {
            List<assisted> assisteds = new List<assisted>();
            var domainVolunteer = db.volunteer_domain.Where(vd => vd.id_volunteer == volunteer.id_volunteer).ToList();
            foreach (var item in db.assisted.ToList())
            {
                foreach (var ad in item.assisted_domain)
                {
                    if (domainVolunteer.Find(x => x.code_volunteering == ad.code_volunteering) != null)
                    {
                        if (!assisteds.Contains(item))
                        {
                            assisteds.Add(item);
                        }
                    }
                }
            }
            var temp = new List<assisted>(assisteds);

            var avalVolunteer = db.availability_volunteer.Where(av => av.id_volunteer == volunteer.id_volunteer).ToList();
            foreach (var item in temp)
            {
                var avalAssisted = db.assisted_availability.Where(x => x.id_assisted == item.id_assisted).ToList();
                for (int i = 0; i < avalVolunteer.Count; i++)
                {
                    if (avalAssisted.Find(x => x.code_availability == avalVolunteer[i].code_availability) == null)
                    {
                        assisteds.Remove(item);
                    }
                }
            }
            var temp1 = new List<assisted>(assisteds);
            var langVolunteer = db.volunteer_language.Where(vl => vl.id_volunteer == volunteer.id_volunteer).ToList();
            foreach (var item in temp1)
            {
                var langAssisted = db.assisted_language.Where(x => x.id_assisted == item.id_assisted).ToList();
                for (int i = 0; i < langVolunteer.Count; i++)
                {
                    if (langAssisted.Find(x => x.code_language == langVolunteer[i].code_language) == null)
                    {
                        assisteds.Remove(item);
                    }
                }
            }
            assisteds = assisteds.Where(a => a.code_city == volunteer.code_city).ToList();

            return Assisted.convertassistedtabletolistassistedentity(assisteds);

            //SendMail(assisted.e_mail, "ddd", "ddd");
        }
        public static List<Assisted> RemoveAssisted(string id_assisted)
        {
            db.assisted.Remove(db.assisted.FirstOrDefault(x => x.id_assisted == id_assisted));
            db.SaveChanges();
            return Assisted.convertassistedtabletolistassistedentity(db.assisted.ToList());
        }
        public static List<Assisted> EditAssisted(Assisted assisted)
        {
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).first_name = assisted.first_name;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).last_name = assisted.last_name;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).date_birth = assisted.date_birth;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_gender = assisted.code_gender;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_status = assisted.code_status;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_city = assisted.code_city;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).postal_code = assisted.postal_code;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).street = assisted.street;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).number_building = assisted.number_building;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).number_house = assisted.number_house;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).e_mail = assisted.e_mail;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).number_floor = assisted.number_floor;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).phone = assisted.phone;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).password = assisted.password ;
            db.SaveChanges();
            return Assisted.convertassistedtabletolistassistedentity(db.assisted.ToList());
        }

        public void SendMail(string Email, string subject, string message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient("srvExch2dag");
            mail.From = new MailAddress("lielb1005@gmail.com");
            mail.Subject = subject;
            mail.Body = message;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.To.Add(Email);

            try
            {
                client.Send(mail);
            }
            catch (System.Exception ex)
            {

                Console.WriteLine("Exception caught in sendMail(): {0}", ex.ToString());
            }
            finally
            {
                client.Dispose();
            }

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
        public static List<Language> GetLanguageAssisted(string assisted_id)
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Language> list2 = new List<Language>();
            List<int> myLanguages = db.assisted_language.Where(x => x.id_assisted == assisted_id).Select(y => y.code_language).ToList();
            foreach (var item in db.language)
            {
                bool isSelected = false;
                if (myLanguages.Contains(item.code_language))
                {
                    isSelected = true;
                }
                list2.Add(new Language { code_language = item.code_language, name_language = item.name_language, IsSelected = isSelected });
            }
            return list2;
        }
        public static List<Language> GetLanguage()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Language> list2 = new List<Language>();
            foreach (var item in db.language)
            {
                list2.Add(new Language { code_language = item.code_language, name_language = item.name_language, IsSelected=false });
            }
            return list2;
        }
        public static List<City> GetCity()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<City> list3 = new List<City>();
            foreach (var item in db.city)
            {
                list3.Add(new City { code_city = item.code_city, name_city = item.name_city });
            }
            return list3;
        }
        public static List<Days> GetDays()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Days> list4 = new List<Days>();
            foreach (var item in db.days)
            {
                list4.Add(new Days { code_day = item.code_day, description = item.description });
            }
            return list4;
        }
        public static List<Shift> GetShift()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Shift> list5 = new List<Shift>();
            foreach (var item in db.shifts)
            {
                list5.Add(new Shift { code_shift = item.code_shift, description = item.description });
            }
            return list5;
        }
        public static List<VolunteeringDomain> GetVolunteeringDomain(string assisted_id)
        {
            Progect_lEntities db = new Progect_lEntities();
            List<VolunteeringDomain> ListVolunteeringDomain = new List<VolunteeringDomain>();
            List<int> myVolunteeringDomain = db.assisted_domain.Where(x => x.id_assisted == assisted_id).Select(y => y.code_volunteering).ToList();

            foreach (var item in db.volunteering_domain)
            {
                bool isSelected = false;
                if (myVolunteeringDomain.Contains(item.code_volunteering))
                {
                    isSelected = true;
                }
                ListVolunteeringDomain.Add(new VolunteeringDomain { code_domain = item.code_domain, code_volunteering = item.code_volunteering, IsSelected = isSelected });
            }
            return ListVolunteeringDomain;
        }
        public static List<Availability> GetAvailabilitys()
        {
            List<Availability> availabilitys = new List<Availability>();
            var days = db.days.ToList();
            var shifts = db.shifts.ToList();
            foreach (availability item in db.availability)
            {
                availabilitys.Add(new Availability
                {
                    code_day = item.code_day,
                    day_description = days.FirstOrDefault(x => x.code_day == item.code_day).description,
                    shift_description = shifts.FirstOrDefault(x => x.code_shift == item.code_shift).description,
                    code_shift = item.code_shift,
                    IsSelected = false
                });
            }
            return availabilitys;
        }
        public static List<Availability> GetAvailability()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Availability> lista = new List<Availability>();
            foreach (var item in db.availability)
            {
                lista.Add(new Availability { code_availability = item.code_availability, code_day = item.code_day, code_shift = item.code_shift, IsSelected = false });
            }
            return lista;
        }
        public static List<Availability> GetAvailabilityAssisted(string assisted_id)
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Availability> ListAvailabilities = new List<Availability>();
            List<int> myAvailability = db.assisted_availability.Where(x => x.id_assisted == assisted_id).Select(y => y.code_availability).ToList();

            foreach (var item in db.availability)
            {
                bool isSelected = false;
                if (myAvailability.Contains(item.code_availability))
                {
                    isSelected = true;
                }
                ListAvailabilities.Add(new Availability { code_availability = item.code_availability, code_day = item.code_day, code_shift = item.code_shift, IsSelected = isSelected });
            }
            return ListAvailabilities;
        }
    }

}    
