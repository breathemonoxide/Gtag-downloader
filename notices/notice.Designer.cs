namespace GorillaTag_Downloader
{
    partial class notice
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 47);
            label1.TabIndex = 1;
            label1.Text = "NOTICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 56);
            label2.Name = "label2";
            label2.Size = new Size(235, 15);
            label2.TabIndex = 2;
            label2.Text = "This is not intended to be a GTPatcher copy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(280, 15);
            label3.TabIndex = 3;
            label3.Text = "It has been brought to my attention that people are ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(277, 15);
            label4.TabIndex = 4;
            label4.Text = "thinking that this is a copy of GTPatcher, however i ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 101);
            label6.Name = "label6";
            label6.Size = new Size(302, 15);
            label6.TabIndex = 6;
            label6.Text = "began making this before i knew GTPatcher was a thing.";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 116);
            label7.Name = "label7";
            label7.Size = new Size(292, 15);
            label7.TabIndex = 7;
            label7.Text = "I hope you can understand that this was not meant to ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 131);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 8;
            label8.Text = "copy it.";
            // 
            // button1
            // 
            button1.Location = new Point(96, 149);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 9;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            // 
            // notice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 171);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "notice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}