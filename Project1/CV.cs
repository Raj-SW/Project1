using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class CV:DisplayInterface
    {
        private String intro;
        private List<Experience> listExperience= new List<Experience>();
        private List<Education> listEducation= new List<Education>();
        private List<Training> listTraining= new   List<Training>();
        private List<String> skills = new List<string>();
        private List<String> techSkills = new List<string>();
        private List<String> contactDetails= new List<string>();

        private List<CV> listCV= new List<CV>();

        public  CV(string intro, List<Experience> listExperience, List<Education> listEducation, List<Training> listTraining, List<String> skills, List<String> techSkills, List<String> contactDetails)
        {
            this.intro = intro;
            this.listExperience = listExperience;
            this.listEducation = listEducation;
            this.listTraining = listTraining;
            this.skills=skills;
            this.techSkills=techSkills;
            this.contactDetails = contactDetails;
        }

        public String getIntro() { return intro; }
        public List<Experience> getExp() { return listExperience; }
        public List<Training> getTraining() { return listTraining; }
        public List<Education> getEducation() { return listEducation; }


    }
}
