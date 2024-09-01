namespace GorillaTag_Downloader
{
    partial class Extra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extra));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Extra builds";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 144);
            button1.Name = "button1";
            button1.Size = new Size(266, 66);
            button1.TabIndex = 1;
            button1.Text = "PreAlpha";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 216);
            button2.Name = "button2";
            button2.Size = new Size(266, 66);
            button2.TabIndex = 2;
            button2.Text = "Pre-PreAlpha";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 72);
            button3.Name = "button3";
            button3.Size = new Size(266, 66);
            button3.TabIndex = 3;
            button3.Text = "Beta";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 288);
            button4.Name = "button4";
            button4.Size = new Size(266, 66);
            button4.TabIndex = 4;
            button4.Text = "Very early";
            button4.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.Gainsboro;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Location = new Point(12, 373);
            button16.Name = "button16";
            button16.Size = new Size(124, 43);
            button16.TabIndex = 22;
            button16.Text = "return";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 423);
            Controls.Add(button16);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Extra";
            Text = "Extra builds";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button16;
    }
}