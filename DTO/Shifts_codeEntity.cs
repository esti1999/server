using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Shifts_codeEntity
    {
        public int code_shifts { get; set; }
        public string name_shifts { get; set; }



        public static Shifts_codeEntity ConvertShifts_codeTableToShifts_codeEntity(shifts_code_ shifts_Code)
        {
            Shifts_codeEntity shifts_Code1 = new Shifts_codeEntity
            {
                code_shifts = shifts_Code.code_shifts,
                name_shifts = shifts_Code.name_shifts
            };
            return shifts_Code1;
        }


        public static shifts_code_ ConvertShifts_codeEntityToShifts_codeTable(Shifts_codeEntity shifts_Code)
        {
            shifts_code_ shifts_Code1 = new shifts_code_
            {
                code_shifts = shifts_Code.code_shifts,
                name_shifts = shifts_Code.name_shifts
            };
            return shifts_Code1;
        }


        public static List<Shifts_codeEntity> ConvertShifts_codeTableToListShifts_codeEntity(List<shifts_code_> shifts_Codes)
        {
            List<Shifts_codeEntity> shifts_Codes1 = new List<Shifts_codeEntity>();
            foreach(var item in shifts_Codes)
            {
                shifts_Codes1.Add(ConvertShifts_codeTableToShifts_codeEntity(item));
            }
            return shifts_Codes1;
        }


        public static List<shifts_code_> ConvertShifts_codeEntityToListShifts_codeTable(List<Shifts_codeEntity> shifts_Codes)
        {
            List<shifts_code_> shifts_Codes1 = new List<shifts_code_>();
            foreach (var item in shifts_Codes)
            {
                shifts_Codes1.Add(ConvertShifts_codeEntityToShifts_codeTable(item));
            }
            return shifts_Codes1;
        }
    }
}
