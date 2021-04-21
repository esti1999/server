using DAL;
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
        public static Assisted getBtId(string id_assisted)
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
                    assisted a1 = Assisted.convertassistedentitytoassistedtable(assisted);
                    a.code_city = a1.code_city;
                    a.code_gender = a1.code_gender;
                    a.code_status = a1.code_status;
                    a.date_birth = a1.date_birth;
                    a.e_mail = a1.e_mail;
                    a.first_name = a1.first_name;
                    a.id_assisted = a1.id_assisted;
                    a.last_name = a1.last_name;
                    a.number_building = a1.number_building;
                    a.number_floor = a1.number_floor;
                    a.number_house = a1.number_house;
                    a.password = a1.password;
                    a.phone = a1.phone;
                    a.postal_code = a1.postal_code;
                    a.street = a1.street;
                }
                else
                {
                    db.assisted.Add(Assisted.convertassistedentitytoassistedtable(assisted));
                }

                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static bool EmbededAssisted(Assisted assisted)
        {
            List<volunteer> vDomain = new List<volunteer>();
            var domainAssisted = db.assisted_domain.Where(ad => ad.id_assisted == assisted.id_assisted).ToList();
            foreach (var item in db.volunteer.ToList())
            {
                foreach (var vd in item.volunteer_domain)
                {
                    if(domainAssisted.Find(x=>x.volunteering_domain == vd.volunteering_domain) != null)
                    {
                        if (!vDomain.Contains(item))
                        {
                            vDomain.Add(item);
                        }
                    }
                }
            }

            var avalAssisted = db.assisted_availability.Where(av => av.id_assisted == assisted.id_assisted).ToList();
            foreach (var item in vDomain)
            {
                var list = db.availability_volunteer.Where(x => x.id_volunteer == item.id_volunteer).ToList();
                for (int i = 0; i < avalAssisted.Count; i++)
                {
                    if(list.Find(x=>x.code_availability == avalAssisted[i].code_availability) != null)
                    {

                        return true;
                    }
                }
            }
            return false;
            //var domaim = db.volunteer_domain
            //db.volunteer.Where(v=>v.code_volunteering_domain == )
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

        public void SendMail(volunteer volunteer, string subject, string message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient("srvExch2dag");
            mail.From = new MailAddress("EruimHarigim@szmc.org.il");
            mail.Subject = subject;
            mail.Body = message;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.To.Add("");

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
        public static List<Language> GetLanguage()
        {
            Progect_lEntities db = new Progect_lEntities();
            List<Language> list2 = new List<Language>();
            foreach (var item in db.language)
            {
                list2.Add(new Language { CodeLanguage = item.code_language, NameLanguage = item.name_language });
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
    }    
}
