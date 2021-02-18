using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class address_code_volunteerEntity
    {
        public int id { get; set; }
        public int code_adress { get; set; }
        public int code_volunteer { get; set; }


        public static address_code_volunteerEntity Convertaddress_code_volunteerTableToaddress_code_volunteerEntity(address_code_volunteer_ address_Code_Volunteer)
        {
            address_code_volunteerEntity address_Code_Volunteer1 = new address_code_volunteerEntity
            {
                id = address_Code_Volunteer.id,
                code_adress = address_Code_Volunteer.code_adress,
                code_volunteer = address_Code_Volunteer.code_volunteer
            };
            return address_Code_Volunteer1;
        }



        public static address_code_volunteer_ Convertaddress_code_volunteerEntityToaddress_code_volunteerTable(address_code_volunteerEntity address_Code_Volunteer)
        {
            address_code_volunteer_ address_Code_Volunteer1 = new address_code_volunteer_
            {
                id = address_Code_Volunteer.id,
                code_adress = address_Code_Volunteer.code_adress,
                code_volunteer = address_Code_Volunteer.code_volunteer
            };
            return address_Code_Volunteer1;
        }



        public static List<address_code_volunteerEntity> Convertaddress_code_volunteerTableListToaddress_code_volunteerEntity(List<address_code_volunteer_> address_Code_Volunteer)
        {
            List<address_code_volunteerEntity> address_Code_Volunteer1 = new List<address_code_volunteerEntity>();
            foreach (var item in address_Code_Volunteer)
            {
                address_Code_Volunteer1.Add(Convertaddress_code_volunteerTableToaddress_code_volunteerEntity(item));
            }
            return address_Code_Volunteer1;
        }


             public static List<address_code_volunteer_> Convertaddress_code_volunteerEntityToListaddress_code_volunteerTable(List<address_code_volunteerEntity> address_Code_Volunteer)
        {
            List<address_code_volunteer_> address_code_volunteer2 = new List<address_code_volunteer_>();
            foreach (var item in address_Code_Volunteer)
            {
                address_code_volunteer2.Add(Convertaddress_code_volunteerEntityToaddress_code_volunteerTable(item));
            }
            return address_code_volunteer2;
        }


    }
}
