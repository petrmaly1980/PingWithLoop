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
            this.dataGridViewSuccess = new System.Windows.Forms.DataGridView();
            this.colSuccesssIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccesssTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFailed = new System.Windows.Forms.DataGridView();
            this.colFailedIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTimeOut = new System.Windows.Forms.TextBox();
            this.textBoxBufferSize = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxRandomPacketSize = new System.Windows.Forms.CheckBox();
            this.textBoxRandomMin = new System.Windows.Forms.TextBox();
            this.textBoxRandomMax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonUnlimitedPing = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxEmailBody = new System.Windows.Forms.TextBox();
            this.textBoxEmailSubject = new System.Windows.Forms.TextBox();
            this.textBoxEmailTo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFailed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPing
            // 
            this.buttonPing.Location = new System.Drawing.Point(348, 94);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(280, 23);
            this.buttonPing.TabIndex = 0;
            this.buttonPing.Text = "Ping 1x";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(39, 6);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(299, 20);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.Text = "8.8.8.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // buttonPingLoopStart
            // 
            this.buttonPingLoopStart.Location = new System.Drawing.Point(348, 120);
            this.buttonPingLoopStart.Name = "buttonPingLoopStart";
            this.buttonPingLoopStart.Size = new System.Drawing.Size(137, 23);
            this.buttonPingLoopStart.TabIndex = 4;
            this.buttonPingLoopStart.Text = "PingLoopStart";
            this.buttonPingLoopStart.UseVisualStyleBackColor = true;
            this.buttonPingLoopStart.Click += new System.EventHandler(this.buttonPingLoopStart_Click);
            // 
            // textBoxTimeLoop
            // 
            this.textBoxTimeLoop.Location = new System.Drawing.Point(290, 32);
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
            this.buttonPingLoopStop.Location = new System.Drawing.Point(491, 119);
            this.buttonPingLoopStop.Name = "buttonPingLoopStop";
            this.buttonPingLoopStop.Size = new System.Drawing.Size(137, 54);
            this.buttonPingLoopStop.TabIndex = 6;
            this.buttonPingLoopStop.Text = "PingLoopStop";
            this.buttonPingLoopStop.UseVisualStyleBackColor = true;
            this.buttonPingLoopStop.Click += new System.EventHandler(this.buttonPingLoopStop_Click);
            // 
            // labelCounterAll
            // 
            this.labelCounterAll.AutoSize = true;
            this.labelCounterAll.Location = new System.Drawing.Point(79, 650);
            this.labelCounterAll.Name = "labelCounterAll";
            this.labelCounterAll.Size = new System.Drawing.Size(13, 13);
            this.labelCounterAll.TabIndex = 8;
            this.labelCounterAll.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Counter All:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(441, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Failed:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Success:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Repeat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Counter Limit:";
            // 
            // textBoxCounterLimit
            // 
            this.textBoxCounterLimit.Location = new System.Drawing.Point(290, 62);
            this.textBoxCounterLimit.Name = "textBoxCounterLimit";
            this.textBoxCounterLimit.Size = new System.Drawing.Size(48, 20);
            this.textBoxCounterLimit.TabIndex = 16;
            this.textBoxCounterLimit.Text = "100";
            // 
            // buttonClearSuccess
            // 
            this.buttonClearSuccess.Location = new System.Drawing.Point(327, 341);
            this.buttonClearSuccess.Name = "buttonClearSuccess";
            this.buttonClearSuccess.Size = new System.Drawing.Size(93, 22);
            this.buttonClearSuccess.TabIndex = 17;
            this.buttonClearSuccess.Text = "Clear Success";
            this.buttonClearSuccess.UseVisualStyleBackColor = true;
            this.buttonClearSuccess.Click += new System.EventHandler(this.buttonClearSuccess_Click);
            // 
            // buttonClearFailed
            // 
            this.buttonClearFailed.Location = new System.Drawing.Point(774, 341);
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
            this.labelCounterSuccess.Location = new System.Drawing.Point(64, 347);
            this.labelCounterSuccess.Name = "labelCounterSuccess";
            this.labelCounterSuccess.Size = new System.Drawing.Size(13, 13);
            this.labelCounterSuccess.TabIndex = 19;
            this.labelCounterSuccess.Text = "0";
            // 
            // labelCounterFailed
            // 
            this.labelCounterFailed.AutoSize = true;
            this.labelCounterFailed.ForeColor = System.Drawing.Color.Red;
            this.labelCounterFailed.Location = new System.Drawing.Point(485, 346);
            this.labelCounterFailed.Name = "labelCounterFailed";
            this.labelCounterFailed.Size = new System.Drawing.Size(13, 13);
            this.labelCounterFailed.TabIndex = 20;
            this.labelCounterFailed.Text = "0";
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
            this.dataGridViewSuccess.Location = new System.Drawing.Point(11, 368);
            this.dataGridViewSuccess.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSuccess.Name = "dataGridViewSuccess";
            this.dataGridViewSuccess.ReadOnly = true;
            this.dataGridViewSuccess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSuccess.RowHeadersVisible = false;
            this.dataGridViewSuccess.RowHeadersWidth = 51;
            this.dataGridViewSuccess.RowTemplate.Height = 24;
            this.dataGridViewSuccess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSuccess.Size = new System.Drawing.Size(409, 280);
            this.dataGridViewSuccess.TabIndex = 22;
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
            this.dataGridViewFailed.Location = new System.Drawing.Point(435, 368);
            this.dataGridViewFailed.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFailed.Name = "dataGridViewFailed";
            this.dataGridViewFailed.ReadOnly = true;
            this.dataGridViewFailed.RowHeadersVisible = false;
            this.dataGridViewFailed.RowHeadersWidth = 51;
            this.dataGridViewFailed.RowTemplate.Height = 24;
            this.dataGridViewFailed.Size = new System.Drawing.Size(414, 280);
            this.dataGridViewFailed.TabIndex = 23;
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
            // TimeOut
            // 
            this.TimeOut.AutoSize = true;
            this.TimeOut.Location = new System.Drawing.Point(27, 35);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(50, 13);
            this.TimeOut.TabIndex = 24;
            this.TimeOut.Text = "TimeOut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Packet size:";
            // 
            // textBoxTimeOut
            // 
            this.textBoxTimeOut.Location = new System.Drawing.Point(86, 32);
            this.textBoxTimeOut.Name = "textBoxTimeOut";
            this.textBoxTimeOut.Size = new System.Drawing.Size(71, 20);
            this.textBoxTimeOut.TabIndex = 26;
            this.textBoxTimeOut.Text = "1000";
            this.toolTip1.SetToolTip(this.textBoxTimeOut, "An Int32 value that specifies the maximum number of milliseconds (after sending t" +
        "he echo message) to wait for the ICMP echo reply message.");
            // 
            // textBoxBufferSize
            // 
            this.textBoxBufferSize.Location = new System.Drawing.Point(86, 62);
            this.textBoxBufferSize.Name = "textBoxBufferSize";
            this.textBoxBufferSize.Size = new System.Drawing.Size(71, 20);
            this.textBoxBufferSize.TabIndex = 27;
            this.textBoxBufferSize.Text = "32";
            this.toolTip1.SetToolTip(this.textBoxBufferSize, "Buffer size");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "byte";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(752, 652);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 30;
            this.labelStatus.Text = "Status";
            // 
            // checkBoxRandomPacketSize
            // 
            this.checkBoxRandomPacketSize.AutoSize = true;
            this.checkBoxRandomPacketSize.Location = new System.Drawing.Point(193, 28);
            this.checkBoxRandomPacketSize.Name = "checkBoxRandomPacketSize";
            this.checkBoxRandomPacketSize.Size = new System.Drawing.Size(120, 17);
            this.checkBoxRandomPacketSize.TabIndex = 32;
            this.checkBoxRandomPacketSize.Text = "RandomPacketSize";
            this.checkBoxRandomPacketSize.UseVisualStyleBackColor = true;
            // 
            // textBoxRandomMin
            // 
            this.textBoxRandomMin.Location = new System.Drawing.Point(44, 16);
            this.textBoxRandomMin.Name = "textBoxRandomMin";
            this.textBoxRandomMin.Size = new System.Drawing.Size(49, 20);
            this.textBoxRandomMin.TabIndex = 33;
            this.textBoxRandomMin.Text = "32";
            // 
            // textBoxRandomMax
            // 
            this.textBoxRandomMax.Location = new System.Drawing.Point(44, 42);
            this.textBoxRandomMax.Name = "textBoxRandomMax";
            this.textBoxRandomMax.Size = new System.Drawing.Size(49, 20);
            this.textBoxRandomMax.TabIndex = 34;
            this.textBoxRandomMax.Text = "1024";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Max";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.checkBoxRandomPacketSize);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxRandomMin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxRandomMax);
            this.groupBox1.Location = new System.Drawing.Point(19, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 78);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random packet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Max 65535";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "bytes";
            // 
            // buttonUnlimitedPing
            // 
            this.buttonUnlimitedPing.Location = new System.Drawing.Point(348, 150);
            this.buttonUnlimitedPing.Name = "buttonUnlimitedPing";
            this.buttonUnlimitedPing.Size = new System.Drawing.Size(137, 23);
            this.buttonUnlimitedPing.TabIndex = 38;
            this.buttonUnlimitedPing.Text = "Unlimited Loop Ping";
            this.buttonUnlimitedPing.UseVisualStyleBackColor = true;
            this.buttonUnlimitedPing.Click += new System.EventHandler(this.buttonUnlimitedPing_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBoxEmailBody);
            this.groupBox3.Controls.Add(this.textBoxEmailSubject);
            this.groupBox3.Controls.Add(this.textBoxEmailTo);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 238);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email Notify";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Body:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Subject:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "To:";
            // 
            // textBoxEmailBody
            // 
            this.textBoxEmailBody.Location = new System.Drawing.Point(66, 68);
            this.textBoxEmailBody.Multiline = true;
            this.textBoxEmailBody.Name = "textBoxEmailBody";
            this.textBoxEmailBody.Size = new System.Drawing.Size(323, 80);
            this.textBoxEmailBody.TabIndex = 2;
            // 
            // textBoxEmailSubject
            // 
            this.textBoxEmailSubject.Location = new System.Drawing.Point(66, 42);
            this.textBoxEmailSubject.Name = "textBoxEmailSubject";
            this.textBoxEmailSubject.Size = new System.Drawing.Size(206, 20);
            this.textBoxEmailSubject.TabIndex = 1;
            // 
            // textBoxEmailTo
            // 
            this.textBoxEmailTo.Location = new System.Drawing.Point(66, 19);
            this.textBoxEmailTo.Name = "textBoxEmailTo";
            this.textBoxEmailTo.Size = new System.Drawing.Size(206, 20);
            this.textBoxEmailTo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 276);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxIP);
            this.tabPage1.Controls.Add(this.buttonPing);
            this.tabPage1.Controls.Add(this.buttonUnlimitedPing);
            this.tabPage1.Controls.Add(this.textBoxCounterLimit);
            this.tabPage1.Controls.Add(this.buttonPingLoopStart);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.buttonPingLoopStop);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TimeOut);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxTimeLoop);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxTimeOut);
            this.tabPage1.Controls.Add(this.textBoxBufferSize);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ping General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(416, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 238);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail Server";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Server address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Port:";
            // 
            // Pingwithloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dataGridViewFailed);
            this.Controls.Add(this.dataGridViewSuccess);
            this.Controls.Add(this.labelCounterFailed);
            this.Controls.Add(this.labelCounterSuccess);
            this.Controls.Add(this.buttonClearFailed);
            this.Controls.Add(this.buttonClearSuccess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCounterAll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pingwithloop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping With Loop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFailed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxRandomPacketSize;
        private System.Windows.Forms.TextBox textBoxRandomMin;
        private System.Windows.Forms.TextBox textBoxRandomMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonUnlimitedPing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxEmailBody;
        private System.Windows.Forms.TextBox textBoxEmailSubject;
        private System.Windows.Forms.TextBox textBoxEmailTo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
    }
}

