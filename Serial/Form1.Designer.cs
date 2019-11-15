﻿namespace Serial
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
            this.comboBox_baud.Location = new System.Drawing.Point(5, 66);
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
            this.button_conn.Location = new System.Drawing.Point(5, 131);
            this.button_conn.Name = "button_conn";
            this.button_conn.Size = new System.Drawing.Size(73, 48);
            this.button_conn.TabIndex = 4;
            this.button_conn.Text = "Connect";
            this.button_conn.UseVisualStyleBackColor = true;
            this.button_conn.Click += new System.EventHandler(this.button_conn_Click);
            // 
            // textBox_send_ascii
            // 
            this.textBox_send_ascii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send_ascii.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_send_ascii.Location = new System.Drawing.Point(89, 560);
            this.textBox_send_ascii.Multiline = true;
            this.textBox_send_ascii.Name = "textBox_send_ascii";
            this.textBox_send_ascii.Size = new System.Drawing.Size(446, 117);
            this.textBox_send_ascii.TabIndex = 6;
            this.textBox_send_ascii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_send_ascii_KeyPress);
            // 
            // textBox_send_hex
            // 
            this.textBox_send_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send_hex.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_send_hex.Location = new System.Drawing.Point(541, 560);
            this.textBox_send_hex.Multiline = true;
            this.textBox_send_hex.Name = "textBox_send_hex";
            this.textBox_send_hex.Size = new System.Drawing.Size(446, 117);
            this.textBox_send_hex.TabIndex = 7;
            this.textBox_send_hex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_send_hex_KeyPress);
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
            this.textBox_recv_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ascii";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "hex";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 689);
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
    }
}
