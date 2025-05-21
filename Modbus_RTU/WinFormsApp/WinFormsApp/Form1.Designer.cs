namespace WinFormsApp
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
            comboBox1 = new ComboBox();
            btnClickThis = new Button();
            label = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Send = new Button();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            HEX = new Label();
            textBox7 = new TextBox();
            btnClose = new Button();
            Sure = new Button();
            textBox8 = new TextBox();
            Paritycombobox = new ComboBox();
            DataBitscombobox = new ComboBox();
            StopBitscombobox = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            CRC_rec_textbox = new TextBox();
            label17 = new Label();
            label18 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10F);
            label1.Location = new Point(56, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 0;
            label1.Text = "Com";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(78, 27);
            comboBox1.TabIndex = 1;
            // 
            // btnClickThis
            // 
            btnClickThis.Font = new Font("Microsoft JhengHei UI", 10F);
            btnClickThis.Location = new Point(456, 45);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(124, 29);
            btnClickThis.TabIndex = 2;
            btnClickThis.Text = "Open";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft JhengHei UI", 10F);
            label.Location = new Point(456, 25);
            label.Name = "label";
            label.Size = new Size(48, 22);
            label.TabIndex = 3;
            label.Text = "label";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10F);
            label3.Location = new Point(140, 25);
            label3.Name = "label3";
            label3.Size = new Size(40, 22);
            label3.TabIndex = 7;
            label3.Text = "bps";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(122, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(78, 27);
            comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10F);
            label4.Location = new Point(204, 25);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 9;
            label4.Text = "Parity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Cursor = Cursors.Cross;
            label2.Font = new Font("Microsoft JhengHei UI", 10F);
            label2.Location = new Point(38, 90);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 11;
            label2.Text = "send_package";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 8F);
            label5.Location = new Point(38, 112);
            label5.Name = "label5";
            label5.Size = new Size(109, 18);
            label5.TabIndex = 12;
            label5.Text = "Additional_Adr";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 8F);
            label6.Location = new Point(160, 112);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 13;
            label6.Text = "Function";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 8F);
            label7.Location = new Point(226, 112);
            label7.Name = "label7";
            label7.Size = new Size(63, 18);
            label7.TabIndex = 14;
            label7.Text = "StartAdr";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 8F);
            label8.Location = new Point(295, 112);
            label8.Name = "label8";
            label8.Size = new Size(55, 18);
            label8.TabIndex = 15;
            label8.Text = "Length";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 8F);
            label9.Location = new Point(363, 112);
            label9.Name = "label9";
            label9.Size = new Size(35, 18);
            label9.TabIndex = 16;
            label9.Text = "CRC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 27);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 27);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(226, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 27);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(295, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 27);
            textBox4.TabIndex = 21;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Font = new Font("Microsoft JhengHei UI", 9F);
            textBox5.Location = new Point(363, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(87, 27);
            textBox5.TabIndex = 22;
            // 
            // Send
            // 
            Send.Enabled = false;
            Send.Font = new Font("Microsoft JhengHei UI", 10F);
            Send.Location = new Point(521, 133);
            Send.Name = "Send";
            Send.Size = new Size(59, 27);
            Send.TabIndex = 23;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Font = new Font("Microsoft JhengHei UI", 10F);
            label10.Location = new Point(38, 6);
            label10.Name = "label10";
            label10.Size = new Size(159, 22);
            label10.TabIndex = 24;
            label10.Text = "Serial Port Settings";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(594, 47);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(193, 27);
            textBox6.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 163);
            label11.Name = "label11";
            label11.Size = new Size(60, 19);
            label11.TabIndex = 26;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(160, 163);
            label12.Name = "label12";
            label12.Size = new Size(60, 19);
            label12.TabIndex = 27;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(226, 163);
            label13.Name = "label13";
            label13.Size = new Size(60, 19);
            label13.TabIndex = 28;
            label13.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(295, 163);
            label14.Name = "label14";
            label14.Size = new Size(60, 19);
            label14.TabIndex = 29;
            label14.Text = "label14";
            // 
            // HEX
            // 
            HEX.AutoSize = true;
            HEX.Location = new Point(-3, 163);
            HEX.Name = "HEX";
            HEX.Size = new Size(41, 19);
            HEX.TabIndex = 31;
            HEX.Text = "HEX:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(595, 134);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(192, 27);
            textBox7.TabIndex = 32;
            // 
            // btnClose
            // 
            btnClose.Enabled = false;
            btnClose.Font = new Font("Microsoft JhengHei UI", 10F);
            btnClose.Location = new Point(456, 80);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 29);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Sure
            // 
            Sure.Enabled = false;
            Sure.Font = new Font("Microsoft JhengHei UI", 10F);
            Sure.Location = new Point(456, 133);
            Sure.Name = "Sure";
            Sure.Size = new Size(59, 27);
            Sure.TabIndex = 34;
            Sure.Text = "Sure";
            Sure.UseVisualStyleBackColor = true;
            Sure.Click += Sure_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(38, 212);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(749, 27);
            textBox8.TabIndex = 35;
            // 
            // Paritycombobox
            // 
            Paritycombobox.FormattingEnabled = true;
            Paritycombobox.Location = new Point(206, 47);
            Paritycombobox.Name = "Paritycombobox";
            Paritycombobox.Size = new Size(78, 27);
            Paritycombobox.TabIndex = 36;
            // 
            // DataBitscombobox
            // 
            DataBitscombobox.FormattingEnabled = true;
            DataBitscombobox.Location = new Point(290, 47);
            DataBitscombobox.Name = "DataBitscombobox";
            DataBitscombobox.Size = new Size(78, 27);
            DataBitscombobox.TabIndex = 37;
            // 
            // StopBitscombobox
            // 
            StopBitscombobox.FormattingEnabled = true;
            StopBitscombobox.Location = new Point(374, 47);
            StopBitscombobox.Name = "StopBitscombobox";
            StopBitscombobox.Size = new Size(78, 27);
            StopBitscombobox.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 10F);
            label15.Location = new Point(287, 25);
            label15.Name = "label15";
            label15.Size = new Size(75, 22);
            label15.TabIndex = 39;
            label15.Text = "DataBits";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft JhengHei UI", 10F);
            label16.Location = new Point(374, 25);
            label16.Name = "label16";
            label16.Size = new Size(76, 22);
            label16.TabIndex = 40;
            label16.Text = "StopBits";
            // 
            // CRC_rec_textbox
            // 
            CRC_rec_textbox.Enabled = false;
            CRC_rec_textbox.Location = new Point(363, 179);
            CRC_rec_textbox.Name = "CRC_rec_textbox";
            CRC_rec_textbox.Size = new Size(87, 27);
            CRC_rec_textbox.TabIndex = 41;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(363, 163);
            label17.Name = "label17";
            label17.Size = new Size(67, 19);
            label17.TabIndex = 42;
            label17.Text = "CRC_rec";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(38, 190);
            label18.Name = "label18";
            label18.Size = new Size(60, 19);
            label18.TabIndex = 43;
            label18.Text = "label18";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(CRC_rec_textbox);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(StopBitscombobox);
            Controls.Add(DataBitscombobox);
            Controls.Add(Paritycombobox);
            Controls.Add(textBox8);
            Controls.Add(Sure);
            Controls.Add(btnClose);
            Controls.Add(textBox7);
            Controls.Add(HEX);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(Send);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(btnClickThis);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnClickThis;
        private Label label;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button Send;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label HEX;
        private TextBox textBox7;
        private Button btnClose;
        private Button Sure;
        private TextBox textBox8;
        private ComboBox Paritycombobox;
        private ComboBox DataBitscombobox;
        private ComboBox StopBitscombobox;
        private Label label15;
        private Label label16;
        private TextBox CRC_rec_textbox;
        private Label label17;
        private Label label18;
    }
}
