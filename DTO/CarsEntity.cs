using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CarsEntity
    {
        public int car_code { get; set; }
        public int code_volunteer { get; set; }
        public string hook { get; set; }
        public string dragged { get; set; }
        public int code_type { get; set; }


        public static CarsEntity ConvertCarsTableToCarsEntity(cars car)
        {
            CarsEntity car1 = new CarsEntity
            {
                car_code = car.car_code,
                code_volunteer = car.code_volunteer,
                hook = car.hook,
                dragged = car.dragged,
                code_type = car.code_type
            };
            return car1;
        }



        public static cars ConvertCarsEntityToCarsTable(CarsEntity car)
        {
            cars car1 = new cars
            {
                car_code = car.car_code,
                code_volunteer = car.code_volunteer,
                hook = car.hook,
                dragged = car.dragged,
                code_type = car.code_type
            };
            return car1;
        }


        public static List<CarsEntity> ConvertCarsTableToListCarsEntity(List<cars> cars)
        {
            List<CarsEntity> cars1 = new List<CarsEntity>();
            foreach(var item in cars)
            {
                cars1.Add(ConvertCarsTableToCarsEntity(item));
            }
            return cars1;
        }


        public static List<cars> ConvertCarsEntityToListCarsTable(List<CarsEntity> cars)
        {
            List<cars> cars1 = new List<cars>();
            foreach (var item in cars)
            {
                cars1.Add(ConvertCarsEntityToCarsTable(item));
            }
            return cars1;
        }

    }
}
