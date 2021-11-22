using System.ComponentModel;

namespace Smart_Lamp_Controller
{
    partial class Add_Device_2
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
            this.passTwo = new System.Windows.Forms.TextBox();
            this.ssidtwo = new System.Windows.Forms.TextBox();
            this.passOne = new System.Windows.Forms.TextBox();
            this.DeviceTypeList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ssidOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newDeviceName = new System.Windows.Forms.TextBox();
            this.connectToDevice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passTwo
            // 
            this.passTwo.Location = new System.Drawing.Point(291, 285);
            this.passTwo.Name = "passTwo";
            this.passTwo.Size = new System.Drawing.Size(100, 20);
            this.passTwo.TabIndex = 34;
            // 
            // ssidtwo
            // 
            this.ssidtwo.Location = new System.Drawing.Point(291, 256);
            this.ssidtwo.Name = "ssidtwo";
            this.ssidtwo.Size = new System.Drawing.Size(100, 20);
            this.ssidtwo.TabIndex = 33;
            // 
            // passOne
            // 
            this.passOne.Location = new System.Drawing.Point(291, 230);
            this.passOne.Name = "passOne";
            this.passOne.Size = new System.Drawing.Size(100, 20);
            this.passOne.TabIndex = 32;
            // 
            // DeviceTypeList
            // 
            this.DeviceTypeList.FormattingEnabled = true;
            this.DeviceTypeList.Location = new System.Drawing.Point(291, 137);
            this.DeviceTypeList.Name = "DeviceTypeList";
            this.DeviceTypeList.Size = new System.Drawing.Size(121, 21);
            this.DeviceTypeList.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(150, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Password Two";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(150, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "SSID Two";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(150, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password One";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 40);
            this.progressBar1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(150, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "SSID One";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(141, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 83);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add New Device";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(150, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Device Type";
            // 
            // ssidOne
            // 
            this.ssidOne.Location = new System.Drawing.Point(291, 201);
            this.ssidOne.Name = "ssidOne";
            this.ssidOne.Size = new System.Drawing.Size(100, 20);
            this.ssidOne.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(150, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Device Name";
            // 
            // newDeviceName
            // 
            this.newDeviceName.Location = new System.Drawing.Point(291, 104);
            this.newDeviceName.Name = "newDeviceName";
            this.newDeviceName.Size = new System.Drawing.Size(121, 20);
            this.newDeviceName.TabIndex = 19;
            // 
            // connectToDevice
            // 
            this.connectToDevice.Location = new System.Drawing.Point(255, 331);
            this.connectToDevice.Name = "connectToDevice";
            this.connectToDevice.Size = new System.Drawing.Size(249, 54);
            this.connectToDevice.TabIndex = 18;
            this.connectToDevice.Text = "Connect!";
            this.connectToDevice.UseVisualStyleBackColor = true;
            // 
            // Add_Device_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passTwo);
            this.Controls.Add(this.ssidtwo);
            this.Controls.Add(this.passOne);
            this.Controls.Add(this.DeviceTypeList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssidOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDeviceName);
            this.Controls.Add(this.connectToDevice);
            this.Name = "Add_Device_2";
            this.Text = "Add_Device_2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        #endregion
    }
}