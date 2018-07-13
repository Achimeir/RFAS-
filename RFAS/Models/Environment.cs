using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Environment
    {
        //public Environment(AccessControlStructure accessModel, List<Access> accessList, string currentUser=null, List<User> newUsersList = null)
        //{
        //   accessModel = accessModel;
        //    accessList = accessList;
        //    this.currentUser = currentUser;
        //    if (usersList==null)
        //   {
        //        usersList = new List<User>() { new Admin("Admin", "123456", null) };
        //    }
        //}
        public static List<User> usersList;
        public static List<File> filesList;

        public static List<Access> accessList;
        public static AccessControlStructure accessModel;

        public string currentUser { get; set; }

        public Environment(string currentUser)
        {
           this.currentUser = currentUser;       
        }

        static Environment()
        {
            usersList = new List<User>() { new Admin("Admin", "123456", null),
                                           new RegularUser ("Rani","12345",null),
                                           new GuestUser ("Guest","1234",null)};

            filesList = new List<File>() { new File("file1", "c:/temp", FileType.Text, false, null, usersList[1]) };

            accessList = new List<Access>() { new Access(usersList[1], usersList[1], filesList[0], AccessType.RWD) };

            accessModel = new AccessControlStructure(accessList, AccessControlType.AccessMatrix);
        }

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
