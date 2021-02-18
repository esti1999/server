using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrainingEntity
    {
        public int code_volunteer { get; set; }
        public int code_training { get; set; }
        public string rank { get; set; }



        public static TrainingEntity ConvertTrainingTableToTrainingEntity(training training)
        {
            TrainingEntity training1 = new TrainingEntity
            {
                code_volunteer = training.code_volunteer,
                code_training = training.code_training,
                rank = training.rank
            };
            return training1;
        }



        public static training ConvertTrainingEntityToTrainingTable(TrainingEntity training)
        {
            training training1 = new training
            {
                code_volunteer = training.code_volunteer,
                code_training = training.code_training,
                rank = training.rank
            };
            return training1;
        }


        public static List<TrainingEntity> ConvertTrainingTableToListTrainingEntity(List<training> trainings)
        {
            List<TrainingEntity> trainings1 = new List<TrainingEntity>();
            foreach(var item in trainings)
            {
                trainings1.Add(ConvertTrainingTableToTrainingEntity(item));
            }
            return trainings1;
        }


        public static List<training> ConvertTrainingEntityToListTrainingTable(List<TrainingEntity> trainings)
        {
            List<training> trainings1 = new List<training>();
            foreach (var item in trainings)
            {
                trainings1.Add(ConvertTrainingEntityToTrainingTable(item));
            }
            return trainings1;
        }
    }
}
