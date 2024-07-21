using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    //View Model : Is A Class Represents The Data That Will Be Rendered In View (Html)
    internal class UserViewModel
    {
        public string? Fname {  get; set; }
        public string? Lname {  get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public static explicit operator UserViewModel (User user)
        {
            string[]? s = user?.FullName?.Split(" ");
            return new UserViewModel
            {
                Fname = s?[0] ?? string.Empty,
                Lname = s?[1] ?? string.Empty,
                Email=user?.Email??string.Empty,
                Password=user?.Password??string.Empty

            };
        }
        public override string ToString()
        {
            return $"fname : {Fname},Lname : {Lname},Email : {Email} ";
        }
    }
}
