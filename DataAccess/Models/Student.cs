using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Student
    {
        public int RollNumber { get; internal set; }

        public string FirstName { get; internal set; }

        public string LastName { get; internal set; }

        public int ClassID { get; internal set; }
    }
}
