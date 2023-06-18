namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 190);
            button1.Name = "button1";
            button1.Size = new Size(332, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(86, 256);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(636, 139);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 48);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 84);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "T.C:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 120);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 156);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Saat:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(191, 48);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(281, 23);
            maskedTextBox1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(191, 84);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(281, 23);
            maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(191, 120);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(281, 23);
            maskedTextBox3.TabIndex = 12;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(191, 156);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(281, 23);
            maskedTextBox4.TabIndex = 13;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(517, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(517, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(527, 190);
            button2.Name = "button2";
            button2.Size = new Size(181, 23);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}