using System;
using System.Windows.Forms;

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
            this.Add_Device_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listofDevices = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Device_Btn
            // 
            this.Add_Device_Btn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.Add_Device_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Device_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Add_Device_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Device_Btn.Location = new System.Drawing.Point(12, 41);
            this.Add_Device_Btn.Name = "Add_Device_Btn";
            this.Add_Device_Btn.Padding = new System.Windows.Forms.Padding(1);
            this.Add_Device_Btn.Size = new System.Drawing.Size(275, 40);
            this.Add_Device_Btn.TabIndex = 0;
            this.Add_Device_Btn.Text = "Add Device";
            this.Add_Device_Btn.UseVisualStyleBackColor = false;
            this.Add_Device_Btn.Click += new System.EventHandler(this.Add_Device_Btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listofDevices
            // 
            this.listofDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listofDevices.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listofDevices.Location = new System.Drawing.Point(12, 87);
            this.listofDevices.Name = "listofDevices";
            this.listofDevices.Size = new System.Drawing.Size(275, 97);
            this.listofDevices.TabIndex = 5;
            this.listofDevices.UseCompatibleStateImageBehavior = false;
            this.listofDevices.SelectedIndexChanged += new System.EventHandler(this.listofDevices_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(267, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(299, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listofDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Device_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 196);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 196);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Lamp Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListView listofDevices;


        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Button Add_Device_Btn;

        #endregion
    }
}