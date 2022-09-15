using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Training
    {
        private String trainingName;
        private String trainingDesc;

        public Training(string trainingName, string trainingDesc)
        {
            this.trainingName = trainingName;
            this.trainingDesc = trainingDesc;
        }

        public String getTrainingName() { return trainingName; }
        public String getTrainingDesc() { return trainingDesc; }
    }
}
