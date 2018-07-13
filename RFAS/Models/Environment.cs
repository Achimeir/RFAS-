using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Environment
    {
        public Environment(AccessControlStructure accessModel, List<Access> accessList, string currentUser=null, List<User> newUsersList = null)
        {
            this.accessModel = accessModel;
            this.accessList = accessList;
            this.currentUser = currentUser;
            if (usersList==null)
            {
                usersList = new List<User>() { new Admin("Admin", "123456", null) };
            }
        }

        public static List<User> usersList = new List<User>() { new Admin("Admin", "123456", null),
                                                                new RegularUser ("Rani","12345",null),
                                                                new GuestUser ("Guest","1234",null)};
        
        public string currentUser { get; set; }
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
