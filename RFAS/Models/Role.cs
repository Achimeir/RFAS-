using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        public Role(string roleName, Dictionary<File, AccessType> files_dict)
        {
            this.roleName = roleName;
            this.filesDict = files_dict;
            if (this.filesDict == null)
                this.filesDict = new Dictionary<File, AccessType>();
        }

        public string roleName { get; set; }
        
        public Dictionary<File, AccessType> filesDict { get; set; }

        public void changeRoleAccessType (AccessType newRoleAccessType)
        {

        }

        public void addFile (File fileName)
        {

        }

        public void discardFile(File fileName)
        {

        }

        public void updateRole (Role newRole)
        {

        }


    }
}
