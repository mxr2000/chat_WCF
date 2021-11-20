using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnSignUpSucceeded(User user);
        [OperationContract(IsOneWay = true)]
        void OnSignUpFailed(string message);

        [OperationContract(IsOneWay = true)]
        void OnLogInSucceeded(User user, ObservableCollection<ContactGroup> contactGroups);
        [OperationContract(IsOneWay = true)]
        void OnLogInFailed(string message);

        // 联系人信息更新
        [OperationContract(IsOneWay = true)]
        void UpdateContact(Contact contact);
        //联系人上线
        [OperationContract(IsOneWay = true)]
        void OnContactOnline(int contactID);
        //联系人下线
        [OperationContract(IsOneWay = true)]
        void OnContactOffline(int contactID);


        [OperationContract(IsOneWay = true)]
        void OnReceiveMessage(int senderID, string message);
        

    }
}
