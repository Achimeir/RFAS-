using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    // Enum representing the access type a user has on a file(Read/Delete/Write).
    public enum AccessType
    {
        None,
        R,
        W,
        RW,
        D,
        RD,
        WD,
        RWD       
    }

    // Enum for representing Grant/Deny permission on a file.
    public enum GrantDenyType
    {
        None,
        Deny,
        Grant,
        GrantDeny
    }
    public enum Classification
    {
        TS,
        Secret,
        Confidential,
        Restricted,
        Official,
        Unclassified,
        None
    }

    public class Access
    {
        public Access(User accessCreator, User userName, File fileName, AccessType accessType=AccessType.None, bool canGrant=true, bool canDeny=true)
        {
            this.accessCreator = accessCreator;
            this.userName = userName;
            this.fileName = fileName;
            this.accessType = accessType;
            this.canGrant = canGrant;
            this.canDeny = canDeny;
        }

        public User accessCreator { get; set; }
        public User userName { get; set; }
        public File fileName { get; set; }
        public AccessType accessType { get; set; }
        public bool canGrant { get; set; }
        public bool canDeny { get; set; }
    }
}
