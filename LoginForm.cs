using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Models;
using Project.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new MyProjectContext();

                // Lấy thông tin từ các trường văn bản
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                // Tạo một đối tượng Account từ dữ liệu người dùng nhập vào
                

                // Kiểm tra xem tài khoản đã tồn tại chưa
                var existingAccount = context.Account.FirstOrDefault(a => a.Username == username && a.Password == password);

                if (existingAccount != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    // Thực hiện các hành động sau khi đăng nhập thành công
                    frmStudent frmStudent = new frmStudent();
                    frmStudent.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new MyProjectContext();

                // Lấy thông tin từ các trường văn bản
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                // Tạo một đối tượng Account từ dữ liệu người dùng nhập vào
                var account = new Account
                {
                    Username = username,
                    Password = password
                    // Thêm các thuộc tính khác của Account nếu cần
                };

                // Kiểm tra xem tài khoản đã tồn tại chưa
                var existingAccount = context.Account.FirstOrDefault(a => a.Username == username);
                if (existingAccount == null)
                {
                    // Thêm tài khoản vào cơ sở dữ liệu
                    context.Account.Add(account);
                    context.SaveChanges();
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    frmStudent frmStudent = new frmStudent();
                    //frmStudent.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        

    }
}

