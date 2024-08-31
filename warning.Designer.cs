namespace GorillaTag_Downloader
{
    partial class Warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 47);
            label1.TabIndex = 0;
            label1.Text = "WARNING!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 1;
            label2.Text = "This is a pre-release version of GorillaTag downloader! ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(291, 15);
            label3.TabIndex = 2;
            label3.Text = "Expect bugs and glitches. Report any problems to me.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 101);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 3;
            label4.Text = "Most importantly have fun! :3";
            // 
            // button1
            // 
            button1.Location = new Point(98, 136);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 4;
            button1.Text = "I accept the chaos!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Warning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 171);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Warning";
            Text = "Warning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}