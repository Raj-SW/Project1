using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Experience
    {
        private String cmpName;
        private String Date;
        private String jobOverview;

        public Experience(string cmpName, string date, string jobOverview)
        {
            this.cmpName = cmpName;
            this.Date = date;
            this.jobOverview = jobOverview;
        }


        public String getCmpName() { return cmpName; }
        public String getDate() { return Date; }
        public String getJobOverview() { return jobOverview; }

    }
}
