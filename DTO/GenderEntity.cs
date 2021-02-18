using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GenderEntity
    {
        public int code_gender { get; set; }
        public string name_gender { get; set; }


        public static GenderEntity ConvertGenderTableToGenderEntity(gender gender)
        {
            GenderEntity gender1 = new GenderEntity
            {
               code_gender = gender.code_gender,
               name_gender = gender.name_gender
            };
            return gender1;
        }



        public static gender ConvertGenderEntityToGenderTable(GenderEntity gender)
        {
            gender gender1 = new gender
            {
                code_gender = gender.code_gender,
                name_gender = gender.name_gender
            };
            return gender1;
        }


        public static List<GenderEntity> ConvertGenderTableToListGenderEntity(List<gender> genders)
        {
            List<GenderEntity> genders1 = new List<GenderEntity>();
            foreach(var item in genders)
            {
                genders1.Add(ConvertGenderTableToGenderEntity(item));
            }
            return genders1;
        }



        public static List<gender> ConvertGenderEntityToListGenderTable(List<GenderEntity> genders)
        {
            List<gender> genders1 = new List<gender>();
            foreach (var item in genders)
            {
                genders1.Add(ConvertGenderEntityToGenderTable(item));
            }
            return genders1;
        }
    }
}
