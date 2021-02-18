using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Type_carsEntity
    {
        public int code_type { get; set; }
        public string name_type { get; set; }



        public static Type_carsEntity ConvertType_carsTableToType_carsEntity(type_cars type_Cars)
        {
            Type_carsEntity type_Cars1 = new Type_carsEntity
            {
                code_type = type_Cars.code_type,
                name_type = type_Cars.name_type
            };
            return type_Cars1;
        }



        public static type_cars ConvertType_carsEntityToType_carsTable(Type_carsEntity type_Cars)
        {
            type_cars type_Cars1 = new type_cars
            {
                code_type = type_Cars.code_type,
                name_type = type_Cars.name_type
            };
            return type_Cars1;
        }


        public static List<Type_carsEntity> ConvertType_carsTableToListType_carsEntity(List<type_cars> type_Cars)
        {
            List<Type_carsEntity> type_Cars1 = new List<Type_carsEntity>();
            foreach(var item in type_Cars)
            {
                type_Cars1.Add(ConvertType_carsTableToType_carsEntity(item));
            }
            return type_Cars1;
        }


        public static List<type_cars> ConvertType_carsEntityToListType_carsTable(List<Type_carsEntity> type_Cars)
        {
            List<type_cars> type_Cars1 = new List<type_cars>();
            foreach (var item in type_Cars)
            {
                type_Cars1.Add(ConvertType_carsEntityToType_carsTable(item));
            }
            return type_Cars1;
        }
    }
}
