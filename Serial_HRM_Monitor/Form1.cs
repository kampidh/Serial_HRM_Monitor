using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Serial_HRM_Monitor
{
    public partial class Form1 : Form
    {
        private List<PortInfo> _ports = new List<PortInfo>();
        private string bufferData = "0";
        private string testData = "0";
        private string trimmedData = "0";
        private string[] parsedData = new string[4] { "00.00", "00.00", "00.00", "00.00" };

        private double dBPM = 0;
        private double dIR = 0;
        private double dRED = 0;
        private double dSPO = 0;

        private CultureInfo culture = CultureInfo.InvariantCulture;

        StreamWriter SlowLog;

        private string[] logBuffer = new string[5];
        private int logIndex = 0;
        
        private class PortInfo
        {
            public string Name { get; set; }
            public string Caption { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            PortBaud.DataSource = new[] { "230400", "115200", "57600", "38400", "19200", "9600", "4800" };
            PortParity.DataSource = new[] { "None", "Odd", "Even", "Mark", "Space" };
            PortDataBits.DataSource = new[] { "5", "6", "7", "8" };
            PortStopBits.DataSource = new[] { "1", "2", "1.5" };
            PortFlowCtl.DataSource = new[] { "None", "RTS", "RTS/X", "Xon/Xoff" };
            PortBaud.SelectedIndex = 1;
            PortParity.SelectedIndex = 0;
            PortDataBits.SelectedIndex = 3;
            PortStopBits.SelectedIndex = 0;
            PortFlowCtl.SelectedIndex = 0;

            bgColorPick.BackColor = Properties.Settings.Default.graphBGCol;
            gridColorPick.BackColor = Properties.Settings.Default.graphGridCol;
            lineColorPick.BackColor = Properties.Settings.Default.graphLineCol;
            chart1.Series[0].BorderWidth = Properties.Settings.Default.graphLineThickness;

            blipheart.Parent = chart1;
            blipheart.BackColor = System.Drawing.Color.Transparent;

            //blipheart.BackColor = Properties.Settings.Default.graphBGCol;
            blipheart.ForeColor = Properties.Settings.Default.graphLineCol;

            NameVersionLabel.Text = String.Format("{0} v{1}",Application.ProductName,Application.ProductVersion);

            switch (chart1.Series[0].BorderWidth)
            {
                case 1:
                    toolStripMenuThick1.Checked = true;
                    break;
                case 2:
                    toolStripMenuThick2.Checked = true;
                    break;
                case 3:
                    toolStripMenuThick3.Checked = true;
                    break;
                case 4:
                    toolStripMenuThick4.Checked = true;
                    break;
                case 5:
                    toolStripMenuThick5.Checked = true;
                    break;
            }

            chart1.BackColor = bgColorPick.BackColor;
            chart1.ChartAreas[0].BackColor = bgColorPick.BackColor;
            chart1.ChartAreas[0].BackSecondaryColor = bgColorPick.BackColor;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisX.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisY.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = gridColorPick.BackColor;
            chart1.Series[0].Color = lineColorPick.BackColor;
            chart1.Series[1].Color = lineColorPick.BackColor;

            BPMFileText.Text = Properties.Settings.Default.BPMFile;
            SPO2FileText.Text = Properties.Settings.Default.SPOFile;

            heartIconToolStripMenuItem.Checked = Properties.Settings.Default.HeartIcon;

            mySerial.DataReceived += rx_data_event;
            backgroundDataWorker.DoWork += new DoWorkEventHandler(TaskBackground);
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            toolTip1.SetToolTip(EnableTextFile, "Enables an output stream every 1 second\nthat can be used with OBS text input.");
            
            try
            {
                var portNames = SerialPort.GetPortNames();
                using (var searcher = new ManagementObjectSearcher
                    ("SELECT * FROM WIN32_SerialPort"))
                {
                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                    _ports = (from portName in portNames
                              join port in ports on portName equals port["DeviceID"].ToString()
                              select new PortInfo
                              {
                                  Name = portName,
                                  Caption = port["Caption"].ToString()
                              }).ToList();
                }

                foreach (var port in _ports)
                {
                    PortList.Items.Add($"{port.Caption}");
                }

                if (PortList.Items.Count == 0)
                {
                    //throw new Exception("No COM port available");
                    if (MessageBox.Show("No COM port available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        connect.Enabled = false;
                    }
                }
                else
                {
                    PortList.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void connect_Click(object sender, EventArgs e)
        {
            /*Connect*/
            if(LogIsEnabled.Checked && !mySerial.IsOpen)
            {
                if (LogFileText.Text == "")
                {
                    MessageBox.Show("Log is enabled, but no file is defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (EnableTextFile.Checked)
                {
                    if (BPMFileText.Text == "")
                    {
                        MessageBox.Show("Text output is enabled, but no BPM file is defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (SPO2FileText.Text == "")
                    {
                        MessageBox.Show("Text output is enabled, but no SpO2 file is defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (File.Exists(LogFileText.Text))
                {
                    if (MessageBox.Show("Do you want to overwrite " + LogFileText.Text + "?\nAll of it contents will be lost!", "Log file overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (!mySerial.IsOpen)
                        {
                            serial_startup();

                            SlowLog = new StreamWriter(LogFileText.Text);
                            SlowLog.WriteLine("Time,BPM,SpO2");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (!mySerial.IsOpen)
                    {
                        serial_startup();

                        SlowLog = new StreamWriter(LogFileText.Text);
                        SlowLog.WriteLine("Time,BPM,SpO2");
                    }
                }
            }
            else if (!LogIsEnabled.Checked && !mySerial.IsOpen)
            {
                if (EnableTextFile.Checked)
                {
                    if (BPMFileText.Text == "")
                    {
                        MessageBox.Show("Text output is enabled, but no BPM file is defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (SPO2FileText.Text == "")
                    {
                        MessageBox.Show("Text output is enabled, but no SpO2 file is defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!mySerial.IsOpen)
                {
                    serial_startup();
                }
            }

            /*Disconnect*/
            else if (mySerial.IsOpen)
            {
                try
                {
                    mySerial.Write("2");
                    mySerial.Close();
                    mySerial.DiscardInBuffer();
                    mySerial.DiscardOutBuffer();

                }
                catch {/*ignore*/}

                if (LogIsEnabled.Checked) { SlowLog.Dispose(); }
                UserControl_state(false);
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void serial_startup()
        {
            if (Serial_port_config())
            {
                try
                {
                    mySerial.Open();
                    mySerial.Write("1");
                }
                catch
                {
                    //throw new Exception("Can't open " + mySerial.PortName + " port, it might be used in another program");
                    if (MessageBox.Show("Can't open " + mySerial.PortName + " port, it might be used in another program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        refreshPort();
                        return;
                    }
                }

                UserControl_state(true);
            }

            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void rx_data_event(object sender, SerialDataReceivedEventArgs e)
        {
            if (mySerial.IsOpen)
            {
                try
                {
                    int dataLength = mySerial.BytesToRead;
                    char[] dataRecevied = new char[dataLength];
                    if (mySerial.IsOpen) //idk why it has to be called twice for stability during disconnection...
                    {
                        int nbytes = mySerial.Read(dataRecevied, 0, dataLength);
                        if (nbytes == 0) return;
                        testData += new string(dataRecevied);
                    }

                    this.BeginInvoke((Action)(() =>
                    {
                        if (!backgroundDataWorker.IsBusy)
                        {
                            backgroundDataWorker.RunWorkerAsync();
                        }
                        chart1.ResetAutoValues();
                        chart1.ChartAreas[0].RecalculateAxesScale();

                        if (chart1.Series[0].Points.Count > 200)
                        {
                            chart1.Series[0].Points.RemoveAt(0);
                            chart1.Series[1].Points.RemoveAt(0);
                        }
                        if (dIR != 0)
                        {
                            chart1.Series[0].Points.Add(dIR);
                            chart1.Series[1].Points.Add(dRED);
                        }
                    }));
                }
                catch { throw new Exception("Can't read form " + mySerial.PortName + " port it might be opened in another program"); }
            }
        }

        private void TaskBackground(object sender, DoWorkEventArgs e)
        {
            //process the data asynchronously so it won't disturb the serial capture progress
            this.BeginInvoke((Action)(() =>
            {
                //Clear receive buffer after end mark.
                if (testData.Contains(">"))
                {
                    bufferData = testData;
                    testData = "";
                }

                /*Trim the data and make sure that the trimmed data is valid without glitches.
                This may won't look smooth on the graph because it may keep dropping data.
                But it better this way rather than having non-valid data and causing problems
                during the conversion to corresponding variables.*/
                if (bufferData.Contains("<") && bufferData.Contains(">"))
                {
                    trimmedData = GetStringBetweenCharacters(bufferData, '<', '>');
                    if (trimmedData.Length < 25 || trimmedData.Length > 29) //25-29 normally
                    {
                        bufferData = "";
                        //trimmedData = "";
                    }
                    else
                    {
                        parsedData = trimmedData.Split(',');
                    }
                } else
                {
                    bufferData = "";
                }

                //Store the trimmed data into the corresponding variables.
                double blipBPM = dBPM;

                try
                {
                    dIR = Convert.ToDouble(parsedData[1], culture);
                    dRED = Convert.ToDouble(parsedData[2], culture);
                    dBPM = Convert.ToDouble(parsedData[0], culture);
                    dSPO = Convert.ToDouble(parsedData[3], culture);

                    BPMtext.Text = parsedData[0];
                    SPO2text.Text = parsedData[3] + "%";
                    IRtext.Text = parsedData[1];
                    REDtext.Text = parsedData[2];
                } catch { }

                if (blipBPM != dBPM && heartIconToolStripMenuItem.Checked == true)
                {
                    timer3.Start();
                    blipheart.Visible = true;
                    //player.Play();
                }

                //On program debug
                RawDataText.Text = bufferData;
                TrimmedDataText.Text = trimmedData;
            }));
        }

        public static string GetStringBetweenCharacters(string input, char charFrom, char charTo)
        {
            int posFrom = input.IndexOf(charFrom);
            if (posFrom != -1) //if found char
            {
                int posTo = input.IndexOf(charTo, posFrom + 1);
                if (posTo != -1) //if found char
                {
                    return input.Substring(posFrom + 1, posTo - posFrom - 1);
                }
            }

            return string.Empty;
        }
        
        private bool Serial_port_config()
        {
            var info = _ports[PortList.SelectedIndex];
            try { mySerial.PortName = info.Name; }
            catch { throw new Exception("There are no available ports"); }
            mySerial.BaudRate = (Int32.Parse(PortBaud.Text));
            mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (PortStopBits.SelectedIndex + 1).ToString(), true);
            mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), PortParity.SelectedIndex.ToString(), true);
            mySerial.DataBits = (Int32.Parse(PortDataBits.Text));
            mySerial.Handshake = (Handshake)Enum.Parse(typeof(Handshake), PortFlowCtl.SelectedIndex.ToString(), true);

            return true;
        }

        private void UserControl_state(bool value)
        {
            SerialControlGroup.Enabled = !value;
            FileOutputGroup.Enabled = !value;
            graphMenuStrip.Enabled = !value;
            graphColorSettingGroup.Enabled = !value;
            LogIsEnabled.Enabled = !value;
            LogFileText.Enabled = !value;
            LogFileButton.Enabled = !value;

            if (value)
            {
                connect.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected: " + mySerial.PortName + " @ " + mySerial.BaudRate + " bps";
            }
            else
            {
                connect.Text = "Connect";
                toolStripStatusLabel1.Text = "Disconnected";
            }
        }

        /*------------------------------------
        ------------Timers
        ------------------------------------*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            string b = string.Format("{0:N2}", dBPM);
            string s = string.Format("{0:N2}%", dSPO);
            string bn = string.Format("{0:N0}", dBPM);
            string sn = string.Format("{0:N0}%", dSPO);

            /*
            if (dBPM < 100)
            {
                b = b.Insert(0, " ");
                bn = bn.Insert(0, " ");
            }

            if (dSPO < 100)
            {
                s = s.Insert(0, " ");
                sn = sn.Insert(0, " ");
            }
            */

            if (EnableTextFile.Checked)
            {
                try
                {
                    using (var bpm = new StreamWriter(BPMFileText.Text))
                    {
                        if (TextFileBPMisRounded.Checked)
                        {
                            bpm.Write(bn);
                            //File.WriteAllText(BPMFileText.Text, bn); //Old method
                        }
                        else
                        {
                            bpm.Write(b);
                            //File.WriteAllText(BPMFileText.Text, b);
                        }
                    }
                }
                catch
                {
                    throw new Exception(BPMFileText.Text + " is on use.");
                }

                try
                {
                    using (var spo = new StreamWriter(SPO2FileText.Text))
                    {
                        if (TextFileSPOisRounded.Checked)
                        {
                            spo.Write(sn);
                            //File.WriteAllText(BPMFileText.Text, sn); //Old method
                        }
                        else
                        {
                            spo.Write(s);
                            //File.WriteAllText(BPMFileText.Text, s);
                        }
                    }
                }
                catch
                {
                    throw new Exception(SPO2FileText.Text + " is on use.");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            double minBPMval = 0;
            double maxBPMval = 0;

            double minSPOval = 0;
            double maxSPOval = 0;

            chart2.ResetAutoValues();
            chart2.ChartAreas[0].RecalculateAxesScale();

            if (chart2.Series[0].Points.Count > 300)
            {
                chart2.Series[0].Points.RemoveAt(0);
            }
            if(dBPM != 0) chart2.Series[0].Points.Add(dBPM);

            chart3.ResetAutoValues();
            chart3.ChartAreas[0].RecalculateAxesScale();

            if (chart3.Series[0].Points.Count > 300)
            {
                chart3.Series[0].Points.RemoveAt(0);
            }
            if (dSPO != 0) chart3.Series[0].Points.Add(dSPO);

            if (chart2.Series[0].Points.Count > 0)
            {
                minBPMval = chart2.Series[0].Points.Select(v => v.YValues[0]).Min();
                maxBPMval = chart2.Series[0].Points.Select(v => v.YValues[0]).Max();
            }

            if (chart3.Series[0].Points.Count > 0)
            {
                minSPOval = chart3.Series[0].Points.Select(v => v.YValues[0]).Min();
                maxSPOval = chart3.Series[0].Points.Select(v => v.YValues[0]).Max();
            }

            bpmMin.Text = "Min: " + minBPMval.ToString();
            bpmMax.Text = "Max: " + maxBPMval.ToString();

            spoMin.Text = "Min: " + minSPOval.ToString() + "%";
            spoMax.Text = "Max: " + maxSPOval.ToString() + "%";

            if (LogIsEnabled.Checked && dBPM != 0 && dSPO != 0)
            {
                //made a ring buffer so that it only writes to file
                //once every 5 seconds / 5 sanples

                //string d = DateTime.Now.ToString("s");
                //string s = string.Format("{0},{1:N2},{2:N2}", d, dBPM, dSPO);

                //use string interpolation instead
                string a = $"{DateTime.Now:s},{dBPM:N2},{dSPO:N2}";

                logBuffer[logIndex] = a;
                logIndex++;

                if (logIndex == 5)
                {
                    logIndex = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        SlowLog.WriteLine(logBuffer[i]);
                    }
                    SlowLog.Flush();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (blipheart.Visible == true)
            {
                blipheart.Visible = false;
                timer3.Stop();
            }
            else
            {
                //blipheart.Visible = true;
            }
        }

        /*------------------------------------
        ------------UI Section
        ------------------------------------*/

        private void BPMFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BPMFileText.Text = saveFileDialog1.FileName;
                Properties.Settings.Default.BPMFile = saveFileDialog1.FileName;
            }
        }

        private void SPO2FileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SPO2FileText.Text = saveFileDialog1.FileName;
                Properties.Settings.Default.SPOFile = saveFileDialog1.FileName;
            }
        }

        private void LogFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                LogFileText.Text = saveFileDialog2.FileName;
            }
        }

        private void bgColorPick_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = chart1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bgColorPick.BackColor = colorDialog1.Color;
            }
        }

        private void gridColorPick_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = chart1.ChartAreas[0].AxisX.MajorGrid.LineColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                gridColorPick.BackColor = colorDialog1.Color;
            }
        }

        private void lineColorPick_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = chart1.Series[0].Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lineColorPick.BackColor = colorDialog1.Color;
            }
        }

        private void colorApply_Click(object sender, EventArgs e)
        {
            chart1.BackColor = bgColorPick.BackColor;
            chart1.ChartAreas[0].BackColor = bgColorPick.BackColor;
            chart1.ChartAreas[0].BackSecondaryColor = bgColorPick.BackColor;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisX.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisY.LineColor = gridColorPick.BackColor;
            chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = gridColorPick.BackColor;
            chart1.Series[0].Color = lineColorPick.BackColor;
            chart1.Series[1].Color = lineColorPick.BackColor;
            blipheart.ForeColor = lineColorPick.BackColor;
            Properties.Settings.Default.graphBGCol = bgColorPick.BackColor;
            Properties.Settings.Default.graphGridCol = gridColorPick.BackColor;
            Properties.Settings.Default.graphLineCol = lineColorPick.BackColor;
            Properties.Settings.Default.Save();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = chart1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.BackColor = colorDialog1.Color;
                chart1.ChartAreas[0].BackColor = colorDialog1.Color;
                chart1.ChartAreas[0].BackSecondaryColor = colorDialog1.Color;
                bgColorPick.BackColor = colorDialog1.Color;
                Properties.Settings.Default.graphBGCol = colorDialog1.Color;
            }
        }

        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = chart1.ChartAreas[0].AxisX.MajorGrid.LineColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = colorDialog1.Color;
                chart1.ChartAreas[0].AxisX.LineColor = colorDialog1.Color;
                chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = colorDialog1.Color;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = colorDialog1.Color;
                chart1.ChartAreas[0].AxisY.LineColor = colorDialog1.Color;
                chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = colorDialog1.Color;
                gridColorPick.BackColor = colorDialog1.Color;
                Properties.Settings.Default.graphGridCol = colorDialog1.Color;
            }
        }

        private void lineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = chart1.Series[0].Color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Color = colorDialog1.Color;
                chart1.Series[1].Color = colorDialog1.Color;
                lineColorPick.BackColor = colorDialog1.Color;
                blipheart.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.graphLineCol = colorDialog1.Color;
            }
        }

        private void xGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xGridToolStripMenuItem.Checked)
            {
                xGridToolStripMenuItem.Checked = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            } else
            {
                xGridToolStripMenuItem.Checked = true;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            }
        }

        private void yGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yGridToolStripMenuItem.Checked)
            {
                yGridToolStripMenuItem.Checked = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            }
            else
            {
                yGridToolStripMenuItem.Checked = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
        }

        private void toolStripMenuThick1_Click(object sender, EventArgs e)
        {
            toolStripMenuThick1.Checked = true;
            toolStripMenuThick2.Checked = false;
            toolStripMenuThick3.Checked = false;
            toolStripMenuThick4.Checked = false;
            toolStripMenuThick5.Checked = false;

            chart1.Series[0].BorderWidth = 1;
            Properties.Settings.Default.graphLineThickness = 1;
        }

        private void toolStripMenuThick2_Click(object sender, EventArgs e)
        {
            toolStripMenuThick1.Checked = false;
            toolStripMenuThick2.Checked = true;
            toolStripMenuThick3.Checked = false;
            toolStripMenuThick4.Checked = false;
            toolStripMenuThick5.Checked = false;

            chart1.Series[0].BorderWidth = 2;
            Properties.Settings.Default.graphLineThickness = 2;
        }

        private void toolStripMenuThick3_Click(object sender, EventArgs e)
        {
            toolStripMenuThick1.Checked = false;
            toolStripMenuThick2.Checked = false;
            toolStripMenuThick3.Checked = true;
            toolStripMenuThick4.Checked = false;
            toolStripMenuThick5.Checked = false;

            chart1.Series[0].BorderWidth = 3;
            Properties.Settings.Default.graphLineThickness = 3;
        }

        private void toolStripMenuThick4_Click(object sender, EventArgs e)
        {
            toolStripMenuThick1.Checked = false;
            toolStripMenuThick2.Checked = false;
            toolStripMenuThick3.Checked = false;
            toolStripMenuThick4.Checked = true;
            toolStripMenuThick5.Checked = false;

            chart1.Series[0].BorderWidth = 4;
            Properties.Settings.Default.graphLineThickness = 4;
        }

        private void toolStripMenuThick5_Click(object sender, EventArgs e)
        {
            toolStripMenuThick1.Checked = false;
            toolStripMenuThick2.Checked = false;
            toolStripMenuThick3.Checked = false;
            toolStripMenuThick4.Checked = false;
            toolStripMenuThick5.Checked = true;

            chart1.Series[0].BorderWidth = 5;
            Properties.Settings.Default.graphLineThickness = 5;
        }

        private void refreshPort()
        {
            PortList.Items.Clear();

            try
            {
                var portNames = SerialPort.GetPortNames();
                using (var searcher = new ManagementObjectSearcher
                    ("SELECT * FROM WIN32_SerialPort"))
                {
                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                    _ports = (from portName in portNames
                              join port in ports on portName equals port["DeviceID"].ToString()
                              select new PortInfo
                              {
                                  Name = portName,
                                  Caption = port["Caption"].ToString()
                              }).ToList();
                }

                foreach (var port in _ports)
                {
                    PortList.Items.Add($"{port.Caption}");
                }

                if (PortList.Items.Count == 0)
                {
                    if (MessageBox.Show("No COM port available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        connect.Enabled = false;
                    }
                }
                else
                {
                    PortList.SelectedIndex = 0;
                    connect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshPortButton_Click(object sender, EventArgs e)
        {
            refreshPort();
        }

        private void licenseButton_Click(object sender, EventArgs e)
        {
            LicenseWindow a = new LicenseWindow();
            a.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/coniferconifer/ESP32_MAX30102_simple-SpO2_plotter");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kampidh");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/free-icon/heart-rate-monitor_2906350?related_item_id=2906350&term=heartbeat");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ko-fi.com/kampidh");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kampidh/Serial_HRM_Monitor"); //project page link
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerial.IsOpen)
                mySerial.Close();
            if (LogIsEnabled.Checked) { SlowLog.Dispose(); }
            Properties.Settings.Default.Save();
        }

        private void red2ndGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (red2ndGraphToolStripMenuItem.Checked)
            {
                red2ndGraphToolStripMenuItem.Checked = false;
                chart1.Series[1].Enabled = false;
            } else
            {
                red2ndGraphToolStripMenuItem.Checked = true;
                chart1.Series[1].Enabled = true;
            }
        }

    }
}
