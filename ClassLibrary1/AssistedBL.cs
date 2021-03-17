using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AssistedBL
    {
        public static Progect_lEntities1 db = new Progect_lEntities1();
        public static List<Assisted> getall()
        {
            List<assisted> assisted = db.assisted.ToList();
            return Assisted.convertassistedtabletolistassistedentity(assisted);
        }
        public static Assisted getBtId(string id_assisted)
        {
            assisted assisted = db.assisted.FirstOrDefault(x => id_assisted == id_assisted);
            return Assisted.convertassistedtabletoassistedentity(assisted);
        }
        public static bool AddAssisted(Assisted assisted)
        {
            try
            {
                db.assisted.Add(Assisted.convertassistedentitytoassistedtable(assisted));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
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
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_language = assisted.code_language;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_status = assisted.code_status;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_help_domain = assisted.code_help_domain;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).code_city = assisted.code_city;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).postal_code = assisted.postal_code;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).street = assisted.street;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).number_building = assisted.number_building;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).number_house = assisted.number_house;
            db.assisted.FirstOrDefault(x => x.id_assisted == assisted.id_assisted).e_mail = assisted.e_mail;
            db.SaveChanges();
            return Assisted.convertassistedtabletolistassistedentity(db.assisted.ToList());
        }
        public static List<PersonalStatus> GetPersonalStatuses()
        {
            Progect_lEntities1 db = new Progect_lEntities1();
            List<PersonalStatus> list = new List<PersonalStatus>();
            foreach (var item in db.personal_status)
            {
                list.Add(new PersonalStatus { code_status = item.code_status, description = item.description });
            }
            return list;
        }
        public static List<Gender> GetGender()
        {
            Progect_lEntities1 db = new Progect_lEntities1();
            List<Gender> list1 = new List<Gender>();
            foreach (var item in db.gender)
            {
                list1.Add(new Gender { code_gender = item.code_gender, description = item.description });
            }
            return list1;
        }
    }    
}
