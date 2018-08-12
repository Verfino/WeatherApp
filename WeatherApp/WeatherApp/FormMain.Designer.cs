namespace WeatherApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelTodayNight = new System.Windows.Forms.Label();
            this.labelTodayTempNight = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.labelTomorrowTempNight = new System.Windows.Forms.Label();
            this.labelTomorrowDay = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTomorrow = new System.Windows.Forms.Label();
            this.label2Days = new System.Windows.Forms.Label();
            this.label3Days = new System.Windows.Forms.Label();
            this.labelTomorrowNight = new System.Windows.Forms.Label();
            this.labelTodayTempDay = new System.Windows.Forms.Label();
            this.labelTodayDay = new System.Windows.Forms.Label();
            this.labelTomorrowTempDay = new System.Windows.Forms.Label();
            this.menuStripFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(534, 24);
            this.menuStripFile.TabIndex = 0;
            this.menuStripFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.Location = new System.Drawing.Point(123, 139);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(85, 29);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "label1";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemperature.Location = new System.Drawing.Point(396, 113);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(126, 55);
            this.labelTemperature.TabIndex = 2;
            this.labelTemperature.Text = "20\'C";
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWeather.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWeather.Image")));
            this.pictureBoxWeather.Location = new System.Drawing.Point(33, 127);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxWeather.TabIndex = 3;
            this.pictureBoxWeather.TabStop = false;
            // 
            // labelTodayNight
            // 
            this.labelTodayNight.AutoSize = true;
            this.labelTodayNight.BackColor = System.Drawing.Color.Transparent;
            this.labelTodayNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTodayNight.Location = new System.Drawing.Point(125, 193);
            this.labelTodayNight.Name = "labelTodayNight";
            this.labelTodayNight.Size = new System.Drawing.Size(60, 16);
            this.labelTodayNight.TabIndex = 5;
            this.labelTodayNight.Text = "At night : ";
            // 
            // labelTodayTempNight
            // 
            this.labelTodayTempNight.AutoSize = true;
            this.labelTodayTempNight.BackColor = System.Drawing.Color.Transparent;
            this.labelTodayTempNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTodayTempNight.Location = new System.Drawing.Point(199, 193);
            this.labelTodayTempNight.Name = "labelTodayTempNight";
            this.labelTodayTempNight.Size = new System.Drawing.Size(27, 16);
            this.labelTodayTempNight.TabIndex = 6;
            this.labelTodayTempNight.Text = "0\'C";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.labelTomorrowTempDay);
            this.panel.Controls.Add(this.labelTomorrowNight);
            this.panel.Controls.Add(this.label3Days);
            this.panel.Controls.Add(this.label2Days);
            this.panel.Controls.Add(this.labelTomorrow);
            this.panel.Controls.Add(this.labelTomorrowTempNight);
            this.panel.Controls.Add(this.labelTomorrowDay);
            this.panel.Controls.Add(this.pictureBox5);
            this.panel.Controls.Add(this.pictureBox4);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(12, 230);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(510, 269);
            this.panel.TabIndex = 7;
            // 
            // labelTomorrowTempNight
            // 
            this.labelTomorrowTempNight.AutoSize = true;
            this.labelTomorrowTempNight.BackColor = System.Drawing.Color.Transparent;
            this.labelTomorrowTempNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTomorrowTempNight.Location = new System.Drawing.Point(220, 25);
            this.labelTomorrowTempNight.Name = "labelTomorrowTempNight";
            this.labelTomorrowTempNight.Size = new System.Drawing.Size(27, 16);
            this.labelTomorrowTempNight.TabIndex = 8;
            this.labelTomorrowTempNight.Text = "0\'C";
            // 
            // labelTomorrowDay
            // 
            this.labelTomorrowDay.AutoSize = true;
            this.labelTomorrowDay.BackColor = System.Drawing.Color.Transparent;
            this.labelTomorrowDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTomorrowDay.Location = new System.Drawing.Point(154, 3);
            this.labelTomorrowDay.Name = "labelTomorrowDay";
            this.labelTomorrowDay.Size = new System.Drawing.Size(55, 16);
            this.labelTomorrowDay.TabIndex = 14;
            this.labelTomorrowDay.Text = "At day : ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(84, 193);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(84, 102);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTomorrow
            // 
            this.labelTomorrow.AutoSize = true;
            this.labelTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTomorrow.Location = new System.Drawing.Point(1, 25);
            this.labelTomorrow.Name = "labelTomorrow";
            this.labelTomorrow.Size = new System.Drawing.Size(77, 16);
            this.labelTomorrow.TabIndex = 15;
            this.labelTomorrow.Text = "Tomorrow";
            // 
            // label2Days
            // 
            this.label2Days.AutoSize = true;
            this.label2Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Days.Location = new System.Drawing.Point(1, 125);
            this.label2Days.Name = "label2Days";
            this.label2Days.Size = new System.Drawing.Size(81, 16);
            this.label2Days.TabIndex = 16;
            this.label2Days.Text = "For 2 days";
            // 
            // label3Days
            // 
            this.label3Days.AutoSize = true;
            this.label3Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3Days.Location = new System.Drawing.Point(1, 219);
            this.label3Days.Name = "label3Days";
            this.label3Days.Size = new System.Drawing.Size(81, 16);
            this.label3Days.TabIndex = 17;
            this.label3Days.Text = "For 3 days";
            // 
            // labelTomorrowNight
            // 
            this.labelTomorrowNight.AutoSize = true;
            this.labelTomorrowNight.BackColor = System.Drawing.Color.Transparent;
            this.labelTomorrowNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTomorrowNight.Location = new System.Drawing.Point(154, 25);
            this.labelTomorrowNight.Name = "labelTomorrowNight";
            this.labelTomorrowNight.Size = new System.Drawing.Size(60, 16);
            this.labelTomorrowNight.TabIndex = 18;
            this.labelTomorrowNight.Text = "At night : ";
            // 
            // labelTodayTempDay
            // 
            this.labelTodayTempDay.AutoSize = true;
            this.labelTodayTempDay.BackColor = System.Drawing.Color.Transparent;
            this.labelTodayTempDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTodayTempDay.Location = new System.Drawing.Point(199, 168);
            this.labelTodayTempDay.Name = "labelTodayTempDay";
            this.labelTodayTempDay.Size = new System.Drawing.Size(27, 16);
            this.labelTodayTempDay.TabIndex = 19;
            this.labelTodayTempDay.Text = "0\'C";
            // 
            // labelTodayDay
            // 
            this.labelTodayDay.AutoSize = true;
            this.labelTodayDay.BackColor = System.Drawing.Color.Transparent;
            this.labelTodayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTodayDay.Location = new System.Drawing.Point(125, 168);
            this.labelTodayDay.Name = "labelTodayDay";
            this.labelTodayDay.Size = new System.Drawing.Size(55, 16);
            this.labelTodayDay.TabIndex = 20;
            this.labelTodayDay.Text = "At day : ";
            // 
            // labelTomorrowTempDay
            // 
            this.labelTomorrowTempDay.AutoSize = true;
            this.labelTomorrowTempDay.BackColor = System.Drawing.Color.Transparent;
            this.labelTomorrowTempDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTomorrowTempDay.Location = new System.Drawing.Point(220, 3);
            this.labelTomorrowTempDay.Name = "labelTomorrowTempDay";
            this.labelTomorrowTempDay.Size = new System.Drawing.Size(27, 16);
            this.labelTomorrowTempDay.TabIndex = 21;
            this.labelTomorrowTempDay.Text = "0\'C";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.labelTodayTempDay);
            this.Controls.Add(this.labelTodayDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelTodayTempNight);
            this.Controls.Add(this.pictureBoxWeather);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.menuStripFile);
            this.Controls.Add(this.labelTodayNight);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelTodayNight;
        private System.Windows.Forms.Label labelTodayTempNight;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTomorrowTempNight;
        private System.Windows.Forms.Label labelTomorrowDay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTodayTempDay;
        private System.Windows.Forms.Label labelTomorrowNight;
        private System.Windows.Forms.Label label3Days;
        private System.Windows.Forms.Label label2Days;
        private System.Windows.Forms.Label labelTomorrow;
        private System.Windows.Forms.Label labelTomorrowTempDay;
        private System.Windows.Forms.Label labelTodayDay;
    }
}

