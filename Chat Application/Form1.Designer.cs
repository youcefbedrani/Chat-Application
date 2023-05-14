namespace Chat_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.client_1 = new System.Windows.Forms.GroupBox();
            this.port1 = new System.Windows.Forms.Label();
            this.ip1 = new System.Windows.Forms.Label();
            this.port11 = new System.Windows.Forms.TextBox();
            this.ip11 = new System.Windows.Forms.TextBox();
            this.client_2 = new System.Windows.Forms.GroupBox();
            this.port2 = new System.Windows.Forms.Label();
            this.port22 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.Label();
            this.ip22 = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.list_message = new System.Windows.Forms.ListBox();
            this.connect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.client_1.SuspendLayout();
            this.client_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // client_1
            // 
            this.client_1.Controls.Add(this.port1);
            this.client_1.Controls.Add(this.ip1);
            this.client_1.Controls.Add(this.port11);
            this.client_1.Controls.Add(this.ip11);
            this.client_1.Location = new System.Drawing.Point(76, 93);
            this.client_1.Name = "client_1";
            this.client_1.Size = new System.Drawing.Size(576, 324);
            this.client_1.TabIndex = 0;
            this.client_1.TabStop = false;
            this.client_1.Text = "Client1";
            this.client_1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // port1
            // 
            this.port1.AutoSize = true;
            this.port1.Location = new System.Drawing.Point(25, 199);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(106, 48);
            this.port1.TabIndex = 5;
            this.port1.Text = "PORT";
            this.port1.Click += new System.EventHandler(this.port1_Click);
            // 
            // ip1
            // 
            this.ip1.AutoSize = true;
            this.ip1.Location = new System.Drawing.Point(38, 101);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(50, 48);
            this.ip1.TabIndex = 4;
            this.ip1.Text = "IP";
            this.ip1.Click += new System.EventHandler(this.label1_Click);
            // 
            // port11
            // 
            this.port11.Location = new System.Drawing.Point(147, 196);
            this.port11.Name = "port11";
            this.port11.Size = new System.Drawing.Size(385, 55);
            this.port11.TabIndex = 2;
            this.port11.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ip11
            // 
            this.ip11.Location = new System.Drawing.Point(147, 98);
            this.ip11.Name = "ip11";
            this.ip11.Size = new System.Drawing.Size(385, 55);
            this.ip11.TabIndex = 3;
            // 
            // client_2
            // 
            this.client_2.Controls.Add(this.port2);
            this.client_2.Controls.Add(this.port22);
            this.client_2.Controls.Add(this.ip2);
            this.client_2.Controls.Add(this.ip22);
            this.client_2.Location = new System.Drawing.Point(713, 93);
            this.client_2.Name = "client_2";
            this.client_2.Size = new System.Drawing.Size(598, 324);
            this.client_2.TabIndex = 1;
            this.client_2.TabStop = false;
            this.client_2.Text = "Client2";
            // 
            // port2
            // 
            this.port2.AutoSize = true;
            this.port2.Location = new System.Drawing.Point(30, 199);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(106, 48);
            this.port2.TabIndex = 7;
            this.port2.Text = "PORT";
            // 
            // port22
            // 
            this.port22.Location = new System.Drawing.Point(177, 196);
            this.port22.Name = "port22";
            this.port22.Size = new System.Drawing.Size(384, 55);
            this.port22.TabIndex = 4;
            this.port22.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ip2
            // 
            this.ip2.AutoSize = true;
            this.ip2.Location = new System.Drawing.Point(47, 101);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(50, 48);
            this.ip2.TabIndex = 6;
            this.ip2.Text = "IP";
            this.ip2.Click += new System.EventHandler(this.label4_Click);
            // 
            // ip22
            // 
            this.ip22.Location = new System.Drawing.Point(177, 101);
            this.ip22.Name = "ip22";
            this.ip22.Size = new System.Drawing.Size(384, 55);
            this.ip22.TabIndex = 5;
            this.ip22.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(76, 980);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(1249, 134);
            this.textMessage.TabIndex = 4;
            // 
            // list_message
            // 
            this.list_message.FormattingEnabled = true;
            this.list_message.ItemHeight = 48;
            this.list_message.Location = new System.Drawing.Point(76, 466);
            this.list_message.Name = "list_message";
            this.list_message.Size = new System.Drawing.Size(1532, 484);
            this.list_message.TabIndex = 5;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(1372, 187);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(225, 69);
            this.connect.TabIndex = 6;
            this.connect.Text = "Start";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(1372, 987);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(225, 127);
            this.send.TabIndex = 7;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stop.Location = new System.Drawing.Point(1372, 292);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(225, 69);
            this.stop.TabIndex = 8;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1176);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.send);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.list_message);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.client_2);
            this.Controls.Add(this.client_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.client_1.ResumeLayout(false);
            this.client_1.PerformLayout();
            this.client_2.ResumeLayout(false);
            this.client_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox client_1;
        private Label port1;
        private Label ip1;
        private TextBox port11;
        private TextBox ip11;
        private GroupBox client_2;
        private Label port2;
        private TextBox port22;
        private Label ip2;
        private TextBox ip22;
        private TextBox textMessage;
        private ListBox list_message;
        private Button connect;
        private Button send;
        private Button stop;
    }
}