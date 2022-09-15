using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    interface DisplayInterface
    {
        void displayMenu();
        void showMenu1(List<Experience> exp);
        void showMenu2(List<Education> edu, List<Training> train);
        void showMenu3(List<String> skills);
        void showMenu4(List<String> techSkills);
        void showMenu5(List<String> contactDetails);


    }
}
