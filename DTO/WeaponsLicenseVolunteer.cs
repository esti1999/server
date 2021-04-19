using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class WeaponsLicenseVolunteer
   {
        public int code_weapons_license_volunteer { get; set; }
        public int code_weapons_license { get; set; }
        public string id_volunteer { get; set; }
        public System.DateTime validity { get; set; }

        public static WeaponsLicenseVolunteer convertweaponslicensevolunteertabletoweaponslicensevolunteerentity(weapons_license_volunteer w)
        {
            WeaponsLicenseVolunteer w1 = new WeaponsLicenseVolunteer()
            {
                code_weapons_license_volunteer = w.code_weapons_license_volunteer,
                id_volunteer = w.id_volunteer,
                validity=w.validity

            };
            return w1;
        }
        public static weapons_license_volunteer convertweaponslicensevolunteerentitytoweaponslicensevolunteertable(WeaponsLicenseVolunteer w)
        {
            weapons_license_volunteer w1 = new weapons_license_volunteer()
            {
                code_weapons_license_volunteer = w.code_weapons_license_volunteer,
                id_volunteer = w.id_volunteer,
                validity = w.validity

            };
            return w1;
        }
        public static List<WeaponsLicenseVolunteer> convertweaponslicensevolunteertabletolistweaponslicensevolunteerentity(List<weapons_license_volunteer> wl)
        {
            List<WeaponsLicenseVolunteer> w1 = new List<WeaponsLicenseVolunteer>();
            foreach (var item in wl)
            {
                w1.Add(convertweaponslicensevolunteertabletoweaponslicensevolunteerentity(item));
            }
            return w1;
        }
        public static List<weapons_license_volunteer> convertweaponslicensevolunteerentitytolistweaponslicensevolunteertable(List<WeaponsLicenseVolunteer> wl)
        {
            List<weapons_license_volunteer> w1 = new List<weapons_license_volunteer>();
            foreach (var item in wl)
            {
                w1.Add(convertweaponslicensevolunteerentitytoweaponslicensevolunteertable(item));
            }
            return w1;
        }

    }
}
