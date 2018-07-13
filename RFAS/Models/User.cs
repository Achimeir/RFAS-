using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum UserType
    {
        Guest,Regular,Admin
    }

    public class User
    {
        public User(string userName, string userPass, Role userRole, Classification classification=Classification.None)
        {
            this.userName = userName;
            this.userPass = userPass;
            this.classification = classification;
            this.userRole = userRole;
        }


        public string userName { get; private set; }
        public string userPass { get; set; }
        public Classification classification { get; set; }
        public Role userRole { get; set; }


        public bool checkLogin (string userName,string userPass)
        {
            return true;
        }
    }

    class GuestUser : User
    {
        public GuestUser(string userName, string userPass, Role userRole, Classification classification = Classification.None) : base(userName, userPass, userRole, classification)
        {
        }
    }

    public class RegularUser : User
    {
        public RegularUser(string userName, string userPass, Role userRole, Classification classification = Classification.None, string userHashKey = null) : base(userName, userPass, userRole, classification)
        {
            this.userHashKey = userHashKey;
        }

        public string userHashKey { get; set; }


        public void createUserHashKey(string newUserHashKey)
        {

        }

        public virtual void changeUserPass(User userName, string newUserPass)
        {

        }


        public virtual string[] readFile(File fileName)
        {
            return null;
        }

        public virtual void deleteFile(File fileName)
        {

        }

        public virtual void grantAccess(Access acc, User userName)
        {

        }

        public virtual void denyAccess(Access acc, User userName)
        {

        }

        public virtual File deHashFile(File fileName)
        {
            return new File(null, null, FileType.Text, true, null, new User(null, null, new Role(null, AccessType.None, null)));
        }
    }

    public class Admin : RegularUser
    {
        public Admin(string userName, string userPass, Role userRole, Classification classification = Classification.None, string userHashKey = null) : base(userName, userPass, userRole, classification, userHashKey)
        {
        }

        public override void changeUserPass(User userName, string newUserPass)
        {
            base.changeUserPass(userName, newUserPass);
        }

        public override File deHashFile(File fileName)
        {
            return base.deHashFile(fileName);
        }

        public File hashFile(File fileName, User userName)
        {
            return new File(null, null, FileType.Text, true, null, new User(null, null, new Role(null, AccessType.None, null)));
        }

        public User createUser (string userName, string userPass, UserType type)
        {
            return new User(null, null, new Role(null, AccessType.None, null));
        }

        public void deleteUser (User userName)
        {

        }

        public void changeAccess (Access oldAccess, Access newAccess)
        {

        }
    }
}
