namespace Serial
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_conn = new System.Windows.Forms.Button();
            this.textBox_send_ascii = new System.Windows.Forms.TextBox();
            this.textBox_send_hex = new System.Windows.Forms.TextBox();
            this.textBox_recv_ascii = new System.Windows.Forms.TextBox();
            this.textBox_recv_hex = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_n = new System.Windows.Forms.RadioButton();
            this.radioButton_r = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox_hex = new System.Windows.Forms.GroupBox();
            this.groupBox_ascii = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(5, 31);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(73, 21);
            this.comboBox_ports.TabIndex = 0;
            this.comboBox_ports.DropDown += new System.EventHandler(this.comboBox_ports_DropDown);
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.comboBox_baud.Location = new System.Drawing.Point(5, 58);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(73, 59);
            this.comboBox_baud.TabIndex = 1;
            this.comboBox_baud.Text = "115200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // button_conn
            // 
            this.button_conn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_conn.Location = new System.Drawing.Point(5, 123);
            this.button_conn.Name = "button_conn";
            this.button_conn.Size = new System.Drawing.Size(73, 48);
            this.button_conn.TabIndex = 4;
            this.button_conn.Text = "Connect";
            this.button_conn.UseVisualStyleBackColor = true;
            this.button_conn.Click += new System.EventHandler(this.button_conn_Click);
            // 
            // textBox_send_ascii
            // 
            this.textBox_send_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send_ascii.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_send_ascii.Location = new System.Drawing.Point(89, 560);
            this.textBox_send_ascii.Multiline = true;
            this.textBox_send_ascii.Name = "textBox_send_ascii";
            this.textBox_send_ascii.Size = new System.Drawing.Size(446, 117);
            this.textBox_send_ascii.TabIndex = 6;
            this.textBox_send_ascii.TextChanged += new System.EventHandler(this.textBox_send_ascii_TextChanged);
            // 
            // textBox_send_hex
            // 
            this.textBox_send_hex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send_hex.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_send_hex.Location = new System.Drawing.Point(541, 560);
            this.textBox_send_hex.Multiline = true;
            this.textBox_send_hex.Name = "textBox_send_hex";
            this.textBox_send_hex.Size = new System.Drawing.Size(446, 117);
            this.textBox_send_hex.TabIndex = 7;
            this.textBox_send_hex.TextChanged += new System.EventHandler(this.textBox_send_hex_TextChanged);
            // 
            // textBox_recv_ascii
            // 
            this.textBox_recv_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recv_ascii.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recv_ascii.Location = new System.Drawing.Point(89, 12);
            this.textBox_recv_ascii.Multiline = true;
            this.textBox_recv_ascii.Name = "textBox_recv_ascii";
            this.textBox_recv_ascii.ReadOnly = true;
            this.textBox_recv_ascii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recv_ascii.Size = new System.Drawing.Size(898, 262);
            this.textBox_recv_ascii.TabIndex = 8;
            // 
            // textBox_recv_hex
            // 
            this.textBox_recv_hex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recv_hex.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recv_hex.Location = new System.Drawing.Point(89, 280);
            this.textBox_recv_hex.Multiline = true;
            this.textBox_recv_hex.Name = "textBox_recv_hex";
            this.textBox_recv_hex.ReadOnly = true;
            this.textBox_recv_hex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recv_hex.Size = new System.Drawing.Size(898, 262);
            this.textBox_recv_hex.TabIndex = 9;
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_send.Enabled = false;
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(5, 560);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(73, 117);
            this.button_send.TabIndex = 10;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ascii";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "hex";
            // 
            // radioButton_n
            // 
            this.radioButton_n.AutoSize = true;
            this.radioButton_n.Location = new System.Drawing.Point(6, 19);
            this.radioButton_n.Name = "radioButton_n";
            this.radioButton_n.Size = new System.Drawing.Size(69, 17);
            this.radioButton_n.TabIndex = 14;
            this.radioButton_n.TabStop = true;
            this.radioButton_n.Text = "\\n (0x0A)";
            this.radioButton_n.UseVisualStyleBackColor = true;
            this.radioButton_n.CheckedChanged += new System.EventHandler(this.radioButton_newline_CheckedChanged);
            // 
            // radioButton_r
            // 
            this.radioButton_r.AutoSize = true;
            this.radioButton_r.Location = new System.Drawing.Point(6, 43);
            this.radioButton_r.Name = "radioButton_r";
            this.radioButton_r.Size = new System.Drawing.Size(67, 17);
            this.radioButton_r.TabIndex = 15;
            this.radioButton_r.TabStop = true;
            this.radioButton_r.Text = "\\r (0x0D)";
            this.radioButton_r.UseVisualStyleBackColor = true;
            this.radioButton_r.CheckedChanged += new System.EventHandler(this.radioButton_newline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_n);
            this.groupBox1.Controls.Add(this.radioButton_r);
            this.groupBox1.Location = new System.Drawing.Point(5, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 71);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Line";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(5, 185);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(73, 28);
            this.button_clear.TabIndex = 18;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox_hex
            // 
            this.groupBox_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_hex.Location = new System.Drawing.Point(541, 683);
            this.groupBox_hex.Name = "groupBox_hex";
            this.groupBox_hex.Size = new System.Drawing.Size(446, 1);
            this.groupBox_hex.TabIndex = 19;
            this.groupBox_hex.TabStop = false;
            this.groupBox_hex.Text = "hex";
            this.groupBox_hex.Visible = false;
            // 
            // groupBox_ascii
            // 
            this.groupBox_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_ascii.Location = new System.Drawing.Point(89, 683);
            this.groupBox_ascii.Name = "groupBox_ascii";
            this.groupBox_ascii.Size = new System.Drawing.Size(446, 1);
            this.groupBox_ascii.TabIndex = 20;
            this.groupBox_ascii.TabStop = false;
            this.groupBox_ascii.Text = "hex";
            this.groupBox_ascii.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 689);
            this.Controls.Add(this.groupBox_ascii);
            this.Controls.Add(this.groupBox_hex);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_recv_hex);
            this.Controls.Add(this.textBox_recv_ascii);
            this.Controls.Add(this.textBox_send_hex);
            this.Controls.Add(this.textBox_send_ascii);
            this.Controls.Add(this.button_conn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_baud);
            this.Controls.Add(this.comboBox_ports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_conn;
        private System.Windows.Forms.TextBox textBox_send_ascii;
        private System.Windows.Forms.TextBox textBox_send_hex;
        private System.Windows.Forms.TextBox textBox_recv_ascii;
        private System.Windows.Forms.TextBox textBox_recv_hex;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_n;
        private System.Windows.Forms.RadioButton radioButton_r;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox_hex;
        private System.Windows.Forms.GroupBox groupBox_ascii;
    }
}

