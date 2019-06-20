namespace Server
{
    partial class MainServer
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
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSetting = new System.Windows.Forms.TextBox();
            this.btnSetSave = new CCWin.SkinControl.SkinButtom();
            this.btnSetClear = new CCWin.SkinControl.SkinButtom();
            this.btnSerClose = new CCWin.SkinControl.SkinButtom();
            this.btnSerStar = new CCWin.SkinControl.SkinButtom();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSerMax = new System.Windows.Forms.ComboBox();
            this.txtOnlineCount = new System.Windows.Forms.TextBox();
            this.txtSerPort = new System.Windows.Forms.TextBox();
            this.txtSerIP = new System.Windows.Forms.TextBox();
            this.txtSerState = new System.Windows.Forms.TextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listChat = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearch = new CCWin.SkinControl.SkinButtom();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSetIP = new System.Windows.Forms.TextBox();
            this.btnsearchByIp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.BaseColor = System.Drawing.Color.Yellow;
            this.skinTabControl1.BorderColor = System.Drawing.Color.Orange;
            this.skinTabControl1.Controls.Add(this.tabPage1);
            this.skinTabControl1.Controls.Add(this.tabPage2);
            this.skinTabControl1.Controls.Add(this.tabPage3);
            this.skinTabControl1.Controls.Add(this.tabPage4);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(-1, -1);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageColor = System.Drawing.Color.LightBlue;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(686, 436);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnSetSave);
            this.tabPage1.Controls.Add(this.btnSetClear);
            this.tabPage1.Controls.Add(this.btnSerClose);
            this.tabPage1.Controls.Add(this.btnSerStar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "运行管理";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSetting);
            this.groupBox2.Location = new System.Drawing.Point(207, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务器日志";
            // 
            // txtSetting
            // 
            this.txtSetting.BackColor = System.Drawing.Color.SkyBlue;
            this.txtSetting.Location = new System.Drawing.Point(6, 20);
            this.txtSetting.Multiline = true;
            this.txtSetting.Name = "txtSetting";
            this.txtSetting.Size = new System.Drawing.Size(459, 304);
            this.txtSetting.TabIndex = 0;
            // 
            // btnSetSave
            // 
            this.btnSetSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSetSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetSave.DownBack = null;
            this.btnSetSave.Location = new System.Drawing.Point(467, 342);
            this.btnSetSave.MouseBack = null;
            this.btnSetSave.Name = "btnSetSave";
            this.btnSetSave.NormlBack = null;
            this.btnSetSave.Size = new System.Drawing.Size(75, 23);
            this.btnSetSave.TabIndex = 1;
            this.btnSetSave.Text = "保存日志";
            this.btnSetSave.UseVisualStyleBackColor = false;
            this.btnSetSave.Click += new System.EventHandler(this.btnSetSave_Click);
            // 
            // btnSetClear
            // 
            this.btnSetClear.BackColor = System.Drawing.Color.Transparent;
            this.btnSetClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetClear.DownBack = null;
            this.btnSetClear.Location = new System.Drawing.Point(299, 342);
            this.btnSetClear.MouseBack = null;
            this.btnSetClear.Name = "btnSetClear";
            this.btnSetClear.NormlBack = null;
            this.btnSetClear.Size = new System.Drawing.Size(75, 23);
            this.btnSetClear.TabIndex = 1;
            this.btnSetClear.Text = "清屏";
            this.btnSetClear.UseVisualStyleBackColor = false;
            this.btnSetClear.Click += new System.EventHandler(this.btnSetClear_Click);
            // 
            // btnSerClose
            // 
            this.btnSerClose.BackColor = System.Drawing.Color.Transparent;
            this.btnSerClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSerClose.DownBack = null;
            this.btnSerClose.Location = new System.Drawing.Point(126, 342);
            this.btnSerClose.MouseBack = null;
            this.btnSerClose.Name = "btnSerClose";
            this.btnSerClose.NormlBack = null;
            this.btnSerClose.Size = new System.Drawing.Size(75, 23);
            this.btnSerClose.TabIndex = 1;
            this.btnSerClose.Text = "关闭服务器";
            this.btnSerClose.UseVisualStyleBackColor = false;
            this.btnSerClose.Click += new System.EventHandler(this.btnSerClose_Click);
            // 
            // btnSerStar
            // 
            this.btnSerStar.BackColor = System.Drawing.Color.Transparent;
            this.btnSerStar.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSerStar.DownBack = null;
            this.btnSerStar.Location = new System.Drawing.Point(9, 342);
            this.btnSerStar.MouseBack = null;
            this.btnSerStar.Name = "btnSerStar";
            this.btnSerStar.NormlBack = null;
            this.btnSerStar.Size = new System.Drawing.Size(75, 23);
            this.btnSerStar.TabIndex = 1;
            this.btnSerStar.Text = "开启服务器";
            this.btnSerStar.UseVisualStyleBackColor = false;
            this.btnSerStar.Click += new System.EventHandler(this.btnSerStar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSerMax);
            this.groupBox1.Controls.Add(this.txtOnlineCount);
            this.groupBox1.Controls.Add(this.txtSerPort);
            this.groupBox1.Controls.Add(this.txtSerIP);
            this.groupBox1.Controls.Add(this.txtSerState);
            this.groupBox1.Controls.Add(this.skinLabel5);
            this.groupBox1.Controls.Add(this.skinLabel4);
            this.groupBox1.Controls.Add(this.skinLabel3);
            this.groupBox1.Controls.Add(this.skinLabel2);
            this.groupBox1.Controls.Add(this.skinLabel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器信息";
            // 
            // cmbSerMax
            // 
            this.cmbSerMax.FormattingEnabled = true;
            this.cmbSerMax.Items.AddRange(new object[] {
            "40",
            "30",
            "20",
            "10"});
            this.cmbSerMax.Location = new System.Drawing.Point(18, 289);
            this.cmbSerMax.Name = "cmbSerMax";
            this.cmbSerMax.Size = new System.Drawing.Size(100, 20);
            this.cmbSerMax.TabIndex = 2;
            this.cmbSerMax.Text = "40";
            // 
            // txtOnlineCount
            // 
            this.txtOnlineCount.Location = new System.Drawing.Point(18, 225);
            this.txtOnlineCount.Name = "txtOnlineCount";
            this.txtOnlineCount.Size = new System.Drawing.Size(100, 21);
            this.txtOnlineCount.TabIndex = 1;
            this.txtOnlineCount.Text = "0";
            // 
            // txtSerPort
            // 
            this.txtSerPort.Location = new System.Drawing.Point(18, 164);
            this.txtSerPort.Name = "txtSerPort";
            this.txtSerPort.Size = new System.Drawing.Size(100, 21);
            this.txtSerPort.TabIndex = 1;
            this.txtSerPort.Text = "51111";
            // 
            // txtSerIP
            // 
            this.txtSerIP.Location = new System.Drawing.Point(18, 102);
            this.txtSerIP.Name = "txtSerIP";
            this.txtSerIP.Size = new System.Drawing.Size(100, 21);
            this.txtSerIP.TabIndex = 1;
            this.txtSerIP.Text = "121.42.36.149";
            // 
            // txtSerState
            // 
            this.txtSerState.Location = new System.Drawing.Point(18, 51);
            this.txtSerState.Name = "txtSerState";
            this.txtSerState.Size = new System.Drawing.Size(100, 21);
            this.txtSerState.TabIndex = 1;
            this.txtSerState.Text = "关闭";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(16, 268);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "系统负荷：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(15, 205);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(68, 17);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "在线人数：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(15, 144);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "端口：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(16, 82);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(67, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "服务器IP：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(16, 31);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "服务器状态：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.listChat);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "在线管理";
            // 
            // listChat
            // 
            this.listChat.BackColor = System.Drawing.Color.SkyBlue;
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 12;
            this.listChat.Location = new System.Drawing.Point(9, 14);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(661, 376);
            this.listChat.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.dataUsers);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(678, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "数据管理";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearch.DownBack = null;
            this.btnSearch.Location = new System.Drawing.Point(552, 35);
            this.btnSearch.MouseBack = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormlBack = null;
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "显示用户数据";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataUsers
            // 
            this.dataUsers.AllowUserToAddRows = false;
            this.dataUsers.AllowUserToDeleteRows = false;
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Location = new System.Drawing.Point(0, 64);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.ReadOnly = true;
            this.dataUsers.RowTemplate.Height = 23;
            this.dataUsers.Size = new System.Drawing.Size(675, 262);
            this.dataUsers.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.txtSetIP);
            this.tabPage4.Controls.Add(this.btnsearchByIp);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(678, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "数据查询";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(672, 62);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtSetIP
            // 
            this.txtSetIP.Location = new System.Drawing.Point(303, 35);
            this.txtSetIP.Name = "txtSetIP";
            this.txtSetIP.Size = new System.Drawing.Size(164, 21);
            this.txtSetIP.TabIndex = 1;
            // 
            // btnsearchByIp
            // 
            this.btnsearchByIp.Location = new System.Drawing.Point(473, 34);
            this.btnsearchByIp.Name = "btnsearchByIp";
            this.btnsearchByIp.Size = new System.Drawing.Size(125, 23);
            this.btnsearchByIp.TabIndex = 0;
            this.btnsearchByIp.Text = "输入要查询者的IP";
            this.btnsearchByIp.UseVisualStyleBackColor = true;
            this.btnsearchByIp.Click += new System.EventHandler(this.btnsearchByIp_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 434);
            this.Controls.Add(this.skinTabControl1);
            this.Name = "MainServer";
            this.Text = "MainServer";
            this.Load += new System.EventHandler(this.MainServer_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.TextBox txtOnlineCount;
        private System.Windows.Forms.TextBox txtSerPort;
        private System.Windows.Forms.TextBox txtSerIP;
        private System.Windows.Forms.TextBox txtSerState;
        private CCWin.SkinControl.SkinButtom btnSetSave;
        private CCWin.SkinControl.SkinButtom btnSetClear;
        private CCWin.SkinControl.SkinButtom btnSerClose;
        private CCWin.SkinControl.SkinButtom btnSerStar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSetting;
        private System.Windows.Forms.ComboBox cmbSerMax;
        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.DataGridView dataUsers;
        private CCWin.SkinControl.SkinButtom btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSetIP;
        private System.Windows.Forms.Button btnsearchByIp;
        private System.Windows.Forms.Timer timer1;
    }
}