using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tạo một class phụ để chứa dữ liệu Khóa học
        public class Course
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        // Xử lý nạp dữ liệu khi Form vừa chạy lên
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Course> listCourses = new List<Course>()
            {
                new Course() { Id = "C01", Name = "Lập trình C# cơ bản" },
                new Course() { Id = "C02", Name = "Lập trình Web ASP.NET" },
                new Course() { Id = "C03", Name = "Cơ sở dữ liệu SQL Server" }
            };

            cboCourse.DataSource = listCourses;
            cboCourse.DisplayMember = "Name"; // Hiển thị tên khóa học
            cboCourse.ValueMember = "Id";     // Lưu trữ mã khóa học ngầm
        }

        // Xử lý khi bấm nút Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text;
            string dob = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string courseName = cboCourse.Text;

            string thongTin = "XÁC NHẬN THÔNG TIN ĐĂNG KÝ:\n\n" +
                              "- Số điện thoại: " + phone + "\n" +
                              "- Ngày sinh: " + dob + "\n" +
                              "- Khóa học: " + courseName;

            MessageBox.Show(thongTin, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm này do bạn click đúp vào ComboBox sinh ra, cứ để nguyên
        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtxtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}