using Microsoft.Data.SqlClient;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project.DataAccess
{
    public class StudentDBContext : BaseDAL
    {
        // Using Singleton Pattern
        public static StudentDBContext instance = null;
        private static readonly object instanceLock = new object();
        private StudentDBContext() { }
        public static StudentDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StudentDBContext();
                    }
                    return instance;
                }
            }
        }
       
        public IEnumerable<Student> GetStudentList()
        {
            var students = new List<Student>();
            try
            {
                using var context = new MyProjectContext();
                students = context.Students.ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return students;
        }
        public Student GetStudentByName(string Name)
        {
            Student student = null;
            try
            {
                using (var context = new MyProjectContext())
                {
                    student = context.Students.FirstOrDefault(c => c.Name == Name);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving student by name: " + ex.Message);
            }
            return student;
        }

        public Student GetStudentByID(string ID)
        {
            Student student = null;
            
            try
            {
                using var context = new MyProjectContext();
                student = context.Students.SingleOrDefault(c => c.Id == ID);
              
                }
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }
        public void AddNew(Student student)
        {
            try
            {
                Student students = GetStudentByID(student.Id);
                if (students == null)
                {
                    using var context = new MyProjectContext();
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Student is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void UpdateNew(Student student)
        {
            try
            {
                Student students = GetStudentByID(student.Id);
                if (students != null)
                {
                    using var context = new MyProjectContext();
                    context.Students.Update(student);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Student is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void Remove(string ID)
        {
            try
            {
                Student student = GetStudentByID(ID);
                if (student != null)
                {
                    using var context = new MyProjectContext();
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Student does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }
}
