using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Requests_for_helpEntity
    {
        public int code_Assisted { get; set; }
        public int code_volunteering { get; set; }
        public System.DateTime date { get; set; }
        public int code_shifts { get; set; }
        public string day { get; set; }
        public string Urgency_level { get; set; }
        public string tenure { get; set; }



        public static Requests_for_helpEntity ConvertRequests_for_helpTableToRequests_for_helpEntity(Requests_for_help requests_For_Help)
        {
            Requests_for_helpEntity requests_For_Help1 = new Requests_for_helpEntity
            {
                code_Assisted = requests_For_Help.code_Assisted,
                code_volunteering = requests_For_Help.code_volunteering,
                date = requests_For_Help.date,
                code_shifts = requests_For_Help.code_shifts,
                day = requests_For_Help.day,
                Urgency_level = requests_For_Help.Urgency_level,
                tenure = requests_For_Help.tenure
            };
            return requests_For_Help1;
        }



        public static Requests_for_help ConvertRequests_for_helpEntityToRequests_for_helpTable(Requests_for_helpEntity requests_For_Help)
        {
            Requests_for_help requests_For_Help1 = new Requests_for_help
            {
                code_Assisted = requests_For_Help.code_Assisted,
                code_volunteering = requests_For_Help.code_volunteering,
                date = requests_For_Help.date,
                code_shifts = requests_For_Help.code_shifts,
                day = requests_For_Help.day,
                Urgency_level = requests_For_Help.Urgency_level,
                tenure = requests_For_Help.tenure
            };
            return requests_For_Help1;
        }



        public static List<Requests_for_helpEntity> ConvertRequests_for_helpTableToListRequests_for_helpEntity(List<Requests_for_help> requests_For_Helps)
        {
            List<Requests_for_helpEntity> requests_For_Helps1 = new List<Requests_for_helpEntity>();
            foreach(var item in requests_For_Helps)
            {
                requests_For_Helps1.Add(ConvertRequests_for_helpTableToRequests_for_helpEntity(item));
            }
            return requests_For_Helps1;
        }



        public static List<Requests_for_help> ConvertRequests_for_helpEntityToListRequests_for_helpTable(List<Requests_for_helpEntity> requests_For_Helps)
        {
            List<Requests_for_help> requests_For_Helps1 = new List<Requests_for_help>();
            foreach (var item in requests_For_Helps)
            {
                requests_For_Helps1.Add(ConvertRequests_for_helpEntityToRequests_for_helpTable(item));
            }
            return requests_For_Helps1;
        }

    }
}
