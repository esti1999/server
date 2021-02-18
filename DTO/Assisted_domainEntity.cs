using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Assisted_domainEntity
    {
        public int code_assisted { get; set; }
        public int code_volunteering { get; set; }
        public int code_domain { get; set; }



        public static Assisted_domainEntity ConvertAssisted_domainTableToAsssisted_domainEntity(assisted_domain assisted_Domain)
        {
            Assisted_domainEntity assisted_Domain1 = new Assisted_domainEntity()
            {
                code_assisted = assisted_Domain.code_assisted,
                code_volunteering = assisted_Domain.code_volunteering,
                code_domain = assisted_Domain.code_domain
            };
            return assisted_Domain1;
        }

        public static assisted_domain ConvertAssisted_domainEntityToAssisted_domainTable(Assisted_domainEntity assisted_Domain)
        {
            assisted_domain assisted_Domain1 = new assisted_domain()
            {
                code_assisted = assisted_Domain.code_assisted,
                code_volunteering = assisted_Domain.code_volunteering,
                code_domain = assisted_Domain.code_domain
            };
            return assisted_Domain1;
        }
        public static List<Assisted_domainEntity> Convertassisted_domainTableToListAssisted_domainEntity(List<assisted_domain> assisted_Domain)
        {
            List<Assisted_domainEntity> assisted_Domain1 = new List<Assisted_domainEntity>();
            foreach (var item in assisted_Domain)
            {
                assisted_Domain1.Add(ConvertAssisted_domainTableToAsssisted_domainEntity(item));
            }
            return assisted_Domain1;

        }



        public static List<assisted_domain> Convertassisted_domainEntityToListAssisted_domainTable(List<Assisted_domainEntity> assisted_Domain)
        {
            List<assisted_domain> assisted_Domain1 = new List<assisted_domain>();
            foreach (var item in assisted_Domain)
            {
                assisted_Domain1.Add(ConvertAssisted_domainEntityToAssisted_domainTable(item));
            }
            return assisted_Domain1;

        }


    }




}
