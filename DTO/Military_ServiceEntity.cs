using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Military_ServiceEntity
    {
        public int code_service { get; set; }
        public int code_volunteer { get; set; }
        public System.DateTime Release_Date { get; set; }
        public string rank { get; set; }

    
        public static Military_ServiceEntity ConvertMilitary_ServiceTableToMilitary_ServiceEntity(Military_Service military_Service)
        {
            Military_ServiceEntity military_Service1 = new Military_ServiceEntity
            {
                code_service = military_Service.code_service,
                code_volunteer = military_Service.code_volunteer,
                Release_Date = military_Service.Release_Date,
                rank = military_Service.rank

            };
            return military_Service1;
        }

        public static Military_Service ConvertMilitary_ServiceEntityToMilitary_ServiceTable(Military_ServiceEntity military_Service)
        {
            Military_Service military_Service1 = new Military_Service
            {
                code_service = military_Service.code_service,
                code_volunteer = military_Service.code_volunteer,
                Release_Date = military_Service.Release_Date,
                rank = military_Service.rank

            };
            return military_Service1;
        }


        public static List<Military_ServiceEntity> ConvertMilitary_ServiceTableToListMilitary_ServiceEntity(List<Military_Service> military_Services)
        {
            List<Military_ServiceEntity> military_Services1 = new List<Military_ServiceEntity>();
            foreach(var item in military_Services)
            {
                military_Services1.Add(ConvertMilitary_ServiceTableToMilitary_ServiceEntity(item));

            }
            return military_Services1;
        }


        public static List<Military_Service> ConvertMilitary_ServiceEntityToListMilitary_ServiceTable(List<Military_ServiceEntity> military_Services)
        {
            List<Military_Service> military_Services1 = new List<Military_Service>();
            foreach (var item in military_Services)
            {
                military_Services1.Add(ConvertMilitary_ServiceEntityToMilitary_ServiceTable(item));

            }
            return military_Services1;
        }
    }
  
}
