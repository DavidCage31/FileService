namespace FileService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainText = new RichTextBox();
            textBox1 = new TextBox();
            buttonOpen = new Button();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            buttonClose = new Button();
            buttonDelete = new Button();
            FindBox = new TextBox();
            buttonFind = new Button();
            tabControl1 = new TabControl();
            ReplaceBox = new TextBox();
            buttonReplace = new Button();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.Location = new Point(4, 46);
            MainText.Name = "MainText";
            MainText.Size = new Size(480, 456);
            MainText.TabIndex = 0;
            MainText.Text = "";
            MainText.TextChanged += MainText_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(498, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(722, 3);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // button2
            // 
            button2.Location = new Point(4, 510);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSave_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(499, 102);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(218, 224);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(822, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(922, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FindBox
            // 
            FindBox.Location = new Point(498, 36);
            FindBox.Name = "FindBox";
            FindBox.Size = new Size(218, 27);
            FindBox.TabIndex = 7;
            FindBox.TextChanged += FindBox_TextChanged;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(722, 34);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(94, 29);
            buttonFind.TabIndex = 8;
            buttonFind.Text = "Найти";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(4, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(488, 28);
            tabControl1.TabIndex = 11;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ReplaceBox
            // 
            ReplaceBox.Location = new Point(499, 69);
            ReplaceBox.Name = "ReplaceBox";
            ReplaceBox.Size = new Size(218, 27);
            ReplaceBox.TabIndex = 12;
            ReplaceBox.TextChanged += ReplaceBox_TextChanged;
            // 
            // buttonReplace
            // 
            buttonReplace.Location = new Point(723, 69);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(94, 29);
            buttonReplace.TabIndex = 13;
            buttonReplace.Text = "Заменить";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 547);
            Controls.Add(buttonReplace);
            Controls.Add(ReplaceBox);
            Controls.Add(MainText);
            Controls.Add(tabControl1);
            Controls.Add(buttonFind);
            Controls.Add(FindBox);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClose);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(buttonOpen);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MainText;
        private TextBox textBox1;
        private Button buttonOpen;
        private Button button2;
        private RichTextBox richTextBox2;
        private Button buttonClose;
        private Button buttonDelete;
        private TextBox FindBox;
        private Button buttonFind;
        private TabControl tabControl1;
        private TextBox ReplaceBox;
        private Button buttonReplace;
    }
}
