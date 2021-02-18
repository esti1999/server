using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Training_codeEntity
    {
        public int code_training { get; set; }
        public string name_training { get; set; }



        public static Training_codeEntity ConvertTraining_codeTableToTraining_codeEntity(training_code_ training_Code)
        {
            Training_codeEntity training_Code1 = new Training_codeEntity
            {
                code_training = training_Code.code_training,
                name_training = training_Code.name_training
            };
            return training_Code1;
        }


        public static training_code_ ConvertTraining_codeEntityToTraining_codeTable(Training_codeEntity training_Code)
        {
            training_code_ training_Code1 = new training_code_
            {
                code_training = training_Code.code_training,
                name_training = training_Code.name_training
            };
            return training_Code1;
        }



        public static List<Training_codeEntity> ConvertTraining_codeTableToListTraining_codeEntity(List<training_code_> training_Codes)
        {
            List<Training_codeEntity> training_Codes1 = new List<Training_codeEntity>();
            foreach(var item in training_Codes)
            {
                training_Codes1.Add(ConvertTraining_codeTableToTraining_codeEntity(item));
            }
            return training_Codes1;
        }


        public static List<training_code_> ConvertTraining_codeEntityToListTraining_codeTable(List<Training_codeEntity> training_Codes)
        {
            List<training_code_> training_Codes1 = new List<training_code_>();
            foreach (var item in training_Codes)
            {
                training_Codes1.Add(ConvertTraining_codeEntityToTraining_codeTable(item));
            }
            return training_Codes1;
        }
    }
}
