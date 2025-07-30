using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FindForm : Form
    {
        private RichTextBox _richTextBox;
        public FindForm(RichTextBox richTextBox)
        {
            InitializeComponent();
            _richTextBox = richTextBox;

            this.FormClosed += FindForm_FormClosed;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxFind.Text;
            int start = 0;
            int last = _richTextBox.Text.LastIndexOf(keyword);

            // Bỏ highlight cũ
            _richTextBox.SelectAll();
            _richTextBox.SelectionBackColor = Color.White;

            // Highlight các kết quả tìm được
            while (start <= last && start != -1)
            {
                int index = _richTextBox.Find(keyword, start, RichTextBoxFinds.MatchCase);
                if (index == -1) break;

                _richTextBox.SelectionBackColor = Color.Yellow;
                start = index + keyword.Length;
            }
        }

        private void FindForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Xóa highlight khi form đóng
            _richTextBox.SelectAll();
            _richTextBox.SelectionBackColor = Color.White;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string findText = textBoxFind.Text;
            string replaceText = textBoxReplace.Text;

            if (!string.IsNullOrEmpty(findText))
            {
                // Lưu vị trí con trỏ hiện tại
                int cursorPosition = _richTextBox.SelectionStart;

                // Thay thế tất cả chuỗi tìm thấy bằng chuỗi mới
                _richTextBox.Text = _richTextBox.Text.Replace(findText, replaceText);

                // Đặt lại vị trí con trỏ
                _richTextBox.SelectionStart = cursorPosition;
                _richTextBox.SelectionLength = 0;
            }
        }
    }
}
