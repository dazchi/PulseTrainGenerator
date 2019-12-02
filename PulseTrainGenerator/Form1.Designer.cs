namespace PulseTrainGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Port = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.numericUpDown_steps = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_pps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_steps = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_abort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pps)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Port.Location = new System.Drawing.Point(21, 12);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(46, 21);
            this.label_Port.TabIndex = 1;
            this.label_Port.Text = "Port:";
            // 
            // comboBox_port
            // 
            this.comboBox_port.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(73, 10);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(105, 27);
            this.comboBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_connect.Location = new System.Drawing.Point(184, 9);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(96, 27);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(20, 110);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(230, 23);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_steps
            // 
            this.numericUpDown_steps.Location = new System.Drawing.Point(114, 52);
            this.numericUpDown_steps.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_steps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_steps.Name = "numericUpDown_steps";
            this.numericUpDown_steps.Size = new System.Drawing.Size(129, 25);
            this.numericUpDown_steps.TabIndex = 6;
            this.numericUpDown_steps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_steps.Value = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.numericUpDown_steps.ValueChanged += new System.EventHandler(this.numericUpDown_steps_ValueChanged);
            // 
            // numericUpDown_pps
            // 
            this.numericUpDown_pps.Location = new System.Drawing.Point(114, 19);
            this.numericUpDown_pps.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDown_pps.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_pps.Name = "numericUpDown_pps";
            this.numericUpDown_pps.Size = new System.Drawing.Size(129, 25);
            this.numericUpDown_pps.TabIndex = 7;
            this.numericUpDown_pps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_pps.Value = new decimal(new int[] {
            512000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "pps(aprox.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Count(x5):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total = ";
            // 
            // label_steps
            // 
            this.label_steps.AutoSize = true;
            this.label_steps.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_steps.Location = new System.Drawing.Point(90, 86);
            this.label_steps.Name = "label_steps";
            this.label_steps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_steps.Size = new System.Drawing.Size(86, 21);
            this.label_steps.TabIndex = 11;
            this.label_steps.Text = "100 Steps";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_abort);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.label_steps);
            this.groupBox1.Controls.Add(this.numericUpDown_steps);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_pps);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button_abort
            // 
            this.button_abort.Location = new System.Drawing.Point(20, 137);
            this.button_abort.Name = "button_abort";
            this.button_abort.Size = new System.Drawing.Size(230, 23);
            this.button_abort.TabIndex = 12;
            this.button_abort.Text = "Abort";
            this.button_abort.UseVisualStyleBackColor = true;
            this.button_abort.Click += new System.EventHandler(this.button_abort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.label_Port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UART Pulse Train Generator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pps)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.NumericUpDown numericUpDown_steps;
        private System.Windows.Forms.NumericUpDown numericUpDown_pps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_steps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_abort;
    }
}

