namespace WinFormsApp1
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
            IP_textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Port_textbox = new TextBox();
            BtnConnect = new Button();
            label3 = new Label();
            Additional_Adr = new TextBox();
            Function = new TextBox();
            StartAdr = new TextBox();
            Length = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            HEX = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            BtnSure = new Button();
            BtnSend = new Button();
            BtnDisconnect = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // IP_textbox
            // 
            IP_textbox.Location = new Point(70, 52);
            IP_textbox.Name = "IP_textbox";
            IP_textbox.Size = new Size(96, 27);
            IP_textbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 1;
            label1.Text = "IP_label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 30);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 2;
            label2.Text = "Port_label";
            // 
            // Port_textbox
            // 
            Port_textbox.Location = new Point(202, 52);
            Port_textbox.Name = "Port_textbox";
            Port_textbox.Size = new Size(96, 27);
            Port_textbox.TabIndex = 3;
            // 
            // BtnConnect
            // 
            BtnConnect.Location = new Point(334, 15);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(94, 29);
            BtnConnect.TabIndex = 4;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += BtnConnect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 20);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Additional_Adr
            // 
            Additional_Adr.Location = new Point(70, 125);
            Additional_Adr.Name = "Additional_Adr";
            Additional_Adr.Size = new Size(96, 27);
            Additional_Adr.TabIndex = 6;
            Additional_Adr.TextChanged += Additional_Adr_TextChanged;
            // 
            // Function
            // 
            Function.Location = new Point(202, 125);
            Function.Name = "Function";
            Function.Size = new Size(69, 27);
            Function.TabIndex = 7;
            Function.TextChanged += Function_TextChanged_1;
            // 
            // StartAdr
            // 
            StartAdr.Location = new Point(292, 125);
            StartAdr.Name = "StartAdr";
            StartAdr.Size = new Size(69, 27);
            StartAdr.TabIndex = 8;
            StartAdr.TextChanged += StartAdr_TextChanged_1;
            // 
            // Length
            // 
            Length.Location = new Point(384, 125);
            Length.Name = "Length";
            Length.Size = new Size(69, 27);
            Length.TabIndex = 9;
            Length.TextChanged += Length_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 103);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 10;
            label4.Text = "Additional_Adr";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 103);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 11;
            label5.Text = "Function";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 103);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 12;
            label6.Text = "StartAdr";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 103);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 13;
            label7.Text = "Length";
            // 
            // HEX
            // 
            HEX.AutoSize = true;
            HEX.Location = new Point(24, 157);
            HEX.Name = "HEX";
            HEX.Size = new Size(41, 19);
            HEX.TabIndex = 14;
            HEX.Text = "HEX:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 157);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 157);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 16;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(293, 157);
            label10.Name = "label10";
            label10.Size = new Size(60, 19);
            label10.TabIndex = 17;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(384, 155);
            label11.Name = "label11";
            label11.Size = new Size(60, 19);
            label11.TabIndex = 18;
            label11.Text = "label11";
            // 
            // BtnSure
            // 
            BtnSure.Enabled = false;
            BtnSure.Location = new Point(466, 125);
            BtnSure.Name = "BtnSure";
            BtnSure.Size = new Size(56, 29);
            BtnSure.TabIndex = 19;
            BtnSure.Text = "Sure";
            BtnSure.UseVisualStyleBackColor = true;
            BtnSure.Click += BtnSure_Click;
            // 
            // BtnSend
            // 
            BtnSend.Enabled = false;
            BtnSend.Location = new Point(528, 125);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(56, 29);
            BtnSend.TabIndex = 20;
            BtnSend.Text = "Send";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // BtnDisconnect
            // 
            BtnDisconnect.Enabled = false;
            BtnDisconnect.Location = new Point(334, 50);
            BtnDisconnect.Name = "BtnDisconnect";
            BtnDisconnect.Size = new Size(94, 29);
            BtnDisconnect.TabIndex = 21;
            BtnDisconnect.Text = "Disconnect";
            BtnDisconnect.UseVisualStyleBackColor = true;
            BtnDisconnect.Click += BtnDisconnect_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(449, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 27);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(717, 27);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(70, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(717, 27);
            textBox5.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(-4, 262);
            label12.Name = "label12";
            label12.Size = new Size(69, 19);
            label12.TabIndex = 25;
            label12.Text = "發送內容";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(-4, 348);
            label13.Name = "label13";
            label13.Size = new Size(69, 19);
            label13.TabIndex = 26;
            label13.Text = "收到內容";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(590, 128);
            label14.Name = "label14";
            label14.Size = new Size(60, 19);
            label14.TabIndex = 27;
            label14.Text = "label14";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(BtnDisconnect);
            Controls.Add(BtnSend);
            Controls.Add(BtnSure);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(HEX);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Length);
            Controls.Add(StartAdr);
            Controls.Add(Function);
            Controls.Add(Additional_Adr);
            Controls.Add(label3);
            Controls.Add(BtnConnect);
            Controls.Add(Port_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IP_textbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IP_textbox;
        private Label label1;
        private Label label2;
        private TextBox Port_textbox;
        private Button BtnConnect;
        private Label label3;
        private TextBox Additional_Adr;
        private TextBox Function;
        private TextBox StartAdr;
        private TextBox Length;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label HEX;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button BtnSure;
        private Button BtnSend;
        private Button BtnDisconnect;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
