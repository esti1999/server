using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Service_codeEntity
    {
        public int code_Service { get; set; }
        public string name_Service { get; set; }



        public static Service_codeEntity ConverService_codeTableToService_codeEntity(Service_code_ service_Code)
        {
            Service_codeEntity service_Code1 = new Service_codeEntity
            {
                code_Service = service_Code.code_Service,
                name_Service = service_Code.name_Service
            };
            return service_Code1;
        }



        public static Service_code_ ConverService_codeEntityToService_codeTable(Service_codeEntity service_Code)
        {
            Service_code_ service_Code1 = new Service_code_
            {
                code_Service = service_Code.code_Service,
                name_Service = service_Code.name_Service
            };
            return service_Code1;
        }



        public static List<Service_codeEntity> ConverService_codeTableToListService_codeEntity(List<Service_code_> service_Codes)
        {
            List<Service_codeEntity> service_Codes1 = new List<Service_codeEntity>();
            foreach(var item in service_Codes)
            {
                service_Codes1.Add(ConverService_codeTableToService_codeEntity(item));
            }
            return service_Codes1;
        }


        public static List<Service_code_> ConverService_codeEntityToListService_codeTable(List<Service_codeEntity> service_Codes)
        {
            List<Service_code_> service_Codes1 = new List<Service_code_>();
            foreach (var item in service_Codes)
            {
                service_Codes1.Add(ConverService_codeEntityToService_codeTable(item));
            }
            return service_Codes1;
        }
    }
}
