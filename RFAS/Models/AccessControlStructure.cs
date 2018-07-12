using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum AccessControlType
    {
        ACL,
        CList,
        AccessMatrix
    }

    class AccessControlStructure
    {
        public AccessControlStructure(List<Access> accessList, AccessControlType accessControlType)
        {
            this.accessList = accessList;
            this.accessControlType = accessControlType;
        }

        public List<Access> accessList { get; set; }
        public AccessControlType accessControlType { get; set; }

        /*TODO: fix the signature of the functions
        public Dictionary <string,(string,Access)> getCList ()
        {

        }
        public Dictionary<string, (string, Access)> getACL()
        {

        }

        public Dictionary<string,Dictionary<string,Access>> getAccessMatrix()
        {

        }*/

        public List<Access> getAccessForFile (File fileName)
        {
            return new List<Access>();
        }

        public List <Access> GetAccessForUser (User userName)
        {
            return new List<Access>();
        }

        public void addAccess (Access newAccess)
        {

        }

        public void discardAccess (Access oldAccess)
        {

        }

        public void updateAccess (Access updatedAccess)
        {

        }
    }
}
