using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class Volunteer_domainEntity
    {
        public int code_volunteer { get; set; }
        public int code_volunteering { get; set; }
        public int code_domain { get; set; }


        public static Volunteer_domainEntity ConvertVolunteer_domainTableToVolunteer_domainEntity(Volunteer_domain volunteer_Domain)
        {
            Volunteer_domainEntity volunteer_Domain1 = new Volunteer_domainEntity
            {
                code_domain = volunteer_Domain.code_domain,
                code_volunteer = volunteer_Domain.code_volunteer,
                code_volunteering = volunteer_Domain.code_volunteering
            };
            return volunteer_Domain1;
        }

        public static Volunteer_domain ConvertVolunteer_domainEntityToVolunteer_domainTable(Volunteer_domainEntity volunteer_Domain)
        {
            Volunteer_domain volunteer_Domain1 = new Volunteer_domain
            {
                code_domain = volunteer_Domain.code_domain,
                code_volunteer = volunteer_Domain.code_volunteer,
                code_volunteering = volunteer_Domain.code_volunteering
            };
            return volunteer_Domain1;
        }


        public static List<Volunteer_domainEntity> ConvertVolunteer_domainTableToListVolunteer_domainEntity(List<Volunteer_domain> volunteer_Domains)
        {
            List<Volunteer_domainEntity> volunteer_Domains1 = new List<Volunteer_domainEntity>();
            foreach(var item in volunteer_Domains)
            {
                volunteer_Domains1.Add(ConvertVolunteer_domainTableToVolunteer_domainEntity(item));
            }
            return volunteer_Domains1;
        }


        public static List<Volunteer_domain> ConvertVolunteer_domainEntityToListVolunteer_domainTable(List<Volunteer_domainEntity> volunteer_Domains)
        {
            List<Volunteer_domain> volunteer_Domains1 = new List<Volunteer_domain>();
            foreach (var item in volunteer_Domains)
            {
                volunteer_Domains1.Add(ConvertVolunteer_domainEntityToVolunteer_domainTable(item));
            }
            return volunteer_Domains1;
        }

    }

    
}
