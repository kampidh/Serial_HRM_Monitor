namespace Serial_HRM_Monitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialControlGroup = new System.Windows.Forms.GroupBox();
            this.refreshPortButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PortFlowCtl = new System.Windows.Forms.ComboBox();
            this.PortParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PortStopBits = new System.Windows.Forms.ComboBox();
            this.PortDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBaud = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FileOutputGroup = new System.Windows.Forms.GroupBox();
            this.TextFileSPOisRounded = new System.Windows.Forms.CheckBox();
            this.TextFileBPMisRounded = new System.Windows.Forms.CheckBox();
            this.SPO2FileButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BPMFileButton = new System.Windows.Forms.Button();
            this.SPO2FileText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BPMFileText = new System.Windows.Forms.TextBox();
            this.EnableTextFile = new System.Windows.Forms.CheckBox();
            this.REDtext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IRtext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SPO2text = new System.Windows.Forms.TextBox();
            this.BPMtext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.blipheart = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineThicknessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuThick1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuThick2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuThick3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuThick4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuThick5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.red2ndGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LogFileButton = new System.Windows.Forms.Button();
            this.LogFileText = new System.Windows.Forms.TextBox();
            this.LogIsEnabled = new System.Windows.Forms.CheckBox();
            this.spoMax = new System.Windows.Forms.Label();
            this.bpmMax = new System.Windows.Forms.Label();
            this.spoMin = new System.Windows.Forms.Label();
            this.bpmMin = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.TrimmedDataText = new System.Windows.Forms.Label();
            this.RawDataText = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.graphColorSettingGroup = new System.Windows.Forms.GroupBox();
            this.colorApply = new System.Windows.Forms.Button();
            this.lineColorPick = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.gridColorPick = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bgColorPick = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.licenseButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundDataWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.heartIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameVersionLabel = new System.Windows.Forms.Label();
            this.SerialControlGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FileOutputGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.graphMenuStrip.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.graphColorSettingGroup.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PortList
            // 
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.FormattingEnabled = true;
            this.PortList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PortList.Location = new System.Drawing.Point(6, 38);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(280, 21);
            this.PortList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // SerialControlGroup
            // 
            this.SerialControlGroup.Controls.Add(this.refreshPortButton);
            this.SerialControlGroup.Controls.Add(this.label6);
            this.SerialControlGroup.Controls.Add(this.PortFlowCtl);
            this.SerialControlGroup.Controls.Add(this.label1);
            this.SerialControlGroup.Controls.Add(this.PortParity);
            this.SerialControlGroup.Controls.Add(this.PortList);
            this.SerialControlGroup.Controls.Add(this.label5);
            this.SerialControlGroup.Controls.Add(this.label4);
            this.SerialControlGroup.Controls.Add(this.PortStopBits);
            this.SerialControlGroup.Controls.Add(this.PortDataBits);
            this.SerialControlGroup.Controls.Add(this.label3);
            this.SerialControlGroup.Controls.Add(this.label2);
            this.SerialControlGroup.Controls.Add(this.PortBaud);
            this.SerialControlGroup.Location = new System.Drawing.Point(12, 12);
            this.SerialControlGroup.Name = "SerialControlGroup";
            this.SerialControlGroup.Size = new System.Drawing.Size(292, 209);
            this.SerialControlGroup.TabIndex = 6;
            this.SerialControlGroup.TabStop = false;
            this.SerialControlGroup.Text = "Serial options";
            // 
            // refreshPortButton
            // 
            this.refreshPortButton.Location = new System.Drawing.Point(196, 72);
            this.refreshPortButton.Name = "refreshPortButton";
            this.refreshPortButton.Size = new System.Drawing.Size(90, 31);
            this.refreshPortButton.TabIndex = 10;
            this.refreshPortButton.Text = "Refresh list";
            this.refreshPortButton.UseVisualStyleBackColor = true;
            this.refreshPortButton.Click += new System.EventHandler(this.refreshPortButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Flow control";
            // 
            // PortFlowCtl
            // 
            this.PortFlowCtl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortFlowCtl.FormattingEnabled = true;
            this.PortFlowCtl.Location = new System.Drawing.Point(80, 180);
            this.PortFlowCtl.Name = "PortFlowCtl";
            this.PortFlowCtl.Size = new System.Drawing.Size(100, 21);
            this.PortFlowCtl.TabIndex = 8;
            // 
            // PortParity
            // 
            this.PortParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortParity.FormattingEnabled = true;
            this.PortParity.Location = new System.Drawing.Point(80, 153);
            this.PortParity.Name = "PortParity";
            this.PortParity.Size = new System.Drawing.Size(100, 21);
            this.PortParity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop bits";
            // 
            // PortStopBits
            // 
            this.PortStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortStopBits.FormattingEnabled = true;
            this.PortStopBits.Location = new System.Drawing.Point(80, 126);
            this.PortStopBits.Name = "PortStopBits";
            this.PortStopBits.Size = new System.Drawing.Size(100, 21);
            this.PortStopBits.TabIndex = 4;
            // 
            // PortDataBits
            // 
            this.PortDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortDataBits.FormattingEnabled = true;
            this.PortDataBits.Location = new System.Drawing.Point(80, 99);
            this.PortDataBits.Name = "PortDataBits";
            this.PortDataBits.Size = new System.Drawing.Size(100, 21);
            this.PortDataBits.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // PortBaud
            // 
            this.PortBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortBaud.FormattingEnabled = true;
            this.PortBaud.Location = new System.Drawing.Point(80, 72);
            this.PortBaud.Name = "PortBaud";
            this.PortBaud.Size = new System.Drawing.Size(100, 21);
            this.PortBaud.TabIndex = 0;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 234);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(292, 52);
            this.connect.TabIndex = 7;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Disconnected";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(311, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 274);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FileOutputGroup);
            this.tabPage1.Controls.Add(this.REDtext);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.IRtext);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.SPO2text);
            this.tabPage1.Controls.Add(this.BPMtext);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FileOutputGroup
            // 
            this.FileOutputGroup.Controls.Add(this.TextFileSPOisRounded);
            this.FileOutputGroup.Controls.Add(this.TextFileBPMisRounded);
            this.FileOutputGroup.Controls.Add(this.SPO2FileButton);
            this.FileOutputGroup.Controls.Add(this.label12);
            this.FileOutputGroup.Controls.Add(this.BPMFileButton);
            this.FileOutputGroup.Controls.Add(this.SPO2FileText);
            this.FileOutputGroup.Controls.Add(this.label11);
            this.FileOutputGroup.Controls.Add(this.BPMFileText);
            this.FileOutputGroup.Controls.Add(this.EnableTextFile);
            this.FileOutputGroup.Location = new System.Drawing.Point(149, 79);
            this.FileOutputGroup.Name = "FileOutputGroup";
            this.FileOutputGroup.Size = new System.Drawing.Size(279, 145);
            this.FileOutputGroup.TabIndex = 7;
            this.FileOutputGroup.TabStop = false;
            this.FileOutputGroup.Text = "Text output stream";
            // 
            // TextFileSPOisRounded
            // 
            this.TextFileSPOisRounded.AutoSize = true;
            this.TextFileSPOisRounded.Checked = true;
            this.TextFileSPOisRounded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextFileSPOisRounded.Location = new System.Drawing.Point(153, 92);
            this.TextFileSPOisRounded.Name = "TextFileSPOisRounded";
            this.TextFileSPOisRounded.Size = new System.Drawing.Size(72, 17);
            this.TextFileSPOisRounded.TabIndex = 10;
            this.TextFileSPOisRounded.Text = "Rounding";
            this.TextFileSPOisRounded.UseVisualStyleBackColor = true;
            // 
            // TextFileBPMisRounded
            // 
            this.TextFileBPMisRounded.AutoSize = true;
            this.TextFileBPMisRounded.Checked = true;
            this.TextFileBPMisRounded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextFileBPMisRounded.Location = new System.Drawing.Point(153, 46);
            this.TextFileBPMisRounded.Name = "TextFileBPMisRounded";
            this.TextFileBPMisRounded.Size = new System.Drawing.Size(72, 17);
            this.TextFileBPMisRounded.TabIndex = 10;
            this.TextFileBPMisRounded.Text = "Rounding";
            this.TextFileBPMisRounded.UseVisualStyleBackColor = true;
            // 
            // SPO2FileButton
            // 
            this.SPO2FileButton.Location = new System.Drawing.Point(232, 109);
            this.SPO2FileButton.Name = "SPO2FileButton";
            this.SPO2FileButton.Size = new System.Drawing.Size(32, 20);
            this.SPO2FileButton.TabIndex = 9;
            this.SPO2FileButton.Text = "...";
            this.SPO2FileButton.UseVisualStyleBackColor = true;
            this.SPO2FileButton.Click += new System.EventHandler(this.SPO2FileButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "SpO₂:";
            // 
            // BPMFileButton
            // 
            this.BPMFileButton.Location = new System.Drawing.Point(232, 63);
            this.BPMFileButton.Name = "BPMFileButton";
            this.BPMFileButton.Size = new System.Drawing.Size(32, 20);
            this.BPMFileButton.TabIndex = 9;
            this.BPMFileButton.Text = "...";
            this.BPMFileButton.UseVisualStyleBackColor = true;
            this.BPMFileButton.Click += new System.EventHandler(this.BPMFileButton_Click);
            // 
            // SPO2FileText
            // 
            this.SPO2FileText.Location = new System.Drawing.Point(7, 109);
            this.SPO2FileText.Name = "SPO2FileText";
            this.SPO2FileText.ReadOnly = true;
            this.SPO2FileText.Size = new System.Drawing.Size(218, 20);
            this.SPO2FileText.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "BPM:";
            // 
            // BPMFileText
            // 
            this.BPMFileText.Location = new System.Drawing.Point(7, 63);
            this.BPMFileText.Name = "BPMFileText";
            this.BPMFileText.ReadOnly = true;
            this.BPMFileText.Size = new System.Drawing.Size(218, 20);
            this.BPMFileText.TabIndex = 1;
            // 
            // EnableTextFile
            // 
            this.EnableTextFile.AutoSize = true;
            this.EnableTextFile.Location = new System.Drawing.Point(7, 24);
            this.EnableTextFile.Name = "EnableTextFile";
            this.EnableTextFile.Size = new System.Drawing.Size(59, 17);
            this.EnableTextFile.TabIndex = 0;
            this.EnableTextFile.Text = "Enable";
            this.EnableTextFile.UseVisualStyleBackColor = true;
            // 
            // REDtext
            // 
            this.REDtext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.REDtext.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REDtext.Location = new System.Drawing.Point(18, 163);
            this.REDtext.MaxLength = 5;
            this.REDtext.Name = "REDtext";
            this.REDtext.ReadOnly = true;
            this.REDtext.Size = new System.Drawing.Size(120, 38);
            this.REDtext.TabIndex = 6;
            this.REDtext.Text = "000.00";
            this.REDtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Red val:";
            // 
            // IRtext
            // 
            this.IRtext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IRtext.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRtext.Location = new System.Drawing.Point(18, 96);
            this.IRtext.MaxLength = 5;
            this.IRtext.Name = "IRtext";
            this.IRtext.ReadOnly = true;
            this.IRtext.Size = new System.Drawing.Size(120, 38);
            this.IRtext.TabIndex = 4;
            this.IRtext.Text = "000.00";
            this.IRtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "IR val:";
            // 
            // SPO2text
            // 
            this.SPO2text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SPO2text.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPO2text.Location = new System.Drawing.Point(156, 29);
            this.SPO2text.MaxLength = 6;
            this.SPO2text.Name = "SPO2text";
            this.SPO2text.ReadOnly = true;
            this.SPO2text.Size = new System.Drawing.Size(138, 38);
            this.SPO2text.TabIndex = 2;
            this.SPO2text.Text = "000.00%";
            this.SPO2text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BPMtext
            // 
            this.BPMtext.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BPMtext.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPMtext.Location = new System.Drawing.Point(18, 29);
            this.BPMtext.MaxLength = 5;
            this.BPMtext.Name = "BPMtext";
            this.BPMtext.ReadOnly = true;
            this.BPMtext.Size = new System.Drawing.Size(120, 38);
            this.BPMtext.TabIndex = 1;
            this.BPMtext.Text = "000.00";
            this.BPMtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "SpO₂:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "BPM:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.blipheart);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PPG Graph";
            // 
            // blipheart
            // 
            this.blipheart.AutoSize = true;
            this.blipheart.BackColor = System.Drawing.Color.Black;
            this.blipheart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blipheart.ForeColor = System.Drawing.Color.White;
            this.blipheart.Location = new System.Drawing.Point(12, 11);
            this.blipheart.Name = "blipheart";
            this.blipheart.Size = new System.Drawing.Size(78, 55);
            this.blipheart.TabIndex = 1;
            this.blipheart.Text = "♥";
            this.blipheart.Visible = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ContextMenuStrip = this.graphMenuStrip;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Enabled = false;
            series2.Legend = "Legend2";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(447, 248);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // graphMenuStrip
            // 
            this.graphMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.gridColorToolStripMenuItem,
            this.lineColorToolStripMenuItem,
            this.lineThicknessToolStripMenuItem,
            this.toolStripSeparator1,
            this.xGridToolStripMenuItem,
            this.yGridToolStripMenuItem,
            this.toolStripSeparator2,
            this.red2ndGraphToolStripMenuItem,
            this.heartIconToolStripMenuItem});
            this.graphMenuStrip.Name = "graphMenuStrip";
            this.graphMenuStrip.Size = new System.Drawing.Size(191, 192);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color...";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.gridColorToolStripMenuItem.Text = "Grid color...";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lineColorToolStripMenuItem.Text = "Line color...";
            this.lineColorToolStripMenuItem.Click += new System.EventHandler(this.lineColorToolStripMenuItem_Click);
            // 
            // lineThicknessToolStripMenuItem
            // 
            this.lineThicknessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuThick1,
            this.toolStripMenuThick2,
            this.toolStripMenuThick3,
            this.toolStripMenuThick4,
            this.toolStripMenuThick5});
            this.lineThicknessToolStripMenuItem.Name = "lineThicknessToolStripMenuItem";
            this.lineThicknessToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lineThicknessToolStripMenuItem.Text = "Line thickness";
            // 
            // toolStripMenuThick1
            // 
            this.toolStripMenuThick1.Name = "toolStripMenuThick1";
            this.toolStripMenuThick1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuThick1.Text = "1";
            this.toolStripMenuThick1.Click += new System.EventHandler(this.toolStripMenuThick1_Click);
            // 
            // toolStripMenuThick2
            // 
            this.toolStripMenuThick2.Name = "toolStripMenuThick2";
            this.toolStripMenuThick2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuThick2.Text = "2";
            this.toolStripMenuThick2.Click += new System.EventHandler(this.toolStripMenuThick2_Click);
            // 
            // toolStripMenuThick3
            // 
            this.toolStripMenuThick3.Name = "toolStripMenuThick3";
            this.toolStripMenuThick3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuThick3.Text = "3";
            this.toolStripMenuThick3.Click += new System.EventHandler(this.toolStripMenuThick3_Click);
            // 
            // toolStripMenuThick4
            // 
            this.toolStripMenuThick4.Name = "toolStripMenuThick4";
            this.toolStripMenuThick4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuThick4.Text = "4";
            this.toolStripMenuThick4.Click += new System.EventHandler(this.toolStripMenuThick4_Click);
            // 
            // toolStripMenuThick5
            // 
            this.toolStripMenuThick5.Name = "toolStripMenuThick5";
            this.toolStripMenuThick5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuThick5.Text = "5";
            this.toolStripMenuThick5.Click += new System.EventHandler(this.toolStripMenuThick5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // xGridToolStripMenuItem
            // 
            this.xGridToolStripMenuItem.Checked = true;
            this.xGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xGridToolStripMenuItem.Name = "xGridToolStripMenuItem";
            this.xGridToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.xGridToolStripMenuItem.Text = "X Grid";
            this.xGridToolStripMenuItem.Click += new System.EventHandler(this.xGridToolStripMenuItem_Click);
            // 
            // yGridToolStripMenuItem
            // 
            this.yGridToolStripMenuItem.Checked = true;
            this.yGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yGridToolStripMenuItem.Name = "yGridToolStripMenuItem";
            this.yGridToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.yGridToolStripMenuItem.Text = "Y Grid";
            this.yGridToolStripMenuItem.Click += new System.EventHandler(this.yGridToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // red2ndGraphToolStripMenuItem
            // 
            this.red2ndGraphToolStripMenuItem.Name = "red2ndGraphToolStripMenuItem";
            this.red2ndGraphToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.red2ndGraphToolStripMenuItem.Text = "(2nd) Red value graph";
            this.red2ndGraphToolStripMenuItem.Click += new System.EventHandler(this.red2ndGraphToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LogFileButton);
            this.tabPage4.Controls.Add(this.LogFileText);
            this.tabPage4.Controls.Add(this.LogIsEnabled);
            this.tabPage4.Controls.Add(this.spoMax);
            this.tabPage4.Controls.Add(this.bpmMax);
            this.tabPage4.Controls.Add(this.spoMin);
            this.tabPage4.Controls.Add(this.bpmMin);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.chart3);
            this.tabPage4.Controls.Add(this.chart2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(447, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trend Graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LogFileButton
            // 
            this.LogFileButton.Location = new System.Drawing.Point(415, 106);
            this.LogFileButton.Name = "LogFileButton";
            this.LogFileButton.Size = new System.Drawing.Size(24, 20);
            this.LogFileButton.TabIndex = 6;
            this.LogFileButton.Text = "...";
            this.LogFileButton.UseVisualStyleBackColor = true;
            this.LogFileButton.Click += new System.EventHandler(this.LogFileButton_Click);
            // 
            // LogFileText
            // 
            this.LogFileText.Location = new System.Drawing.Point(346, 106);
            this.LogFileText.Name = "LogFileText";
            this.LogFileText.ReadOnly = true;
            this.LogFileText.Size = new System.Drawing.Size(65, 20);
            this.LogFileText.TabIndex = 5;
            // 
            // LogIsEnabled
            // 
            this.LogIsEnabled.AutoSize = true;
            this.LogIsEnabled.Location = new System.Drawing.Point(346, 86);
            this.LogIsEnabled.Name = "LogIsEnabled";
            this.LogIsEnabled.Size = new System.Drawing.Size(72, 17);
            this.LogIsEnabled.TabIndex = 4;
            this.LogIsEnabled.Text = "Log to file";
            this.LogIsEnabled.UseVisualStyleBackColor = true;
            // 
            // spoMax
            // 
            this.spoMax.AutoSize = true;
            this.spoMax.Location = new System.Drawing.Point(351, 176);
            this.spoMax.Name = "spoMax";
            this.spoMax.Size = new System.Drawing.Size(68, 13);
            this.spoMax.TabIndex = 3;
            this.spoMax.Text = "Max: 00.00%";
            // 
            // bpmMax
            // 
            this.bpmMax.AutoSize = true;
            this.bpmMax.Location = new System.Drawing.Point(351, 53);
            this.bpmMax.Name = "bpmMax";
            this.bpmMax.Size = new System.Drawing.Size(60, 13);
            this.bpmMax.TabIndex = 3;
            this.bpmMax.Text = "Max: 00.00";
            // 
            // spoMin
            // 
            this.spoMin.AutoSize = true;
            this.spoMin.Location = new System.Drawing.Point(351, 160);
            this.spoMin.Name = "spoMin";
            this.spoMin.Size = new System.Drawing.Size(65, 13);
            this.spoMin.TabIndex = 3;
            this.spoMin.Text = "Min: 00.00%";
            // 
            // bpmMin
            // 
            this.bpmMin.AutoSize = true;
            this.bpmMin.Location = new System.Drawing.Point(351, 37);
            this.bpmMin.Name = "bpmMin";
            this.bpmMin.Size = new System.Drawing.Size(57, 13);
            this.bpmMin.TabIndex = 3;
            this.bpmMin.Text = "Min: 00.00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(361, 217);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 26);
            this.label23.TabIndex = 2;
            this.label23.Text = "1s interval\r\n5 minutes graph";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(351, 138);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "SpO₂:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(351, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "BPM:";
            // 
            // chart3
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY2.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(4, 128);
            this.chart3.Name = "chart3";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(341, 116);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY2.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(4, 3);
            this.chart2.Name = "chart2";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(341, 116);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.TrimmedDataText);
            this.tabPage3.Controls.Add(this.RawDataText);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.graphColorSettingGroup);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(447, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Config & Guide";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(131, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Short guide";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(195, 170);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(99, 13);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Kampidh ko-fi tip jar";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(7, 122);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(154, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Icon by Freepik @ flaticon.com";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(7, 85);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(114, 13);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Kampidh\'s github page";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 103);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "coniferconifer\'s ESP32 base code";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(273, 52);
            this.label19.TabIndex = 0;
            this.label19.Text = "What do you need:\r\n- ESP32 and MAX30102 sensor (MH-ET LIVE)\r\nThe ESP32 code is a " +
    "modified version of conifer\'s simple\r\nSpO₂ plotter BLE code linked below.\r\n";
            // 
            // TrimmedDataText
            // 
            this.TrimmedDataText.AutoSize = true;
            this.TrimmedDataText.Location = new System.Drawing.Point(11, 227);
            this.TrimmedDataText.Name = "TrimmedDataText";
            this.TrimmedDataText.Size = new System.Drawing.Size(22, 13);
            this.TrimmedDataText.TabIndex = 1;
            this.TrimmedDataText.Text = "-----";
            // 
            // RawDataText
            // 
            this.RawDataText.AutoSize = true;
            this.RawDataText.Location = new System.Drawing.Point(174, 227);
            this.RawDataText.Name = "RawDataText";
            this.RawDataText.Size = new System.Drawing.Size(22, 13);
            this.RawDataText.TabIndex = 1;
            this.RawDataText.Text = "-----";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Trimmed data debug:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Raw data debug:";
            // 
            // graphColorSettingGroup
            // 
            this.graphColorSettingGroup.Controls.Add(this.colorApply);
            this.graphColorSettingGroup.Controls.Add(this.lineColorPick);
            this.graphColorSettingGroup.Controls.Add(this.label17);
            this.graphColorSettingGroup.Controls.Add(this.gridColorPick);
            this.graphColorSettingGroup.Controls.Add(this.label15);
            this.graphColorSettingGroup.Controls.Add(this.label14);
            this.graphColorSettingGroup.Controls.Add(this.bgColorPick);
            this.graphColorSettingGroup.Location = new System.Drawing.Point(6, 6);
            this.graphColorSettingGroup.Name = "graphColorSettingGroup";
            this.graphColorSettingGroup.Size = new System.Drawing.Size(119, 199);
            this.graphColorSettingGroup.TabIndex = 4;
            this.graphColorSettingGroup.TabStop = false;
            this.graphColorSettingGroup.Text = "PPG graph config";
            // 
            // colorApply
            // 
            this.colorApply.Location = new System.Drawing.Point(26, 161);
            this.colorApply.Name = "colorApply";
            this.colorApply.Size = new System.Drawing.Size(75, 23);
            this.colorApply.TabIndex = 5;
            this.colorApply.Text = "Apply";
            this.colorApply.UseVisualStyleBackColor = true;
            this.colorApply.Click += new System.EventHandler(this.colorApply_Click);
            // 
            // lineColorPick
            // 
            this.lineColorPick.BackColor = System.Drawing.Color.Red;
            this.lineColorPick.ForeColor = System.Drawing.Color.Black;
            this.lineColorPick.Location = new System.Drawing.Point(78, 103);
            this.lineColorPick.Name = "lineColorPick";
            this.lineColorPick.Size = new System.Drawing.Size(34, 33);
            this.lineColorPick.TabIndex = 4;
            this.lineColorPick.UseVisualStyleBackColor = false;
            this.lineColorPick.Click += new System.EventHandler(this.lineColorPick_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Graph line";
            // 
            // gridColorPick
            // 
            this.gridColorPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridColorPick.ForeColor = System.Drawing.Color.Black;
            this.gridColorPick.Location = new System.Drawing.Point(78, 64);
            this.gridColorPick.Name = "gridColorPick";
            this.gridColorPick.Size = new System.Drawing.Size(34, 33);
            this.gridColorPick.TabIndex = 4;
            this.gridColorPick.UseVisualStyleBackColor = false;
            this.gridColorPick.Click += new System.EventHandler(this.gridColorPick_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Grid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Background";
            // 
            // bgColorPick
            // 
            this.bgColorPick.BackColor = System.Drawing.Color.Black;
            this.bgColorPick.ForeColor = System.Drawing.Color.Black;
            this.bgColorPick.Location = new System.Drawing.Point(78, 25);
            this.bgColorPick.Name = "bgColorPick";
            this.bgColorPick.Size = new System.Drawing.Size(34, 33);
            this.bgColorPick.TabIndex = 2;
            this.bgColorPick.UseVisualStyleBackColor = false;
            this.bgColorPick.Click += new System.EventHandler(this.bgColorPick_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.NameVersionLabel);
            this.tabPage5.Controls.Add(this.linkLabel5);
            this.tabPage5.Controls.Add(this.licenseButton);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(447, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Disclaimer";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(10, 173);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(132, 13);
            this.linkLabel5.TabIndex = 3;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Project link @ github page";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // licenseButton
            // 
            this.licenseButton.Location = new System.Drawing.Point(13, 119);
            this.licenseButton.Name = "licenseButton";
            this.licenseButton.Size = new System.Drawing.Size(160, 23);
            this.licenseButton.TabIndex = 2;
            this.licenseButton.Text = "License text...";
            this.licenseButton.UseVisualStyleBackColor = true;
            this.licenseButton.Click += new System.EventHandler(this.licenseButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(404, 52);
            this.label24.TabIndex = 1;
            this.label24.Text = "This software and conifer\'s arduino code are NOT INTENDED FOR MEDICAL USE.\r\nIt co" +
    "mes on \"AS IS\" WITHOUT WARRANTY.\r\n\r\nLicensed under Apache License, Version 2.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(386, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "FOR EDUCATIONAL AND RECREATIONAL PURPOSE ONLY.";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundDataWorker
            // 
            this.backgroundDataWorker.WorkerSupportsCancellation = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "csv";
            this.saveFileDialog2.OverwritePrompt = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // heartIconToolStripMenuItem
            // 
            this.heartIconToolStripMenuItem.Checked = true;
            this.heartIconToolStripMenuItem.CheckOnClick = true;
            this.heartIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.heartIconToolStripMenuItem.Name = "heartIconToolStripMenuItem";
            this.heartIconToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.heartIconToolStripMenuItem.Text = "Heart icon";
            // 
            // NameVersionLabel
            // 
            this.NameVersionLabel.AutoSize = true;
            this.NameVersionLabel.Location = new System.Drawing.Point(10, 220);
            this.NameVersionLabel.Name = "NameVersionLabel";
            this.NameVersionLabel.Size = new System.Drawing.Size(108, 13);
            this.NameVersionLabel.TabIndex = 4;
            this.NameVersionLabel.Text = "Serial HRM Monitor v";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 320);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.SerialControlGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Serial HRM Monitor";
            this.SerialControlGroup.ResumeLayout(false);
            this.SerialControlGroup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.FileOutputGroup.ResumeLayout(false);
            this.FileOutputGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.graphMenuStrip.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.graphColorSettingGroup.ResumeLayout(false);
            this.graphColorSettingGroup.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SerialControlGroup;
        private System.Windows.Forms.ComboBox PortParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PortStopBits;
        private System.Windows.Forms.ComboBox PortDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortBaud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PortFlowCtl;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox SPO2text;
        private System.Windows.Forms.TextBox BPMtext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundDataWorker;
        private System.Windows.Forms.TextBox REDtext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IRtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox FileOutputGroup;
        private System.Windows.Forms.CheckBox EnableTextFile;
        private System.Windows.Forms.Button SPO2FileButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BPMFileButton;
        private System.Windows.Forms.TextBox SPO2FileText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BPMFileText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label RawDataText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox TextFileBPMisRounded;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bgColorPick;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox graphColorSettingGroup;
        private System.Windows.Forms.Button colorApply;
        private System.Windows.Forms.Button lineColorPick;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button gridColorPick;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip graphMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yGridToolStripMenuItem;
        private System.Windows.Forms.Button refreshPortButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolStripMenuItem lineThicknessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuThick1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuThick2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuThick3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuThick4;
        private System.Windows.Forms.CheckBox TextFileSPOisRounded;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuThick5;
        private System.Windows.Forms.Label TrimmedDataText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label spoMax;
        private System.Windows.Forms.Label bpmMax;
        private System.Windows.Forms.Label spoMin;
        private System.Windows.Forms.Label bpmMin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button LogFileButton;
        private System.Windows.Forms.TextBox LogFileText;
        private System.Windows.Forms.CheckBox LogIsEnabled;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button licenseButton;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem red2ndGraphToolStripMenuItem;
        private System.Windows.Forms.Label blipheart;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem heartIconToolStripMenuItem;
        private System.Windows.Forms.Label NameVersionLabel;
    }
}

