using Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserServiceImpl : Contracts.IUserService
    {
        static Data data;
        public void LogIn(string username, string password)
        {
            bool success = false;
            OperationContext context = OperationContext.Current;
            var callback = context.GetCallbackChannel<Contracts.IUserServiceCallback>();
            if (success)
            {
                
                ObservableCollection<ContactGroup> contactGroups = null;
                foreach(var group in contactGroups)
                {
                    foreach (var contact in group.Members)
                        if (data.OnlineUserIDs.Contains(contact.ID))
                            contact.Online = true;
                        else
                            contact.Online = false;
                            
                }
                //data.OnlineUserIDs.Add()
                //callback.OnLogInSucceeded();

                //通知所有人其上线
                foreach (var user in data.OnlineUsers)
                {
                    //user.CallBack.OnContactOnline();
                }
            }
            else
            {
                callback.OnLogInFailed("Wrong username or password");
            }
        }

        public void LogOut(int userID)
        {
            //通知所有人其下线
            foreach(var user in data.OnlineUsers)
            {
                user.CallBack.OnContactOffline(userID);
            }
        }

        public void SendMessage(int receiverID, string message)
        {
            throw new NotImplementedException();
        }

        public void SignUp(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
