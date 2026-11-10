namespace Communication_System
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerRunTime = new System.Windows.Forms.Timer(this.components);
            this.tslLight = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_ConnState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_Spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_Ready = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel_Log = new Communication_System.ControlTool.UGroupPanel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.btn_ClearLog = new System.Windows.Forms.Button();
            this.chk_AutoScroll = new System.Windows.Forms.CheckBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel_Stat = new Communication_System.ControlTool.UGroupPanel();
            this.lbl_CommTime = new System.Windows.Forms.Label();
            this.lbl_RecvCount = new System.Windows.Forms.TextBox();
            this.lbl_SendCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uPipeVertical1 = new Communication_System.ControlTool.UPipeVertical();
            this.ptb_receiveNumber = new System.Windows.Forms.PictureBox();
            this.ptb_RunTime = new System.Windows.Forms.PictureBox();
            this.ptb_sendCount = new System.Windows.Forms.PictureBox();
            this.uPipeVertical2 = new Communication_System.ControlTool.UPipeVertical();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_Send = new Communication_System.ControlTool.UGroupPanel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btn_SendClear = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_SendBox = new System.Windows.Forms.RichTextBox();
            this.cbo_SendContent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_ConnectSet = new Communication_System.ControlTool.UGroupPanel();
            this.ptb_disconnect = new System.Windows.Forms.PictureBox();
            this.ptb_Connect = new System.Windows.Forms.PictureBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.titleBar1 = new Communication_System.ControlTool.TitleBar();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.btn_Max = new System.Windows.Forms.PictureBox();
            this.btn_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel_Stat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_receiveNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_Send.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_ConnectSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_disconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.titleBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRunTime
            // 
            this.timerRunTime.Interval = 1000;
            this.timerRunTime.Tick += new System.EventHandler(this.timerRunTime_Tick);
            // 
            // tslLight
            // 
            this.tslLight.Image = global::Communication_System.Properties.Resources.icon_dot1;
            this.tslLight.Name = "tslLight";
            this.tslLight.Size = new System.Drawing.Size(24, 24);
            // 
            // tsl_ConnState
            // 
            this.tsl_ConnState.Name = "tsl_ConnState";
            this.tsl_ConnState.Size = new System.Drawing.Size(64, 24);
            this.tsl_ConnState.Text = "未连接";
            // 
            // tsl_Spring
            // 
            this.tsl_Spring.Name = "tsl_Spring";
            this.tsl_Spring.Size = new System.Drawing.Size(1048, 24);
            this.tsl_Spring.Spring = true;
            // 
            // tsl_Ready
            // 
            this.tsl_Ready.Name = "tsl_Ready";
            this.tsl_Ready.Size = new System.Drawing.Size(88, 24);
            this.tsl_Ready.Text = "就绪中......";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLight,
            this.tsl_ConnState,
            this.tsl_Spring,
            this.tsl_Ready});
            this.statusStrip1.Location = new System.Drawing.Point(0, 818);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1239, 31);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel_Log
            // 
            this.panel_Log.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Log.Controls.Add(this.pictureBox16);
            this.panel_Log.Controls.Add(this.btn_ClearLog);
            this.panel_Log.Controls.Add(this.chk_AutoScroll);
            this.panel_Log.Controls.Add(this.rtb_Log);
            this.panel_Log.Controls.Add(this.pictureBox5);
            this.panel_Log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Log.GroupTitle = "      通讯日志";
            this.panel_Log.Location = new System.Drawing.Point(480, 87);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(705, 681);
            this.panel_Log.TabIndex = 4;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox16.Image = global::Communication_System.Properties.Resources.删除1;
            this.pictureBox16.Location = new System.Drawing.Point(518, 6);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(30, 22);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 11;
            this.pictureBox16.TabStop = false;
            // 
            // btn_ClearLog
            // 
            this.btn_ClearLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ClearLog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClearLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ClearLog.Location = new System.Drawing.Point(518, 3);
            this.btn_ClearLog.Margin = new System.Windows.Forms.Padding(8);
            this.btn_ClearLog.Name = "btn_ClearLog";
            this.btn_ClearLog.Size = new System.Drawing.Size(126, 30);
            this.btn_ClearLog.TabIndex = 9;
            this.btn_ClearLog.Text = "  清空日志";
            this.btn_ClearLog.UseVisualStyleBackColor = false;
            this.btn_ClearLog.Click += new System.EventHandler(this.btn_ClearLog_Click);
            // 
            // chk_AutoScroll
            // 
            this.chk_AutoScroll.AutoSize = true;
            this.chk_AutoScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.chk_AutoScroll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk_AutoScroll.Location = new System.Drawing.Point(379, 9);
            this.chk_AutoScroll.Margin = new System.Windows.Forms.Padding(8);
            this.chk_AutoScroll.Name = "chk_AutoScroll";
            this.chk_AutoScroll.Size = new System.Drawing.Size(110, 22);
            this.chk_AutoScroll.TabIndex = 5;
            this.chk_AutoScroll.Text = "自动滚动";
            this.chk_AutoScroll.UseVisualStyleBackColor = false;
            this.chk_AutoScroll.CheckedChanged += new System.EventHandler(this.chk_AutoScroll_CheckedChanged);
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.SystemColors.Menu;
            this.rtb_Log.Location = new System.Drawing.Point(0, 31);
            this.rtb_Log.Margin = new System.Windows.Forms.Padding(8);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_Log.Size = new System.Drawing.Size(705, 650);
            this.rtb_Log.TabIndex = 3;
            this.rtb_Log.Text = "";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.pictureBox5.Image = global::Communication_System.Properties.Resources.列表;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // panel_Stat
            // 
            this.panel_Stat.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Stat.Controls.Add(this.lbl_CommTime);
            this.panel_Stat.Controls.Add(this.lbl_RecvCount);
            this.panel_Stat.Controls.Add(this.lbl_SendCount);
            this.panel_Stat.Controls.Add(this.label5);
            this.panel_Stat.Controls.Add(this.label6);
            this.panel_Stat.Controls.Add(this.label4);
            this.panel_Stat.Controls.Add(this.uPipeVertical1);
            this.panel_Stat.Controls.Add(this.ptb_receiveNumber);
            this.panel_Stat.Controls.Add(this.ptb_RunTime);
            this.panel_Stat.Controls.Add(this.ptb_sendCount);
            this.panel_Stat.Controls.Add(this.uPipeVertical2);
            this.panel_Stat.Controls.Add(this.pictureBox2);
            this.panel_Stat.GroupTitle = "       通讯统计";
            this.panel_Stat.Location = new System.Drawing.Point(22, 592);
            this.panel_Stat.Name = "panel_Stat";
            this.panel_Stat.Size = new System.Drawing.Size(432, 176);
            this.panel_Stat.TabIndex = 3;
            // 
            // lbl_CommTime
            // 
            this.lbl_CommTime.AutoSize = true;
            this.lbl_CommTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CommTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.lbl_CommTime.Location = new System.Drawing.Point(319, 137);
            this.lbl_CommTime.Margin = new System.Windows.Forms.Padding(8);
            this.lbl_CommTime.Name = "lbl_CommTime";
            this.lbl_CommTime.Size = new System.Drawing.Size(106, 21);
            this.lbl_CommTime.TabIndex = 18;
            this.lbl_CommTime.Text = "00:00:00";
            // 
            // lbl_RecvCount
            // 
            this.lbl_RecvCount.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_RecvCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_RecvCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_RecvCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_RecvCount.Location = new System.Drawing.Point(203, 129);
            this.lbl_RecvCount.Margin = new System.Windows.Forms.Padding(8);
            this.lbl_RecvCount.Name = "lbl_RecvCount";
            this.lbl_RecvCount.Size = new System.Drawing.Size(44, 32);
            this.lbl_RecvCount.TabIndex = 17;
            this.lbl_RecvCount.Text = "0";
            this.lbl_RecvCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SendCount
            // 
            this.lbl_SendCount.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SendCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_SendCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SendCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.lbl_SendCount.Location = new System.Drawing.Point(43, 129);
            this.lbl_SendCount.Margin = new System.Windows.Forms.Padding(8);
            this.lbl_SendCount.Name = "lbl_SendCount";
            this.lbl_SendCount.Size = new System.Drawing.Size(44, 32);
            this.lbl_SendCount.TabIndex = 17;
            this.lbl_SendCount.Text = "0";
            this.lbl_SendCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(319, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "通信时长";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(174, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "接收次数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "发送次数";
            // 
            // uPipeVertical1
            // 
            this.uPipeVertical1.Active = false;
            this.uPipeVertical1.BackColor = System.Drawing.Color.Transparent;
            this.uPipeVertical1.Location = new System.Drawing.Point(297, 61);
            this.uPipeVertical1.Margin = new System.Windows.Forms.Padding(8);
            this.uPipeVertical1.Name = "uPipeVertical1";
            this.uPipeVertical1.Size = new System.Drawing.Size(10, 107);
            this.uPipeVertical1.TabIndex = 15;
            this.uPipeVertical1.Text = "uPipeVertical1";
            // 
            // ptb_receiveNumber
            // 
            this.ptb_receiveNumber.BackColor = System.Drawing.SystemColors.Control;
            this.ptb_receiveNumber.Image = global::Communication_System.Properties.Resources.下载;
            this.ptb_receiveNumber.Location = new System.Drawing.Point(160, 49);
            this.ptb_receiveNumber.Margin = new System.Windows.Forms.Padding(8);
            this.ptb_receiveNumber.Name = "ptb_receiveNumber";
            this.ptb_receiveNumber.Size = new System.Drawing.Size(112, 44);
            this.ptb_receiveNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_receiveNumber.TabIndex = 14;
            this.ptb_receiveNumber.TabStop = false;
            // 
            // ptb_RunTime
            // 
            this.ptb_RunTime.BackColor = System.Drawing.SystemColors.Control;
            this.ptb_RunTime.Image = global::Communication_System.Properties.Resources.时钟;
            this.ptb_RunTime.Location = new System.Drawing.Point(312, 49);
            this.ptb_RunTime.Margin = new System.Windows.Forms.Padding(8);
            this.ptb_RunTime.Name = "ptb_RunTime";
            this.ptb_RunTime.Size = new System.Drawing.Size(112, 44);
            this.ptb_RunTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_RunTime.TabIndex = 14;
            this.ptb_RunTime.TabStop = false;
            // 
            // ptb_sendCount
            // 
            this.ptb_sendCount.BackColor = System.Drawing.SystemColors.Control;
            this.ptb_sendCount.Image = global::Communication_System.Properties.Resources.转换_左右_L;
            this.ptb_sendCount.Location = new System.Drawing.Point(8, 49);
            this.ptb_sendCount.Margin = new System.Windows.Forms.Padding(8);
            this.ptb_sendCount.Name = "ptb_sendCount";
            this.ptb_sendCount.Size = new System.Drawing.Size(112, 44);
            this.ptb_sendCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_sendCount.TabIndex = 14;
            this.ptb_sendCount.TabStop = false;
            // 
            // uPipeVertical2
            // 
            this.uPipeVertical2.Active = false;
            this.uPipeVertical2.BackColor = System.Drawing.Color.Transparent;
            this.uPipeVertical2.Location = new System.Drawing.Point(136, 61);
            this.uPipeVertical2.Margin = new System.Windows.Forms.Padding(8);
            this.uPipeVertical2.Name = "uPipeVertical2";
            this.uPipeVertical2.Size = new System.Drawing.Size(10, 107);
            this.uPipeVertical2.TabIndex = 3;
            this.uPipeVertical2.Text = "uPipeVertical2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.pictureBox2.Image = global::Communication_System.Properties.Resources.感叹号中;
            this.pictureBox2.Location = new System.Drawing.Point(8, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_Send
            // 
            this.panel_Send.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Send.Controls.Add(this.pictureBox12);
            this.panel_Send.Controls.Add(this.pictureBox11);
            this.panel_Send.Controls.Add(this.btn_SendClear);
            this.panel_Send.Controls.Add(this.btn_Send);
            this.panel_Send.Controls.Add(this.txt_SendBox);
            this.panel_Send.Controls.Add(this.cbo_SendContent);
            this.panel_Send.Controls.Add(this.label3);
            this.panel_Send.Controls.Add(this.pictureBox10);
            this.panel_Send.Controls.Add(this.pictureBox3);
            this.panel_Send.GroupTitle = "      数据发送";
            this.panel_Send.Location = new System.Drawing.Point(21, 339);
            this.panel_Send.Name = "panel_Send";
            this.panel_Send.Size = new System.Drawing.Size(432, 238);
            this.panel_Send.TabIndex = 2;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.pictureBox12.Image = global::Communication_System.Properties.Resources.发送;
            this.pictureBox12.Location = new System.Drawing.Point(66, 190);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 29);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox11.Image = global::Communication_System.Properties.Resources.扫把;
            this.pictureBox11.Location = new System.Drawing.Point(245, 187);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // btn_SendClear
            // 
            this.btn_SendClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SendClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_SendClear.Location = new System.Drawing.Point(224, 177);
            this.btn_SendClear.Margin = new System.Windows.Forms.Padding(8);
            this.btn_SendClear.Name = "btn_SendClear";
            this.btn_SendClear.Size = new System.Drawing.Size(151, 49);
            this.btn_SendClear.TabIndex = 8;
            this.btn_SendClear.Text = "    清 空";
            this.btn_SendClear.UseVisualStyleBackColor = false;
            this.btn_SendClear.Click += new System.EventHandler(this.btn_SendClear_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Send.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Send.Location = new System.Drawing.Point(44, 181);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(151, 49);
            this.btn_Send.TabIndex = 11;
            this.btn_Send.Text = "    发 送";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_SendBox
            // 
            this.txt_SendBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SendBox.Location = new System.Drawing.Point(27, 107);
            this.txt_SendBox.Margin = new System.Windows.Forms.Padding(8);
            this.txt_SendBox.Name = "txt_SendBox";
            this.txt_SendBox.Size = new System.Drawing.Size(370, 69);
            this.txt_SendBox.TabIndex = 8;
            this.txt_SendBox.Text = "";
            // 
            // cbo_SendContent
            // 
            this.cbo_SendContent.FormattingEnabled = true;
            this.cbo_SendContent.Location = new System.Drawing.Point(224, 60);
            this.cbo_SendContent.Margin = new System.Windows.Forms.Padding(8);
            this.cbo_SendContent.Name = "cbo_SendContent";
            this.cbo_SendContent.Size = new System.Drawing.Size(173, 39);
            this.cbo_SendContent.TabIndex = 7;
            this.cbo_SendContent.SelectedIndexChanged += new System.EventHandler(this.cbo_SendContent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(107, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "发送内容：";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Image = global::Communication_System.Properties.Resources.file_text_fill;
            this.pictureBox10.Location = new System.Drawing.Point(27, 49);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(74, 55);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.pictureBox3.Image = global::Communication_System.Properties.Resources.端口;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel_ConnectSet
            // 
            this.panel_ConnectSet.BackColor = System.Drawing.SystemColors.Control;
            this.panel_ConnectSet.Controls.Add(this.ptb_disconnect);
            this.panel_ConnectSet.Controls.Add(this.ptb_Connect);
            this.panel_ConnectSet.Controls.Add(this.btn_Disconnect);
            this.panel_ConnectSet.Controls.Add(this.btn_Connect);
            this.panel_ConnectSet.Controls.Add(this.txt_Port);
            this.panel_ConnectSet.Controls.Add(this.txt_IP);
            this.panel_ConnectSet.Controls.Add(this.label2);
            this.panel_ConnectSet.Controls.Add(this.label1);
            this.panel_ConnectSet.Controls.Add(this.pictureBox8);
            this.panel_ConnectSet.Controls.Add(this.pictureBox7);
            this.panel_ConnectSet.Controls.Add(this.pictureBox6);
            this.panel_ConnectSet.GroupTitle = "      连接设置";
            this.panel_ConnectSet.Location = new System.Drawing.Point(22, 87);
            this.panel_ConnectSet.Name = "panel_ConnectSet";
            this.panel_ConnectSet.Size = new System.Drawing.Size(432, 238);
            this.panel_ConnectSet.TabIndex = 1;
            // 
            // ptb_disconnect
            // 
            this.ptb_disconnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptb_disconnect.Image = global::Communication_System.Properties.Resources.正方形;
            this.ptb_disconnect.Location = new System.Drawing.Point(244, 192);
            this.ptb_disconnect.Margin = new System.Windows.Forms.Padding(8);
            this.ptb_disconnect.Name = "ptb_disconnect";
            this.ptb_disconnect.Size = new System.Drawing.Size(35, 29);
            this.ptb_disconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_disconnect.TabIndex = 10;
            this.ptb_disconnect.TabStop = false;
            // 
            // ptb_Connect
            // 
            this.ptb_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.ptb_Connect.Image = global::Communication_System.Properties.Resources.向右三角形;
            this.ptb_Connect.Location = new System.Drawing.Point(65, 188);
            this.ptb_Connect.Margin = new System.Windows.Forms.Padding(8);
            this.ptb_Connect.Name = "ptb_Connect";
            this.ptb_Connect.Size = new System.Drawing.Size(35, 33);
            this.ptb_Connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Connect.TabIndex = 9;
            this.ptb_Connect.TabStop = false;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Disconnect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Disconnect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Disconnect.Location = new System.Drawing.Point(223, 183);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(151, 49);
            this.btn_Disconnect.TabIndex = 8;
            this.btn_Disconnect.Text = "    断 开";
            this.btn_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Connect.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Connect.Location = new System.Drawing.Point(46, 183);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(151, 49);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "    连 接";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.tcpConnect_Clik);
            // 
            // txt_Port
            // 
            this.txt_Port.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Port.Location = new System.Drawing.Point(197, 126);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(8);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(199, 35);
            this.txt_Port.TabIndex = 6;
            // 
            // txt_IP
            // 
            this.txt_IP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_IP.Location = new System.Drawing.Point(197, 54);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(8);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(199, 35);
            this.txt_IP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(106, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "端口号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(106, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "目标IP:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Communication_System.Properties.Resources.端口__1_;
            this.pictureBox8.Location = new System.Drawing.Point(26, 117);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(74, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Communication_System.Properties.Resources.电脑;
            this.pictureBox7.Location = new System.Drawing.Point(26, 51);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(74, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.pictureBox6.Image = global::Communication_System.Properties.Resources.齿轮;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // titleBar1
            // 
            this.titleBar1.Controls.Add(this.btn_Close);
            this.titleBar1.Controls.Add(this.btn_Max);
            this.titleBar1.Controls.Add(this.btn_Min);
            this.titleBar1.Controls.Add(this.pictureBox1);
            this.titleBar1.Icon = null;
            this.titleBar1.Location = new System.Drawing.Point(-3, 1);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1244, 67);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.TitleText = "TCP 网络通讯测试工具";
            this.titleBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar1_MouseDown);
            this.titleBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar1_MouseMove);
            this.titleBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar1_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.btn_Close.Image = global::Communication_System.Properties.Resources.关闭;
            this.btn_Close.Location = new System.Drawing.Point(1174, 16);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(62, 33);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 13;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.btn_Max.Image = global::Communication_System.Properties.Resources._24gl_square__1_;
            this.btn_Max.Location = new System.Drawing.Point(1104, 16);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(62, 33);
            this.btn_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Max.TabIndex = 13;
            this.btn_Max.TabStop = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.btn_Min.Image = global::Communication_System.Properties.Resources.缩小;
            this.btn_Min.Location = new System.Drawing.Point(1025, 16);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(8);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(62, 33);
            this.btn_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Min.TabIndex = 12;
            this.btn_Min.TabStop = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(98)))), ((int)(((byte)(170)))));
            this.pictureBox1.Image = global::Communication_System.Properties.Resources.端口连接__1_;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 849);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_Log);
            this.Controls.Add(this.panel_Stat);
            this.Controls.Add(this.panel_Send);
            this.Controls.Add(this.panel_ConnectSet);
            this.Controls.Add(this.titleBar1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_Log.ResumeLayout(false);
            this.panel_Log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel_Stat.ResumeLayout(false);
            this.panel_Stat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_receiveNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_RunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_Send.ResumeLayout(false);
            this.panel_Send.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_ConnectSet.ResumeLayout(false);
            this.panel_ConnectSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_disconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.titleBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlTool.TitleBar titleBar1;
        private ControlTool.UGroupPanel panel_ConnectSet;
        private ControlTool.UGroupPanel panel_Send;
        private ControlTool.UGroupPanel panel_Stat;
        private ControlTool.UGroupPanel panel_Log;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_Connect;
        private System.Windows.Forms.PictureBox ptb_disconnect;
        private System.Windows.Forms.ComboBox cbo_SendContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.RichTextBox txt_SendBox;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button btn_SendClear;
        private ControlTool.UPipeVertical uPipeVertical2;
        private ControlTool.UPipeVertical uPipeVertical1;
        private System.Windows.Forms.PictureBox ptb_sendCount;
        private System.Windows.Forms.TextBox lbl_SendCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptb_receiveNumber;
        private System.Windows.Forms.PictureBox ptb_RunTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbl_RecvCount;
        private System.Windows.Forms.Label lbl_CommTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerRunTime;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Button btn_ClearLog;
        private System.Windows.Forms.CheckBox chk_AutoScroll;
        private System.Windows.Forms.PictureBox btn_Min;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Max;
        private System.Windows.Forms.ToolStripStatusLabel tslLight;
        private System.Windows.Forms.ToolStripStatusLabel tsl_ConnState;
        private System.Windows.Forms.ToolStripStatusLabel tsl_Spring;
        private System.Windows.Forms.ToolStripStatusLabel tsl_Ready;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

