namespace PasswordGenerator
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            comboBox4 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "Длина пароля:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(448, 30);
            label2.TabIndex = 2;
            label2.Text = "Включать похожие символы (i, l, 1, L, o, 0, O):";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "да", "нет" });
            comboBox1.Location = new Point(480, 173);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 29);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 260);
            label3.Name = "label3";
            label3.Size = new Size(336, 30);
            label3.TabIndex = 4;
            label3.Text = "Включать небуквенные символы:";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "да", "нет" });
            comboBox2.Location = new Point(480, 264);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 29);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(480, 87);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(188, 29);
            comboBox3.TabIndex = 6;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 467);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 7;
            label4.Text = "Пароль:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(122, 467);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(546, 35);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(122, 555);
            button1.Name = "button1";
            button1.Size = new Size(263, 79);
            button1.TabIndex = 9;
            button1.Text = "Сгенерировать!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(895, 380);
            label5.Name = "label5";
            label5.Size = new Size(143, 30);
            label5.TabIndex = 10;
            label5.Text = "Путь к файлу:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(690, 475);
            label6.Name = "label6";
            label6.Size = new Size(364, 13);
            label6.TabIndex = 11;
            label6.Text = "PasswordGenerator\\PasswordGenerator\\bin\\Debug\\net6.0-windows\\";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1051, 472);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 21);
            comboBox4.TabIndex = 12;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            comboBox4.Click += update_file_list;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(791, 539);
            button2.Name = "button2";
            button2.Size = new Size(263, 79);
            button2.TabIndex = 13;
            button2.Text = "Сохранить!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 660);
            Controls.Add(button2);
            Controls.Add(comboBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public ComboBox comboBox1;
        public Label label3;
        public ComboBox comboBox2;
        public ComboBox comboBox3;
        public Label label4;
        public TextBox textBox1;
        public Button button1;
        public Label label5;
        public Label label6;
        public ComboBox comboBox4;
        public Button button2;
    }
}