namespace Pingwithloop
{
    partial class Pingwithloop
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
            this.buttonPing = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPingLoopStart = new System.Windows.Forms.Button();
            this.textBoxTimeLoop = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPingLoopStop = new System.Windows.Forms.Button();
            this.labelCounterAll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCounterLimit = new System.Windows.Forms.TextBox();
            this.buttonClearSuccess = new System.Windows.Forms.Button();
            this.buttonClearFailed = new System.Windows.Forms.Button();
            this.labelCounterSuccess = new System.Windows.Forms.Label();
            this.labelCounterFailed = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridViewSuccess = new System.Windows.Forms.DataGridView();
            this.dataGridViewFailed = new System.Windows.Forms.DataGridView();
            this.TimeOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTimeOut = new System.Windows.Forms.TextBox();
            this.textBoxBufferSize = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.colFailedIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFailed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(370, 10);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(107, 23);
            this.buttonPing.TabIndex = 0;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(35, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(299, 20);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.Text = "8.8.8.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // buttonPingLoopStart
            // 
            this.buttonPingLoopStart.Location = new System.Drawing.Point(370, 36);
            this.buttonPingLoopStart.Name = "buttonPingLoopStart";
            this.buttonPingLoopStart.Size = new System.Drawing.Size(107, 23);
            this.buttonPingLoopStart.TabIndex = 4;
            this.buttonPingLoopStart.Text = "PingLoopStart";
            this.buttonPingLoopStart.UseVisualStyleBackColor = true;
            this.buttonPingLoopStart.Click += new System.EventHandler(this.buttonPingLoopStart_Click);
            // 
            // textBoxTimeLoop
            // 
            this.textBoxTimeLoop.Location = new System.Drawing.Point(286, 38);
            this.textBoxTimeLoop.Name = "textBoxTimeLoop";
            this.textBoxTimeLoop.Size = new System.Drawing.Size(48, 20);
            this.textBoxTimeLoop.TabIndex = 5;
            this.textBoxTimeLoop.Text = "2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.onTick);
            // 
            // buttonPingLoopStop
            // 
            this.buttonPingLoopStop.Location = new System.Drawing.Point(483, 36);
            this.buttonPingLoopStop.Name = "buttonPingLoopStop";
            this.buttonPingLoopStop.Size = new System.Drawing.Size(122, 23);
            this.buttonPingLoopStop.TabIndex = 6;
            this.buttonPingLoopStop.Text = "PingLoopStop";
            this.buttonPingLoopStop.UseVisualStyleBackColor = true;
            this.buttonPingLoopStop.Click += new System.EventHandler(this.buttonPingLoopStop_Click);
            // 
            // labelCounterAll
            // 
            this.labelCounterAll.AutoSize = true;
            this.labelCounterAll.Location = new System.Drawing.Point(79, 486);
            this.labelCounterAll.Name = "labelCounterAll";
            this.labelCounterAll.Size = new System.Drawing.Size(13, 13);
            this.labelCounterAll.TabIndex = 8;
            this.labelCounterAll.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Counter All:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(464, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Failed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Success:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Repeat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Counter Limit:";
            // 
            // textBoxCounterLimit
            // 
            this.textBoxCounterLimit.Location = new System.Drawing.Point(286, 68);
            this.textBoxCounterLimit.Name = "textBoxCounterLimit";
            this.textBoxCounterLimit.Size = new System.Drawing.Size(48, 20);
            this.textBoxCounterLimit.TabIndex = 16;
            this.textBoxCounterLimit.Text = "100";
            // 
            // buttonClearSuccess
            // 
            this.buttonClearSuccess.Location = new System.Drawing.Point(302, 109);
            this.buttonClearSuccess.Name = "buttonClearSuccess";
            this.buttonClearSuccess.Size = new System.Drawing.Size(93, 22);
            this.buttonClearSuccess.TabIndex = 17;
            this.buttonClearSuccess.Text = "Clear Success";
            this.buttonClearSuccess.UseVisualStyleBackColor = true;
            this.buttonClearSuccess.Click += new System.EventHandler(this.buttonClearSuccess_Click);
            // 
            // buttonClearFailed
            // 
            this.buttonClearFailed.Location = new System.Drawing.Point(727, 110);
            this.buttonClearFailed.Name = "buttonClearFailed";
            this.buttonClearFailed.Size = new System.Drawing.Size(75, 22);
            this.buttonClearFailed.TabIndex = 18;
            this.buttonClearFailed.Text = "Clear Failed";
            this.buttonClearFailed.UseVisualStyleBackColor = true;
            this.buttonClearFailed.Click += new System.EventHandler(this.buttonClearFailed_Click);
            // 
            // labelCounterSuccess
            // 
            this.labelCounterSuccess.AutoSize = true;
            this.labelCounterSuccess.Location = new System.Drawing.Point(64, 115);
            this.labelCounterSuccess.Name = "labelCounterSuccess";
            this.labelCounterSuccess.Size = new System.Drawing.Size(13, 13);
            this.labelCounterSuccess.TabIndex = 19;
            this.labelCounterSuccess.Text = "0";
            // 
            // labelCounterFailed
            // 
            this.labelCounterFailed.AutoSize = true;
            this.labelCounterFailed.ForeColor = System.Drawing.Color.Red;
            this.labelCounterFailed.Location = new System.Drawing.Point(506, 115);
            this.labelCounterFailed.Name = "labelCounterFailed";
            this.labelCounterFailed.Size = new System.Drawing.Size(13, 13);
            this.labelCounterFailed.TabIndex = 20;
            this.labelCounterFailed.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(682, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed by Petr Maly";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridViewSuccess
            // 
            this.dataGridViewSuccess.AllowUserToAddRows = false;
            this.dataGridViewSuccess.AllowUserToDeleteRows = false;
            this.dataGridViewSuccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuccess.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewSuccess.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewSuccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSuccesssIP,
            this.colSuccesssBytes,
            this.colSuccesssStatus,
            this.colSuccesssDate,
            this.colSuccesssTime});
            this.dataGridViewSuccess.Location = new System.Drawing.Point(11, 136);
            this.dataGridViewSuccess.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSuccess.Name = "dataGridViewSuccess";
            this.dataGridViewSuccess.ReadOnly = true;
            this.dataGridViewSuccess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSuccess.RowHeadersVisible = false;
            this.dataGridViewSuccess.RowHeadersWidth = 51;
            this.dataGridViewSuccess.RowTemplate.Height = 24;
            this.dataGridViewSuccess.Size = new System.Drawing.Size(384, 348);
            this.dataGridViewSuccess.TabIndex = 22;
            // 
            // dataGridViewFailed
            // 
            this.dataGridViewFailed.AllowUserToAddRows = false;
            this.dataGridViewFailed.AllowUserToDeleteRows = false;
            this.dataGridViewFailed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFailed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewFailed.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewFailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFailed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFailedIP,
            this.colFailedBytes,
            this.colFailedStatus,
            this.colFailedDate,
            this.colFailedTime});
            this.dataGridViewFailed.Location = new System.Drawing.Point(399, 136);
            this.dataGridViewFailed.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFailed.Name = "dataGridViewFailed";
            this.dataGridViewFailed.ReadOnly = true;
            this.dataGridViewFailed.RowHeadersVisible = false;
            this.dataGridViewFailed.RowHeadersWidth = 51;
            this.dataGridViewFailed.RowTemplate.Height = 24;
            this.dataGridViewFailed.Size = new System.Drawing.Size(403, 348);
            this.dataGridViewFailed.TabIndex = 23;
            // 
            // TimeOut
            // 
            this.TimeOut.AutoSize = true;
            this.TimeOut.Location = new System.Drawing.Point(23, 41);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(50, 13);
            this.TimeOut.TabIndex = 24;
            this.TimeOut.Text = "TimeOut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Packet size:";
            // 
            // textBoxTimeOut
            // 
            this.textBoxTimeOut.Location = new System.Drawing.Point(82, 38);
            this.textBoxTimeOut.Name = "textBoxTimeOut";
            this.textBoxTimeOut.Size = new System.Drawing.Size(71, 20);
            this.textBoxTimeOut.TabIndex = 26;
            this.textBoxTimeOut.Text = "1000";
            this.toolTip1.SetToolTip(this.textBoxTimeOut, "An Int32 value that specifies the maximum number of milliseconds (after sending t" +
        "he echo message) to wait for the ICMP echo reply message.");
            // 
            // textBoxBufferSize
            // 
            this.textBoxBufferSize.Location = new System.Drawing.Point(83, 68);
            this.textBoxBufferSize.Name = "textBoxBufferSize";
            this.textBoxBufferSize.Size = new System.Drawing.Size(71, 20);
            this.textBoxBufferSize.TabIndex = 27;
            this.textBoxBufferSize.Text = "32";
            this.toolTip1.SetToolTip(this.textBoxBufferSize, "Buffer size");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "byte";
            // 
            // colFailedIP
            // 
            this.colFailedIP.FillWeight = 106.3119F;
            this.colFailedIP.HeaderText = "IP";
            this.colFailedIP.MinimumWidth = 6;
            this.colFailedIP.Name = "colFailedIP";
            this.colFailedIP.ReadOnly = true;
            // 
            // colFailedBytes
            // 
            this.colFailedBytes.HeaderText = "Bytes";
            this.colFailedBytes.Name = "colFailedBytes";
            this.colFailedBytes.ReadOnly = true;
            // 
            // colFailedStatus
            // 
            this.colFailedStatus.FillWeight = 76.66875F;
            this.colFailedStatus.HeaderText = "Status";
            this.colFailedStatus.MinimumWidth = 6;
            this.colFailedStatus.Name = "colFailedStatus";
            this.colFailedStatus.ReadOnly = true;
            // 
            // colFailedDate
            // 
            this.colFailedDate.FillWeight = 95.19191F;
            this.colFailedDate.HeaderText = "Date";
            this.colFailedDate.MinimumWidth = 6;
            this.colFailedDate.Name = "colFailedDate";
            this.colFailedDate.ReadOnly = true;
            // 
            // colFailedTime
            // 
            this.colFailedTime.FillWeight = 121.8274F;
            this.colFailedTime.HeaderText = "Time";
            this.colFailedTime.MinimumWidth = 6;
            this.colFailedTime.Name = "colFailedTime";
            this.colFailedTime.ReadOnly = true;
            // 
            // colSuccesssIP
            // 
            this.colSuccesssIP.FillWeight = 102.0748F;
            this.colSuccesssIP.HeaderText = "IP";
            this.colSuccesssIP.MinimumWidth = 6;
            this.colSuccesssIP.Name = "colSuccesssIP";
            this.colSuccesssIP.ReadOnly = true;
            // 
            // colSuccesssBytes
            // 
            this.colSuccesssBytes.HeaderText = "Bytes";
            this.colSuccesssBytes.Name = "colSuccesssBytes";
            this.colSuccesssBytes.ReadOnly = true;
            // 
            // colSuccesssStatus
            // 
            this.colSuccesssStatus.FillWeight = 77.88841F;
            this.colSuccesssStatus.HeaderText = "Status";
            this.colSuccesssStatus.MinimumWidth = 6;
            this.colSuccesssStatus.Name = "colSuccesssStatus";
            this.colSuccesssStatus.ReadOnly = true;
            // 
            // colSuccesssDate
            // 
            this.colSuccesssDate.FillWeight = 98.20932F;
            this.colSuccesssDate.HeaderText = "Date";
            this.colSuccesssDate.MinimumWidth = 6;
            this.colSuccesssDate.Name = "colSuccesssDate";
            this.colSuccesssDate.ReadOnly = true;
            // 
            // colSuccesssTime
            // 
            this.colSuccesssTime.FillWeight = 121.8274F;
            this.colSuccesssTime.HeaderText = "Time";
            this.colSuccesssTime.MinimumWidth = 6;
            this.colSuccesssTime.Name = "colSuccesssTime";
            this.colSuccesssTime.ReadOnly = true;
            // 
            // Pingwithloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 510);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxBufferSize);
            this.Controls.Add(this.textBoxTimeOut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeOut);
            this.Controls.Add(this.dataGridViewFailed);
            this.Controls.Add(this.dataGridViewSuccess);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelCounterFailed);
            this.Controls.Add(this.labelCounterSuccess);
            this.Controls.Add(this.buttonClearFailed);
            this.Controls.Add(this.buttonClearSuccess);
            this.Controls.Add(this.textBoxCounterLimit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCounterAll);
            this.Controls.Add(this.buttonPingLoopStop);
            this.Controls.Add(this.textBoxTimeLoop);
            this.Controls.Add(this.buttonPingLoopStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.buttonPing);
            this.Name = "Pingwithloop";
            this.Text = "Ping With Loop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFailed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPingLoopStart;
        private System.Windows.Forms.TextBox textBoxTimeLoop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPingLoopStop;
        private System.Windows.Forms.Label labelCounterAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCounterLimit;
        private System.Windows.Forms.Button buttonClearSuccess;
        private System.Windows.Forms.Button buttonClearFailed;
        private System.Windows.Forms.Label labelCounterSuccess;
        private System.Windows.Forms.Label labelCounterFailed;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridViewSuccess;
        private System.Windows.Forms.DataGridView dataGridViewFailed;
        private System.Windows.Forms.Label TimeOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTimeOut;
        private System.Windows.Forms.TextBox textBoxBufferSize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccesssIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccesssBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccesssStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccesssDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccesssTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailedIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailedBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailedStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailedTime;
    }
}

