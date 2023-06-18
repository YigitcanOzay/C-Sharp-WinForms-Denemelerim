namespace WinFormsApp1
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "adana", "izmir", "niğde", "mersin", "kayseri", "istanbul", "nevşehir", "kırşehir", "bursa", "ankara", "balıkesir", "aydın", "gaziantep" });
            comboBox1.Location = new Point(464, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 38);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(464, 92);
            button1.Name = "button1";
            button1.Size = new Size(121, 41);
            button1.TabIndex = 1;
            button1.Text = "Şehir ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 92);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 2;
            button2.Text = "ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 35);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "doktor", "yazılımcı", "programcı" });
            listBox1.Location = new Point(643, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 244);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(512, 237);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 5;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(692, 333);
            button4.Name = "button4";
            button4.Size = new Size(110, 46);
            button4.TabIndex = 6;
            button4.Text = "ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(692, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 35);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 35);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 8;
            label1.Text = "textten ekleme";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 136);
            label2.Name = "label2";
            label2.Size = new Size(154, 30);
            label2.TabIndex = 9;
            label2.Text = "koddan ekleme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 285);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 10;
            label3.Text = "txt add";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 40);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 11;
            label4.Text = "chkbx uyg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(862, 32);
            label5.Name = "label5";
            label5.Size = new Size(118, 30);
            label5.TabIndex = 12;
            label5.Text = "ListBox uyg";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1029, 518);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}