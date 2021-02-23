using System;
using System.Collections.Generic;

namespace ManageTasks
{
    interface IAssignable
    {
        //a list with users and doers
        public List<User> Users { get; set; }

        /// <summary>
        /// Adding a user to a task. This method can be called repeatedly in order to add more than one users.
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="NullReferenceException"></exception>
        public void AddUser(User user)
        {
            if (user == null)
                throw new NullReferenceException("Null cannot be assigned as a user to a task!");
            Users.Add(user);
        }

        static string PrintMessage()
        {
            return "Het=y";
        }
    }
}