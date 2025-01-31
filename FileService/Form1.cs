namespace FileService
{
    public partial class Form1 : Form
    {
        static int i = -1;
        static int MainTextChangeCount = 0;
        FileList files = new FileList();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void MainText_TextChanged(object sender, EventArgs e)
        {
            //if (MainTextChangeCount == 5)
            //{
            //    fs[i].Rewrite(MainText.Text);

            //    MainTextChangeCount = 0;
            //}
            //else
            //    MainTextChangeCount++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && files.CurrentFile("Files\\" + textBox1.Text + ".txt") == -1)
            {
                TabPage tabPage = new TabPage(textBox1.Text);

                tabControl1.TabPages.Add(tabPage);

                files.Add(new NorFile(textBox1.Text));

                MainText.Text = files[files.Size - 1].Text;

                i = files.Size - 1;

                tabControl1.SelectedTab = tabControl1.TabPages[i];
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
                files[i].Rewrite(MainText.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                files[i].Rewrite(MainText.Text);
                files.Remove(i);
                tabControl1.TabPages.RemoveAt(i);
                i = 0;

                if (files.Size != 0)
                    MainText.Text = files[0].Text;
                else
                    MainText.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                files[i].Delete();
                files.Remove(i);
                tabControl1.TabPages.RemoveAt(i);
                i = 0;

                if (files.Size != 0)
                    MainText.Text = files[0].Text;
                else
                    MainText.Text = "";
            }
        }

        private void FindBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                richTextBox2.Text = "";

                string[] list = files[i].Find(@FindBox.Text);

                if (list.Length != 1)
                {
                    richTextBox2.Text += list.Length.ToString() + '\n';

                    foreach (string line in list)
                        richTextBox2.Text += line + '\n';

                    richTextBox2.Text += "============\n";

                    var groupList = from line in list
                                    group line by line[0];

                    foreach (var key in groupList)
                    {
                        richTextBox2.Text += key.Key + ":\n";

                        foreach (var line in key)
                            richTextBox2.Text += line + '\n';

                        Console.WriteLine();
                    }
                }
                else
                    richTextBox2.Text = list[0] + "\n";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (files.Size != 0)
            {
                MainText.Text = File.ReadAllText("Files\\" + tabControl1.SelectedTab.Text + ".txt");
                i = files.CurrentFile("Files\\" + tabControl1.SelectedTab.Text + ".txt");
            }
        }

        private void ReplaceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                files[i].Replace(FindBox.Text, ReplaceBox.Text);
                MainText.Text = files[i].Text;
            }
        }
    }
}
