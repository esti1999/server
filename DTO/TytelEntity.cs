using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TytelEntity
    {
        public int code_tytel { get; set; }
        public string name_tytel { get; set; }

        public static TytelEntity ConvertTytelTableTotytelEntity(tytel tytel)
        {
            TytelEntity tytel1 = new TytelEntity
            {
                code_tytel = tytel.code_tytel,
                name_tytel = tytel.name_tytel
            };
            return tytel1;
        }

        public static tytel ConvertTytelEntityTotytelTable(TytelEntity tytel)
        {
            tytel tytel1 = new tytel
            {
                code_tytel = tytel.code_tytel,
                name_tytel = tytel.name_tytel
            };
            return tytel1;
        }


        public static List<TytelEntity> ConvertTytelTableToListtytelEntity(List<tytel> tytels)
        {
            List<TytelEntity> tytels1 = new List<TytelEntity>();
            foreach(var item in tytels)
            {
                tytels1.Add(ConvertTytelTableTotytelEntity(item));
            }
            return tytels1;
        }


        public static List<tytel> ConvertTytelEntityToListtytelTable(List<TytelEntity> tytels)
        {
            List<tytel> tytels1 = new List<tytel>();
            foreach (var item in tytels)
            {
                tytels1.Add(ConvertTytelEntityTotytelTable(item));
            }
            return tytels1;
        }
    }
}
