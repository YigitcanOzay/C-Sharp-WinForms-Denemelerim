namespace WinFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            groupBox1 = new GroupBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            button2 = new Button();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(57, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 185);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 7;
            label4.Text = "Saat";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(115, 182);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 29);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 142);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 148);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 4;
            label3.Text = "Tarih";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 102);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "İzmir", "Çanakkale", "Adana", "İstanbul" });
            comboBox2.Location = new Point(115, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 29);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "İzmir", "İstanbul", "Adana" });
            comboBox1.Location = new Point(115, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 29);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 57);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(557, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 229);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(150, 144);
            button1.Name = "button1";
            button1.Size = new Size(164, 39);
            button1.TabIndex = 6;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 112);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 5;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 76);
            label6.Name = "label6";
            label6.Size = new Size(34, 21);
            label6.TabIndex = 4;
            label6.Text = "T.C:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(150, 108);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(164, 29);
            maskedTextBox3.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(150, 73);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(164, 29);
            maskedTextBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 29);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 41);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 0;
            label5.Text = "Yolcu Ad Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(57, 412);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(832, 151);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(57, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 136);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(598, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ravie", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(29, 38);
            label8.Name = "label8";
            label8.Padding = new Padding(10);
            label8.Size = new Size(461, 56);
            label8.TabIndex = 0;
            label8.Text = "MoonLight Hava Yolları";
            // 
            // button2
            // 
            button2.Location = new Point(395, 239);
            button2.Name = "button2";
            button2.Size = new Size(81, 35);
            button2.TabIndex = 4;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(406, 297);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 5;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(950, 608);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form6";
            Text = "Uçuş Rezarvasyon Sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label9;
    }
}