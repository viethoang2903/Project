using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataAccess;
using Project.Models;

namespace Project.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetStudents() => StudentDBContext.Instance.GetStudentList();

        public void AddStudent(Student student) => StudentDBContext.Instance.AddNew(student);

        public void UpdateStudent(Student student) => StudentDBContext.Instance.UpdateNew(student);
        public void DeleteStudent(string ID) => StudentDBContext.Instance.Remove(ID);

        public Student GetStudentByID(string ID) => StudentDBContext.instance.GetStudentByID(ID);

        public Student GetStudentByName(string Name) => StudentDBContext.instance.GetStudentByName(Name);


    }
}
