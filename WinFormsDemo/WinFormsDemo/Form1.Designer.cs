﻿namespace WinFormsDemo
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(302, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 82);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 145);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(215, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Is Author";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 205);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 7;
            label3.Text = "Full Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 27);
            textBox3.TabIndex = 6;
            textBox3.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox textBox3;
    }
}
