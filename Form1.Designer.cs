namespace WeatherProQQ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_windSpeed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_visibility = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_feelsLike = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_sunset = new System.Windows.Forms.Label();
            this.lbl_sunrise = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_sunset = new System.Windows.Forms.PictureBox();
            this.pb_sunrise = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_tempStats = new System.Windows.Forms.PictureBox();
            this.lbl_advice = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pb_today = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_todaymin = new System.Windows.Forms.Label();
            this.lbl_todaymax = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pb_day1 = new System.Windows.Forms.PictureBox();
            this.lbl_day1 = new System.Windows.Forms.Label();
            this.lbl_min1 = new System.Windows.Forms.Label();
            this.lbl_max1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pb_day2 = new System.Windows.Forms.PictureBox();
            this.lbl_day2 = new System.Windows.Forms.Label();
            this.lbl_min2 = new System.Windows.Forms.Label();
            this.lbl_max2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pb_day3 = new System.Windows.Forms.PictureBox();
            this.lbl_day3 = new System.Windows.Forms.Label();
            this.lbl_min3 = new System.Windows.Forms.Label();
            this.lbl_max3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pb_day4 = new System.Windows.Forms.PictureBox();
            this.lbl_day4 = new System.Windows.Forms.Label();
            this.lbl_min4 = new System.Windows.Forms.Label();
            this.lbl_max4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sunset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sunrise)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tempStats)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_today)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp.Font = new System.Drawing.Font("Calibri Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_temp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_temp.Location = new System.Drawing.Point(163, 91);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(68, 97);
            this.lbl_temp.TabIndex = 0;
            this.lbl_temp.Text = "t";
            // 
            // lbl_windSpeed
            // 
            this.lbl_windSpeed.AutoSize = true;
            this.lbl_windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_windSpeed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_windSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_windSpeed.Location = new System.Drawing.Point(33, 306);
            this.lbl_windSpeed.Name = "lbl_windSpeed";
            this.lbl_windSpeed.Size = new System.Drawing.Size(58, 18);
            this.lbl_windSpeed.TabIndex = 0;
            this.lbl_windSpeed.Text = "wSpeed";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pb_icon);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_pressure);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_visibility);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_humidity);
            this.panel1.Controls.Add(this.lbl_feelsLike);
            this.panel1.Controls.Add(this.lbl_windSpeed);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_temp);
            this.panel1.Location = new System.Drawing.Point(22, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 366);
            this.panel1.TabIndex = 1;
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(18, 82);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(139, 129);
            this.pb_icon.TabIndex = 1;
            this.pb_icon.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_status.Location = new System.Drawing.Point(344, 103);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(103, 29);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Weather";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recent weather status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(362, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Visibilityℹ️";
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pressure.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pressure.Location = new System.Drawing.Point(265, 306);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(35, 18);
            this.lbl_pressure.TabIndex = 0;
            this.lbl_pressure.Text = "pres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(136, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Humidityℹ️";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Windℹ️";
            // 
            // lbl_visibility
            // 
            this.lbl_visibility.AutoSize = true;
            this.lbl_visibility.BackColor = System.Drawing.Color.Transparent;
            this.lbl_visibility.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_visibility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_visibility.Location = new System.Drawing.Point(371, 306);
            this.lbl_visibility.Name = "lbl_visibility";
            this.lbl_visibility.Size = new System.Drawing.Size(58, 18);
            this.lbl_visibility.TabIndex = 0;
            this.lbl_visibility.Text = "wSpeed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(255, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pressureℹ️";
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_humidity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_humidity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_humidity.Location = new System.Drawing.Point(156, 306);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(36, 18);
            this.lbl_humidity.TabIndex = 0;
            this.lbl_humidity.Text = "hum";
            // 
            // lbl_feelsLike
            // 
            this.lbl_feelsLike.AutoSize = true;
            this.lbl_feelsLike.BackColor = System.Drawing.Color.Transparent;
            this.lbl_feelsLike.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_feelsLike.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_feelsLike.Location = new System.Drawing.Point(345, 132);
            this.lbl_feelsLike.Name = "lbl_feelsLike";
            this.lbl_feelsLike.Size = new System.Drawing.Size(63, 19);
            this.lbl_feelsLike.TabIndex = 0;
            this.lbl_feelsLike.Text = "feelslike";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_time.Location = new System.Drawing.Point(13, 33);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(59, 29);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "time";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.BackColor = System.Drawing.Color.Transparent;
            this.lbl_location.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_location.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_location.Location = new System.Drawing.Point(33, 31);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(109, 33);
            this.lbl_location.TabIndex = 0;
            this.lbl_location.Text = "Location";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.lbl_sunset);
            this.panel2.Controls.Add(this.lbl_sunrise);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pb_sunset);
            this.panel2.Controls.Add(this.pb_sunrise);
            this.panel2.Location = new System.Drawing.Point(520, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 365);
            this.panel2.TabIndex = 2;
            // 
            // lbl_sunset
            // 
            this.lbl_sunset.AutoSize = true;
            this.lbl_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sunset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sunset.Location = new System.Drawing.Point(126, 267);
            this.lbl_sunset.Name = "lbl_sunset";
            this.lbl_sunset.Size = new System.Drawing.Size(75, 26);
            this.lbl_sunset.TabIndex = 2;
            this.lbl_sunset.Text = "Sunrise";
            // 
            // lbl_sunrise
            // 
            this.lbl_sunrise.AutoSize = true;
            this.lbl_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sunrise.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sunrise.Location = new System.Drawing.Point(126, 84);
            this.lbl_sunrise.Name = "lbl_sunrise";
            this.lbl_sunrise.Size = new System.Drawing.Size(75, 26);
            this.lbl_sunrise.TabIndex = 2;
            this.lbl_sunrise.Text = "Sunrise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(126, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sunset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(126, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sunrise";
            // 
            // pb_sunset
            // 
            this.pb_sunset.BackColor = System.Drawing.Color.Transparent;
            this.pb_sunset.Location = new System.Drawing.Point(15, 224);
            this.pb_sunset.Name = "pb_sunset";
            this.pb_sunset.Size = new System.Drawing.Size(105, 99);
            this.pb_sunset.TabIndex = 1;
            this.pb_sunset.TabStop = false;
            // 
            // pb_sunrise
            // 
            this.pb_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.pb_sunrise.Location = new System.Drawing.Point(15, 32);
            this.pb_sunrise.Name = "pb_sunrise";
            this.pb_sunrise.Size = new System.Drawing.Size(105, 99);
            this.pb_sunrise.TabIndex = 1;
            this.pb_sunrise.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pb_tempStats);
            this.panel3.Controls.Add(this.lbl_advice);
            this.panel3.Location = new System.Drawing.Point(772, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 365);
            this.panel3.TabIndex = 3;
            // 
            // pb_tempStats
            // 
            this.pb_tempStats.BackColor = System.Drawing.Color.Transparent;
            this.pb_tempStats.Location = new System.Drawing.Point(97, 43);
            this.pb_tempStats.Name = "pb_tempStats";
            this.pb_tempStats.Size = new System.Drawing.Size(184, 178);
            this.pb_tempStats.TabIndex = 1;
            this.pb_tempStats.TabStop = false;
            // 
            // lbl_advice
            // 
            this.lbl_advice.AutoSize = true;
            this.lbl_advice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_advice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_advice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_advice.Location = new System.Drawing.Point(32, 265);
            this.lbl_advice.Name = "lbl_advice";
            this.lbl_advice.Size = new System.Drawing.Size(59, 23);
            this.lbl_advice.TabIndex = 2;
            this.lbl_advice.Text = "advice";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pb_today);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lbl_todaymin);
            this.panel4.Controls.Add(this.lbl_todaymax);
            this.panel4.Location = new System.Drawing.Point(53, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 114);
            this.panel4.TabIndex = 4;
            // 
            // pb_today
            // 
            this.pb_today.Location = new System.Drawing.Point(16, 33);
            this.pb_today.Name = "pb_today";
            this.pb_today.Size = new System.Drawing.Size(73, 69);
            this.pb_today.TabIndex = 1;
            this.pb_today.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Today";
            // 
            // lbl_todaymin
            // 
            this.lbl_todaymin.AutoSize = true;
            this.lbl_todaymin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_todaymin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_todaymin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_todaymin.Location = new System.Drawing.Point(125, 67);
            this.lbl_todaymin.Name = "lbl_todaymin";
            this.lbl_todaymin.Size = new System.Drawing.Size(44, 23);
            this.lbl_todaymin.TabIndex = 0;
            this.lbl_todaymin.Text = "pres";
            // 
            // lbl_todaymax
            // 
            this.lbl_todaymax.AutoSize = true;
            this.lbl_todaymax.BackColor = System.Drawing.Color.Transparent;
            this.lbl_todaymax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_todaymax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_todaymax.Location = new System.Drawing.Point(125, 33);
            this.lbl_todaymax.Name = "lbl_todaymax";
            this.lbl_todaymax.Size = new System.Drawing.Size(45, 23);
            this.lbl_todaymax.TabIndex = 0;
            this.lbl_todaymax.Text = "pres";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pb_day1);
            this.panel5.Controls.Add(this.lbl_day1);
            this.panel5.Controls.Add(this.lbl_min1);
            this.panel5.Controls.Add(this.lbl_max1);
            this.panel5.Location = new System.Drawing.Point(271, 485);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 114);
            this.panel5.TabIndex = 4;
            // 
            // pb_day1
            // 
            this.pb_day1.Location = new System.Drawing.Point(9, 33);
            this.pb_day1.Name = "pb_day1";
            this.pb_day1.Size = new System.Drawing.Size(73, 69);
            this.pb_day1.TabIndex = 1;
            this.pb_day1.TabStop = false;
            // 
            // lbl_day1
            // 
            this.lbl_day1.AutoSize = true;
            this.lbl_day1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_day1.Location = new System.Drawing.Point(5, 7);
            this.lbl_day1.Name = "lbl_day1";
            this.lbl_day1.Size = new System.Drawing.Size(56, 23);
            this.lbl_day1.TabIndex = 2;
            this.lbl_day1.Text = "Today";
            // 
            // lbl_min1
            // 
            this.lbl_min1.AutoSize = true;
            this.lbl_min1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_min1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_min1.Location = new System.Drawing.Point(96, 67);
            this.lbl_min1.Name = "lbl_min1";
            this.lbl_min1.Size = new System.Drawing.Size(44, 23);
            this.lbl_min1.TabIndex = 0;
            this.lbl_min1.Text = "pres";
            // 
            // lbl_max1
            // 
            this.lbl_max1.AutoSize = true;
            this.lbl_max1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_max1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_max1.Location = new System.Drawing.Point(96, 33);
            this.lbl_max1.Name = "lbl_max1";
            this.lbl_max1.Size = new System.Drawing.Size(45, 23);
            this.lbl_max1.TabIndex = 0;
            this.lbl_max1.Text = "pres";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pb_day2);
            this.panel6.Controls.Add(this.lbl_day2);
            this.panel6.Controls.Add(this.lbl_min2);
            this.panel6.Controls.Add(this.lbl_max2);
            this.panel6.Location = new System.Drawing.Point(489, 485);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 114);
            this.panel6.TabIndex = 4;
            // 
            // pb_day2
            // 
            this.pb_day2.Location = new System.Drawing.Point(12, 33);
            this.pb_day2.Name = "pb_day2";
            this.pb_day2.Size = new System.Drawing.Size(73, 69);
            this.pb_day2.TabIndex = 1;
            this.pb_day2.TabStop = false;
            // 
            // lbl_day2
            // 
            this.lbl_day2.AutoSize = true;
            this.lbl_day2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_day2.Location = new System.Drawing.Point(8, 7);
            this.lbl_day2.Name = "lbl_day2";
            this.lbl_day2.Size = new System.Drawing.Size(56, 23);
            this.lbl_day2.TabIndex = 2;
            this.lbl_day2.Text = "Today";
            // 
            // lbl_min2
            // 
            this.lbl_min2.AutoSize = true;
            this.lbl_min2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_min2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_min2.Location = new System.Drawing.Point(91, 67);
            this.lbl_min2.Name = "lbl_min2";
            this.lbl_min2.Size = new System.Drawing.Size(44, 23);
            this.lbl_min2.TabIndex = 0;
            this.lbl_min2.Text = "pres";
            // 
            // lbl_max2
            // 
            this.lbl_max2.AutoSize = true;
            this.lbl_max2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_max2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_max2.Location = new System.Drawing.Point(91, 33);
            this.lbl_max2.Name = "lbl_max2";
            this.lbl_max2.Size = new System.Drawing.Size(45, 23);
            this.lbl_max2.TabIndex = 0;
            this.lbl_max2.Text = "pres";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pb_day3);
            this.panel7.Controls.Add(this.lbl_day3);
            this.panel7.Controls.Add(this.lbl_min3);
            this.panel7.Controls.Add(this.lbl_max3);
            this.panel7.Location = new System.Drawing.Point(707, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(205, 114);
            this.panel7.TabIndex = 4;
            // 
            // pb_day3
            // 
            this.pb_day3.Location = new System.Drawing.Point(18, 33);
            this.pb_day3.Name = "pb_day3";
            this.pb_day3.Size = new System.Drawing.Size(73, 69);
            this.pb_day3.TabIndex = 1;
            this.pb_day3.TabStop = false;
            // 
            // lbl_day3
            // 
            this.lbl_day3.AutoSize = true;
            this.lbl_day3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_day3.Location = new System.Drawing.Point(14, 7);
            this.lbl_day3.Name = "lbl_day3";
            this.lbl_day3.Size = new System.Drawing.Size(56, 23);
            this.lbl_day3.TabIndex = 2;
            this.lbl_day3.Text = "Today";
            // 
            // lbl_min3
            // 
            this.lbl_min3.AutoSize = true;
            this.lbl_min3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_min3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_min3.Location = new System.Drawing.Point(98, 67);
            this.lbl_min3.Name = "lbl_min3";
            this.lbl_min3.Size = new System.Drawing.Size(44, 23);
            this.lbl_min3.TabIndex = 0;
            this.lbl_min3.Text = "pres";
            // 
            // lbl_max3
            // 
            this.lbl_max3.AutoSize = true;
            this.lbl_max3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_max3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_max3.Location = new System.Drawing.Point(98, 33);
            this.lbl_max3.Name = "lbl_max3";
            this.lbl_max3.Size = new System.Drawing.Size(45, 23);
            this.lbl_max3.TabIndex = 0;
            this.lbl_max3.Text = "pres";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pb_day4);
            this.panel8.Controls.Add(this.lbl_day4);
            this.panel8.Controls.Add(this.lbl_min4);
            this.panel8.Controls.Add(this.lbl_max4);
            this.panel8.Location = new System.Drawing.Point(925, 485);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(205, 114);
            this.panel8.TabIndex = 4;
            // 
            // pb_day4
            // 
            this.pb_day4.Location = new System.Drawing.Point(15, 33);
            this.pb_day4.Name = "pb_day4";
            this.pb_day4.Size = new System.Drawing.Size(73, 69);
            this.pb_day4.TabIndex = 1;
            this.pb_day4.TabStop = false;
            // 
            // lbl_day4
            // 
            this.lbl_day4.AutoSize = true;
            this.lbl_day4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_day4.Location = new System.Drawing.Point(11, 7);
            this.lbl_day4.Name = "lbl_day4";
            this.lbl_day4.Size = new System.Drawing.Size(56, 23);
            this.lbl_day4.TabIndex = 2;
            this.lbl_day4.Text = "Today";
            // 
            // lbl_min4
            // 
            this.lbl_min4.AutoSize = true;
            this.lbl_min4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_min4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_min4.Location = new System.Drawing.Point(94, 67);
            this.lbl_min4.Name = "lbl_min4";
            this.lbl_min4.Size = new System.Drawing.Size(44, 23);
            this.lbl_min4.TabIndex = 0;
            this.lbl_min4.Text = "pres";
            // 
            // lbl_max4
            // 
            this.lbl_max4.AutoSize = true;
            this.lbl_max4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_max4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_max4.Location = new System.Drawing.Point(94, 33);
            this.lbl_max4.Name = "lbl_max4";
            this.lbl_max4.Size = new System.Drawing.Size(45, 23);
            this.lbl_max4.TabIndex = 0;
            this.lbl_max4.Text = "pres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::WeatherProQQ.Properties.Resources.wallpaperbetter_com_1920x1080;
            this.ClientSize = new System.Drawing.Size(1176, 648);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1192, 687);
            this.MinimumSize = new System.Drawing.Size(1192, 687);
            this.Name = "Form1";
            this.Text = "WeatherProQQ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sunset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sunrise)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tempStats)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_today)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_day4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_windSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_pressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_visibility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_feelsLike;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_sunrise;
        private System.Windows.Forms.Label lbl_sunrise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_sunset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_sunset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_tempStats;
        private System.Windows.Forms.Label lbl_advice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pb_today;
        private System.Windows.Forms.PictureBox pb_day1;
        private System.Windows.Forms.PictureBox pb_day2;
        private System.Windows.Forms.PictureBox pb_day3;
        private System.Windows.Forms.PictureBox pb_day4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_day1;
        private System.Windows.Forms.Label lbl_day2;
        private System.Windows.Forms.Label lbl_day3;
        private System.Windows.Forms.Label lbl_day4;
        private System.Windows.Forms.Label lbl_max1;
        private System.Windows.Forms.Label lbl_todaymax;
        private System.Windows.Forms.Label lbl_max2;
        private System.Windows.Forms.Label lbl_max3;
        private System.Windows.Forms.Label lbl_max4;
        private System.Windows.Forms.Label lbl_todaymin;
        private System.Windows.Forms.Label lbl_min1;
        private System.Windows.Forms.Label lbl_min2;
        private System.Windows.Forms.Label lbl_min3;
        private System.Windows.Forms.Label lbl_min4;
    }
}

