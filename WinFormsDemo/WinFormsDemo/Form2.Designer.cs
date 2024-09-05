namespace WinFormsDemo
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
            Yes = new CheckedListBox();
            True = new CheckedListBox();
            Have = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // Yes
            // 
            Yes.FormattingEnabled = true;
            Yes.Items.AddRange(new object[] { "Yes", "No" });
            Yes.Location = new Point(288, 80);
            Yes.Name = "Yes";
            Yes.Size = new Size(79, 26);
            Yes.TabIndex = 0;
            Yes.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // True
            // 
            True.FormattingEnabled = true;
            True.Items.AddRange(new object[] { "True", "False" });
            True.Location = new Point(288, 123);
            True.Name = "True";
            True.Size = new Size(89, 26);
            True.TabIndex = 1;
            True.SelectedIndexChanged += True_SelectedIndexChanged;
            // 
            // Have
            // 
            Have.FormattingEnabled = true;
            Have.Items.AddRange(new object[] { "Have", "Don't have" });
            Have.Location = new Point(288, 167);
            Have.Name = "Have";
            Have.Size = new Size(105, 26);
            Have.TabIndex = 2;
            Have.SelectedIndexChanged += Have_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 3;
            label1.Text = "You want to be an author?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "You hold a PhD?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(246, 20);
            label3.TabIndex = 5;
            label3.Text = "You already have publications here?";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(151, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(335, 29);
            progressBar1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Have);
            Controls.Add(True);
            Controls.Add(Yes);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox Yes;
        private CheckedListBox True;
        private CheckedListBox Have;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
    }
}