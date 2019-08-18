using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SQLDataAcess : IDataAccess
    {
        public IList<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            //Simulate access to database students
            students.Add(new Student() { RollNumber = 1, FirstName = "Swapnil", LastName = "Ghodke", ClassID = 1 });
            students.Add(new Student() { RollNumber = 1, FirstName = "Kiran", LastName = "Thokal", ClassID = 1 });
            students.Add(new Student() { RollNumber = 1, FirstName = "Amol", LastName = "Shinde", ClassID = 2 });
            students.Add(new Student() { RollNumber = 1, FirstName = "Amol", LastName = "Pawar", ClassID = 2 });
            students.Add(new Student() { RollNumber = 1, FirstName = "Kiran", LastName = "Shinde", ClassID = 3 });
            students.Add(new Student() { RollNumber = 1, FirstName = "Swapnil", LastName = "Shinde", ClassID = 3 });

            return students;
        }
    }
}
