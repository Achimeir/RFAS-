using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        public Role(string roleName, AccessType roleAccessType, List<File> roleFilesList)
        {
            this.roleName = roleName;
            this.roleAccessType = roleAccessType;
            this.roleFilesList = roleFilesList;
        }

        public string roleName { get; set; }
        public AccessType roleAccessType { get; set; }
        public List<File> roleFilesList { get; set; }

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
