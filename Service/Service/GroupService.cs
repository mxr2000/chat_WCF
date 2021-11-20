using Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class GroupService
    {
        public ObservableCollection<ContactGroup> GetContactGroupsByUserID(int userID)
        {
            ObservableCollection<ContactGroup> contactGroups = new ObservableCollection<ContactGroup>();

            return contactGroups;
        }

        public void AddGroup(int userID, string groupName)
        {

        }

        public void AddContactToGroup(ContactGroup contactGroup, Contact contact)
        {

        }

        public void DeleteGroup(ContactGroup contactGroup)
        {

        }

        public void MoveUserAmongGroups(int userID, ContactGroup newContactGroup)
        {

        }
    }
}
