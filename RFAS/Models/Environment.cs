using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Environment
    {
        public static List<User> usersList;             // User list representing the user list in the system.
        public static List<File> filesList;             // File list representing the file list in the system.

        public static List<Access> accessList;          // Access list representing the access list in the system.

        public User currentUser { get; set; }           // The current user logged in to the environment.

        public Environment(User currentUser)
        {
           this.currentUser = currentUser;       
        }

        static Environment()
        {
            // Initializing the system with 3 random users of 3 different types.
            usersList = new List<User>() { new Admin("Admin", "123456", null),
                                           new RegularUser ("Rani","12345",null),
                                           new GuestUser ("Guest","1234",null)};
            filesList = new List<File>();
            accessList = new List<Access>();
        }
    }
}
