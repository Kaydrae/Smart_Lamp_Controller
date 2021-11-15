namespace Smart_Lamp_Controller
{
    partial class Form1
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
            this.Connect_To_Device_btn = new System.Windows.Forms.Button();
            this.Add_Device_Btn = new System.Windows.Forms.Button();
            this.listofDevices = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removingDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDeviceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDeviceInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect_To_Device_btn
            // 
            this.Connect_To_Device_btn.Location = new System.Drawing.Point(12, 26);
            this.Connect_To_Device_btn.Name = "Connect_To_Device_btn";
            this.Connect_To_Device_btn.Size = new System.Drawing.Size(75, 23);
            this.Connect_To_Device_btn.TabIndex = 0;
            this.Connect_To_Device_btn.Text = "Connect";
            this.Connect_To_Device_btn.UseVisualStyleBackColor = true;
            this.Connect_To_Device_btn.Click += new System.EventHandler(this.Connect_To_Device_btn_Click);
            // 
            // Add_Device_Btn
            // 
            this.Add_Device_Btn.Location = new System.Drawing.Point(196, 26);
            this.Add_Device_Btn.Name = "Add_Device_Btn";
            this.Add_Device_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Device_Btn.TabIndex = 1;
            this.Add_Device_Btn.Text = "Add Device";
            this.Add_Device_Btn.UseVisualStyleBackColor = true;
            this.Add_Device_Btn.Click += new System.EventHandler(this.Add_Device_Btn_Click);
            // 
            // listofDevices
            // 
            this.listofDevices.FormattingEnabled = true;
            this.listofDevices.Location = new System.Drawing.Point(12, 55);
            this.listofDevices.Name = "listofDevices";
            this.listofDevices.Size = new System.Drawing.Size(259, 95);
            this.listofDevices.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.applicationToolStripMenuItem, this.helpToolStripMenuItem, this.aboutToolStripMenuItem, this.getDeviceInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addingDeviceToolStripMenuItem, this.removingDeviceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // addingDeviceToolStripMenuItem
            // 
            this.addingDeviceToolStripMenuItem.Name = "addingDeviceToolStripMenuItem";
            this.addingDeviceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addingDeviceToolStripMenuItem.Text = "Adding Device";
            // 
            // removingDeviceToolStripMenuItem
            // 
            this.removingDeviceToolStripMenuItem.Name = "removingDeviceToolStripMenuItem";
            this.removingDeviceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.removingDeviceToolStripMenuItem.Text = "Removing Device";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.versionToolStripMenuItem, this.appInformationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // appInformationToolStripMenuItem
            // 
            this.appInformationToolStripMenuItem.Name = "appInformationToolStripMenuItem";
            this.appInformationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.appInformationToolStripMenuItem.Text = "App Information";
            // 
            // getDeviceInfoToolStripMenuItem
            // 
            this.getDeviceInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.getDeviceInfoToolStripMenuItem1, this.connectToolStripMenuItem, this.disconnectToolStripMenuItem, this.deleteDeviceToolStripMenuItem, this.restartDeviceToolStripMenuItem});
            this.getDeviceInfoToolStripMenuItem.Name = "getDeviceInfoToolStripMenuItem";
            this.getDeviceInfoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.getDeviceInfoToolStripMenuItem.Text = "Device";
            this.getDeviceInfoToolStripMenuItem.Click += new System.EventHandler(this.getDeviceInfoToolStripMenuItem_Click);
            // 
            // getDeviceInfoToolStripMenuItem1
            // 
            this.getDeviceInfoToolStripMenuItem1.Name = "getDeviceInfoToolStripMenuItem1";
            this.getDeviceInfoToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.getDeviceInfoToolStripMenuItem1.Text = "Get Device Info";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // deleteDeviceToolStripMenuItem
            // 
            this.deleteDeviceToolStripMenuItem.Name = "deleteDeviceToolStripMenuItem";
            this.deleteDeviceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteDeviceToolStripMenuItem.Text = "Delete Device";
            // 
            // restartDeviceToolStripMenuItem
            // 
            this.restartDeviceToolStripMenuItem.Name = "restartDeviceToolStripMenuItem";
            this.restartDeviceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restartDeviceToolStripMenuItem.Text = "Restart Device";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listofDevices);
            this.Controls.Add(this.Add_Device_Btn);
            this.Controls.Add(this.Connect_To_Device_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 196);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 196);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Lamp Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listofDevices;

        private System.Windows.Forms.ToolStripMenuItem getDeviceInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartDeviceToolStripMenuItem;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addingDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removingDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getDeviceInfoToolStripMenuItem;

        private System.Windows.Forms.Button Connect_To_Device_btn;
        private System.Windows.Forms.Button Add_Device_Btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        #endregion
    }
}