using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    class GroupDao : BaseDao
    {
        public ContactGroup GetContactGroupByUserIDAndGroupName(int userID, string groupName)
        {
            ContactGroup contactGroup = null;
            string sql = "SELECT * FROM groups WHERE user_id = " + userID + " and group_name = '" + groupName + "'";
            
            return contactGroup;
        }
    }
}
