using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Language
   {
        public int CodeLanguage { get; set; }
        public string NameLanguage { get; set; }
        public bool Read { get; set; }
        public bool Speak { get; set; }
        public bool NativeLanguage { get; set; }


        //public static Language convertlanguagetabletolanguageentity(language l)
        //{
        //    Language l1 = new Language()
        //    {
        //        code_language = l.code_language,
        //        name_language = l.name_language
        //    };
        //    return l1;
        //}
        //public static language convertlanguageentitytolanguagetable(Language l)
        //{
        //    language l1 = new language()
        //    {
        //        code_language = l.code_language,
        //        name_language = l.name_language
        //    };
        //    return l1;
        //}
        //public static List<Language> convertvolunteertabletolistvolunteerentity(List<language> ll)
        //{
        //    List<Language> l1 = new List<Language>();
        //    foreach (var item in ll)
        //    {
        //        l1.Add(convertlanguagetabletolanguageentity(item));
        //    }
        //    return l1;
        //}
        //public static List<language> convertvolunteerentitytolistvolunteerentity(List<Language> ll)
        //{
        //    List<language> l1 = new List<language>();
        //    foreach (var item in ll)
        //    {
        //        l1.Add(convertlanguageentitytolanguagetable(item));
        //    }
        //    return l1;
        //}

        public static Language convertlanguagetabletolanguageentity(language l)
        {
            Language l1 = new Language()
            {
                CodeLanguage = l.code_language,
                NameLanguage = l.name_language
            };
            return l1;
        }
        public static language convertlanguageentitytolanguagetable(Language l)
        {
            language l1 = new language()
            {
                code_language = l.CodeLanguage,
                name_language = l.NameLanguage
            };
            return l1;
        }
        public static List<Language> convertvolunteertabletolistvolunteerentity(List<language> ll)
        {
            List<Language> l1 = new List<Language>();
            foreach (var item in ll)
            {
                l1.Add(convertlanguagetabletolanguageentity(item));
            }
            return l1;
        }
        public static List<language> convertvolunteerentitytolistvolunteertable(List<Language> ll)
        {
            List<language> l1 = new List<language>();
            foreach (var item in ll)
            {
                l1.Add(convertlanguageentitytolanguagetable(item));
            }
            return l1;
        }

    }
}
