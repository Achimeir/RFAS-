using System;
using System.Security.Cryptography;


namespace Models
{
    // Enumeration for representing the user types.
    public enum UserType
    {
        Guest,Regular,Admin
    }

    /* This class represents a user in the system. 
     * Each user contains the following:
     * User name, User password, Role name, Classification and AES Keys and IV byte array
     * generated uniquely for each user */

    public class User
    {
        public User(string userName, string userPass, string RoleName, Classification classification=Classification.None)
        {
            this.userName = userName;
            this.userPass = userPass;
            this.classification = classification;
            this.userRole = new Role(RoleName);
            this.userKeys = AESEncryptionWrapper.getInstance().generateKeyAndVector();
        }


        public string userName { get; set; }
        public string userPass { get; set; }
        public Classification classification { get; set; }
        public Role userRole { get; set; }
        public Tuple<byte[], byte[]> userKeys { get; set; }
        
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
    }

    public class Admin : RegularUser
    {
        public Admin(string userName, string userPass, string RoleName, Classification classification = Classification.None, string userHashKey = null) :
            base(userName, userPass, RoleName, classification, userHashKey)
        {
        }

    }
}
