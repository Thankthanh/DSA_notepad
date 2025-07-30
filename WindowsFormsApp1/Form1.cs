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
    public partial class Form1 : System.Windows.Forms.Form
    {
        private MyStack<string> undoStack = new MyStack<string>();
        private MyStack<string> redoStack = new MyStack<string>();
        private string _lastText = "";
        private bool isInternalChange = false; // Tránh lặp vô hạn khi cập nhật RichTextBox

        public Form1()
        {
            InitializeComponent();
            UpdateTextCount(); // Cập nhật số lượng từ ban đầu
            richTextBox1.TextChanged += new EventHandler(richTextBox1_TextChanged); // Gán sự kiện TextChanged
            SetupShortcuts();

        }

        private void SetupShortcuts()
        {
            // Gán phím tắt cho menu New
            menuItemNew.ShortcutKeys = Keys.Control | Keys.N;
            menuItemNew.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Open
            menuItemOpen.ShortcutKeys = Keys.Control | Keys.O;
            menuItemOpen.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Save
            menuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            menuItemSave.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Exit
            menuItemExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuItemExit.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Undo
            menuItemUndo.ShortcutKeys = Keys.Control | Keys.Z;
            menuItemUndo.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Find
            menuItemFind.ShortcutKeys = Keys.Control | Keys.F;
            menuItemFind.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Copy
            menuItemCopy.ShortcutKeys = Keys.Control | Keys.C ;
            menuItemCopy.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Cut
            menuItemCut.ShortcutKeys = Keys.Control | Keys.X;
            menuItemCut.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Paste
            menuItemPaste.ShortcutKeys = Keys.Control | Keys.V;
            menuItemPaste.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Select All
            menuItemSellectAll.ShortcutKeys = Keys.Control | Keys.A;
            menuItemSellectAll.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Date/Time
            menuItemDateTime.ShortcutKeys = Keys.F5;
            menuItemDateTime.ShowShortcutKeys = true;
            // Gán phím tắt cho menu Redo
            menuItemRedo.ShortcutKeys = Keys.Control | Keys.Y;
            menuItemRedo.ShowShortcutKeys = true;
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Da nhan Open");
            OpenFile();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Da nhan Save");
            SaveFile();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Da nhan Exit");
            Application.Exit(); // Thoát chương trình
        }

        private void menuItemUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }
        
        private void Undo()
        {
            if (!undoStack.IsEmpty)
            {
                isInternalChange = true;
                string currentText = richTextBox1.Text;
                string undoText = undoStack.Pop();
                redoStack.Push(currentText);
                richTextBox1.Text = undoText;
                _lastText = undoText; // cập nhật trạng thái cuối
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                isInternalChange = false;
            }
        }

        private void menuItemRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }
        
        private void Redo()
        {
            if (!redoStack.IsEmpty)
            {
                isInternalChange = true;
                string currentText = richTextBox1.Text;
                string redoText = redoStack.Pop();
                undoStack.Push(currentText);
                richTextBox1.Text = redoText;
                _lastText = redoText;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                isInternalChange = false;
            }
        }

        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save a Text File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1 != null)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Open a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1 != null)
                {
                    isInternalChange = true;
                    string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = fileContent;
                    _lastText = fileContent;
                    undoStack.Clear();
                    redoStack.Clear();
                    isInternalChange = false;
                }
            }
        }

        private void menuItemFind_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm(richTextBox1);
            findForm.Show();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void menuItemDateTime_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += System.DateTime.Now.ToString();
            UpdateTextCount();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isInternalChange)
            {
                string currentText = richTextBox1.Text;

                if (currentText != _lastText) // Tránh lưu trùng lặp hoặc thay đổi nhỏ
                {
                    undoStack.Push(_lastText);
                    _lastText = currentText;
                    redoStack.Clear();
                }
            }

            UpdateTextCount();
        }

        private void UpdateTextCount()
        {
            // Lấy văn bản từ richTextBox1
            string text = richTextBox1.Text;

            // Đếm số từ bằng cách tách văn bản theo khoảng trắng
            // và loại bỏ các phần tử rỗng
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            // Cập nhật nhãn với số lượng từ
            labelTextCount.Text = $"Words: {wordCount}";
        }

        private void menuItemCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void menuItemSellectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void menuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = font.Font;
        }

        private void menuItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = color.Color;
        }

        private void menuItemBulletList_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void menuItemZoomIn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 63.0f)
            {
                richTextBox1.ZoomFactor += 0.1f;
                UpdateZoomDisplay();
            }
        }

        private void UpdateZoomDisplay()
        {
            textBoxScale.Text = (richTextBox1.ZoomFactor * 100).ToString("F0"); // Cập nhật tỷ lệ zoom trong TextBox
        }

        private void menuItemZoomOut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.1f)
            {
                richTextBox1.ZoomFactor -= 0.1f;
                UpdateZoomDisplay();
            }
        }

        private void menuItemDefault_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f; // Quay về mức zoom gốc (100%)
            UpdateZoomDisplay();
        }

        private void textBoxScale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(textBoxScale.Text, out float scalePercentage))
                {
                    if (scalePercentage >= 10 && scalePercentage <= 500)
                    {
                        richTextBox1.ZoomFactor = scalePercentage / 100f;
                        UpdateZoomDisplay();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a value between 10 and 500.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.SuppressKeyPress = true;
            }
        }

        private void menuItemAboutUs_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(); // Hiển thị dưới dạng cửa sổ nhỏ, chặn form chính
        }
    }
}