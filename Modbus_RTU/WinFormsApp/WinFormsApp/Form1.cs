using System.Drawing;
using System.IO.Ports;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        //// 建議可以用structure寫
        byte[] pakage = new byte[200];
        byte Additional_Adr; // 設備位置 1 byte
        byte Fuc; // function 1 byte
        ushort StartAdr; // 從哪個register 2 byte
        byte Reg1, Reg2;
        ushort Quantity; // 取多少 2 byte
        byte Q1, Q2;
        ushort counter_req=0; // 計算request封包大小
        ushort counter_rec=0; // 計算receive封包大小

        public Form1()
        {
            InitializeComponent();
            // add COM port to comboBox1
            for (int i = 1; i <= 10; i++)
            {
                string Items = "COM" + i.ToString();
                comboBox1.Items.Add(Items);
            }

            // add bps to comboBox2
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("38400");
            comboBox2.Items.Add("115200");

            // add Paritycombobox
            Paritycombobox.Items.Add("None");
            Paritycombobox.Items.Add("Even");
            Paritycombobox.Items.Add("Odd");
            Paritycombobox.Items.Add("Mark");
            Paritycombobox.Items.Add("Space");

            // add DataBitscombobox
            DataBitscombobox.Items.Add("8");
            DataBitscombobox.Items.Add("7");
            DataBitscombobox.Items.Add("6");

            // add StopBitscombobox
            StopBitscombobox.Items.Add("1");
            StopBitscombobox.Items.Add("2");

            //設定預設選單為第一個
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            Paritycombobox.SelectedIndex = 0;
            DataBitscombobox.SelectedIndex = 0;
            StopBitscombobox.SelectedIndex = 0;

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {

            // 初始化 COM Port 設定
            _serialPort = new SerialPort();

            string Port = comboBox1.SelectedItem.ToString();
            string Bps = comboBox2.SelectedItem.ToString();
            string parity = Paritycombobox.SelectedItem.ToString();
            string dataBit = DataBitscombobox.SelectedItem.ToString();
            string stopBits = StopBitscombobox.SelectedItem.ToString();
            // string stopBitsSetting = comboBox3.SelectedItem.ToString();

            // 1. 填入PortName，資料型態：string
            _serialPort.PortName = Port;

            // 2. 填入BaudRate，資料型態：ushort
            _serialPort.BaudRate = ushort.Parse(Bps);

            // 3. 填入Parity，資料型態：列舉，變數設Parity會撞
            // string parityOption = stopBitsSetting.Split(',')[0].Trim(); // 取得 "O" "E" "N"
            // 根據選項設定 Parity
            if (parity == "Odd")
            {
                _serialPort.Parity = Parity.Odd;  // 設定為奇校驗
            }
            else if (parity == "None")
            {
                _serialPort.Parity = Parity.None; // 設定為無校驗
            }
            else if (parity == "Even")
            {
                _serialPort.Parity = Parity.Even;
            }
            else if (parity == "Mark")
            {
                _serialPort.Parity = Parity.Mark;
            }
            else
            {
                _serialPort.Parity = Parity.Space;
            }

            // 4. 填入DataBits，資料型態：ushort
            // string DataBitsOption = stopBitsSetting.Split(',')[1].Trim();
            _serialPort.DataBits = ushort.Parse(dataBit);


            // 5. 填入StopBits，資料型態：列舉，變數設StopBits會撞
            // string StopBitsOption = stopBitsSetting.Split(',')[2].Trim();
            if (stopBits == "1")
            {
                _serialPort.StopBits = StopBits.One;
            }
            else if (stopBits == "2")
            {
                _serialPort.StopBits = StopBits.Two;
            }

            try
            {
                // 檢查指定COM port是否存在、是否有其他程式正在使用這個 port
                _serialPort.Open();
                label.Text = Port + "已開啟";
                textBox6.Text = Port + ", " + Bps + ", " + parity + ", " + dataBit + ", " + stopBits;

                // Enable btn
                btnClickThis.Enabled = false;
                btnClose.Enabled = true;
                Sure.Enabled = true;

            }
            catch (Exception ex)
            {
                label.Text = "發生錯誤: " + ex.Message;
                textBox6.Clear();
            }
        }

        // TextChanged：即時檢查
        // address(1 byte) change
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TryParse使用方法：(type).TryParse(string, out number)
            if (byte.TryParse(textBox1.Text, out Additional_Adr))
            {
                // 顯示為 2 位數十六進位
                string Adr_hex = Additional_Adr.ToString("X2");
                label11.Text = Adr_hex;
                
            }
            else
            {
                label11.Text = "False"; // 顯示錯誤
            }
        }

        // Fuc(1 byte) change
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (byte.TryParse(textBox2.Text, out Fuc))
            {
                string Fuc_hex = Fuc.ToString("X2");
                label12.Text = Fuc_hex;
            }
            else
            {
                label12.Text = "False";
            }
        }

        // Register(2 byte) change
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (ushort.TryParse(textBox3.Text, out StartAdr))
            {
                // 保留高位
                Reg1 = (byte)(StartAdr >> 8);
                // 保留低位
                Reg2 = (byte)(StartAdr & 0xFF);
                string Reg1_hex = Reg1.ToString("X2");
                string Reg2_hex = Reg2.ToString("X2");
                label13.Text = Reg1_hex.ToString() + Reg2_hex.ToString(); ;
                
            }
            else
            {
                label13.Text = "False";
            }
        }

        // Length(2 byte) change
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (ushort.TryParse(textBox4.Text, out Quantity))
            {
                Q1 = (byte)(Quantity >> 8);
                Q2 = (byte)(Quantity & 0xFF);
                string len1_hex = Q1.ToString("X2");
                string len2_hex = Q2.ToString("X2");
                label14.Text = len1_hex + len2_hex;
                
            }
            else
            {
                label14.Text = "False";
            }

        }

        private void Sure_Click(object sender, EventArgs e)
        {
            if (label11.Text == "False" | label12.Text == "False" | label13.Text == "False" | label14.Text == "False")
            {
                textBox7.Text = "False";
                Send.Enabled = false;
            }
            else
            {
                // 建立 Modbus RTU request封包
                pakage[0] = Additional_Adr;
                counter_req += 1;

                pakage[1] = Fuc;
                counter_req += 1;

                pakage[2] = Reg1;
                pakage[3] = Reg2;
                counter_req += 2;

                pakage[4] = Q1;
                pakage[5] = Q2;
                counter_req += 2;

                ushort CRC = CalculateCRC(pakage, 6);
                pakage[6] = (byte)(CRC & 0xFF);
                pakage[7] = (byte)((CRC >> 8) & 0xFF);
                counter_req += 2;
                textBox5.Text = pakage[6].ToString("X2") + pakage[7].ToString("X2");

                string pakage_result = "";
                for (int i = 0; i < counter_req; i++) 
                {
                    pakage_result += pakage[i].ToString("X2") + " ";
                }
                //foreach (byte b in pakage)
                //{
                //    pakage_result += b.ToString("X2") + " ";
                //}
                textBox7.Text = pakage_result;
                Send.Enabled = true;
                counter_rec = counter_req;
                counter_req = 0;
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            // 傳送封包
            // https://learn.microsoft.com/zh-tw/dotnet/api/system.io.ports.serialport.write?view=net-9.0-pp&viewFallbackFrom=dotnet-plat-ext-8.0
            _serialPort.Write(pakage, 0, counter_rec); //位元組 偏移量 寫入長度

            // 等待設備回應
            Thread.Sleep(500);

            // 讀取回傳資料 Returns the number of bytes read.
            // https://learn.microsoft.com/zh-tw/dotnet/api/system.io.ports.serialport.read?view=net-9.0-pp&viewFallbackFrom=dotnet-plat-ext-8.0
            int bytesToRead = _serialPort.BytesToRead; // 知道有多少資料要讀
            byte[] receive = new byte[bytesToRead]; // 要存丟回來的資料

            // 回應的資料：fuc(1 byte) + byte count(1 byte) + Register value(2*N byte)
            int bytesRead = _serialPort.Read(receive, 0, bytesToRead); // bytearray存回傳資料 偏移量 要讀多少

            // 檢查回傳的CRC是否吻合
            ushort CRC_return = CalculateCRC(receive, bytesToRead-2);
            byte CRC_return1, CRC_return2;
            CRC_return1 = (byte)(CRC_return & 0xFF);
            CRC_return2 = (byte)(CRC_return >> 8);
            CRC_rec_textbox.Text = CRC_return1.ToString("X2") + CRC_return2.ToString("X2");

            if((receive[bytesToRead - 2] == CRC_return1) & (receive[bytesToRead - 1]) == CRC_return2)
            {
                label18.Text = "True";
                // 顯示回傳資料的內容
                string result = "";
                foreach (byte b in receive)
                {
                    result += b.ToString("X2") + " ";
                }
                textBox8.Text = result;
            }
            else
            {
                label18.Text = "False";
            }
        }

        ushort CalculateCRC(byte[] data, int length)
        {
            // 計算檢查碼 CRC-16多項式是A001(8005反轉)
            // 步驟1: 令 16-bit 暫存器 (CRC 暫存器) = 0xFFFF。
            ushort crc = 0xFFFF;
            // 步驟2: Exclusive OR 第一個 8-bit byte 的訊息指令與低位元 16-bit CRC 暫存器, 
            // 做 Exclusive OR 將結果存入 CRC 暫存器內。
            for (int i = 0; i < length; i++)
            {
                crc ^= data[i];
                // 步驟3: 檢查最右值, 如果是 0 將CRC右移, 否則 Exclusive OR 
                // 0xA001 與 CRC 暫存器, 將結果存入 CRC 暫存器內。
                for (int j = 0; j < 8; j++)
                {
                    bool n = (crc & 1) == 0; //最右值是0是true 最右值1是false
                    if (n)
                    {
                        crc >>= 1;
                    }
                    else
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                }
                // 步驟4: 重複步驟3, 將 8-bit 全部運算完成。
            }
            // 步驟5: 重複步驟2~步驟4, 取下一個 8-bit 的訊息指令, 直到所有訊息指令運算完成。
            
            
            // 最後, 得到的 CRC 暫存器的值, 即是 CRC 的檢查碼，回傳回去。
            return crc;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            // 點close按鈕port也隨之關閉
            _serialPort.Close();
            label.Text = _serialPort.PortName + "已關閉";


            btnClickThis.Enabled = true;
            btnClose.Enabled = false;
            Send.Enabled = false;
            Sure.Enabled = false;
        }

        
    }
}
