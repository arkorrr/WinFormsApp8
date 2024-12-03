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

namespace WinFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool Input(out double num1, out double num2)
        {
            num1 = num2 = 0;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Field 1 is not guilty of being empty");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Field 2 is not guilty of being empty");
                return false;
            }

            if (!double.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("Field 1 is guilty of misrepresenting only numbers");
                return false;
            }

            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("Field 2 is guilty of misrepresenting only numbers");
                return false;
            }

            return true;
        }







        private void OperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem operationsMenu = new ToolStripMenuItem("Operations");
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Addition");
            addMenuItem.Click += (sender, e) =>
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                MessageBox.Show("Sum: " + (num1 + num2));
            };
            operationsMenu.DropDownItems.Add(addMenuItem);

            ToolStripMenuItem subtractMenuItem = new ToolStripMenuItem("Subtraction");
            subtractMenuItem.Click += (sender, e) =>
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                MessageBox.Show("Difference: " + (num1 - num2));
            };
            operationsMenu.DropDownItems.Add(subtractMenuItem);
        }

        private void ExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem extraMenu = new ToolStripMenuItem("Extras");
            ToolStripMenuItem clearMenuItem = new ToolStripMenuItem("Clear Form");
            clearMenuItem.Click += (sender, e) =>
            {
                textBox1.Clear();
                textBox2.Clear();
            };
            extraMenu.DropDownItems.Add(clearMenuItem);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double num1, num2;
            if (Input(out num1, out num2))
            {
                double result = num1 + num2;
                MessageBox.Show("Added result: " + result);
            }
        }

        private void LiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (Input(out num1, out num2))
            {
                double result = num1 - num2;
                MessageBox.Show("The result is visible: " + result);
            }
        }

        private void ClearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

