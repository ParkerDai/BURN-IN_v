namespace WindowsFormsApplication1
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDevCnt = new System.Windows.Forms.TextBox();
            this.lstDev = new System.Windows.Forms.ListBox();
            this.cmdInvite = new System.Windows.Forms.Button();
            this.cmdLocate = new System.Windows.Forms.Button();
            this.locateTmr = new System.Windows.Forms.Timer(this.components);
            this.cmdChangIP1 = new System.Windows.Forms.Button();
            this.txtDevSetCnt1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chktargetAP = new System.Windows.Forms.CheckBox();
            this.txtTargetAP = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chktargetKer = new System.Windows.Forms.CheckBox();
            this.txtTargetKer = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chktargetIP = new System.Windows.Forms.CheckBox();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chktargetModel = new System.Windows.Forms.CheckBox();
            this.txtTargetModel = new System.Windows.Forms.TextBox();
            this.cmbCanPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDefaultIP = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmbMaxPort = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定 = new System.Windows.Forms.ToolStripMenuItem();
            this.內網環境建置 = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視 = new System.Windows.Forms.ToolStripMenuItem();
            this.支援 = new System.Windows.Forms.ToolStripMenuItem();
            this.inviteTmr = new System.Windows.Forms.Timer(this.components);
            this.cmdCrosstest = new System.Windows.Forms.Button();
            this.cmdComtest = new System.Windows.Forms.Button();
            this.cmdCallFTP = new System.Windows.Forms.Button();
            this.txtDevSetCnt2 = new System.Windows.Forms.TextBox();
            this.cmdChangIP2 = new System.Windows.Forms.Button();
            this.cmdDefaultIP = new System.Windows.Forms.Button();
            this.txtDevDefCnt = new System.Windows.Forms.TextBox();
            this.cmdCanCross = new System.Windows.Forms.Button();
            this.cmdCloseIn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDevCnt
            // 
            this.txtDevCnt.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDevCnt.Location = new System.Drawing.Point(89, 144);
            this.txtDevCnt.Name = "txtDevCnt";
            this.txtDevCnt.Size = new System.Drawing.Size(39, 22);
            this.txtDevCnt.TabIndex = 5;
            this.txtDevCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstDev
            // 
            this.lstDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstDev.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDev.FormattingEnabled = true;
            this.lstDev.HorizontalExtent = 1500;
            this.lstDev.HorizontalScrollbar = true;
            this.lstDev.ItemHeight = 16;
            this.lstDev.Location = new System.Drawing.Point(134, 138);
            this.lstDev.Name = "lstDev";
            this.lstDev.Size = new System.Drawing.Size(669, 500);
            this.lstDev.Sorted = true;
            this.lstDev.TabIndex = 4;
            this.lstDev.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDev_MouseClick);
            // 
            // cmdInvite
            // 
            this.cmdInvite.BackColor = System.Drawing.SystemColors.Control;
            this.cmdInvite.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdInvite.Location = new System.Drawing.Point(8, 138);
            this.cmdInvite.Name = "cmdInvite";
            this.cmdInvite.Size = new System.Drawing.Size(75, 30);
            this.cmdInvite.TabIndex = 3;
            this.cmdInvite.Text = "&Invite";
            this.cmdInvite.UseVisualStyleBackColor = true;
            this.cmdInvite.Click += new System.EventHandler(this.cmdInvite_Click);
            // 
            // cmdLocate
            // 
            this.cmdLocate.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLocate.Enabled = false;
            this.cmdLocate.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdLocate.Location = new System.Drawing.Point(8, 210);
            this.cmdLocate.Name = "cmdLocate";
            this.cmdLocate.Size = new System.Drawing.Size(75, 30);
            this.cmdLocate.TabIndex = 6;
            this.cmdLocate.Text = "Locate";
            this.cmdLocate.UseVisualStyleBackColor = true;
            this.cmdLocate.Click += new System.EventHandler(this.cmdLocate_Click);
            // 
            // locateTmr
            // 
            this.locateTmr.Tick += new System.EventHandler(this.locateTmr_Tick);
            // 
            // cmdChangIP1
            // 
            this.cmdChangIP1.BackColor = System.Drawing.SystemColors.Control;
            this.cmdChangIP1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdChangIP1.Location = new System.Drawing.Point(8, 246);
            this.cmdChangIP1.Name = "cmdChangIP1";
            this.cmdChangIP1.Size = new System.Drawing.Size(75, 30);
            this.cmdChangIP1.TabIndex = 7;
            this.cmdChangIP1.Text = "Chang IP 1";
            this.cmdChangIP1.UseVisualStyleBackColor = true;
            this.cmdChangIP1.Click += new System.EventHandler(this.cmdChangIP1_Click);
            // 
            // txtDevSetCnt1
            // 
            this.txtDevSetCnt1.Location = new System.Drawing.Point(89, 252);
            this.txtDevSetCnt1.Name = "txtDevSetCnt1";
            this.txtDevSetCnt1.Size = new System.Drawing.Size(39, 22);
            this.txtDevSetCnt1.TabIndex = 8;
            this.txtDevSetCnt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbCanPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDefaultIP);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.cmbMaxPort);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(219, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 86);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chktargetAP);
            this.groupBox8.Controls.Add(this.txtTargetAP);
            this.groupBox8.Location = new System.Drawing.Point(430, 21);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(136, 61);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "AP version";
            // 
            // chktargetAP
            // 
            this.chktargetAP.AutoSize = true;
            this.chktargetAP.Location = new System.Drawing.Point(6, 42);
            this.chktargetAP.Name = "chktargetAP";
            this.chktargetAP.Size = new System.Drawing.Size(55, 16);
            this.chktargetAP.TabIndex = 6;
            this.chktargetAP.Text = "Assign";
            this.chktargetAP.UseVisualStyleBackColor = true;
            // 
            // txtTargetAP
            // 
            this.txtTargetAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTargetAP.Location = new System.Drawing.Point(6, 14);
            this.txtTargetAP.MaxLength = 20;
            this.txtTargetAP.Name = "txtTargetAP";
            this.txtTargetAP.Size = new System.Drawing.Size(125, 22);
            this.txtTargetAP.TabIndex = 5;
            this.txtTargetAP.Leave += new System.EventHandler(this.txtTargetAP_Leave);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chktargetKer);
            this.groupBox7.Controls.Add(this.txtTargetKer);
            this.groupBox7.Location = new System.Drawing.Point(288, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(136, 61);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kernel version";
            // 
            // chktargetKer
            // 
            this.chktargetKer.AutoSize = true;
            this.chktargetKer.Location = new System.Drawing.Point(6, 42);
            this.chktargetKer.Name = "chktargetKer";
            this.chktargetKer.Size = new System.Drawing.Size(55, 16);
            this.chktargetKer.TabIndex = 6;
            this.chktargetKer.Text = "Assign";
            this.chktargetKer.UseVisualStyleBackColor = true;
            // 
            // txtTargetKer
            // 
            this.txtTargetKer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTargetKer.Location = new System.Drawing.Point(6, 14);
            this.txtTargetKer.MaxLength = 20;
            this.txtTargetKer.Name = "txtTargetKer";
            this.txtTargetKer.Size = new System.Drawing.Size(125, 22);
            this.txtTargetKer.TabIndex = 5;
            this.txtTargetKer.Leave += new System.EventHandler(this.txtTargetKer_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chktargetIP);
            this.groupBox6.Controls.Add(this.txtTargetIP);
            this.groupBox6.Location = new System.Drawing.Point(148, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(134, 61);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "IP / 網段";
            this.toolTip1.SetToolTip(this.groupBox6, "ex: 10.0.50.100 / 10.0");
            // 
            // chktargetIP
            // 
            this.chktargetIP.AutoSize = true;
            this.chktargetIP.Location = new System.Drawing.Point(6, 42);
            this.chktargetIP.Name = "chktargetIP";
            this.chktargetIP.Size = new System.Drawing.Size(55, 16);
            this.chktargetIP.TabIndex = 6;
            this.chktargetIP.Text = "Assign";
            this.chktargetIP.UseVisualStyleBackColor = true;
            this.chktargetIP.Click += new System.EventHandler(this.chktargetIP_Click);
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTargetIP.Location = new System.Drawing.Point(6, 14);
            this.txtTargetIP.MaxLength = 15;
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(125, 22);
            this.txtTargetIP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtTargetIP, "ex: 10.0.50.100 / 10.0");
            this.txtTargetIP.Leave += new System.EventHandler(this.txtTargetIP_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chktargetModel);
            this.groupBox3.Controls.Add(this.txtTargetModel);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 61);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model name";
            // 
            // chktargetModel
            // 
            this.chktargetModel.AutoSize = true;
            this.chktargetModel.Location = new System.Drawing.Point(6, 42);
            this.chktargetModel.Name = "chktargetModel";
            this.chktargetModel.Size = new System.Drawing.Size(55, 16);
            this.chktargetModel.TabIndex = 6;
            this.chktargetModel.Text = "Assign";
            this.chktargetModel.UseVisualStyleBackColor = true;
            this.chktargetModel.Click += new System.EventHandler(this.chktargetModel_Click);
            // 
            // txtTargetModel
            // 
            this.txtTargetModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTargetModel.Location = new System.Drawing.Point(6, 14);
            this.txtTargetModel.MaxLength = 20;
            this.txtTargetModel.Name = "txtTargetModel";
            this.txtTargetModel.Size = new System.Drawing.Size(125, 22);
            this.txtTargetModel.TabIndex = 5;
            this.txtTargetModel.Leave += new System.EventHandler(this.txtTargetModel_Leave);
            // 
            // cmbCanPort
            // 
            this.cmbCanPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCanPort.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCanPort.FormattingEnabled = true;
            this.cmbCanPort.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cmbCanPort.Location = new System.Drawing.Point(101, 45);
            this.cmbCanPort.Name = "cmbCanPort";
            this.cmbCanPort.Size = new System.Drawing.Size(58, 21);
            this.cmbCanPort.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 108;
            this.label3.Text = "Can Port 個數:";
            // 
            // txtDefaultIP
            // 
            this.txtDefaultIP.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDefaultIP.Location = new System.Drawing.Point(100, 71);
            this.txtDefaultIP.MaxLength = 15;
            this.txtDefaultIP.Name = "txtDefaultIP";
            this.txtDefaultIP.Size = new System.Drawing.Size(125, 23);
            this.txtDefaultIP.TabIndex = 107;
            this.txtDefaultIP.Text = "10.0.50.100";
            this.txtDefaultIP.Visible = false;
            this.txtDefaultIP.Leave += new System.EventHandler(this.txtDefaultIP_Leave);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(8, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 12);
            this.Label2.TabIndex = 106;
            this.Label2.Text = "Default IP (lan1):";
            this.Label2.Visible = false;
            // 
            // cmbMaxPort
            // 
            this.cmbMaxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxPort.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaxPort.FormattingEnabled = true;
            this.cmbMaxPort.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "24",
            "32"});
            this.cmbMaxPort.Location = new System.Drawing.Point(101, 15);
            this.cmbMaxPort.Name = "cmbMaxPort";
            this.cmbMaxPort.Size = new System.Drawing.Size(58, 21);
            this.cmbMaxPort.TabIndex = 105;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(15, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 12);
            this.Label1.TabIndex = 104;
            this.Label1.Text = "Com Port 個數:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定,
            this.檢視,
            this.支援});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定
            // 
            this.設定.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內網環境建置});
            this.設定.Name = "設定";
            this.設定.Size = new System.Drawing.Size(43, 20);
            this.設定.Text = "設定";
            // 
            // 內網環境建置
            // 
            this.內網環境建置.Name = "內網環境建置";
            this.內網環境建置.Size = new System.Drawing.Size(146, 22);
            this.內網環境建置.Text = "內網環境建置";
            this.內網環境建置.Click += new System.EventHandler(this.內網環境建置_Click);
            // 
            // 檢視
            // 
            this.檢視.Name = "檢視";
            this.檢視.Size = new System.Drawing.Size(43, 20);
            this.檢視.Text = "檢視";
            this.檢視.Visible = false;
            // 
            // 支援
            // 
            this.支援.Name = "支援";
            this.支援.Size = new System.Drawing.Size(43, 20);
            this.支援.Text = "支援";
            this.支援.Visible = false;
            // 
            // inviteTmr
            // 
            this.inviteTmr.Interval = 1000;
            this.inviteTmr.Tick += new System.EventHandler(this.inviteTmr_Tick);
            // 
            // cmdCrosstest
            // 
            this.cmdCrosstest.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCrosstest.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdCrosstest.Location = new System.Drawing.Point(8, 426);
            this.cmdCrosstest.Name = "cmdCrosstest";
            this.cmdCrosstest.Size = new System.Drawing.Size(120, 30);
            this.cmdCrosstest.TabIndex = 13;
            this.cmdCrosstest.Text = "Cross Loopback";
            this.cmdCrosstest.UseVisualStyleBackColor = true;
            this.cmdCrosstest.Click += new System.EventHandler(this.cmdCrosstest_Click);
            // 
            // cmdComtest
            // 
            this.cmdComtest.BackColor = System.Drawing.SystemColors.Control;
            this.cmdComtest.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdComtest.Location = new System.Drawing.Point(8, 390);
            this.cmdComtest.Name = "cmdComtest";
            this.cmdComtest.Size = new System.Drawing.Size(120, 30);
            this.cmdComtest.TabIndex = 14;
            this.cmdComtest.Text = "Com Loopback";
            this.cmdComtest.UseVisualStyleBackColor = true;
            this.cmdComtest.Click += new System.EventHandler(this.cmdComtest_Click);
            // 
            // cmdCallFTP
            // 
            this.cmdCallFTP.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCallFTP.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdCallFTP.Location = new System.Drawing.Point(8, 354);
            this.cmdCallFTP.Name = "cmdCallFTP";
            this.cmdCallFTP.Size = new System.Drawing.Size(120, 30);
            this.cmdCallFTP.TabIndex = 15;
            this.cmdCallFTP.Text = "FTP tool";
            this.cmdCallFTP.UseVisualStyleBackColor = true;
            this.cmdCallFTP.Click += new System.EventHandler(this.cmdCallFTP_Click);
            // 
            // txtDevSetCnt2
            // 
            this.txtDevSetCnt2.Location = new System.Drawing.Point(89, 288);
            this.txtDevSetCnt2.Name = "txtDevSetCnt2";
            this.txtDevSetCnt2.Size = new System.Drawing.Size(39, 22);
            this.txtDevSetCnt2.TabIndex = 17;
            this.txtDevSetCnt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdChangIP2
            // 
            this.cmdChangIP2.BackColor = System.Drawing.SystemColors.Control;
            this.cmdChangIP2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdChangIP2.Location = new System.Drawing.Point(8, 282);
            this.cmdChangIP2.Name = "cmdChangIP2";
            this.cmdChangIP2.Size = new System.Drawing.Size(75, 30);
            this.cmdChangIP2.TabIndex = 16;
            this.cmdChangIP2.Text = "Chang IP 2";
            this.cmdChangIP2.UseVisualStyleBackColor = true;
            this.cmdChangIP2.Click += new System.EventHandler(this.cmdChangIP2_Click);
            // 
            // cmdDefaultIP
            // 
            this.cmdDefaultIP.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDefaultIP.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdDefaultIP.Location = new System.Drawing.Point(8, 318);
            this.cmdDefaultIP.Name = "cmdDefaultIP";
            this.cmdDefaultIP.Size = new System.Drawing.Size(75, 30);
            this.cmdDefaultIP.TabIndex = 18;
            this.cmdDefaultIP.Text = "Default IP";
            this.cmdDefaultIP.UseVisualStyleBackColor = true;
            this.cmdDefaultIP.Visible = false;
            this.cmdDefaultIP.Click += new System.EventHandler(this.cmdDefaultIP_Click);
            // 
            // txtDevDefCnt
            // 
            this.txtDevDefCnt.Location = new System.Drawing.Point(89, 324);
            this.txtDevDefCnt.Name = "txtDevDefCnt";
            this.txtDevDefCnt.Size = new System.Drawing.Size(39, 22);
            this.txtDevDefCnt.TabIndex = 19;
            this.txtDevDefCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDevDefCnt.Visible = false;
            // 
            // cmdCanCross
            // 
            this.cmdCanCross.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCanCross.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdCanCross.Location = new System.Drawing.Point(8, 462);
            this.cmdCanCross.Name = "cmdCanCross";
            this.cmdCanCross.Size = new System.Drawing.Size(120, 30);
            this.cmdCanCross.TabIndex = 20;
            this.cmdCanCross.Text = "Can-bus cross";
            this.cmdCanCross.UseVisualStyleBackColor = true;
            this.cmdCanCross.Click += new System.EventHandler(this.cmdCanCross_Click);
            // 
            // cmdCloseIn
            // 
            this.cmdCloseIn.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCloseIn.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmdCloseIn.Location = new System.Drawing.Point(8, 174);
            this.cmdCloseIn.Name = "cmdCloseIn";
            this.cmdCloseIn.Size = new System.Drawing.Size(75, 30);
            this.cmdCloseIn.TabIndex = 21;
            this.cmdCloseIn.Text = "Close invite";
            this.cmdCloseIn.UseVisualStyleBackColor = true;
            this.cmdCloseIn.Click += new System.EventHandler(this.cmdCloseIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 644);
            this.Controls.Add(this.cmdCloseIn);
            this.Controls.Add(this.cmdCanCross);
            this.Controls.Add(this.txtDevDefCnt);
            this.Controls.Add(this.cmdDefaultIP);
            this.Controls.Add(this.txtDevSetCnt2);
            this.Controls.Add(this.cmdChangIP2);
            this.Controls.Add(this.cmdCallFTP);
            this.Controls.Add(this.cmdComtest);
            this.Controls.Add(this.cmdCrosstest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDevSetCnt1);
            this.Controls.Add(this.cmdChangIP1);
            this.Controls.Add(this.cmdLocate);
            this.Controls.Add(this.txtDevCnt);
            this.Controls.Add(this.lstDev);
            this.Controls.Add(this.cmdInvite);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BURN-IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDevCnt;
        private System.Windows.Forms.ListBox lstDev;
        private System.Windows.Forms.Button cmdInvite;
        private System.Windows.Forms.Button cmdLocate;
        private System.Windows.Forms.Timer locateTmr;
        private System.Windows.Forms.Button cmdChangIP1;
        private System.Windows.Forms.TextBox txtDevSetCnt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檢視;
        private System.Windows.Forms.ToolStripMenuItem 設定;
        private System.Windows.Forms.ToolStripMenuItem 支援;
        private System.Windows.Forms.ToolStripMenuItem 內網環境建置;
        private System.Windows.Forms.Timer inviteTmr;
        private System.Windows.Forms.Button cmdCrosstest;
        private System.Windows.Forms.Button cmdComtest;
        private System.Windows.Forms.Button cmdCallFTP;
        internal System.Windows.Forms.ComboBox cmbMaxPort;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDefaultIP;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtDevSetCnt2;
        private System.Windows.Forms.Button cmdChangIP2;
        private System.Windows.Forms.Button cmdDefaultIP;
        private System.Windows.Forms.TextBox txtDevDefCnt;
        private System.Windows.Forms.Button cmdCanCross;
        internal System.Windows.Forms.ComboBox cmbCanPort;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCloseIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chktargetAP;
        private System.Windows.Forms.TextBox txtTargetAP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chktargetKer;
        private System.Windows.Forms.TextBox txtTargetKer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chktargetIP;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chktargetModel;
        private System.Windows.Forms.TextBox txtTargetModel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

