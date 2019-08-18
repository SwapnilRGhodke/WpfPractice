using DataAccess;
using System.Collections.Generic;

namespace ViewModels
{
    public class StudentListViewModel
    {
        private IList<Student> students;

        public IList<Student> Students
        {
            get
            {
                return students;
            }
        }
        
        public StudentListViewModel(IDataAccess dataAccess)
        {            
            students = dataAccess.GetAllStudents();
        }
    }
}
