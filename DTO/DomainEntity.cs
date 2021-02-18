using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DomainEntity
    {
        public int code_domain { get; set; }
        public string name_domain { get; set; }



        public static DomainEntity ConvertDomainTableToDomainEntity(domain Domain)
        {
            DomainEntity domain1 = new DomainEntity
            {
                code_domain = Domain.code_domain,
                name_domain = Domain.name_domain
            };
            return domain1;
        }



        public static domain ConvertDomainTableToDomainEntity(DomainEntity Domain)
        {
            domain domain1 = new domain
            {
                code_domain = Domain.code_domain,
                name_domain = Domain.name_domain
            };
            return domain1;
        }


        public static List<DomainEntity> ConvertDomainTableToListDomainEntity(List<domain> domains)
        {
            List<DomainEntity> domains1 = new List<DomainEntity>();
            foreach(var item in domains)
            {
                domains1.Add(ConvertDomainTableToDomainEntity(item));
            }
            return domains1;
        }


        public static List<domain> ConvertDomainEntityToListDomainTable(List<DomainEntity> domains)
        {
            List<domain> domains1 = new List<domain>();
            foreach (var item in domains)
            {
                domains1.Add(ConvertDomainTableToDomainEntity(item));
            }
            return domains1;
        }
    }
}
