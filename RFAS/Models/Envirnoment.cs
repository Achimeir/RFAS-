using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Envirnoment
    {
        public Envirnoment(List<User> usersList, User new_currentUser, AccessControlStructure accessModel, List<Access> accessList)
        {
            this.usersList = usersList;
            currentUser = new_currentUser;
            this.accessModel = accessModel;
            this.accessList = accessList;
        }

        public List<User> usersList { get; set; }
        public static User currentUser { get; set; }
        public AccessControlStructure accessModel { get; set; }
        public List <Access> accessList { get; set; }
        public List<File> filesList { get; set; }

        public void login (string userName, string userPass)
        {

        }

        public void logout ()
        {

        }

        public List<string> getUsersNames ()
        {
            return new List<string>();
        }



    }
}
