using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class Phone_typeEntity
    {
        public int code_type { get; set; }
        public string name_type { get; set; }


        public static Phone_typeEntity ConvertPhone_typeTableToPhone_typeEntity(Phone_type phone_type)
        {
            Phone_typeEntity phone_Type1 = new Phone_typeEntity
            {
                code_type = phone_type.code_type,
                name_type = phone_type.name_type
            };
            return phone_Type1;
        }

        public static Phone_type ConvertPhone_typeEntityToPhone_typeTable(Phone_typeEntity phone_type)
        {
            Phone_type phone_Type1 = new Phone_type
            {
                code_type = phone_type.code_type,
                name_type = phone_type.name_type
            };
            return phone_Type1;
        }



        public static List<Phone_typeEntity> ConvertPhone_typeTableToListPhone_typeEntity(List<Phone_type> phone_Types)
        {
            List<Phone_typeEntity> phone_Types1 = new List<Phone_typeEntity>();
            foreach(var item in phone_Types)
            {
                phone_Types1.Add(ConvertPhone_typeTableToPhone_typeEntity(item));
            }
            return phone_Types1;
        }



        public static List<Phone_type> ConvertPhone_typeEntityToListPhone_typeTable(List<Phone_typeEntity> phone_Types)
        {
            List<Phone_type> phone_Types1 = new List<Phone_type>();
            foreach (var item in phone_Types)
            {
                phone_Types1.Add(ConvertPhone_typeEntityToPhone_typeTable(item));
            }
            return phone_Types1;
        }

    }

}
