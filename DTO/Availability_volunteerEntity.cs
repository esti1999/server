using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Availability_volunteerEntity
    {
        public int code_volunteer { get; set; }
        public int code_days { get; set; }
        public int code_Shifts { get; set; }



       public static Availability_volunteerEntity ConvertAvailability_volunteerTableToAvailability_volunteerEntity(availability_volunteer_ availability_volunteer)
        {
            Availability_volunteerEntity availability_volunteer1 = new Availability_volunteerEntity
            {
                code_volunteer = availability_volunteer.code_volunteer,
                code_days = availability_volunteer.code_days,
                code_Shifts = availability_volunteer.code_Shifts
            };
            return availability_volunteer1;
        }



        public static availability_volunteer_ ConvertAvailability_volunteerEntityToAvailability_volunteerTable(Availability_volunteerEntity availability_volunteer)
        {
            availability_volunteer_ availability_volunteer1 = new availability_volunteer_
            {
                code_volunteer = availability_volunteer.code_volunteer,
                code_days = availability_volunteer.code_days,
                code_Shifts = availability_volunteer.code_Shifts
            };
            return availability_volunteer1;
        }



        public static List<Availability_volunteerEntity> ConvertAvailability_volunteerTableToListAvailability_volunteerEntity(List<availability_volunteer_> availability_Volunteers)
        {
            List<Availability_volunteerEntity> availability_Volunteers1 = new List<Availability_volunteerEntity>();
            foreach(var item in availability_Volunteers)
            {
                availability_Volunteers1.Add(ConvertAvailability_volunteerTableToAvailability_volunteerEntity(item));
            }
            return availability_Volunteers1;
        }



        public static List<availability_volunteer_> ConvertAvailability_volunteerTableToListAvailability_volunteerEntity(List<Availability_volunteerEntity> availability_Volunteers)
        {
            List<availability_volunteer_> availability_Volunteers1 = new List<availability_volunteer_>();
            foreach (var item in availability_Volunteers)
            {
                availability_Volunteers1.Add(ConvertAvailability_volunteerEntityToAvailability_volunteerTable(item));
            }
            return availability_Volunteers1;
        }

    }
}
