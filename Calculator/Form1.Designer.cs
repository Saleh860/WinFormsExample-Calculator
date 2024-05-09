namespace Calculator
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
            first = new TextBox();
            second = new TextBox();
            add = new Button();
            subtract = new Button();
            multiply = new Button();
            divide = new Button();
            result = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // first
            // 
            first.Font = new Font("Segoe UI", 14F);
            first.Location = new Point(137, 35);
            first.Margin = new Padding(4, 5, 4, 5);
            first.Name = "first";
            first.Size = new Size(141, 45);
            first.TabIndex = 0;
            first.KeyPress += first_KeyPress;
            // 
            // second
            // 
            second.Font = new Font("Segoe UI", 14F);
            second.Location = new Point(137, 115);
            second.Margin = new Padding(4, 5, 4, 5);
            second.Name = "second";
            second.Size = new Size(141, 45);
            second.TabIndex = 1;
            second.KeyPress += first_KeyPress;
            // 
            // add
            // 
            add.BackColor = SystemColors.ControlDark;
            add.Font = new Font("Segoe UI", 14F);
            add.ForeColor = SystemColors.Info;
            add.Location = new Point(137, 203);
            add.Margin = new Padding(4, 5, 4, 5);
            add.Name = "add";
            add.Size = new Size(51, 55);
            add.TabIndex = 2;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // subtract
            // 
            subtract.BackColor = SystemColors.ControlDark;
            subtract.Font = new Font("Segoe UI", 14F);
            subtract.ForeColor = SystemColors.Info;
            subtract.Location = new Point(229, 203);
            subtract.Margin = new Padding(4, 5, 4, 5);
            subtract.Name = "subtract";
            subtract.Size = new Size(51, 55);
            subtract.TabIndex = 2;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = false;
            subtract.Click += subtract_Click;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.ControlDark;
            multiply.Font = new Font("Segoe UI", 14F);
            multiply.ForeColor = SystemColors.Info;
            multiply.Location = new Point(137, 300);
            multiply.Margin = new Padding(4, 5, 4, 5);
            multiply.Name = "multiply";
            multiply.Size = new Size(51, 55);
            multiply.TabIndex = 2;
            multiply.Text = "X";
            multiply.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.ControlDark;
            divide.Font = new Font("Segoe UI", 14F);
            divide.ForeColor = SystemColors.Info;
            divide.Location = new Point(229, 300);
            divide.Margin = new Padding(4, 5, 4, 5);
            divide.Name = "divide";
            divide.Size = new Size(51, 55);
            divide.TabIndex = 2;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            // 
            // result
            // 
            result.BackColor = SystemColors.ControlLightLight;
            result.Enabled = false;
            result.Font = new Font("Segoe UI", 14F);
            result.Location = new Point(134, 402);
            result.Margin = new Padding(4, 0, 4, 0);
            result.Name = "result";
            result.Size = new Size(143, 38);
            result.TabIndex = 3;
            result.Click += result_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 4;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 5;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 415);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 483);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(result);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(subtract);
            Controls.Add(add);
            Controls.Add(second);
            Controls.Add(first);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox first;
        private TextBox second;
        private Button add;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Label result;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
