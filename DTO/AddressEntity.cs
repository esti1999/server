using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class AddressEntity
    {
        public int code_address { get; set; }
        public string street { get; set; }
        public int apartment { get; set; }
        public int floor { get; set; }
        public int code_city { get; set; }
        public int postal_code { get; set; }


        public static AddressEntity ConvertAddressTableToAddressEntity(address address)
        {
            AddressEntity address1 = new AddressEntity()
            {
                code_address = address.code_address,
                street = address.street,
                apartment = address.apartment,
                floor = address.floor,
                code_city = address.code_city,
                postal_code = address.postal_code
            };
            return address1;
        }


        public static address ConvertAddressEntityToAddressTable(AddressEntity address)
        {
            address address1 = new address()
            {
                code_address = address.code_address,
                street = address.street,
                apartment = address.apartment,
                floor = address.floor,
                code_city = address.code_city,
                postal_code = address.postal_code
            };
            return address1;
        }


        public static List<AddressEntity> ConvertaddressTableToListAddressEntity(List<address> address)
        {
            List<AddressEntity> address1 = new List<AddressEntity>();
            foreach (var item in address)
            {
                address1.Add(ConvertAddressTableToAddressEntity(item));
            }
            return address1;
        }

        public static List<address> ConvertAddressEntityToListaddressTable(List<AddressEntity> address)
        {
            List<address> address1 = new List<address>();
            foreach(var item in address)
            {
                address1.Add(ConvertAddressEntityToAddressTable(item));
            }
            return address1;
        }
     
    }
}
