using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSellectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBulletList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemScale = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxScale = new System.Windows.Forms.ToolStripTextBox();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelTextCount = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(224, 26);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(224, 26);
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(224, 26);
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(224, 26);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDateTime,
            this.toolStripSeparator3,
            this.menuItemUndo,
            this.menuItemRedo,
            this.toolStripSeparator1,
            this.menuItemFind,
            this.toolStripSeparator4,
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemPaste,
            this.menuItemSellectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "Edit";
            // 
            // menuItemDateTime
            // 
            this.menuItemDateTime.Name = "menuItemDateTime";
            this.menuItemDateTime.Size = new System.Drawing.Size(224, 26);
            this.menuItemDateTime.Text = "Date/Time";
            this.menuItemDateTime.Click += new System.EventHandler(this.menuItemDateTime_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // menuItemUndo
            // 
            this.menuItemUndo.Name = "menuItemUndo";
            this.menuItemUndo.Size = new System.Drawing.Size(224, 26);
            this.menuItemUndo.Text = "Undo";
            this.menuItemUndo.Click += new System.EventHandler(this.menuItemUndo_Click);
            // 
            // menuItemRedo
            // 
            this.menuItemRedo.Name = "menuItemRedo";
            this.menuItemRedo.Size = new System.Drawing.Size(224, 26);
            this.menuItemRedo.Text = "Redo";
            this.menuItemRedo.Click += new System.EventHandler(this.menuItemRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuItemFind
            // 
            this.menuItemFind.Name = "menuItemFind";
            this.menuItemFind.Size = new System.Drawing.Size(224, 26);
            this.menuItemFind.Text = "Find/Replace";
            this.menuItemFind.Click += new System.EventHandler(this.menuItemFind_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // menuItemCut
            // 
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.Size = new System.Drawing.Size(224, 26);
            this.menuItemCut.Text = "Cut";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.Size = new System.Drawing.Size(224, 26);
            this.menuItemCopy.Text = "Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.Size = new System.Drawing.Size(224, 26);
            this.menuItemPaste.Text = "Paste";
            this.menuItemPaste.Click += new System.EventHandler(this.menuItemPaste_Click);
            // 
            // menuItemSellectAll
            // 
            this.menuItemSellectAll.Name = "menuItemSellectAll";
            this.menuItemSellectAll.Size = new System.Drawing.Size(224, 26);
            this.menuItemSellectAll.Text = "Select All";
            this.menuItemSellectAll.Click += new System.EventHandler(this.menuItemSellectAll_Click);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFont,
            this.menuItemColor,
            this.menuItemBulletList});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(70, 24);
            this.menuFormat.Text = "Format";
            // 
            // menuItemFont
            // 
            this.menuItemFont.Name = "menuItemFont";
            this.menuItemFont.Size = new System.Drawing.Size(156, 26);
            this.menuItemFont.Text = "Font";
            this.menuItemFont.Click += new System.EventHandler(this.menuItemFont_Click);
            // 
            // menuItemColor
            // 
            this.menuItemColor.Name = "menuItemColor";
            this.menuItemColor.Size = new System.Drawing.Size(156, 26);
            this.menuItemColor.Text = "Color";
            this.menuItemColor.Click += new System.EventHandler(this.menuItemColor_Click);
            // 
            // menuItemBulletList
            // 
            this.menuItemBulletList.Name = "menuItemBulletList";
            this.menuItemBulletList.Size = new System.Drawing.Size(156, 26);
            this.menuItemBulletList.Text = "Bullet List";
            this.menuItemBulletList.Click += new System.EventHandler(this.menuItemBulletList_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuFormat,
            this.toolStripMenuItem1,
            this.menuInfo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(692, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemZoomIn,
            this.menuItemZoomOut,
            this.menuItemDefault,
            this.menuItemScale});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem1.Text = "View";
            // 
            // menuItemZoomIn
            // 
            this.menuItemZoomIn.Name = "menuItemZoomIn";
            this.menuItemZoomIn.Size = new System.Drawing.Size(158, 26);
            this.menuItemZoomIn.Text = "Zoom in";
            this.menuItemZoomIn.Click += new System.EventHandler(this.menuItemZoomIn_Click);
            // 
            // menuItemZoomOut
            // 
            this.menuItemZoomOut.Name = "menuItemZoomOut";
            this.menuItemZoomOut.Size = new System.Drawing.Size(158, 26);
            this.menuItemZoomOut.Text = "Zoom out";
            this.menuItemZoomOut.Click += new System.EventHandler(this.menuItemZoomOut_Click);
            // 
            // menuItemDefault
            // 
            this.menuItemDefault.Name = "menuItemDefault";
            this.menuItemDefault.Size = new System.Drawing.Size(158, 26);
            this.menuItemDefault.Text = "Default";
            this.menuItemDefault.Click += new System.EventHandler(this.menuItemDefault_Click);
            // 
            // menuItemScale
            // 
            this.menuItemScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxScale});
            this.menuItemScale.Name = "menuItemScale";
            this.menuItemScale.Size = new System.Drawing.Size(158, 26);
            this.menuItemScale.Text = "Scale (%)";
            // 
            // textBoxScale
            // 
            this.textBoxScale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(100, 27);
            this.textBoxScale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxScale_KeyDown);
            // 
            // menuInfo
            // 
            this.menuInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAboutUs});
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(49, 24);
            this.menuInfo.Text = "Info";
            // 
            // menuItemAboutUs
            // 
            this.menuItemAboutUs.Name = "menuItemAboutUs";
            this.menuItemAboutUs.Size = new System.Drawing.Size(224, 26);
            this.menuItemAboutUs.Text = "About us";
            this.menuItemAboutUs.Click += new System.EventHandler(this.menuItemAboutUs_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 30);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(692, 425);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // labelTextCount
            // 
            this.labelTextCount.AutoSize = true;
            this.labelTextCount.Location = new System.Drawing.Point(-4, 437);
            this.labelTextCount.Name = "labelTextCount";
            this.labelTextCount.Size = new System.Drawing.Size(60, 16);
            this.labelTextCount.TabIndex = 3;
            this.labelTextCount.Text = "Words: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 455);
            this.Controls.Add(this.labelTextCount);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem menuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuItemFont;
        private System.Windows.Forms.MenuStrip menuStrip;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem menuItemFind;
        private ToolStripMenuItem menuItemDateTime;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menuItemCut;
        private ToolStripMenuItem menuItemCopy;
        private ToolStripMenuItem menuItemPaste;
        private ToolStripMenuItem menuItemSellectAll;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem menuItemZoomIn;
        private ToolStripMenuItem menuItemColor;
        private ToolStripMenuItem menuItemBulletList;
        private ToolStripMenuItem menuItemZoomOut;
        private ToolStripMenuItem menuItemDefault;
        private ToolStripMenuItem menuItemScale;
        private ToolStripTextBox textBoxScale;
        private ToolStripMenuItem menuInfo;
        private ToolStripMenuItem menuItemAboutUs;
        private ToolStripMenuItem menuItemNew;
        private Label labelTextCount;
    }
}

