using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LanguagesEntity
    {
        public int code_language { get; set; }
        public int name_language { get; set; }
        public int number_level { get; set; }


        public static LanguagesEntity ConvertLanguagesTableToLanguagesEntity(Languages languages)
        {
            LanguagesEntity languages1 = new LanguagesEntity
            {
                code_language = languages.code_language,
                name_language = languages.name_language,
                number_level = languages.number_level
            };
            return languages1;
        }



        public static Languages ConvertLanguagesEntityToLanguagesTable(LanguagesEntity languages)
        {
            Languages languages1 = new Languages
            {
                code_language = languages.code_language,
                name_language = languages.name_language,
                number_level = languages.number_level
            };
            return languages1;

        }


        public static List<LanguagesEntity> ConvertLanguagesTableToListLanguagesEntity(List<Languages> languages)
        {
            List<LanguagesEntity> languages1 = new List<LanguagesEntity>();
            foreach(var item in languages)
            {
                languages1.Add(ConvertLanguagesTableToLanguagesEntity(item));
            }
            return languages1;
        }


        public static List<Languages> ConvertLanguagesToEntityListLanguagesTable(List<LanguagesEntity> languages)
        {
            List<Languages> languages1 = new List<Languages>();
            foreach (var item in languages)
            {
                languages1.Add(ConvertLanguagesEntityToLanguagesTable(item));
            }
            return languages1;
        }
    }
}
