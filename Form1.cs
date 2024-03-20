using Microsoft.IdentityModel.Tokens;
using Project.DataAccess;
using Project.Models;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project
{
    public partial class frmStudent : Form
    {
        public MyProjectContext context;
        IStudentRepository studentRepository = new StudentRepository();
        public IStudentRepository StudentRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        BindingSource source;
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var studentIdText = tbID.Text;
            if(String.IsNullOrEmpty(studentIdText) || String.IsNullOrWhiteSpace(studentIdText))
            {
                MessageBox.Show("Please enter member ID");
            }
            else
            {
                    var studentId = studentIdText;
                    var studentName = tbName.Text.ToUpper() == "" ? null : tbName.Text;
                    var studentAddress = tbAddress.Text.ToUpper() == "" ? null : tbAddress.Text;
                    decimal studentGpa =decimal.Parse( tbGPA.Text == "" ? null : tbGPA.Text);
                    studentRepository.UpdateStudent(new Student
                    {
                        Id = studentId,
                        Name = studentName,
                        Address = studentAddress,
                        Gpa = studentGpa,
                    });
                    //context.SaveChanges();
                    LoadStudentList();
            }
            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var StudentIdText = tbID.Text;
            if (String.IsNullOrEmpty(StudentIdText) || String.IsNullOrWhiteSpace(StudentIdText))
            {
                MessageBox.Show("Please enter member ID");
            }
            else
            {
                var StudentId = tbID.Text;
                var StudentName = tbName.Text.ToUpper();
                var Address = tbAddress.Text;
                var Gpa = decimal.Parse(tbGPA.Text);

                try
                {
                    Student NewMember = new Student { Id = StudentId, Name = StudentName, Address = Address, Gpa = Gpa };
                    var id = NewMember.Id;
                    StudentRepository studentRepository = new StudentRepository();
                    studentRepository.AddStudent(NewMember);

                    LoadStudentList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var student = GetStudentObject();
                studentRepository.DeleteStudent(student.Id);
                lbName.Text = student.Name;
                LoadStudentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a student");
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            //btnDelete.Enabled = false;
            //dgvListStudent.CellDoubleClick += dgvListStudent_DoubleClick;
            //Student student = StudentDBContext.Instance.GetStudentByID("HE170280");

        }
        private void ClearText()
        {
            tbID.Text = string.Empty;
            tbName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbGPA.Text = string.Empty;

        }
        private Student GetStudentObject()
        {
            Student student = null;
            try
            {
                student = new Student
                {
                    Id = tbID.Text,
                    Name = tbName.Text,
                    Address = tbAddress.Text,
                    Gpa = decimal.Parse(tbGPA.Text),

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get student");
            }
            return student;
        }
        public void LoadStudentList()
        {
            var students = studentRepository.GetStudents();
            try
            {
                source = new BindingSource();
                source.DataSource = students;

                tbID.DataBindings.Clear();
                tbName.DataBindings.Clear();
                tbAddress.DataBindings.Clear();
                tbGPA.DataBindings.Clear();


                tbID.DataBindings.Add("Text", source, "ID");
                tbName.DataBindings.Add("Text", source, "Name");
                tbAddress.DataBindings.Add("Text", source, "Address"); // Corrected field name
                tbGPA.DataBindings.Add("Text", source, "GPA");


                dgvListStudent.DataSource = null;
                dgvListStudent.DataSource = source;
                if (students.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter output = null;
            try
            {
                output = File.CreateText("Student.txt");
                foreach (DataGridViewRow row in dgvListStudent.Rows)
                {
                    // Kiểm tra xem giá trị của ô "Id" có tồn tại không
                    if (row.Cells["Id"].Value != null)
                    {
                        string studentId = row.Cells["Id"].Value.ToString();
                        string studentName = row.Cells["Name"].Value.ToString();
                        string studentAddress = row.Cells["address"].Value.ToString();
                        double GPA = Convert.ToDouble(row.Cells["GPA"].Value);

                        output.WriteLine($"Id:{studentId},Name:{studentName},Address:{studentAddress},GPA:{GPA}");
                        MessageBox.Show("Write to file successfully");
                    }                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (output != null)
                {
                    output.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchName = tbName.Text.ToUpper();
            if (String.IsNullOrWhiteSpace(searchName) || String.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a name to search");
            }
            else
            {
                var student = studentRepository.GetStudentByName(searchName);
                if (student != null)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = student;
                    dgvSearch.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("Student not found");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbID.Text = String.Empty;
            tbName.Text = String.Empty;
            tbAddress.Text = String.Empty;
            tbGPA.Text = String.Empty;
            
        }
    }
}
