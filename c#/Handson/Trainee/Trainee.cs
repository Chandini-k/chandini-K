using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee
{
    class Trainee
    {
        int traineeId;
        string traineeName;
        int projectid;
        public Trainee(int traineeId,string traineeName,int projectid)
        {
            this.TraineeId = traineeId;
            this.TraineeName = traineeName;
            this.projectid = projectid;
        }

        public int TraineeId { get => traineeId; set => traineeId = value; }
        public string TraineeName { get => traineeName; set => traineeName = value; }
        public int Projectid { get => projectid; set => projectid = value; }

        public override string ToString()
        {
            return "\nId "+this.traineeId + "\nName: " + this.traineeName + "\nProject Id: " + this.projectid;
        }
    }
}
