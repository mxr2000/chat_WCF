using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    [ServiceContract(CallbackContract = typeof(IUserServiceCallback), SessionMode = SessionMode.Required)]
    public interface IUserService
    {
        [OperationContract(IsOneWay = true)]
        void LogIn(string username, string password);
        [OperationContract(IsOneWay = true)]
        void SignUp(string username, string password);
        [OperationContract(IsOneWay = true)]
        void LogOut(int userID);
        [OperationContract(IsOneWay = true)]
        void SendMessage(int receiverID, string message);

    }
}
