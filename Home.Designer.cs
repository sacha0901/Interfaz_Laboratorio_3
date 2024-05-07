namespace Lab3
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.label2 = new System.Windows.Forms.Label();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.BtnSearchPorts = new System.Windows.Forms.Button();
            this.CboPorts = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnSensors = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnLcdDisplay = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLedMatrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConect = new System.Windows.Forms.Button();
            this.SpPorts = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.TmrTimer = new System.Windows.Forms.Timer(this.components);
            this.LblTimer = new System.Windows.Forms.Label();
            this.LblTimerConect = new System.Windows.Forms.Label();
            this.TmrTimerConect = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(55, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Velocidad ";
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(192, 188);
            this.CboBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(119, 26);
            this.CboBaudRate.TabIndex = 27;
            this.CboBaudRate.Text = "9600";
            // 
            // BtnSearchPorts
            // 
            this.BtnSearchPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnSearchPorts.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSearchPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchPorts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearchPorts.Location = new System.Drawing.Point(58, 147);
            this.BtnSearchPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchPorts.Name = "BtnSearchPorts";
            this.BtnSearchPorts.Size = new System.Drawing.Size(107, 28);
            this.BtnSearchPorts.TabIndex = 26;
            this.BtnSearchPorts.Text = "search ports";
            this.BtnSearchPorts.UseVisualStyleBackColor = false;
            this.BtnSearchPorts.Click += new System.EventHandler(this.BtnSearchPorts_Click);
            // 
            // CboPorts
            // 
            this.CboPorts.FormattingEnabled = true;
            this.CboPorts.Location = new System.Drawing.Point(192, 147);
            this.CboPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboPorts.Name = "CboPorts";
            this.CboPorts.Size = new System.Drawing.Size(119, 26);
            this.CboPorts.TabIndex = 25;
            this.CboPorts.SelectedIndexChanged += new System.EventHandler(this.CboPorts_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.BtnSensors);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.BtnLcdDisplay);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BtnLedMatrix);
            this.panel1.Location = new System.Drawing.Point(58, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 309);
            this.panel1.TabIndex = 24;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Crimson;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.Location = new System.Drawing.Point(480, 255);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(92, 31);
            this.BtnClose.TabIndex = 29;
            this.BtnClose.Text = "Salir";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Lab3.Properties.Resources.LcdDisplay;
            this.pictureBox5.Location = new System.Drawing.Point(28, 24);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(277, 262);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(372, 197);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 23);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // BtnSensors
            // 
            this.BtnSensors.BackColor = System.Drawing.Color.White;
            this.BtnSensors.Enabled = false;
            this.BtnSensors.FlatAppearance.BorderSize = 0;
            this.BtnSensors.Location = new System.Drawing.Point(360, 186);
            this.BtnSensors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSensors.Name = "BtnSensors";
            this.BtnSensors.Size = new System.Drawing.Size(213, 46);
            this.BtnSensors.TabIndex = 8;
            this.BtnSensors.Text = "Sensores";
            this.BtnSensors.UseVisualStyleBackColor = false;
            this.BtnSensors.Click += new System.EventHandler(this.BtnSensors_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(371, 116);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // BtnLcdDisplay
            // 
            this.BtnLcdDisplay.BackColor = System.Drawing.Color.White;
            this.BtnLcdDisplay.Enabled = false;
            this.BtnLcdDisplay.FlatAppearance.BorderSize = 0;
            this.BtnLcdDisplay.Location = new System.Drawing.Point(359, 105);
            this.BtnLcdDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLcdDisplay.Name = "BtnLcdDisplay";
            this.BtnLcdDisplay.Size = new System.Drawing.Size(213, 46);
            this.BtnLcdDisplay.TabIndex = 7;
            this.BtnLcdDisplay.Text = "Pantalla LCD ";
            this.BtnLcdDisplay.UseVisualStyleBackColor = false;
            this.BtnLcdDisplay.Click += new System.EventHandler(this.BtnLcdDisplay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(371, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BtnLedMatrix
            // 
            this.BtnLedMatrix.BackColor = System.Drawing.Color.White;
            this.BtnLedMatrix.Enabled = false;
            this.BtnLedMatrix.Location = new System.Drawing.Point(360, 24);
            this.BtnLedMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLedMatrix.Name = "BtnLedMatrix";
            this.BtnLedMatrix.Size = new System.Drawing.Size(213, 46);
            this.BtnLedMatrix.TabIndex = 1;
            this.BtnLedMatrix.Text = "    Matriz de Leds 8x8";
            this.BtnLedMatrix.UseVisualStyleBackColor = false;
            this.BtnLedMatrix.Click += new System.EventHandler(this.BtnLedMatrix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "CONTROL CON MICROCONTROLADORES ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sensores temperatura, luz, humedad.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Matriz de LED\'s8x8 - Pantalla LCD de 20x4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnConect
            // 
            this.BtnConect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnConect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConect.Location = new System.Drawing.Point(350, 162);
            this.BtnConect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConect.Name = "BtnConect";
            this.BtnConect.Size = new System.Drawing.Size(120, 34);
            this.BtnConect.TabIndex = 33;
            this.BtnConect.Text = "Conect";
            this.BtnConect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConect.UseVisualStyleBackColor = false;
            this.BtnConect.Click += new System.EventHandler(this.BtnConect_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Lab3.Properties.Resources.disconnected;
            this.pictureBox8.Location = new System.Drawing.Point(550, 147);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(106, 69);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(360, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(523, 21);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(159, 87);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(57, 27);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 87);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // TmrTimer
            // 
            this.TmrTimer.Tick += new System.EventHandler(this.TmrTimer_Tick);
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Location = new System.Drawing.Point(23, 533);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(16, 18);
            this.LblTimer.TabIndex = 35;
            this.LblTimer.Text = "0";
            // 
            // LblTimerConect
            // 
            this.LblTimerConect.AutoSize = true;
            this.LblTimerConect.Location = new System.Drawing.Point(13, 479);
            this.LblTimerConect.Name = "LblTimerConect";
            this.LblTimerConect.Size = new System.Drawing.Size(16, 18);
            this.LblTimerConect.TabIndex = 36;
            this.LblTimerConect.Text = "0";
            // 
            // TmrTimerConect
            // 
            this.TmrTimerConect.Interval = 50;
            this.TmrTimerConect.Tick += new System.EventHandler(this.TmrTimerConect_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 579);
            this.Controls.Add(this.LblTimerConect);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnConect);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.BtnSearchPorts);
            this.Controls.Add(this.CboPorts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Home :::";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.Button BtnSearchPorts;
        private System.Windows.Forms.ComboBox CboPorts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnSensors;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnLcdDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnLedMatrix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button BtnConect;
        public System.IO.Ports.SerialPort SpPorts;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer TmrTimer;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label LblTimerConect;
        private System.Windows.Forms.Timer TmrTimerConect;
    }
}

