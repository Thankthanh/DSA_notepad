using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = "About us";
            this.Size = new Size(300, 200);

            Label label = new Label();
            label.Text = "Members:\n- Giang Trọng Nhân\n- Đặng Xuân Nam\n -Nguyễn Minh Phước\n- Đoàn Lê Thanh Toàn\n- Nguyễn Quốc Trường\n- Nguyễn Thanh Hoài\n- Trần Thế Pháp";
            label.AutoSize = true;
            label.Location = new Point(20, 20);

            this.Controls.Add(label);
        }
    }
}
