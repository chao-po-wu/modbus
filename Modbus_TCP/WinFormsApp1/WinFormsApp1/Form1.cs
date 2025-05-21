using System.Net.Sockets;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        string ipAddress;

        // Data
        byte Fuc;
        ushort StAdr, len;
        byte l1, l2, StAdr1, StAdr2;

        byte[] pakage = new byte[200];

        // MBAP
        ushort Transaction_Identifier = 1;
        byte TI1, TI2;
        ushort Protocol_Identifier = 0;
        byte PI1, PI2;
        ushort b_Length=6;
        byte b_Length1,b_Length2;
        byte Unit_Identifier;

        int counter_req = 12;
        public Form1()
        {
            InitializeComponent();
        }

        // �إ߳s�u
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // �]�wIP�BPort
                ipAddress = IP_textbox.Text;
                int.TryParse(Port_textbox.Text, out int port);
                // label1.Text = ipAddress;
                // label2.Text = port.ToString();

                // �s�u��Modbus���A��
                tcpClient = new TcpClient();
                tcpClient.Connect(ipAddress, port);
                if (tcpClient.Connected)
                {
                    label3.Text = "�s�u���\�I";
                    textBox3.Text = "�s�u��IP:" + ipAddress + " Port:" + port;
                    BtnDisconnect.Enabled = true;
                    BtnConnect.Enabled = false;
                    BtnSure.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                label3.Text = "�s�u���~�G" + ex.Message;
            }

        }

        // �����s�u
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
            label3.Text = "�s�u�_�}";
            textBox3.Clear();
            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;
            BtnSure.Enabled = false;
            BtnSend.Enabled = false;
        }

        // �إ߫ʥ]
        private void BtnSure_Click(object sender, EventArgs e)
        {
            byte.TryParse(Function.Text, out Fuc); // string��byte
            if (label8.Text == "False" | label9.Text == "False" | label10.Text == "False" | label11.Text == "False")
            {
                textBox4.Text = "False";
            }
            else
            {
                // MBAP
                //ushort Transaction_Identifier = 1;
                TI1 = (byte)(Transaction_Identifier >> 8);
                TI2 = (byte)(Transaction_Identifier & 0xFF);
                pakage[0] = TI2;
                pakage[1] = TI1;
                
                //ushort Protocol_Identifier = 0
                PI1 = (byte)(Protocol_Identifier >> 8);
                PI2 = (byte)(Protocol_Identifier & 0xFF);
                pakage[2] = PI1;
                pakage[3] = PI2;

                //ushort b_Length;
                b_Length1 = (byte)(b_Length >> 8);
                b_Length2 = (byte)(b_Length & 0xFF);
                pakage[4] = b_Length1;
                pakage[5] = b_Length2;

                //byte Unit_Identifier;
                byte.TryParse(Additional_Adr.Text, out Unit_Identifier);
                pakage[6] = Unit_Identifier;

                // Data
                pakage[7] = Fuc;
                pakage[8] = StAdr1;
                pakage[9] = StAdr2;
                pakage[10] = l1;
                pakage[11] = l2;

                string pakage_result = "";
                for (int i = 0; i < counter_req; i++)
                {
                    pakage_result += pakage[i].ToString("X2") + " ";
                }
                textBox4.Text = pakage_result;
                BtnSend.Enabled = true;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient.Connected)
                {
                    // ���o��Ƴq�D
                    NetworkStream stream = tcpClient.GetStream();

                    // �H�X�ʥ]
                    stream.Write(pakage, 0, counter_req);
                    label14.Text = "�ʥ]�w�e�X�I";
                    // �U���o�˼g�i�H�O�d�쥻�����e�A�b�᭱�s�W�@��
                    // textBox5.AppendText("\r\n�ʥ]�w�e�X�I");
                    
                    // ���ձ����^���]�p�G���^���^
                    if (stream.DataAvailable)
                    {
                        byte[] response = new byte[256];
                        int bytesRead = stream.Read(response, 0, response.Length);

                        string responseHex = "";
                        for (int i = 0; i < bytesRead; i++)
                        {
                            responseHex += response[i].ToString("X2") + " ";
                        }

                        textBox5.Text = "����^��:" + responseHex;
                        // textBox5.AppendText("\r\n����^���G" + responseHex);
                        Transaction_Identifier += 1;
                    }
                }
                else
                {
                    textBox5.Text = "�Х��s�u�I:";
                    // textBox5.AppendText("\r\n�Х��s�u�I");
                }
            }
            catch (Exception ex)
            {
                textBox5.AppendText("\r\n�o�e�ɵo�Ϳ��~�G" + ex.Message);
            }
        }


        private void Additional_Adr_TextChanged(object sender, EventArgs e)
        {
            // TryParse�ϥΤ�k�G(type).TryParse(string, out number)
            if (byte.TryParse(Additional_Adr.Text, out Unit_Identifier))
            {
                // ��ܬ� 2 ��ƤQ���i��
                string Adr_hex = Unit_Identifier.ToString("X2");
                label8.Text = Adr_hex;

            }
            else
            {
                label8.Text = "False"; // ��ܿ��~
            }
        }

        private void Function_TextChanged_1(object sender, EventArgs e)
        {
            if (byte.TryParse(Function.Text, out Fuc))
            {
                string Fuc_hex = Fuc.ToString("X2");
                label9.Text = Fuc_hex;
            }
            else
            {
                label9.Text = "False";
            }
        }

        private void StartAdr_TextChanged_1(object sender, EventArgs e)
        {
            if (ushort.TryParse(StartAdr.Text, out StAdr))
            {
                // �O�d����
                StAdr1 = (byte)(StAdr >> 8);
                // �O�d�C��
                StAdr2 = (byte)(StAdr & 0xFF);
                string Reg1_hex = StAdr1.ToString("X2");
                string Reg2_hex = StAdr2.ToString("X2");
                label10.Text = Reg1_hex.ToString() + Reg2_hex.ToString(); ;

            }
            else
            {
                label10.Text = "False";
            }
        }

        private void Length_TextChanged_1(object sender, EventArgs e)
        {
            if (ushort.TryParse(Length.Text, out len))
            {
                l1 = (byte)(len >> 8);
                l2 = (byte)(len & 0xFF);
                string len1_hex = l1.ToString("X2");
                string len2_hex = l2.ToString("X2");
                label11.Text = len1_hex + len2_hex;

            }
            else
            {
                label11.Text = "False";
            }
        }

        
    }
}
