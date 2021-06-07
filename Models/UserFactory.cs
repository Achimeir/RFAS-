using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /* This class serves as a factory of users. given user details and user types,
     * the factory creates the requested User */
    public static class UserFactory
    {
        public static User createUser(UserType userType, string userName, string userPsw)
        {
            switch(userType)
            {
                case UserType.Admin:
                    return new Admin(userName, userPsw, null);
                case UserType.Guest:
                    return new GuestUser(userName, userPsw, null);
                case UserType.Regular:
                    return new RegularUser(userName, userPsw, null);
                default:
                    return null;
            }
        }
    }
}
