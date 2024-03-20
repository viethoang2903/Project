using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(string ID);
        Student GetStudentByName(string Name);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(string ID);
    }
}
