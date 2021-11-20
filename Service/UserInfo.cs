using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class UserInfo
    {
        public User User { get; set; }
        public Contracts.IUserServiceCallback CallBack { get; set; }
    }
}
