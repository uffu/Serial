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

            serial.DataReceived += Serial_DataReceived;
            serial.ErrorReceived += Serial_ErrorReceived;

            CheckForIllegalCrossThreadCalls = false;

            initGui();
        }

        private void initGui()
        {
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(SerialPort.GetPortNames());
            if (comboBox_ports.Items.Count > 0)
                comboBox_ports.SelectedIndex = 0;

            radioButton_r.Checked = true;

            // Single bar to avoid short-circuit
            if (load_buttons("ascii.txt", groupBox_ascii, ascii_button_Click) | load_buttons("hex.txt", groupBox_hex, hex_button_Click))
                Height += 150;
        }

        private bool load_buttons(string file, GroupBox gb, EventHandler click)
        {
            if (System.IO.File.Exists(file))
            {
                FlowLayoutPanel f = new FlowLayoutPanel();
                f.WrapContents = true;
                f.AutoScroll = true;
                f.FlowDirection = FlowDirection.LeftToRight;
                f.Dock = DockStyle.Fill;
                gb.Controls.Add(f);
                gb.Visible = true;
                try
                {
                    foreach (string line in System.IO.File.ReadAllLines(file))
                    {
                        Button b = new Button();
                        b.Text = line;
                        b.Click += click;
                        f.Controls.Add(b);
                    }
                }
                catch { }
                return true;
            }
            else
                return false;
        }
        private void hex_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox_send_hex.Text = b.Text.Split(' ')[1];
            button_send.PerformClick();
        }
        private void ascii_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox_send_ascii.Text = b.Text.Split(' ')[1];
            button_send.PerformClick();
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

        

        private char NewLine = ' ';
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serial.BytesToRead > 0)
                {
                    byte[] buffer = new byte[256];
                    int count = serial.Read(buffer, 0, buffer.Length);

                    string hex = "";
                    string ascii = "";
                    for (int i = 0; i < count; i++)
                    {
                        hex += " " + buffer[i].ToString("X2");
                        if (buffer[i] == NewLine)
                            hex += "\r\n";
                        ascii += Tools.toChar(buffer[i]);
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

        private void radioButton_newline_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_n.Checked)
                NewLine = '\n';
            else if (radioButton_r.Checked)
                NewLine = '\r';
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_recv_hex.Clear();
            textBox_recv_ascii.Clear();
        }

        private void textBox_send_hex_TextChanged(object sender, EventArgs e)
        {
            textBox_send_ascii.TextChanged -= textBox_send_ascii_TextChanged;
            textBox_send_ascii.Text = Tools.toAscii(textBox_send_hex.Text);
            textBox_send_ascii.TextChanged += textBox_send_ascii_TextChanged;
        }

        private void textBox_send_ascii_TextChanged(object sender, EventArgs e)
        {
            textBox_send_hex.TextChanged -= textBox_send_hex_TextChanged;
            textBox_send_hex.Text = Tools.toHex(textBox_send_ascii.Text);
            textBox_send_hex.TextChanged += textBox_send_hex_TextChanged;
        }
    }
}
