using System;
using System.Collections.Generic;

namespace Method_Array_List_of_Custom_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DoSomething();
        }
        public void DoSomething()
        {
            User user = new User();
            user.FirstName = "Krzysztof";
            user.LastName = "Bojarczuk";

            User user2 = new User();
            user2.FirstName = "Tomek";

            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user2);

            User.PrintUsers(users);
        }
    }
}
