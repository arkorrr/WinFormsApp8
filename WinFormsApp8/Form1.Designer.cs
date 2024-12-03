namespace WinFormsApp8
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
            toolStrip1 = new ToolStrip();
            updateButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripComboBox = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            ButtonTask2 = new Button();
            addMenuItem = new ToolStripMenuItem();
            subtractMenuItem = new ToolStripMenuItem();
            clearMenuItem = new ToolStripMenuItem();
            updateButton.Text = "Refresh";
            updateButton.Click += (sender, e) => MessageBox.Show("Data refreshed!");
            toolStrip1.Items.Add(updateButton);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { updateButton, toolStripSeparator1, ToolStripComboBox, toolStripSeparator2, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(576, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // updateButton
            // 
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(50, 22);
            updateButton.Text = "Refresh";
            updateButton.Click += updateButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            toolStripSeparator1.Click += toolStripSeparator1_Click;
            // 
            // ToolStripComboBox
            // 
            ToolStripComboBox.Items.AddRange(new object[] { "Red", "Green", "Blue" });
            ToolStripComboBox.Name = "ToolStripComboBox";
            ToolStripComboBox.Size = new Size(106, 25);
            ToolStripComboBox.Click += ToolStripComboBox_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(88, 25);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // ButtonTask2
            // 
            ButtonTask2.Location = new Point(28, 88);
            ButtonTask2.Margin = new Padding(3, 2, 3, 2);
            ButtonTask2.Name = "ButtonTask2";
            ButtonTask2.Size = new Size(82, 22);
            ButtonTask2.TabIndex = 1;
            ButtonTask2.Text = "Task2";
            ButtonTask2.Click += ButtonTask2_Click;
            // 
            // addMenuItem
            // 
            addMenuItem.Name = "addMenuItem";
            addMenuItem.Size = new Size(32, 19);
            addMenuItem.Text = "add";
            // 
            // subtractMenuItem
            // 
            subtractMenuItem.Name = "subtractMenuItem";
            subtractMenuItem.Size = new Size(32, 19);
            subtractMenuItem.Text = "substract";
            // 
            // clearMenuItem
            // 
            clearMenuItem.Name = "clearMenuItem";
            clearMenuItem.Size = new Size(32, 19);
            clearMenuItem.Text = "clearform";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 398);
            Controls.Add(ButtonTask2);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox ToolStripComboBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBox1;
        private Button ButtonTask2;
        private ToolStripMenuItem addMenuItem;
        private ToolStripMenuItem subtractMenuItem;
        private ToolStripMenuItem clearMenuItem;
        private ToolStripButton updateButton;
    }
}
