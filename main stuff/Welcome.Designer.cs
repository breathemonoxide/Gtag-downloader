namespace GorillaTag_Downloader
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            label1 = new Label();
            label2 = new Label();
            Steam = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(90, 50);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 1;
            label1.Text = "downloader!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(100, 131);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Please select your platform";
            label2.Click += label2_Click;
            // 
            // Steam
            // 
            Steam.BackColor = Color.DimGray;
            Steam.FlatAppearance.BorderSize = 0;
            Steam.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Steam.FlatStyle = FlatStyle.Flat;
            Steam.ForeColor = SystemColors.ActiveCaptionText;
            Steam.Location = new Point(100, 185);
            Steam.Name = "Steam";
            Steam.Size = new Size(186, 51);
            Steam.TabIndex = 3;
            Steam.Text = "Steam";
            Steam.UseVisualStyleBackColor = false;
            Steam.Click += Steam_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(100, 242);
            button3.Name = "button3";
            button3.Size = new Size(186, 51);
            button3.TabIndex = 5;
            button3.Text = "Quest (Historical)";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(335, 426);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "V 0.2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Franklin Gothic Medium", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(360, 41);
            label4.TabIndex = 7;
            label4.Text = "Weclome to GorillaTag";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(379, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(Steam);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GTAG downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Label label1;
        private Label label2;
        private Button Steam;
        private Button button3;
        private Label label3;
        private Label label4;
    }
}
