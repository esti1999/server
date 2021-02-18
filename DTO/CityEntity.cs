using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CityEntity
    {
        public int code_city { get; set; }
        public string name_city { get; set; }


        public static CityEntity ConvertCityTableToCityEntity(city City)
        {
            CityEntity city1 = new CityEntity
            {
                code_city = City.code_city,
                name_city = City.name_city
            };
            return city1;
        }



        public static city ConvertCityEntityToCityTable(CityEntity City)
        {
            city city1 = new city
            {
                code_city = City.code_city,
                name_city = City.name_city
            };
            return city1;
        }



        public static List<CityEntity> ConvertCityTableToListCityEntity(List<city> city)
        {
            List<CityEntity> city1 = new List<CityEntity>();
            foreach (var item in city)
            {
                city1.Add(ConvertCityTableToCityEntity(item));
            }
            return city1;
        }



        public static List<city> ConvertCityEntityToListCityTable(List<CityEntity> city)
        {
            List<city> city1 = new List<city>();
            foreach (var item in city)
            {
                city1.Add(ConvertCityEntityToCityTable(item));
            }
            return city1;
        }
    }
}
