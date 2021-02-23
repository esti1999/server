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
        public static projectEntities db = new projectEntities();
        public static List<Personal_Information_AssistedEntity> getall()
        {
            List<Personal_Information_Assisted_> Personal_Information_Assisted = db.Personal_Information_Assisted_.ToList();
            return Personal_Information_AssistedEntity.ConvertPersonal_Information_Assisted_TableToListPersonal_Information_AssistedEntity(Personal_Information_Assisted);
        }
        public static Personal_Information_AssistedEntity getBtId(int code_Assisted)
        {
            Personal_Information_Assisted_ Personal_Information_Assisted = db.Personal_Information_Assisted_.FirstOrDefault(x => code_Assisted == code_Assisted);
            return Personal_Information_AssistedEntity.ConvertPersonal_Information_Assisted_TableToPersonal_Information_AssistedEntity(Personal_Information_Assisted);
        }
        public static bool AddAssisted(Personal_Information_AssistedEntity personal_Information_Assisted)
        {
            try
            {
                db.Personal_Information_Assisted_.Add(Personal_Information_AssistedEntity.ConvertPersonal_Information_AssistedEntityToPersonal_Information_AssistedTable(personal_Information_Assisted));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public static List<Personal_Information_AssistedEntity> RemoveAssisted(int code_Assisted)
        {
            db.Personal_Information_Assisted_.Remove(db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == code_Assisted));
            db.SaveChanges();
            return Personal_Information_AssistedEntity.ConvertPersonal_Information_Assisted_TableToListPersonal_Information_AssistedEntity(db.Personal_Information_Assisted_.ToList());
        }
        public static List<Personal_Information_AssistedEntity> EditAssisted(Personal_Information_AssistedEntity Personal_Information_Assisted)
        {
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).code_tytel = Personal_Information_Assisted.code_tytel;
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).code_gender = Personal_Information_Assisted.code_gender;
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).phone_number = Personal_Information_Assisted.phone_number;
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).phone_type = Personal_Information_Assisted.phone_type;
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).adres = Personal_Information_Assisted.adres;
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).personal_status = Personal_Information_Assisted.personal_status;
            db.Personal_Information_Assisted_.FirstOrDefault(x => x.code_Assisted == Personal_Information_Assisted.code_Assisted).code_languages = Personal_Information_Assisted.code_languages;
            db.SaveChanges();
            return Personal_Information_AssistedEntity.ConvertPersonal_Information_Assisted_TableToListPersonal_Information_AssistedEntity(db.Personal_Information_Assisted_.ToList());
        }
    }
}
