// See https://aka.ms/new-console-template for more information
using System.IO.Ports;

// 讀取USB COM3
// 初始化 COM Port 設定
SerialPort port = new SerialPort("COM2"); //預設""，所以一定要設定
port.BaudRate = 9600; //預設9600
port.DataBits = 8;    //預設8
port.Parity = Parity.None; //預設None
port.StopBits = StopBits.One; //預設One

try
{
    port.Open();
    Console.WriteLine("COM2 已開啟");

    // 建立 Modbus RTU request封包
    byte deviceAddress = 0x01;
    byte functionCode = 0x03;
    ushort startAddress = 0x0000;
    ushort registerCount = 0x0008;
    byte[] request = BuildModbusRequest(deviceAddress, functionCode, startAddress, registerCount); // 地址1，讀取8筆

    // 傳送封包
    port.Write(request, 0, request.Length);

    Console.WriteLine("已送出 Modbus 請求:");
    foreach (byte b in request)
    {
        Console.Write($"{b:X2} ");
    }
    Console.WriteLine();

    // 等待設備回應
    System.Threading.Thread.Sleep(500);

    // 讀取回傳資料
    int bytesToRead = port.BytesToRead; //有多少資料待讀取
    byte[] response = new byte[bytesToRead];
    port.Read(response, 0, bytesToRead);
    Console.WriteLine("裝置回應： " + BitConverter.ToString(response));

}

catch (Exception ex)
{
    Console.WriteLine("發生錯誤: " + ex.Message);
}

finally
{
    if (port.IsOpen)
        port.Close();
}

Console.WriteLine("按任意鍵結束...");
Console.ReadLine();

// 建立 Modbus RTU 封包
static byte[] BuildModbusRequest(byte Address, byte functionCode, ushort startAddress, ushort numRegisters)
{
    byte[] frame = new byte[8];
    frame[0] = Address;
    frame[1] = functionCode;
    frame[2] = (byte)(startAddress >> 8);  // 保留高位元
    frame[3] = (byte)(startAddress & 0xFF);// 保留低位元
    frame[4] = (byte)(numRegisters >> 8);
    frame[5] = (byte)(numRegisters & 0xFF);

    ushort crc = CalculateCRC(frame, 6);
    frame[6] = (byte)(crc & 0xFF);       // CRC Low
    frame[7] = (byte)((crc >> 8) & 0xFF); // CRC High

    return frame;
}

// CalculateCRC
static ushort CalculateCRC(byte[] data, int length)
{
    ushort crc = 0xFFFF; //令 16-bit 暫存器 = 0xFFFF

    for (int i = 0; i < length; i++)
    {
        crc ^= data[i];
        for (int j = 0; j < 8; j++)
        {
            bool lsb = (crc & 0x0001) != 0;
            crc >>= 1;
            if (lsb)
                crc ^= 0xA001;
        }
    }

    return crc;
}