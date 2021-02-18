using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Personal_statusEntity
    {
        public int code_status { get; set; }
        public string name_status { get; set; }




        public static Personal_statusEntity ConvertPersonal_statusTableToPersonal_statusEntity(personal_status personal_Status)
        {
            Personal_statusEntity personal_Status1 = new Personal_statusEntity
            {
                code_status = personal_Status.code_status,
                name_status = personal_Status.name_status
            };
            return personal_Status1;
        }


        public static personal_status ConvertPersonal_statusEntityToPersonal_statusTable(Personal_statusEntity personal_Status)
        {
            personal_status personal_Status1 = new personal_status
            {
                code_status = personal_Status.code_status,
                name_status = personal_Status.name_status
            };
            return personal_Status1;
        }



        public static List<Personal_statusEntity> ConvertPersonal_statusTableToListPersonal_statusEntity(List<personal_status> personal_Statuses)
        {
            List<Personal_statusEntity> personal_Statuses1 = new List<Personal_statusEntity>();
            foreach(var item in personal_Statuses)
            {
                personal_Statuses1.Add(ConvertPersonal_statusTableToPersonal_statusEntity(item));
            }
            return personal_Statuses1;
        }



        public static List<personal_status> ConvertPersonal_statusEntityToListPersonal_statusTable(List<Personal_statusEntity> personal_Statuses)
        {
            List<personal_status> personal_Statuses1 = new List<personal_status>();
            foreach (var item in personal_Statuses)
            {
                personal_Statuses1.Add(ConvertPersonal_statusEntityToPersonal_statusTable(item));
            }
            return personal_Statuses1;
        }
    }
}
