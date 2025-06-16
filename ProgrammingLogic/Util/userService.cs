using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLogic.Util
{
    public class userService
    {
        public List<User> getUsers()
        {
        //this is just raw data to mimic the behavior of a Database DO NOT UPDATE THIS LIST
            return new List<User>()
            {
                new User() { name = "John Doe", email = "John@doe.com", birthDate = new DateTime(1997, 2, 15), id = default },
                new User() { name = "Juanito Gonzales", email = "JuanGgmail.com", birthDate = new DateTime(1985, 3, 15), id = new Guid() },
                new User() { name = "Maria Torres", email = "MT@gmail.com", birthDate = new DateTime(2010, 8, 1), id = new Guid() },
                new User() { name = "Jorge Guerrero", email = "JorgeGuerrero@sitel.com", birthDate = new DateTime(2010, 8, 1), id = new Guid() },
                new User() { name = "Danilo Veguiño", email = "DaniV@Foundever.com", birthDate = new DateTime(2010, 8, 1), id = new Guid() }    ,
                new User() { name = "Felipe Castro", email = "Feli@Outlook.com", birthDate = new DateTime(2010, 8, 1), id = new Guid() }
            };
        }
    }
}
