using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class DomainBL
    {
        public static projectEntities db = new projectEntities();
        public static List<DomainEntity> GetDomainsList()
        {
            List<domain> domain = db.domain.ToList();
            return DomainEntity.ConvertDomainTableToListDomainEntity(domain);
        }
        public static DomainEntity getBtId(int code_domain)
        {
            domain domain = db.domain.FirstOrDefault(x => code_domain == code_domain);
            return DomainEntity.ConvertDomainTableToDomainEntity(domain);
        }
        public static List<DomainEntity> AddDomain(DomainEntity domain)
        {
            db.domain.Add(DomainEntity.ConvertDomainEntityToDomainTable(domain));
            db.SaveChanges();
            return DomainEntity.ConvertDomainTableToListDomainEntity(db.domain.ToList());
        }
        public static List<DomainEntity> RemoveDomain(int code_domaim)
        {
            db.domain.Remove(db.domain.FirstOrDefault(x => x.code_domain == code_domaim));
            db.SaveChanges();
            return DomainEntity.ConvertDomainTableToListDomainEntity(db.domain.ToList());
        }
        public static List<DomainEntity> EditDomain(DomainEntity domain)
        {
            db.domain.FirstOrDefault(x => x.code_domain == domain.code_domain).name_domain = domain.name_domain;
            db.SaveChanges();
            return DomainEntity.ConvertDomainTableToListDomainEntity(db.domain.ToList());
        }
        public static List<VolunteeringEntity> GetVolunteeringByDomain(int code_domain)
        {
            List <volunteering> volunteerings =db.volunteering.Where(x => x.code_domain == code_domain).ToList();
            return VolunteeringEntity.ConvertvolunteeringTableToListVolunteeringEntity(volunteerings);
        }
    }
}
