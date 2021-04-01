using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Array_List_of_Custom_Type
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Output(int times)
        {
            string message = "";
            for (int i = 0; i < times; i++)
            {
                message += FullName + "\n";
            }
            return message;
        }

        public static void PrintUsers(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.Output(1));
            }
        }
        public static void PrintUser(User user)
        {
            Console.WriteLine("Static method. Print User");
            Console.WriteLine(user.Output(1));
        }
    }
}
