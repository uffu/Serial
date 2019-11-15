using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace Serial
{
    public partial class MainForm : Form
    {
        private SerialPort serial = new SerialPort();
        public MainForm()
        {
            InitializeComponent();

            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(SerialPort.GetPortNames());
            if(comboBox_ports.Items.Count > 0)
                comboBox_ports.SelectedIndex = 0;

            serial.DataReceived += Serial_DataReceived;
            serial.ErrorReceived += Serial_ErrorReceived;

            CheckForIllegalCrossThreadCalls = false;
        }

        private void Serial_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (serial.IsOpen)            
                serial.Close();
            
            button_conn.Text = serial.IsOpen ? "Disconnect" : "Connect";
            button_send.Enabled = serial.IsOpen;
        }

        private void comboBox_ports_DropDown(object sender, EventArgs e)
        {
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button_conn_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
            }
            else
            {
                try
                {
                    serial.BaudRate = int.Parse(comboBox_baud.Text);
                    serial.PortName = comboBox_ports.Text;
                    serial.Open();
                }
                catch { return; }
            }

            button_conn.Text = serial.IsOpen ? "Disconnect" : "Connect";
            button_send.Enabled = serial.IsOpen;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serial.IsOpen)            
                serial.Close();            
        }

        private void textBox_send_ascii_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_send_hex.Text = Tools.toHex(textBox_send_ascii.Text);
        }

        private void textBox_send_hex_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_send_ascii.Text = Tools.toAscii(textBox_send_hex.Text);
        }






        private byte[] buffer = new byte[256];
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serial.BytesToRead > 0)
                {
                    int count = serial.Read(buffer, 0, 256);

                    string ascii = "";
                    string hex = "";
                    for (int i = 0; i < count; i++)
                    {
                        char c = Convert.ToChar(buffer[i]);
                        hex += " " + buffer[i].ToString("X2");
                        if (c == '\n')
                            hex += "\r\n";
                        ascii += c.ToString();
                    }
                    textBox_recv_hex.AppendText(hex);
                    textBox_recv_ascii.AppendText(ascii);
                }
            }
            catch { }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string hex = textBox_send_hex.Text;
            List<byte> s = new List<byte>();
            for (int i = 0; i < hex.Length; i += 2)            
                s.Add((byte)Convert.ToUInt32(hex.Substring(i, 2), 16));
            
            serial.Write(s.ToArray(), 0, s.Count);
        }
    }
}
