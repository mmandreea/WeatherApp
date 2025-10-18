using System;

namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.City_label = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.condition_label = new System.Windows.Forms.Label();
            this.details_label = new System.Windows.Forms.Label();
            this.wind_label = new System.Windows.Forms.Label();
            this.pressure_label = new System.Windows.Forms.Label();
            this.sunrise_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sunset_label = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // City_label
            // 
            this.City_label.BackColor = System.Drawing.Color.Transparent;
            this.City_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_label.Location = new System.Drawing.Point(68, 68);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(93, 53);
            this.City_label.TabIndex = 0;
            this.City_label.Text = "CITY";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityTextBox.Location = new System.Drawing.Point(167, 65);
            this.CityTextBox.Multiline = true;
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(430, 50);
            this.CityTextBox.TabIndex = 1;
            this.CityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.search_button.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(638, 63);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(92, 50);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(63, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Condition";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.Transparent;
            this.details.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.SystemColors.Desktop;
            this.details.Location = new System.Drawing.Point(63, 372);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(115, 53);
            this.details.TabIndex = 4;
            this.details.Text = "Details";
            this.details.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(943, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 53);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 53);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wind speed";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 53);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pressure";
            // 
            // condition_label
            // 
            this.condition_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.condition_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.condition_label.Location = new System.Drawing.Point(68, 245);
            this.condition_label.Name = "condition_label";
            this.condition_label.Size = new System.Drawing.Size(281, 62);
            this.condition_label.TabIndex = 9;
            this.condition_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // details_label
            // 
            this.details_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.details_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.details_label.Location = new System.Drawing.Point(68, 425);
            this.details_label.Name = "details_label";
            this.details_label.Size = new System.Drawing.Size(474, 227);
            this.details_label.TabIndex = 10;
            this.details_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wind_label
            // 
            this.wind_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.wind_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind_label.Location = new System.Drawing.Point(632, 425);
            this.wind_label.Name = "wind_label";
            this.wind_label.Size = new System.Drawing.Size(151, 51);
            this.wind_label.TabIndex = 12;
            this.wind_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pressure_label
            // 
            this.pressure_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.pressure_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure_label.Location = new System.Drawing.Point(632, 584);
            this.pressure_label.Name = "pressure_label";
            this.pressure_label.Size = new System.Drawing.Size(151, 51);
            this.pressure_label.TabIndex = 13;
            this.pressure_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunrise_label
            // 
            this.sunrise_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.sunrise_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sunrise_label.Location = new System.Drawing.Point(894, 425);
            this.sunrise_label.Name = "sunrise_label";
            this.sunrise_label.Size = new System.Drawing.Size(218, 79);
            this.sunrise_label.TabIndex = 14;
            this.sunrise_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(946, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 53);
            this.label12.TabIndex = 15;
            this.label12.Text = "Sunset";
            // 
            // sunset_label
            // 
            this.sunset_label.BackColor = System.Drawing.Color.DarkKhaki;
            this.sunset_label.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset_label.Location = new System.Drawing.Point(894, 566);
            this.sunset_label.Name = "sunset_label";
            this.sunset_label.Size = new System.Drawing.Size(218, 86);
            this.sunset_label.TabIndex = 16;
            this.sunset_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(368, 223);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(229, 115);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 17;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 692);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.sunset_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sunrise_label);
            this.Controls.Add(this.pressure_label);
            this.Controls.Add(this.wind_label);
            this.Controls.Add(this.details_label);
            this.Controls.Add(this.condition_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.City_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label condition_label;
        private System.Windows.Forms.Label details_label;
        private System.Windows.Forms.Label wind_label;
        private System.Windows.Forms.Label pressure_label;
        private System.Windows.Forms.Label sunrise_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label sunset_label;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

