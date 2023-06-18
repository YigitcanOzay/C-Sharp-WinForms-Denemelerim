namespace WinFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "T.C Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 71);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 150);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 7;
            textBox1.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(206, 28);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(163, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(383, 71);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(281, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 49);
            label3.Name = "label3";
            label3.Size = new Size(245, 31);
            label3.TabIndex = 5;
            label3.Text = "Yönetici Giriş Sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(591, 341);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Kullanıcı Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private CheckBox checkBox1;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}