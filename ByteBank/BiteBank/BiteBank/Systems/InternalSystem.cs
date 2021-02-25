using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Systems
{
    public class InternalSystem
    {
        public bool Login (IAuthenticatable employee, string password)
        {
            bool userAuthorization = employee.Authenticate(password);

            if (userAuthorization)
            {
                Console.WriteLine("Welcome to the internal system!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Password!");
                return false;
            }
        }
    }
}
