using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Langueges_assisted_codeEntity
    {
        public int id { get; set; }
        public int code_langueges { get; set; }
        public int code_assisted { get; set; }


        public static Langueges_assisted_codeEntity ConvertLangueges_assisted_codeTableToLangueges_assisted_codeEntity(langueges_assisted_code_ langueges_Assisted_Code)
        {
            Langueges_assisted_codeEntity langueges_Assisted_Code1 = new Langueges_assisted_codeEntity
            {
                id = langueges_Assisted_Code.id,
                code_langueges = langueges_Assisted_Code.code_langueges,
                code_assisted = langueges_Assisted_Code.code_assisted
            };
            return langueges_Assisted_Code1;
        }



        public static langueges_assisted_code_ ConvertLangueges_assisted_codeEntityToLangueges_assisted_codeTable(Langueges_assisted_codeEntity langueges_Assisted_Code)
        {
            langueges_assisted_code_ langueges_Assisted_Code1 = new langueges_assisted_code_
            {
                id = langueges_Assisted_Code.id,
                code_langueges = langueges_Assisted_Code.code_langueges,
                code_assisted = langueges_Assisted_Code.code_assisted
            };
            return langueges_Assisted_Code1;
        }


        public static List<Langueges_assisted_codeEntity> ConvertLangueges_assisted_codeTableToListLangueges_assisted_codeEntity(List<langueges_assisted_code_> langueges_Assisted_Codes)
        {
            List<Langueges_assisted_codeEntity> langueges_Assisted_Codes1 = new List<Langueges_assisted_codeEntity>();
            foreach(var item in langueges_Assisted_Codes)
            {
                langueges_Assisted_Codes1.Add(ConvertLangueges_assisted_codeTableToLangueges_assisted_codeEntity(item));
            }
            return langueges_Assisted_Codes1;
        }


        public static List<langueges_assisted_code_> ConvertLangueges_assisted_codeEntityToListLangueges_assisted_codeTable(List<Langueges_assisted_codeEntity> langueges_Assisted_Codes)
        {
            List<langueges_assisted_code_> langueges_Assisted_Codes1 = new List<langueges_assisted_code_>();
            foreach (var item in langueges_Assisted_Codes)
            {
                langueges_Assisted_Codes1.Add(ConvertLangueges_assisted_codeEntityToLangueges_assisted_codeTable(item));
            }
            return langueges_Assisted_Codes1;
        }
    }
}
