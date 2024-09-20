namespace GorillaTag_Downloader.main_stuff
{
    partial class mainquest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainquest));
            panel1 = new Panel();
            button10 = new Button();
            button14 = new Button();
            button13 = new Button();
            button9 = new Button();
            button12 = new Button();
            button11 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 752);
            panel1.TabIndex = 1;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(3, 12);
            button10.Name = "button10";
            button10.Size = new Size(194, 104);
            button10.TabIndex = 18;
            button10.Text = "HISTORICAL";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Location = new Point(3, 570);
            button14.Name = "button14";
            button14.Size = new Size(194, 104);
            button14.TabIndex = 17;
            button14.Text = "QUIT";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(3, 460);
            button13.Name = "button13";
            button13.Size = new Size(194, 104);
            button13.TabIndex = 16;
            button13.Text = "SETTINGS";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gainsboro;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(132, 703);
            button9.Name = "button9";
            button9.Size = new Size(53, 46);
            button9.TabIndex = 15;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gainsboro;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.Location = new Point(73, 703);
            button12.Name = "button12";
            button12.Size = new Size(53, 46);
            button12.TabIndex = 14;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gainsboro;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(14, 703);
            button11.Name = "button11";
            button11.Size = new Size(53, 46);
            button11.TabIndex = 13;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // mainquest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 749);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "mainquest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GTAG downloader";
            Load += mainquest_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button14;
        private Button button13;
        private Button button9;
        private Button button12;
        private Button button11;
        private Button button10;
    }
}