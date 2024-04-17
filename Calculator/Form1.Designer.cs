﻿namespace Calculator
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
			first.Location = new Point(110, 28);
			first.Margin = new Padding(3, 4, 3, 4);
			first.Name = "first";
			first.Size = new Size(114, 39);
			first.TabIndex = 0;
			// 
			// second
			// 
			second.Font = new Font("Segoe UI", 14F);
			second.Location = new Point(110, 93);
			second.Margin = new Padding(3, 4, 3, 4);
			second.Name = "second";
			second.Size = new Size(114, 39);
			second.TabIndex = 1;
			// 
			// add
			// 
			add.BackColor = SystemColors.ActiveCaptionText;
			add.Font = new Font("Segoe UI", 14F);
			add.ForeColor = SystemColors.ButtonHighlight;
			add.Location = new Point(67, 163);
			add.Margin = new Padding(3, 4, 3, 4);
			add.Name = "add";
			add.Size = new Size(41, 44);
			add.TabIndex = 2;
			add.Text = "+";
			add.UseVisualStyleBackColor = false;
			add.Click += add_Click;
			// 
			// subtract
			// 
			subtract.BackColor = SystemColors.ActiveCaptionText;
			subtract.Font = new Font("Segoe UI", 14F);
			subtract.ForeColor = SystemColors.ButtonHighlight;
			subtract.Location = new Point(183, 163);
			subtract.Margin = new Padding(3, 4, 3, 4);
			subtract.Name = "subtract";
			subtract.Size = new Size(41, 44);
			subtract.TabIndex = 3;
			subtract.Text = "-";
			subtract.UseVisualStyleBackColor = false;
			subtract.Click += subtract_Click;
			// 
			// multiply
			// 
			multiply.BackColor = SystemColors.ActiveCaptionText;
			multiply.Font = new Font("Segoe UI", 14F);
			multiply.ForeColor = SystemColors.ControlLightLight;
			multiply.Location = new Point(67, 240);
			multiply.Margin = new Padding(3, 4, 3, 4);
			multiply.Name = "multiply";
			multiply.Size = new Size(41, 44);
			multiply.TabIndex = 4;
			multiply.Text = "X";
			multiply.UseVisualStyleBackColor = false;
			multiply.Click += milt;
			// 
			// divide
			// 
			divide.BackColor = SystemColors.ActiveCaptionText;
			divide.Font = new Font("Segoe UI", 14F);
			divide.ForeColor = SystemColors.ButtonHighlight;
			divide.Location = new Point(183, 240);
			divide.Margin = new Padding(3, 4, 3, 4);
			divide.Name = "divide";
			divide.Size = new Size(41, 44);
			divide.TabIndex = 5;
			divide.Text = "/";
			divide.UseVisualStyleBackColor = false;
			divide.Click += devid;
			// 
			// result
			// 
			result.BackColor = SystemColors.Highlight;
			result.BorderStyle = BorderStyle.FixedSingle;
			result.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			result.ForeColor = Color.Cornsilk;
			result.Location = new Point(96, 315);
			result.Name = "result";
			result.Size = new Size(128, 44);
			result.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 43);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 4;
			label1.Text = "Number 1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(19, 108);
			label2.Name = "label2";
			label2.Size = new Size(75, 20);
			label2.TabIndex = 5;
			label2.Text = "Number 2";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 332);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 6;
			label3.Text = "Result";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Highlight;
			ClientSize = new Size(259, 387);
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
			Margin = new Padding(3, 4, 3, 4);
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
