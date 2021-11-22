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
            this.ScanTime = new System.Windows.Forms.ComboBox();
            this.bleDeviceConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bleDeviceList = new System.Windows.Forms.ListBox();
            this.bluetooth_Search_progress = new System.Windows.Forms.ProgressBar();
            this.bleScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.IP_Known_Connnect_Btn.Location = new System.Drawing.Point(123, 124);
            this.IP_Known_Connnect_Btn.Name = "IP_Known_Connnect_Btn";
            this.IP_Known_Connnect_Btn.Size = new System.Drawing.Size(118, 50);
            this.IP_Known_Connnect_Btn.TabIndex = 27;
            this.IP_Known_Connnect_Btn.Text = "Connect!";
            this.IP_Known_Connnect_Btn.UseVisualStyleBackColor = true;
            // 
            // known_Ipadress_Textbox
            // 
            this.known_Ipadress_Textbox.Location = new System.Drawing.Point(80, 78);
            this.known_Ipadress_Textbox.Name = "known_Ipadress_Textbox";
            this.known_Ipadress_Textbox.Size = new System.Drawing.Size(216, 20);
            this.known_Ipadress_Textbox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "If you know the IP address please enter here!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScanTime);
            this.groupBox2.Controls.Add(this.bleDeviceConnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bleDeviceList);
            this.groupBox2.Controls.Add(this.bluetooth_Search_progress);
            this.groupBox2.Controls.Add(this.bleScan);
            this.groupBox2.Location = new System.Drawing.Point(410, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 237);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth ";
            // 
            // ScanTime
            // 
            this.ScanTime.FormattingEnabled = true;
            this.ScanTime.Items.AddRange(new object[] {"01 Sec", "02 Sec", "05 Sec", "10 Sec", "15 Sec", "30 Sec"});
            this.ScanTime.Location = new System.Drawing.Point(128, 170);
            this.ScanTime.Name = "ScanTime";
            this.ScanTime.Size = new System.Drawing.Size(121, 21);
            this.ScanTime.TabIndex = 33;
            // 
            // bleDeviceConnect
            // 
            this.bleDeviceConnect.Location = new System.Drawing.Point(264, 161);
            this.bleDeviceConnect.Name = "bleDeviceConnect";
            this.bleDeviceConnect.Size = new System.Drawing.Size(108, 37);
            this.bleDeviceConnect.TabIndex = 32;
            this.bleDeviceConnect.Text = "Connect";
            this.bleDeviceConnect.UseVisualStyleBackColor = true;
            this.bleDeviceConnect.Click += new System.EventHandler(this.bleDeviceConnect_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Lets set up your device over bluetooth!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bleDeviceList
            // 
            this.bleDeviceList.FormattingEnabled = true;
            this.bleDeviceList.Location = new System.Drawing.Point(6, 60);
            this.bleDeviceList.Name = "bleDeviceList";
            this.bleDeviceList.Size = new System.Drawing.Size(366, 95);
            this.bleDeviceList.TabIndex = 30;
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
            this.bleScan.Location = new System.Drawing.Point(6, 161);
            this.bleScan.Name = "bleScan";
            this.bleScan.Size = new System.Drawing.Size(108, 37);
            this.bleScan.TabIndex = 28;
            this.bleScan.Text = "Scan";
            this.bleScan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 83);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add New Device";
            // 
            // Add_Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Device";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Device";
            this.Load += new System.EventHandler(this.Add_Device_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox ScanTime;

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