namespace UI_Async
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            textBox_name = new TextBox();
            textBox4 = new TextBox();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            textBox5 = new TextBox();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            progressBar1 = new ProgressBar();
            textBox6 = new TextBox();
            pictureBox6 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(14, 184);
            button1.Name = "button1";
            button1.Size = new Size(141, 63);
            button1.TabIndex = 0;
            button1.Text = "Process sync";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 126);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 52);
            textBox1.TabIndex = 2;
            textBox1.Text = "1. Press the button.  The app will be blocked due to the synchronism. Use the green text box to indicate the time in miliseconds that the thread will be blocked";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(393, 126);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 52);
            textBox2.TabIndex = 5;
            textBox2.Text = "2. Press the button.  The app will not be blocked due to the asynchronism. Use the green text box to indicate the time in miliseconds that the thread will be blocked\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(621, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(393, 184);
            button2.Name = "button2";
            button2.Size = new Size(141, 63);
            button2.TabIndex = 3;
            button2.Text = "Process async";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(776, 126);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 40);
            textBox3.TabIndex = 8;
            textBox3.Text = "3. Press the button.  The app will not be blocked due to the asynchronism. Write a name in the textbox bellow!";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1004, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(776, 184);
            button3.Name = "button3";
            button3.Size = new Size(132, 63);
            button3.TabIndex = 6;
            button3.Text = "Process async (with API)";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(914, 184);
            textBox_name.Multiline = true;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(84, 63);
            textBox_name.TabIndex = 9;
            textBox_name.Text = "Fill me with a name!!";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 291);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(328, 69);
            textBox4.TabIndex = 12;
            textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(242, 366);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(14, 366);
            button4.Name = "button4";
            button4.Size = new Size(141, 63);
            button4.TabIndex = 10;
            button4.Text = "Process C. Cards";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(393, 291);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(328, 69);
            textBox5.TabIndex = 15;
            textBox5.Text = "5. Press the button. A few credit cards will be processed and the progress will be shown bellow. Set the number of credit cards in the red text box above.\r\n";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(621, 366);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 63);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(393, 366);
            button5.Name = "button5";
            button5.Size = new Size(141, 63);
            button5.TabIndex = 13;
            button5.Text = "Process C. cards";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(392, 445);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(329, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(776, 291);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(328, 69);
            textBox6.TabIndex = 19;
            textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1004, 366);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 63);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuHighlight;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(776, 366);
            button6.Name = "button6";
            button6.Size = new Size(87, 63);
            button6.TabIndex = 17;
            button6.Text = "Process C. cards";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(889, 366);
            button7.Name = "button7";
            button7.Size = new Size(87, 63);
            button7.TabIndex = 21;
            button7.Text = "Cancel";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(128, 255, 128);
            textBox7.Location = new Point(12, 73);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 22;
            textBox7.Text = "1";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(255, 255, 128);
            textBox8.Location = new Point(427, 73);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 23);
            textBox8.TabIndex = 23;
            textBox8.Text = "1";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(255, 128, 128);
            textBox9.Location = new Point(213, 73);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(143, 23);
            textBox9.TabIndex = 24;
            textBox9.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 25;
            label1.Text = "Syncronism";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 26;
            label2.Text = "Sleep thread for ms:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 55);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 27;
            label3.Text = "Cancelate after (ms):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 55);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 28;
            label4.Text = "Number of credit cards:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1266, 487);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button7);
            Controls.Add(textBox6);
            Controls.Add(pictureBox6);
            Controls.Add(button6);
            Controls.Add(progressBar1);
            Controls.Add(textBox5);
            Controls.Add(pictureBox5);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox4);
            Controls.Add(button4);
            Controls.Add(textBox_name);
            Controls.Add(textBox3);
            Controls.Add(pictureBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Button button2;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private Button button3;
        private TextBox textBox_name;
        private TextBox textBox4;
        private PictureBox pictureBox4;
        private Button button4;
        private TextBox textBox5;
        private PictureBox pictureBox5;
        private Button button5;
        private ProgressBar progressBar1;
        private TextBox textBox6;
        private PictureBox pictureBox6;
        private Button button6;
        private Button button7;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
