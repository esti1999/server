using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Days_codeEntity
    {
        public int code_day { get; set; }
        public string name_day { get; set; }



        public static Days_codeEntity ConvertDays_codeTableToDays_codeEntity(days_code_ days_Code)
        {
            Days_codeEntity Days_code1 = new Days_codeEntity
            {
                code_day = days_Code.code_day,
                name_day = days_Code.name_day
            };
            return Days_code1;
        }


        public static days_code_ ConvertDays_codeTableToDays_codeEntity(Days_codeEntity days_Code)
        {
            days_code_ Days_code1 = new days_code_
            {
                code_day = days_Code.code_day,
                name_day = days_Code.name_day
            };
            return Days_code1;
        }



        public static List<Days_codeEntity> ConvertDays_codeTableToListDays_codeEntity(List<days_code_> days_Codes)
        {
            List<Days_codeEntity> days_Codes1 = new List<Days_codeEntity>();
            foreach (var item in days_Codes)
            {
                days_Codes1.Add(ConvertDays_codeTableToDays_codeEntity(item));
            }
            return days_Codes1;
        }


        public static List<days_code_> ConvertDays_codeEntityToListDays_codeTable(List<Days_codeEntity> days_Codes)
        {
            List<days_code_> days_Codes1 = new List<days_code_>();
            foreach (var item in days_Codes)
            {
                days_Codes1.Add(ConvertDays_codeTableToDays_codeEntity(item));
            }
            return days_Codes1;
        }
    }
}
