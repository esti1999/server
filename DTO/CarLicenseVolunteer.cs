using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class CarLicenseVolunteer
    {
        public int code_car_license_volunteer { get; set; }
        public int code_car_license { get; set; }
        public string id_volunteer { get; set; }
        public System.DateTime validity { get; set; }

        public static CarLicenseVolunteer convertcarlicensevolunteertabletocarlicensevolunteerentity(car_license_volunteer c)
        {
            CarLicenseVolunteer c1 = new CarLicenseVolunteer()
            {
                code_car_license=c.code_car_license,
                code_car_license_volunteer=c.code_car_license_volunteer,
                id_volunteer=c.id_volunteer,
                validity=c.validity
            };
            return c1;
        }

        public static car_license_volunteer convertcarlicensevolunteerentitytocarlicensevolunteertable(CarLicenseVolunteer c)
        {
            car_license_volunteer c1 = new car_license_volunteer()
            {
                code_car_license = c.code_car_license,
                code_car_license_volunteer = c.code_car_license_volunteer,
                id_volunteer = c.id_volunteer,
                validity = c.validity
            };
            return c1;
        }

        public static List<CarLicenseVolunteer> convertcarlicensevolunteertabletolistcarlicensevolunteerentity(List<car_license_volunteer> cl)
        {
            List<CarLicenseVolunteer> c1 = new List<CarLicenseVolunteer>();
            foreach (var item in cl)
            {
                c1.Add(convertcarlicensevolunteertabletocarlicensevolunteerentity(item));
            }
            return c1;
        }
        public static List<car_license_volunteer> convertcarlicensevolunteerentitytolistcarlicensevolunteertable(List<CarLicenseVolunteer> cl)
        {
            List<car_license_volunteer> c1 = new List<car_license_volunteer>();
            foreach (var item in cl)
            {
                c1.Add(convertcarlicensevolunteerentitytocarlicensevolunteertable(item));
            }
            return c1;
        }
    }
}
