using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
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

        public void discardAccess(File file, AccessType fileAccessType)
        {
            if (filesDict.ContainsKey(file))
            {
                if ((filesDict[file].ToString().Contains(fileAccessType.ToString()))&&!(filesDict[file] == AccessType.None))
                    filesDict[file] = (AccessType)(Math.Max(((int)filesDict[file] - (int)fileAccessType),0));
            }
        }

        public void discardFile(File file)
        {
            if (filesDict.ContainsKey(file))
                filesDict.Remove(file);
        }

        public void updateRole (Role newRole)
        {
            // TODO: what?
        }


    }
}
