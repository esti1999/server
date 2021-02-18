﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class Personal_Information_voEntity
    {
        public int code_volunteer { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int id { get; set; }
        public int code_title { get; set; }
        public System.DateTime birth_date { get; set; }
        public int code_gender { get; set; }
        public int phone_number { get; set; }
        public int phone_type { get; set; }
        public string address { get; set; }
        public int status { get; set; }
        public string mail_address { get; set; }
        public int code_Languages { get; set; }
        public string Level_of_know { get; set; }




        public static Personal_Information_voEntity ConvertPersonal_Information_voTableToPersonal_Information_voEntity(Personal_Information_vo_ personal_Information_Vo)
        {
            Personal_Information_voEntity personal_Information_Vo1 = new Personal_Information_voEntity
            {
                code_volunteer = personal_Information_Vo.code_volunteer,
                first_name = personal_Information_Vo.first_name,
                last_name = personal_Information_Vo.last_name,
                id = personal_Information_Vo.id,
                code_title = personal_Information_Vo.code_title,
                birth_date = personal_Information_Vo.birth_date,
                code_gender = personal_Information_Vo.code_gender,
                phone_number = personal_Information_Vo.phone_number,
                phone_type = personal_Information_Vo.phone_type,
                address = personal_Information_Vo.address,
                status = personal_Information_Vo.status,
                mail_address = personal_Information_Vo.mail_address,
                code_Languages = personal_Information_Vo.code_Languages,
                Level_of_know = personal_Information_Vo.Level_of_know
            };
            return personal_Information_Vo1;
        }


        public static Personal_Information_vo_ ConvertPersonal_Information_voEntityToPersonal_Information_voTable(Personal_Information_voEntity personal_Information_Vo)
        {
            Personal_Information_vo_ personal_Information_Vo1 = new Personal_Information_vo_
            {
                code_volunteer = personal_Information_Vo.code_volunteer,
                first_name = personal_Information_Vo.first_name,
                last_name = personal_Information_Vo.last_name,
                id = personal_Information_Vo.id,
                code_title = personal_Information_Vo.code_title,
                birth_date = personal_Information_Vo.birth_date,
                code_gender = personal_Information_Vo.code_gender,
                phone_number = personal_Information_Vo.phone_number,
                phone_type = personal_Information_Vo.phone_type,
                address = personal_Information_Vo.address,
                status = personal_Information_Vo.status,
                mail_address = personal_Information_Vo.mail_address,
                code_Languages = personal_Information_Vo.code_Languages,
                Level_of_know = personal_Information_Vo.Level_of_know
            };
            return personal_Information_Vo1;
        }



        public static List<Personal_Information_voEntity> ConvertPersonal_Information_voTableToListPersonal_Information_voEntity(List<Personal_Information_vo_> personal_Information_Vos)
        {
            List<Personal_Information_voEntity> personal_Information_Vos1 = new List<Personal_Information_voEntity>();
            foreach(var item in personal_Information_Vos)
            {
                personal_Information_Vos1.Add(ConvertPersonal_Information_voTableToPersonal_Information_voEntity(item));
            }
            return personal_Information_Vos1;
        }



        public static List<Personal_Information_vo_> ConvertPersonal_Information_voEntityToListPersonal_Information_voTable(List<Personal_Information_voEntity> personal_Information_Vos)
        {
            List<Personal_Information_vo_> personal_Information_Vos1 = new List<Personal_Information_vo_>();
            foreach (var item in personal_Information_Vos)
            {
                personal_Information_Vos1.Add(ConvertPersonal_Information_voEntityToPersonal_Information_voTable(item));
            }
            return personal_Information_Vos1;
        }
    }
}
