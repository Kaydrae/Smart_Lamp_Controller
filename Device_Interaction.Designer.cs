using System.ComponentModel;

namespace Smart_Lamp_Controller
{
    partial class Device_Interaction
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectColor = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Interaction";
            // 
            // SelectColor
            // 
            this.SelectColor.Location = new System.Drawing.Point(32, 106);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.Size = new System.Drawing.Size(159, 49);
            this.SelectColor.TabIndex = 1;
            this.SelectColor.Text = "Select Color";
            this.SelectColor.UseVisualStyleBackColor = true;
            this.SelectColor.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(32, 178);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 51);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(32, 250);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 51);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(279, 105);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(159, 51);
            this.power.TabIndex = 4;
            this.power.Text = "Power : On";
            this.power.UseVisualStyleBackColor = true;
            // 
            // Device_Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.power);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.SelectColor);
            this.Controls.Add(this.label1);
            this.Name = "Device_Interaction";
            this.Text = "Device Interaction";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button power;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button SelectColor;

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}