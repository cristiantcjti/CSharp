using ByteBank.Employees;
using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Employees
{
    public abstract class AuthenticatableEmployee : Employee, IAuthenticatable
    {
        public string Password { get; set; }
        public AuthenticatableEmployee(double salary, string cpf) : base(salary, cpf)
        {

        } 
        public bool Authenticate(string password)
        {
            return Password == password;
        }

    }
}
