using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    public class AccountPrototypeFactory
    {
        private UserAccount accountRep;
        private UserAccount supervisor;

        public AccountPrototypeFactory(UserAccount supervisorAccount, UserAccount arep)
        {
            accountRep = arep;
            supervisor = supervisorAccount;
        }

        public UserAccount getAccountRep()
        {
            return (UserAccount)accountRep.Clone();
        }

        public UserAccount getSupervisor()
        {
            return (UserAccount)supervisor.Clone();
        }
    }
}
