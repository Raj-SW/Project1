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


        public virtual void displayMenu()
        {
            int choice=0;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" 1. Show Experience");
                Console.WriteLine(" 2. Show Education/Training");
                Console.WriteLine(" 3. Show Skills");
                Console.WriteLine(" 4. Show Technology Skills");
                Console.WriteLine(" 5. Show Contact Details");
                Console.WriteLine("Enter Choice");
                Console.WriteLine();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        showMenu1(listExperience);
                        break;

                    case 2:
                        showMenu2(listEducation, listTraining);
                        break;

                    case 3: showMenu3(skills);
                        break;

                    case 4: showMenu4(techSkills);
                        break;

                    case 5:showMenu5(contactDetails);
                        break;

                }

            }

        }
        public virtual  void showMenu1(List<Experience> exp)
        {
            while (true)
            {

                int counter = 0;
                int choice = 0;

                foreach (Experience experience in exp)
                {
                    Console.WriteLine(counter + ". " + experience.getCmpName() + " " + experience.getDate());
                    counter++;
                }

                Console.WriteLine("Enter Choice. Press -1 to exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == -1)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(exp.ElementAt(choice).getJobOverview());
                Console.WriteLine();
            }


        }
        public virtual void showMenu2(List<Education> edu, List<Training> train)
        {
            while (true)
            {
                int choice = 0;

                Console.WriteLine("Press 1 to show Education");
                Console.WriteLine("Press 2 to show Training");
                Console.WriteLine("Press -1 to Go Back");
                Console.WriteLine();

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == -1)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        {
                            int choice2 = 0;

                            while (true && edu.Count > 0 && choice2 != -1)
                            {
                                Console.WriteLine("Press -1 to Go Back");

                                foreach (Education education in edu)
                                {
                                    Console.WriteLine(education.getCourseName());
                                    choice2++;
                                    foreach (int yr in education.getYear())
                                    {
                                        Console.WriteLine("Year" + (yr));

                                    }
                                }

                                Console.WriteLine("Choose education");
                                choice2 = Convert.ToInt32(Console.ReadLine());

                                if (choice2 == -1)
                                    break;

                                foreach (Education education1 in edu)
                                {
                                    foreach (int yr in education1.getYear())
                                    {
                                        if (choice2 == yr)
                                        {
                                            Console.WriteLine(education1.getYearDesc()[choice2 - 1]);
                                        }

                                    }
                                }
                            }
                        };
                        break;

                    case 2:
                        {
                            int choice2 = 0;
                            while (true && train.Count > 0 && choice2 != -1)
                            {

                                Console.WriteLine();
                                Console.WriteLine("Press -1 to Go Back");
                                Console.WriteLine();

                                foreach (Training training in train)
                                {
                                    Console.WriteLine(choice2 + " " + training.getTrainingName());
                                    choice2++;

                                }

                                Console.WriteLine();
                                Console.WriteLine("Enter Choice");
                                Console.WriteLine();

                                choice2 = Convert.ToInt32(Console.ReadLine());

                                if (choice2 == -1)
                                {
                                    break;
                                }

                                Console.WriteLine();
                                Console.WriteLine(train[choice2].getTrainingDesc());
                                Console.WriteLine();

                            }
                        };
                        break;
                    default: break;

                }

            }


        }

        public void showMenu3(List<string> skills)
        {
            throw new NotImplementedException();
        }

        public void showMenu4(List<string> techSkills)
        {
            throw new NotImplementedException();
        }

        public void showMenu5(List<string> contactDetails)
        {
            throw new NotImplementedException();
        }
    }
}
