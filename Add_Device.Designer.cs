using System.ComponentModel;

namespace Smart_Lamp_Controller
{
    partial class Add_Device
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Connecting_to_known_ip_progress = new System.Windows.Forms.ProgressBar();
            this.IP_Known_Connnect_Btn = new System.Windows.Forms.Button();
            this.known_Ipadress_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bleDeviceList = new System.Windows.Forms.ListBox();
            this.bleTxt = new System.Windows.Forms.Label();
            this.bleDeviceConnect = new System.Windows.Forms.Button();
            this.bluetooth_Search_progress = new System.Windows.Forms.ProgressBar();
            this.bleScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(138, -72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 83);
            this.label3.TabIndex = 24;
            this.label3.Text = "Add New Device";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Connecting_to_known_ip_progress);
            this.groupBox1.Controls.Add(this.IP_Known_Connnect_Btn);
            this.groupBox1.Controls.Add(this.known_Ipadress_Textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 237);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address";
            // 
            // Connecting_to_known_ip_progress
            // 
            this.Connecting_to_known_ip_progress.Location = new System.Drawing.Point(6, 204);
            this.Connecting_to_known_ip_progress.Name = "Connecting_to_known_ip_progress";
            this.Connecting_to_known_ip_progress.Size = new System.Drawing.Size(367, 27);
            this.Connecting_to_known_ip_progress.TabIndex = 28;
            // 
            // IP_Known_Connnect_Btn
            // 
            this.IP_Known_Connnect_Btn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.IP_Known_Connnect_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IP_Known_Connnect_Btn.ForeColor = System.Drawing.Color.White;
            this.IP_Known_Connnect_Btn.Location = new System.Drawing.Point(6, 141);
            this.IP_Known_Connnect_Btn.Name = "IP_Known_Connnect_Btn";
            this.IP_Known_Connnect_Btn.Padding = new System.Windows.Forms.Padding(1);
            this.IP_Known_Connnect_Btn.Size = new System.Drawing.Size(367, 50);
            this.IP_Known_Connnect_Btn.TabIndex = 27;
            this.IP_Known_Connnect_Btn.Text = "Connect!";
            this.IP_Known_Connnect_Btn.UseVisualStyleBackColor = false;
            this.IP_Known_Connnect_Btn.Click += new System.EventHandler(this.IP_Known_Connnect_Btn_Click);
            // 
            // known_Ipadress_Textbox
            // 
            this.known_Ipadress_Textbox.Location = new System.Drawing.Point(80, 78);
            this.known_Ipadress_Textbox.Name = "known_Ipadress_Textbox";
            this.known_Ipadress_Textbox.Size = new System.Drawing.Size(216, 26);
            this.known_Ipadress_Textbox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "If you know the IP address please enter here!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bleDeviceList);
            this.groupBox2.Controls.Add(this.bleTxt);
            this.groupBox2.Controls.Add(this.bleDeviceConnect);
            this.groupBox2.Controls.Add(this.bluetooth_Search_progress);
            this.groupBox2.Controls.Add(this.bleScan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(410, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 237);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth ";
            // 
            // bleDeviceList
            // 
            this.bleDeviceList.FormattingEnabled = true;
            this.bleDeviceList.ItemHeight = 20;
            this.bleDeviceList.Location = new System.Drawing.Point(6, 48);
            this.bleDeviceList.Name = "bleDeviceList";
            this.bleDeviceList.Size = new System.Drawing.Size(366, 104);
            this.bleDeviceList.TabIndex = 34;
            // 
            // bleTxt
            // 
            this.bleTxt.Location = new System.Drawing.Point(6, 22);
            this.bleTxt.Name = "bleTxt";
            this.bleTxt.Size = new System.Drawing.Size(367, 23);
            this.bleTxt.TabIndex = 33;
            this.bleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bleDeviceConnect
            // 
            this.bleDeviceConnect.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.bleDeviceConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bleDeviceConnect.Location = new System.Drawing.Point(193, 161);
            this.bleDeviceConnect.Name = "bleDeviceConnect";
            this.bleDeviceConnect.Padding = new System.Windows.Forms.Padding(1);
            this.bleDeviceConnect.Size = new System.Drawing.Size(180, 37);
            this.bleDeviceConnect.TabIndex = 32;
            this.bleDeviceConnect.Text = "Connect";
            this.bleDeviceConnect.UseVisualStyleBackColor = false;
            this.bleDeviceConnect.Click += new System.EventHandler(this.bleDeviceConnect_Click);
            // 
            // bluetooth_Search_progress
            // 
            this.bluetooth_Search_progress.Location = new System.Drawing.Point(6, 204);
            this.bluetooth_Search_progress.Name = "bluetooth_Search_progress";
            this.bluetooth_Search_progress.Size = new System.Drawing.Size(366, 27);
            this.bluetooth_Search_progress.TabIndex = 29;
            // 
            // bleScan
            // 
            this.bleScan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bleScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bleScan.Location = new System.Drawing.Point(6, 161);
            this.bleScan.Name = "bleScan";
            this.bleScan.Padding = new System.Windows.Forms.Padding(1);
            this.bleScan.Size = new System.Drawing.Size(180, 37);
            this.bleScan.TabIndex = 28;
            this.bleScan.Text = "Scan";
            this.bleScan.UseVisualStyleBackColor = false;
            this.bleScan.Click += new System.EventHandler(this.bleScan_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 83);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add New Device";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(768, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Device";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Device";
            this.Load += new System.EventHandler(this.Add_Device_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox dd;

        private System.Windows.Forms.Label bleTxt;

        private System.Windows.Forms.Button IP_Known_Connnect_Btn;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        #endregion
    }
}