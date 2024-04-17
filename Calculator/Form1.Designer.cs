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
            first.Location = new Point(96, 21);
            first.Name = "first";
            first.Size = new Size(100, 32);
            first.TabIndex = 0;
            // 
            // second
            // 
            second.Font = new Font("Segoe UI", 14F);
            second.Location = new Point(96, 70);
            second.Name = "second";
            second.Size = new Size(100, 32);
            second.TabIndex = 1;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 14F);
            add.Location = new Point(96, 122);
            add.Name = "add";
            add.Size = new Size(36, 33);
            add.TabIndex = 2;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // subtract
            // 
            subtract.Font = new Font("Segoe UI", 14F);
            subtract.Location = new Point(160, 122);
            subtract.Name = "subtract";
            subtract.Size = new Size(36, 33);
            subtract.TabIndex = 2;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 14F);
            multiply.Location = new Point(96, 180);
            multiply.Name = "multiply";
            multiply.Size = new Size(36, 33);
            multiply.TabIndex = 2;
            multiply.Text = "X";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 14F);
            divide.Location = new Point(160, 180);
            divide.Name = "divide";
            divide.Size = new Size(36, 33);
            divide.TabIndex = 2;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // result
            // 
            result.BackColor = SystemColors.ControlLightLight;
            result.Font = new Font("Segoe UI", 14F);
            result.Location = new Point(94, 241);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 249);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 290);
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
            Name = "Form1";
            Text = "Form1";
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
