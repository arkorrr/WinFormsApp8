namespace WinFormsApp8
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            OperationsToolStripMenuItem = new ToolStripMenuItem();
            AddToolStripMenuItem = new ToolStripMenuItem();
            LiftingToolStripMenuItem = new ToolStripMenuItem();
            ExtrasToolStripMenuItem = new ToolStripMenuItem();
            ClearFormToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { OperationsToolStripMenuItem, ExtrasToolStripMenuItem, ExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(307, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // OperationsToolStripMenuItem
            // 
            OperationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddToolStripMenuItem, LiftingToolStripMenuItem });
            OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            OperationsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            OperationsToolStripMenuItem.Size = new Size(77, 20);
            OperationsToolStripMenuItem.Text = "Operations";
            OperationsToolStripMenuItem.Click += OperationsToolStripMenuItem_Click;
            // 
            // AddToolStripMenuItem
            // 
            AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            AddToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            AddToolStripMenuItem.Size = new Size(180, 22);
            AddToolStripMenuItem.Text = "Addition";
            AddToolStripMenuItem.Click += AddToolStripMenuItem_Click_1;
            // 
            // LiftingToolStripMenuItem
            // 
            LiftingToolStripMenuItem.Name = "LiftingToolStripMenuItem";
            LiftingToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            LiftingToolStripMenuItem.Size = new Size(180, 22);
            LiftingToolStripMenuItem.Text = "Lifting";
            LiftingToolStripMenuItem.Click += LiftingToolStripMenuItem_Click;
            // 
            // ExtrasToolStripMenuItem
            // 
            ExtrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClearFormToolStripMenuItem });
            ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem";
            ExtrasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            ExtrasToolStripMenuItem.Size = new Size(50, 20);
            ExtrasToolStripMenuItem.Text = "Extras";
            ExtrasToolStripMenuItem.Click += ExtrasToolStripMenuItem_Click;
            // 
            // ClearFormToolStripMenuItem
            // 
            ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem";
            ClearFormToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            ClearFormToolStripMenuItem.Size = new Size(180, 22);
            ClearFormToolStripMenuItem.Text = "Clear Form";
            ClearFormToolStripMenuItem.Click += ClearFormToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            ExitToolStripMenuItem.Size = new Size(38, 20);
            ExitToolStripMenuItem.Text = "Exit";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 135);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 56);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter number1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 117);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter number2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 205);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem OperationsToolStripMenuItem;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem LiftingToolStripMenuItem;
        private ToolStripMenuItem ExtrasToolStripMenuItem;
        private ToolStripMenuItem ClearFormToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        
    }
}