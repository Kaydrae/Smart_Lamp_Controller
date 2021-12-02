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
            this.restart = new System.Windows.Forms.Button();
            this.tempature = new System.Windows.Forms.Button();
            this.brightness = new System.Windows.Forms.TrackBar();
            this.speed = new System.Windows.Forms.TrackBar();
            this.pattern = new System.Windows.Forms.ComboBox();
            this.cycle_battern = new System.Windows.Forms.Button();
            this.pattern_duration = new System.Windows.Forms.TrackBar();
            this.palette = new System.Windows.Forms.ComboBox();
            this.cycle_palettes = new System.Windows.Forms.Button();
            this.palettes_duration = new System.Windows.Forms.TrackBar();
            this.cooling = new System.Windows.Forms.TrackBar();
            this.sparkling = new System.Windows.Forms.TrackBar();
            this.twinkle_speed = new System.Windows.Forms.TrackBar();
            this.twinkle_density = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize) (this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pattern_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.palettes_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.sparkling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_density)).BeginInit();
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
            this.SelectColor.Location = new System.Drawing.Point(32, 158);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.Size = new System.Drawing.Size(159, 49);
            this.SelectColor.TabIndex = 1;
            this.SelectColor.Text = "Change Color";
            this.SelectColor.UseVisualStyleBackColor = true;
            this.SelectColor.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(304, 277);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(84, 51);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(304, 391);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(174, 51);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(32, 101);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(159, 51);
            this.power.TabIndex = 4;
            this.power.Text = "Power : On";
            this.power.UseVisualStyleBackColor = true;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(394, 277);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(84, 51);
            this.restart.TabIndex = 5;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            // 
            // tempature
            // 
            this.tempature.Location = new System.Drawing.Point(304, 334);
            this.tempature.Name = "tempature";
            this.tempature.Size = new System.Drawing.Size(174, 51);
            this.tempature.TabIndex = 6;
            this.tempature.Text = "Tempature";
            this.tempature.UseVisualStyleBackColor = true;
            // 
            // brightness
            // 
            this.brightness.Location = new System.Drawing.Point(35, 228);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(156, 45);
            this.brightness.TabIndex = 7;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(35, 279);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(156, 45);
            this.speed.TabIndex = 8;
            // 
            // pattern
            // 
            this.pattern.FormattingEnabled = true;
            this.pattern.Items.AddRange(new object[] {"Pride"});
            this.pattern.Location = new System.Drawing.Point(35, 330);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(121, 21);
            this.pattern.TabIndex = 9;
            // 
            // cycle_battern
            // 
            this.cycle_battern.Location = new System.Drawing.Point(32, 370);
            this.cycle_battern.Name = "cycle_battern";
            this.cycle_battern.Size = new System.Drawing.Size(159, 51);
            this.cycle_battern.TabIndex = 10;
            this.cycle_battern.Text = "Cycle Pattern : On";
            this.cycle_battern.UseVisualStyleBackColor = true;
            // 
            // pattern_duration
            // 
            this.pattern_duration.Location = new System.Drawing.Point(35, 446);
            this.pattern_duration.Name = "pattern_duration";
            this.pattern_duration.Size = new System.Drawing.Size(156, 45);
            this.pattern_duration.TabIndex = 11;
            // 
            // palette
            // 
            this.palette.FormattingEnabled = true;
            this.palette.Items.AddRange(new object[] {"Rainbow"});
            this.palette.Location = new System.Drawing.Point(35, 497);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(121, 21);
            this.palette.TabIndex = 12;
            // 
            // cycle_palettes
            // 
            this.cycle_palettes.Location = new System.Drawing.Point(32, 541);
            this.cycle_palettes.Name = "cycle_palettes";
            this.cycle_palettes.Size = new System.Drawing.Size(159, 51);
            this.cycle_palettes.TabIndex = 13;
            this.cycle_palettes.Text = "Cycle Palettes : On";
            this.cycle_palettes.UseVisualStyleBackColor = true;
            // 
            // palettes_duration
            // 
            this.palettes_duration.Location = new System.Drawing.Point(251, 547);
            this.palettes_duration.Name = "palettes_duration";
            this.palettes_duration.Size = new System.Drawing.Size(156, 45);
            this.palettes_duration.TabIndex = 14;
            // 
            // cooling
            // 
            this.cooling.Location = new System.Drawing.Point(251, 473);
            this.cooling.Name = "cooling";
            this.cooling.Size = new System.Drawing.Size(156, 45);
            this.cooling.TabIndex = 15;
            // 
            // sparkling
            // 
            this.sparkling.Location = new System.Drawing.Point(251, 598);
            this.sparkling.Name = "sparkling";
            this.sparkling.Size = new System.Drawing.Size(156, 45);
            this.sparkling.TabIndex = 16;
            // 
            // twinkle_speed
            // 
            this.twinkle_speed.Location = new System.Drawing.Point(435, 473);
            this.twinkle_speed.Name = "twinkle_speed";
            this.twinkle_speed.Size = new System.Drawing.Size(156, 45);
            this.twinkle_speed.TabIndex = 17;
            // 
            // twinkle_density
            // 
            this.twinkle_density.Location = new System.Drawing.Point(435, 541);
            this.twinkle_density.Name = "twinkle_density";
            this.twinkle_density.Size = new System.Drawing.Size(156, 45);
            this.twinkle_density.TabIndex = 18;
            // 
            // Device_Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.twinkle_density);
            this.Controls.Add(this.twinkle_speed);
            this.Controls.Add(this.sparkling);
            this.Controls.Add(this.cooling);
            this.Controls.Add(this.palettes_duration);
            this.Controls.Add(this.cycle_palettes);
            this.Controls.Add(this.palette);
            this.Controls.Add(this.pattern_duration);
            this.Controls.Add(this.cycle_battern);
            this.Controls.Add(this.pattern);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.tempature);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.power);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.SelectColor);
            this.Controls.Add(this.label1);
            this.Name = "Device_Interaction";
            this.Text = "Device Interaction";
            ((System.ComponentModel.ISupportInitialize) (this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pattern_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.palettes_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.sparkling)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_density)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TrackBar palettes_duration;
        private System.Windows.Forms.TrackBar cooling;
        private System.Windows.Forms.TrackBar sparkling;
        private System.Windows.Forms.TrackBar twinkle_speed;
        private System.Windows.Forms.TrackBar twinkle_density;

        private System.Windows.Forms.Button cycle_palettes;

        private System.Windows.Forms.Button cycle_battern;
        private System.Windows.Forms.TrackBar pattern_duration;
        private System.Windows.Forms.ComboBox palette;

        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.ComboBox pattern;

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