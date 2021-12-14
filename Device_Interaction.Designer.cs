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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize) (this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pattern_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.palettes_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.sparkling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_density)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Interaction";
            // 
            // SelectColor
            // 
            this.SelectColor.BackColor = System.Drawing.Color.Fuchsia;
            this.SelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SelectColor.Location = new System.Drawing.Point(26, 125);
            this.SelectColor.Name = "SelectColor";
            this.SelectColor.Size = new System.Drawing.Size(200, 50);
            this.SelectColor.TabIndex = 1;
            this.SelectColor.Text = "Change Color";
            this.SelectColor.UseVisualStyleBackColor = false;
            this.SelectColor.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(418, 620);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(190, 50);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(26, 620);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(190, 50);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.power.ForeColor = System.Drawing.Color.White;
            this.power.Location = new System.Drawing.Point(26, 65);
            this.power.Name = "power";
            this.power.Padding = new System.Windows.Forms.Padding(1);
            this.power.Size = new System.Drawing.Size(200, 50);
            this.power.TabIndex = 4;
            this.power.Text = "Power : On";
            this.power.UseVisualStyleBackColor = false;
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.restart.ForeColor = System.Drawing.Color.White;
            this.restart.Location = new System.Drawing.Point(614, 620);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(190, 50);
            this.restart.TabIndex = 5;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            // 
            // tempature
            // 
            this.tempature.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.tempature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tempature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tempature.ForeColor = System.Drawing.Color.White;
            this.tempature.Location = new System.Drawing.Point(222, 620);
            this.tempature.Name = "tempature";
            this.tempature.Size = new System.Drawing.Size(190, 50);
            this.tempature.TabIndex = 6;
            this.tempature.Text = "Tempature";
            this.tempature.UseVisualStyleBackColor = false;
            // 
            // brightness
            // 
            this.brightness.Location = new System.Drawing.Point(18, 28);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(156, 45);
            this.brightness.TabIndex = 7;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(24, 28);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(156, 45);
            this.speed.TabIndex = 8;
            // 
            // pattern
            // 
            this.pattern.FormattingEnabled = true;
            this.pattern.Items.AddRange(new object[] {"Pride"});
            this.pattern.Location = new System.Drawing.Point(6, 28);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(188, 32);
            this.pattern.TabIndex = 9;
            // 
            // cycle_battern
            // 
            this.cycle_battern.BackColor = System.Drawing.Color.Turquoise;
            this.cycle_battern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cycle_battern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cycle_battern.ForeColor = System.Drawing.Color.White;
            this.cycle_battern.Location = new System.Drawing.Point(116, 24);
            this.cycle_battern.Name = "cycle_battern";
            this.cycle_battern.Size = new System.Drawing.Size(200, 50);
            this.cycle_battern.TabIndex = 10;
            this.cycle_battern.Text = "Cycle Pattern : On";
            this.cycle_battern.UseVisualStyleBackColor = false;
            // 
            // pattern_duration
            // 
            this.pattern_duration.Location = new System.Drawing.Point(14, 32);
            this.pattern_duration.Name = "pattern_duration";
            this.pattern_duration.Size = new System.Drawing.Size(156, 45);
            this.pattern_duration.TabIndex = 11;
            // 
            // palette
            // 
            this.palette.FormattingEnabled = true;
            this.palette.Items.AddRange(new object[] {"Rainbow"});
            this.palette.Location = new System.Drawing.Point(6, 28);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(186, 32);
            this.palette.TabIndex = 12;
            this.palette.SelectedIndexChanged += new System.EventHandler(this.palette_SelectedIndexChanged);
            // 
            // cycle_palettes
            // 
            this.cycle_palettes.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.cycle_palettes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cycle_palettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cycle_palettes.ForeColor = System.Drawing.Color.White;
            this.cycle_palettes.Location = new System.Drawing.Point(117, 28);
            this.cycle_palettes.Name = "cycle_palettes";
            this.cycle_palettes.Padding = new System.Windows.Forms.Padding(1);
            this.cycle_palettes.Size = new System.Drawing.Size(200, 50);
            this.cycle_palettes.TabIndex = 13;
            this.cycle_palettes.Text = "Cycle Palettes : On";
            this.cycle_palettes.UseVisualStyleBackColor = false;
            // 
            // palettes_duration
            // 
            this.palettes_duration.Location = new System.Drawing.Point(16, 32);
            this.palettes_duration.Name = "palettes_duration";
            this.palettes_duration.Size = new System.Drawing.Size(176, 45);
            this.palettes_duration.TabIndex = 14;
            // 
            // cooling
            // 
            this.cooling.Location = new System.Drawing.Point(23, 28);
            this.cooling.Name = "cooling";
            this.cooling.Size = new System.Drawing.Size(156, 45);
            this.cooling.TabIndex = 15;
            // 
            // sparkling
            // 
            this.sparkling.Location = new System.Drawing.Point(24, 29);
            this.sparkling.Name = "sparkling";
            this.sparkling.Size = new System.Drawing.Size(156, 45);
            this.sparkling.TabIndex = 16;
            // 
            // twinkle_speed
            // 
            this.twinkle_speed.Location = new System.Drawing.Point(23, 28);
            this.twinkle_speed.Name = "twinkle_speed";
            this.twinkle_speed.Size = new System.Drawing.Size(156, 45);
            this.twinkle_speed.TabIndex = 17;
            // 
            // twinkle_density
            // 
            this.twinkle_density.Location = new System.Drawing.Point(16, 25);
            this.twinkle_density.Name = "twinkle_density";
            this.twinkle_density.Size = new System.Drawing.Size(156, 45);
            this.twinkle_density.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(782, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 29;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brightness);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brightness";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.speed);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(26, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pattern);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 80);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pattern";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pattern_duration);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(212, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 80);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pattern Duration";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.palette);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(213, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 80);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Palette";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cooling);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(26, 475);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 80);
            this.groupBox6.TabIndex = 35;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cooling";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.palettes_duration);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(6, 84);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 80);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Palettes Duration";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.twinkle_speed);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(6, 40);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 80);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Twinkle Speed";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.twinkle_density);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(217, 40);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 80);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Twinkle Density";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.sparkling);
            this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Location = new System.Drawing.Point(26, 377);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 80);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Sparkling";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox8);
            this.groupBox11.Controls.Add(this.groupBox9);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(381, 475);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(423, 126);
            this.groupBox11.TabIndex = 40;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Twinkle";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox3);
            this.groupBox12.Controls.Add(this.groupBox4);
            this.groupBox12.Controls.Add(this.cycle_battern);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox12.ForeColor = System.Drawing.Color.White;
            this.groupBox12.Location = new System.Drawing.Point(381, 65);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(421, 194);
            this.groupBox12.TabIndex = 41;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Pattern";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox7);
            this.groupBox13.Controls.Add(this.groupBox5);
            this.groupBox13.Controls.Add(this.cycle_palettes);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(381, 265);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(419, 204);
            this.groupBox13.TabIndex = 42;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Palette";
            // 
            // Device_Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(823, 684);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tempature);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.power);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.SelectColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Device_Interaction";
            this.Text = "Device Interaction";
            this.Load += new System.EventHandler(this.Device_Interaction_Load);
            ((System.ComponentModel.ISupportInitialize) (this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pattern_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.palettes_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.sparkling)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.twinkle_density)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox13;

        private System.Windows.Forms.GroupBox groupBox12;

        private System.Windows.Forms.GroupBox groupBox11;

        private System.Windows.Forms.GroupBox groupBox10;

        private System.Windows.Forms.GroupBox groupBox9;

        private System.Windows.Forms.GroupBox groupBox8;

        private System.Windows.Forms.GroupBox groupBox7;

        private System.Windows.Forms.GroupBox groupBox6;

        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

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