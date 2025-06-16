using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLogic.Util
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public Guid id { get; set; }
        public string toString(){
            return  $"Name: {this.name}, Email {this.email}, Birth Date: {this.birthDate.ToString()}";
        }
    }
}
