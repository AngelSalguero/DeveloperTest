using ProgrammingLogic.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLogic
{
    public class _02
    {
        userService userService = new userService();
        /*
         The tasks consist in building the logic whitin the getUserByGuid to return the user on the object "users" 
         that matches the requested GUID given as a parameter, if no GUID provided or no user found return an empty list
         */
        public List<User> getUserByGuid(Guid? id)
        {
            List<User> users = userService.getUsers();

            Console.WriteLine($"Searching for user with ID: {id}"); // Debugging line to see which ID is being searched since the outcome was not as expected, added this line to help trace the issue.

            if (id == null || !users.Any(u => u.id == id))
            {
                return new List<User>();
            }

            return users.Where(u => u.id == id).ToList();
        }


    }
}
