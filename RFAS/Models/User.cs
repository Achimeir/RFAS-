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
        public User(string userName, string userPass, string RoleName, Classification classification=Classification.None)
        {
            this.userName = userName;
            this.userPass = userPass;
            this.classification = classification;
            this.userRole = userRole;
            this.userRole = new Role(RoleName);
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
        public GuestUser(string userName, string userPass, string RoleName, Classification classification = Classification.None) : base(userName, userPass, RoleName, classification)
        {
        }
    }

    public class RegularUser : User
    {
        public RegularUser(string userName, string userPass, string RoleName, Classification classification = Classification.None, string userHashKey = null) : base(userName, userPass, RoleName, classification)
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
            // TODO
            return null;
            //return new File(null, null, FileType.Text, true, null, new User(null, null, new Role(null, null)));
        }
    }

    public class Admin : RegularUser
    {
        public Admin(string userName, string userPass, string RoleName, Classification classification = Classification.None, string userHashKey = null) :
            base(userName, userPass, RoleName, classification, userHashKey)
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
            // TODO: replace.
            return null;
            //return new File(null, null, FileType.Text, true, null, new User(null, null, new Role(null, null)));
        }

        public User createUser (string userName, string userPass, UserType type)
        {
            // TODO: replace.
            return null;
            //return new User(null, null, new Role(null, null));
        }

        public void deleteUser (User userName)
        {

        }

        public void changeAccess (Access oldAccess, Access newAccess)
        {

        }
    }
}
