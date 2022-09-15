using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Education
    {
        private String courseName;
        private List<int> year;
        private List<String> yrDesc;

        public Education(string courseName, List<int> year, List<string> yrDesc)
        {
            this.courseName = courseName;
            this.year = year;
            this.yrDesc = yrDesc;
        }


        public String getCourseName() { return courseName; }
        public List<int> getYear() { return year; }
        public List<String> getYearDesc() { return yrDesc; }

    }
}
