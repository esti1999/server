using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   


    public class address_code_assistedEntity
    {
        public int id { get; set; }
        public int code_address { get; set; }
        public int code_assisted { get; set; }


        public static address_code_assistedEntity Convertaddress_code_assistedTableToaddress_code_assistedEntity(address_code_assisted_ address_Code_Assisted)
        {
            address_code_assistedEntity address_Code_Assisted1 = new address_code_assistedEntity
            {
                id = address_Code_Assisted.id,
                code_address = address_Code_Assisted.code_address,
                code_assisted = address_Code_Assisted.code_assisted
            };
            return address_Code_Assisted1;
        }



        public static address_code_assisted_ Convertaddress_code_assistedEntityToaddress_code_assistedTable(address_code_assistedEntity address_Code_Assisted)
        {
            address_code_assisted_ address_Code_Assisted1 = new address_code_assisted_
            {
                id = address_Code_Assisted.id,
                code_address = address_Code_Assisted.code_address,
                code_assisted = address_Code_Assisted.code_assisted
            };
            return address_Code_Assisted1;
        }



        public static List<address_code_assistedEntity> Convertaddress_code_assistedTableToListaddress_code_assistedEntity(List<address_code_assisted_> address_Code_Assisteds)
        {
            List<address_code_assistedEntity> address_Code_Assisteds1 = new List<address_code_assistedEntity>();
            foreach (var item in address_Code_Assisteds)
            {
                address_Code_Assisteds1.Add(Convertaddress_code_assistedTableToaddress_code_assistedEntity(item));
            }
            return address_Code_Assisteds1;
        }



        public static List<address_code_assisted_> Convertaddress_code_assistedTableToListaddress_code_assistedEntity(List<address_code_assistedEntity> address_Code_Assisteds)
        {
            List<address_code_assisted_> address_Code_Assisteds2 = new List<address_code_assisted_>();
            foreach (var item in address_Code_Assisteds)
            {
                address_Code_Assisteds2.Add(Convertaddress_code_assistedEntityToaddress_code_assistedTable(item));
            }
            return address_Code_Assisteds2;
        }

    
    }
}
