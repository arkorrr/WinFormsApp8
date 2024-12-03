namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolStripComboBox_Click(object sender, EventArgs e)
        {
            ToolStripComboBox colorComboBox = new ToolStripComboBox();
            colorComboBox.Items.AddRange(new string[] { "Red", "Green", "Blue" });
            colorComboBox.SelectedIndexChanged += (sender, e) =>
            {
                switch (colorComboBox.SelectedItem.ToString())
                {
                    case "Red":
                        this.BackColor = Color.Red;
                        break;
                    case "Green":
                        this.BackColor = Color.Green;
                        break;
                    case "Blue":
                        this.BackColor = Color.Blue;
                        break;
                }
            };
            toolStrip1.Items.Add(colorComboBox);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            ToolStripTextBox toolStripTextBox = new ToolStripTextBox();
            toolStripTextBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MessageBox.Show(toolStripTextBox.Text);
                }
            };
            toolStrip1.Items.Add(toolStripTextBox);
        }

        private void ButtonTask2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {
            ToolStripSeparator separator = new ToolStripSeparator();
            toolStrip1.Items.Add(separator);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
