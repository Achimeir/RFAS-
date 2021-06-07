using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /* This class represents a role in for a user in the system.
       a role is consisted of file dictionary, when each file is given an accesstype.
       moreover, consisted of file to grand-deny-type. */
    public class Role
    {
        public Role(string roleName )
        {
            this.roleName = roleName;
            this.filesDict = new Dictionary<File, AccessType>();
            this.grantDenyDict = new Dictionary<File, GrantDenyType>();
        }

        public string roleName { get; set; }
        
        public Dictionary<File, AccessType> filesDict { get; set; }

        public Dictionary<File, GrantDenyType> grantDenyDict { get; set; }

        /* The function adds a new file with the given accesstype and grantdenytype. */
        public void addFile (File file, AccessType fileAccessType,GrantDenyType fileGrantDenyType = GrantDenyType.GrantDeny)
        {
            if (filesDict.ContainsKey(file))
                addAccess(file, fileAccessType, fileGrantDenyType);

            else
            {
                filesDict.Add(file, fileAccessType);
                grantDenyDict.Add(file, fileGrantDenyType);
            }
        }

        public void addAccess(File file, AccessType fileAccessType, GrantDenyType fileGrantDenyType=GrantDenyType.GrantDeny)
        {
            if (!(filesDict[file].ToString().Contains(fileAccessType.ToString()))&&(filesDict[file] != AccessType.RWD))
                    filesDict[file] = (AccessType)((int)Math.Min(((int)filesDict[file] + (int)fileAccessType), 7));
            grantDenyDict[file] = fileGrantDenyType;
        }


        // The function discards an access from the file.
        public void discardAccess(File file, AccessType fileAccessType)
        {
            if (filesDict.ContainsKey(file))
            {
                if ((filesDict[file].ToString().Contains(fileAccessType.ToString()))&&!(filesDict[file] == AccessType.None))
                    filesDict[file] = (AccessType)(Math.Max(((int)filesDict[file] - (int)fileAccessType),0));
            }
        }
        

    }
}
