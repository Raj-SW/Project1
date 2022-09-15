using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             String Intro = "I am a hard working, honest individual. I am a good timekeeper, always willing to learn new skills. I am friendly, helpful and polite, have a good sense of humour. I am able to work independently in busy environments and also within a team setting. I am outgoing and tactful, and able to listen effectively when solving problems.";
            List<Experience> listExperience = new List<Experience>() { new Experience("Ceridian", "2022", "Intern"), new Experience("Ceridian", "2023", "Software Developer") };
            List<Education> listEducation = new List<Education>() { new Education("BSc Software Engineering", new List<int>() { 1,2},new List<string>() { "Database\nProgramming\nEnginering Principles","Project Management\nUI Design\n"}) };
            List<Training> listTraining = new List<Training>() { new Training("Jedi","OOP, Web, SQL"), new Training("SkillsLab", "OOP, Web, SQL, Immersion") };
            List<String> skills = new List<string>() {"Leadership", "Team Player", "Problem Solver" };
            List<String> techSkills = new List<string>() {"C#","C++","Dart","JS"};
            
            List<String> contactDetails = new List<string>() {"Raj.Seetohul@ceridian.com","58342636","@Raj__SW"};
            CV myCV = new CV(Intro, listExperience,listEducation,listTraining,skills,techSkills,contactDetails);

            Console.WriteLine(myCV.getIntro());
            
            Console.WriteLine();

            myCV.displayMenu();

           
        }

   
        
    }
}
