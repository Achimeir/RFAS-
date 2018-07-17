using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        public Role(string roleName)
        {
            this.roleName = roleName;
            this.filesDict = new Dictionary<File, AccessType>();
        }

        public string roleName { get; set; }
        
        public Dictionary<File, AccessType> filesDict { get; set; }
        
        public void addFile (File file, AccessType fileAccessType)
        {
            filesDict.Add(file, fileAccessType);
        }

        public void discardFile(File file)
        {
            filesDict.Remove(file);
        }

        public void updateRole (Role newRole)
        {
            // TODO: what?
        }


    }
}
