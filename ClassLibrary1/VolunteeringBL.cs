using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
   public class VolunteeringBL
   {
        public static projectEntities db = new projectEntities();
        public static List<VolunteeringEntity> getall()
        {
            List<volunteering> volunteering = db.volunteering.ToList();
            return VolunteeringEntity.ConvertvolunteeringTableToListVolunteeringEntity(volunteering);
        }
        public static VolunteeringEntity getBtId(int code_Volunteering)
        {
            volunteering volunteering = db.volunteering.FirstOrDefault(x => code_Volunteering == code_Volunteering);
            return VolunteeringEntity.ConvertvolunteeringTableToVolunteeringEntity(volunteering);
        }
        public static List<VolunteeringEntity> AddVolunteering(VolunteeringEntity volunteering)
        {
            db.volunteering.Add(VolunteeringEntity.ConvertVolunteeringEntityTovolunteeringTable(volunteering));
            db.SaveChanges();
            return VolunteeringEntity.ConvertvolunteeringTableToListVolunteeringEntity(db.volunteering.ToList());
        }
        public static List<VolunteeringEntity> RemoveVolunteering(int code_Volunteering)
        {
            db.volunteering.Remove(db.volunteering.FirstOrDefault(x => x.code_Volunteering == code_Volunteering));
            db.SaveChanges();
            return VolunteeringEntity.ConvertvolunteeringTableToListVolunteeringEntity(db.volunteering.ToList());
        }
        public static List<VolunteeringEntity> EditVolunteering(VolunteeringEntity volunteering)
        {
            db.volunteering.FirstOrDefault(x => x.code_Volunteering == volunteering.code_Volunteering).name_Volunteering = volunteering.name_Volunteering;
            db.volunteering.FirstOrDefault(x => x.code_Volunteering == volunteering.code_Volunteering).Details = volunteering.Details;
            db.volunteering.FirstOrDefault(x => x.code_Volunteering == volunteering.code_Volunteering).code_domain = volunteering.code_domain;

            db.SaveChanges();
            return VolunteeringEntity.ConvertvolunteeringTableToListVolunteeringEntity(db.volunteering.ToList());
        }
    }
}
