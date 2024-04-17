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
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first.Location = new System.Drawing.Point(110, 28);
            this.first.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(171, 39);
            this.first.TabIndex = 0;
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.second.Location = new System.Drawing.Point(110, 93);
            this.second.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(171, 39);
            this.second.TabIndex = 1;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(110, 163);
            this.add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(41, 44);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtract.Location = new System.Drawing.Point(213, 163);
            this.subtract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(41, 44);
            this.subtract.TabIndex = 2;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(110, 240);
            this.multiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(41, 44);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(213, 240);
            this.divide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(41, 44);
            this.divide.TabIndex = 2;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(107, 321);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(174, 31);
            this.result.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(295, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
