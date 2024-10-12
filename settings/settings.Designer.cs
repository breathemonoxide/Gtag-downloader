namespace GorillaTag_Downloader
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            label1 = new Label();
            button2 = new Button();
            button11 = new Button();
            button12 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 456);
            button2.Name = "button2";
            button2.Size = new Size(245, 56);
            button2.TabIndex = 3;
            button2.Text = "About";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(12, 541);
            button11.Name = "button11";
            button11.Size = new Size(53, 46);
            button11.TabIndex = 14;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.Location = new Point(204, 541);
            button12.Name = "button12";
            button12.Size = new Size(53, 46);
            button12.TabIndex = 15;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 394);
            button1.Name = "button1";
            button1.Size = new Size(245, 56);
            button1.TabIndex = 16;
            button1.Text = "PlaceHolder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(269, 599);
            Controls.Add(button1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "settings";
            Load += settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button11;
        private Button button12;
        private Button button1;
    }
}