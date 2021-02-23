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
        public static projectEntities db = new projectEntities();
        public static List<Personal_Information_volunteerEntity> getall()
        {
            List<Personal_Information_vo_> personal_Information_Volunteer = db.Personal_Information_vo_.ToList();
            return Personal_Information_volunteerEntity.ConvertPersonal_Information_voTableToListPersonal_Information_voEntity(personal_Information_Volunteer);
        }
        public static Personal_Information_volunteerEntity getBtId(int code_Volunteer)
        {
            Personal_Information_vo_ personal_Information_Volunteer = db.Personal_Information_vo_.FirstOrDefault(x => code_Volunteer == code_Volunteer);
            return Personal_Information_volunteerEntity.ConvertPersonal_Information_voTableToPersonal_Information_voEntity(personal_Information_Volunteer);
        }
        public static bool AddVolunteer(Personal_Information_volunteerEntity personal_Information_Volunteer)
        {
            try
            {
                db.Personal_Information_vo_.Add(Personal_Information_volunteerEntity.ConvertPersonal_Information_voEntityToPersonal_Information_voTable(personal_Information_Volunteer));
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }
        public static List<Personal_Information_volunteerEntity> RemoveVolunteer(int code_volunteer)
        {
            db.Personal_Information_vo_.Remove(db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == code_volunteer));
            db.SaveChanges();
            return Personal_Information_volunteerEntity.ConvertPersonal_Information_voTableToListPersonal_Information_voEntity(db.Personal_Information_vo_.ToList());
        }
        public static List<Personal_Information_volunteerEntity> EditVolunteer(Personal_Information_volunteerEntity personal_Information_Volunteer)
        {
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).id = personal_Information_Volunteer.id;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).code_title = personal_Information_Volunteer.code_title;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).birth_date = personal_Information_Volunteer.birth_date;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).code_gender = personal_Information_Volunteer.code_gender;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).phone_number = personal_Information_Volunteer.phone_number;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).phone_type = personal_Information_Volunteer.phone_type;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).address = personal_Information_Volunteer.address;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).status = personal_Information_Volunteer.status;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).mail_address = personal_Information_Volunteer.mail_address;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).code_Languages = personal_Information_Volunteer.code_Languages;
            db.Personal_Information_vo_.FirstOrDefault(x => x.code_volunteer == personal_Information_Volunteer.code_volunteer).Level_of_know = personal_Information_Volunteer.Level_of_know;
            db.SaveChanges();
            return Personal_Information_volunteerEntity.ConvertPersonal_Information_voTableToListPersonal_Information_voEntity(db.Personal_Information_vo_.ToList());
        }
    }
}
