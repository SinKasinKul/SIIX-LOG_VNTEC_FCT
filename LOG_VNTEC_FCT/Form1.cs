using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Data.OleDb;

namespace LOG_VNTEC_FCT
{
    public partial class Main : Form
    {
        ConnectDB ConDB = new ConnectDB();
        DataTableCollection tableCollection;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            rTBResult.ReadOnly = true;
            var appSettings = ConfigurationManager.AppSettings;
            string TimesSec = appSettings.Get("TimesSec");
            string Line = appSettings.Get("Line");
            string Path = appSettings.Get("pahtFileLog");
            string Server = appSettings.Get("Server");

            Int32 TimeInt = Int32.Parse(TimesSec) * 1000;
            timerSQL.Interval = TimeInt;
            timerSQL.Tick += new EventHandler(timerSQL_Tick);

            lbServer.Text = Server;
            lbNamePath.Text = Path;

            lbResult.Text = "Application Start...";
            lbResult.BackColor = Color.Red;

            if (bgWorkerWIP.IsBusy != true)
            {
                bgWorkerWIP.RunWorkerAsync();
            }
            lbResult.Text = "Application Start...";
            this.timerSQL.Enabled = true;

            rBAll.Checked = true;
            getDate();

            lbPW.Hide();
            tBPW.Hide();
        }
        public void getDate()
        {
            string vYear = DateTime.Now.ToString("yyyy");
            int vBYear = Int32.Parse(vYear) + 543;
            string dateShow = DateTime.Now.ToString("dd-MM-yyyy");
            lbDate.Text = dateShow;
        }
        public void PrintResult(string RText)
        {
            string dateLog = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                rTBResult.Text += dateLog + "----> " + RText;
                //rTBResult.Text += RText;
                rTBResult.Text += Environment.NewLine;
            }
            catch
            {
                rTBResult.Text = "-";
            }
        }
        public void logError(string Texts)
        {
            string pathApp = Application.StartupPath;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string timeStemp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Clipboard.SetDataObject(Date +"---->"+ Texts);

            string subdir = pathApp + "\\Log_Error\\" + Date;

            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            try
            {
                File.AppendAllText(subdir + "\\" + "Error_" + Date + ".txt", timeStemp + "--->" + Texts + Environment.NewLine);
            }
            catch
            {
                PrintResult("Can't export file.");
            }
        }
        private void timerSQL_Tick(object sender, EventArgs e)
        {
            if (bgWorkerWIP.IsBusy != true)
            {
                rTBResult.Text = ("");
                bgWorkerWIP.RunWorkerAsync();
            }
        }
        private void BtStart_Click(object sender, EventArgs e)
        {
            if (bgWorkerWIP.IsBusy != true)
            {
                bgWorkerWIP.RunWorkerAsync();
            }
            lbResult.Text = "Application Start...";
            this.timerSQL.Enabled = true;
        }
        private void BtStop_Click(object sender, EventArgs e)
        {
            this.timerSQL.Enabled = false;
            lbResult.Text = "Application Stop...";
        }
        private void BtExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void bgWorkerWIP_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                LogPensToneExcel();
            }
            catch
            {
                PrintResult("App error : " + "Error");
            }
        }
        private void bgWorkerWIP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rBCurrent.Checked = true;
            PrintResult("Finish...");
            getDate();
        }

        private void LogPensToneExcel()
        {
            rTBResult.Text = "";
            PrintResult("Running...");
            lbResult.Text = "Running...";
            lbResult.BackColor = Color.Red;

            string datelog = DateTime.Now.ToString("M-d-yyyy").ToString();

            var appSettings = ConfigurationManager.AppSettings;
            string pahtFileLog = appSettings.Get("pahtFileLog");
            string backupDir = pahtFileLog + "\\BackUp";
            string MC = appSettings.Get("MC");
            string CUS = appSettings.Get("CUS");
            string lineHeader = appSettings.Get("lineHeader");

            try
            {
                if (!Directory.Exists(backupDir))
                {
                    DirectoryInfo dir = Directory.CreateDirectory(backupDir);
                    PrintResult("Path : Create succress.");
                }
            }
            catch (Exception e)
            {
                PrintResult("Path : Check error ");
                logError(e.ToString());
            }

            string[] txtList = Directory.GetFiles(pahtFileLog, "*" + datelog + ".csv");
            string[] txtListBK = Directory.GetFiles(pahtFileLog + "\\BackUp", "*" + datelog + ".csv");

            try
            {
                foreach (string f in txtListBK)
                {
                    File.Delete(f);
                }

                foreach (string f in txtList)
                {
                    // Remove path from the file name.
                    string vFName = f.Substring(pahtFileLog.Length);

                    try
                    {
                        // Will not overwrite if the destination file already exists.
                        File.Copy(Path.Combine(pahtFileLog, vFName), Path.Combine(pahtFileLog + "\\BackUp", vFName));
                        PrintResult("File copy: Success ");
                    }
                    // Catch exception if the file was already copied.
                    catch (IOException copyError)
                    {
                        PrintResult("File copy: Error" + copyError);
                        logError(copyError.ToString());
                    }
                }
            }
            catch
            {
                PrintResult("File : Not Found.");
            }


            if (txtListBK.Length > 0)
            {
                foreach (string sfBK in txtListBK)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(File.OpenRead(sfBK)))
                        {
                            List<string> lines = new List<string>();
                            List<string> vDate = new List<string>();
                            List<string> vTime = new List<string>();
                            List<string> vModel = new List<string>();
                            List<string> vBar01 = new List<string>();
                            List<string> vRes01 = new List<string>();
                            List<string> vBar02 = new List<string>();
                            List<string> vRes02 = new List<string>();
                            List<string> vBar03 = new List<string>();
                            List<string> vRes03 = new List<string>();
                            List<string> vBar04 = new List<string>();
                            List<string> vRes04 = new List<string>();
                            List<string> vBar05 = new List<string>();
                            List<string> vRes05 = new List<string>();
                            List<string> vBar06 = new List<string>();
                            List<string> vRes06 = new List<string>();
                            List<string> vBar07 = new List<string>();
                            List<string> vRes07 = new List<string>();
                            List<string> vBar08 = new List<string>();
                            List<string> vRes08 = new List<string>();
                            List<string> vBar09 = new List<string>();
                            List<string> vRes09 = new List<string>();
                            List<string> vBar10 = new List<string>();
                            List<string> vRes10 = new List<string>();

                            int C = 0;
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();

                                if (!String.IsNullOrWhiteSpace(line))
                                {
                                    string[] values = line.Split(',');

                                    vDate.Add(values[2]);
                                    vTime.Add(values[3]);
                                    vBar01.Add(values[5]);
                                    vRes01.Add(values[9]);
                                    vBar02.Add(values[6]);
                                    vRes02.Add(values[10]);
                                }
                                C++;

                            }

                            string[] vInsDate = vDate.ToArray();
                            string[] vInsTime = vTime.ToArray();

                            int cStart;
                            string fName = sfBK.Substring(backupDir.Length + 1);

                            if (rBLast10Rows.Checked)
                            {
                                cStart = (C - 10) < 0 ? Int32.Parse(lineHeader) : (C - 10);
                            }
                            else if (rBAll.Checked)
                            {
                                cStart = Int32.Parse(lineHeader);
                            }
                            else
                            {
                                cStart = (C - 5) < 0 ? Int32.Parse(lineHeader) : (C - 5);
                            }

                            PrintResult("Read File: " + fName);
                            PrintResult("Total row: " + C + " rows");
                            PrintResult("Strat check row is: " + cStart);

                            int i;
                            int RSts01 = 0, RSts02 = 0;
                            int Sts01 = 0, Sts02 = 0;
                            for (i = cStart; i < C; i++)
                            {
                                string vlogdates = vInsDate[i] + " " + vInsTime[i];
                                DateTime vDates = Convert.ToDateTime(vlogdates);
                                string vlogdate = vDates.ToString("yyyy-MM-dd HH:mm:ss");
                                //string vInsModel = 

                                //PrintResult(vTestDate.ToString());
                                if (vBar01[i] != "")
                                {
                                    //PrintResult(vBar01[i].Substring(0, 6) + " " + vBar01[i] + " " + vlogdate + " " + vRes01[i] + " " + MC + " " + CUS);
                                    string vResult01 = ConDB.MAIN_INS_FCT_LOG(vBar01[i].Substring(0,6), vBar01[i], vlogdate, vRes01[i], MC, CUS);

                                    if (vResult01 == "1")
                                    {
                                        RSts01++;
                                    }
                                    else
                                    {
                                        Sts01++;
                                    }
                                }

                                if (vBar02[i] != "")
                                {
                                    //PrintResult(vInsModel[3] + " " + vBar02[i] + " " + vlogdate + " " + vRes02[i] + " " + MC + " " + CUS);
                                    string vResult02 = ConDB.MAIN_INS_FCT_LOG(vBar02[i].Substring(0, 6), vBar02[i], vlogdate, vRes02[i], MC, CUS);

                                    if (vResult02 == "1")
                                    {
                                        RSts02++;
                                    }
                                    else
                                    {
                                        Sts02++;
                                    }
                                }
                                int vi = ((i + 1) * 100) / C;
                                lbRows.Text = vi.ToString() + "%";
                            }
                            int vTotalOK = RSts01 + RSts02;
                            int vTotalNG = Sts01 + Sts02;

                            PrintResult("Success: " + vTotalOK + " rows " + "Error: " + vTotalNG + " rows ");
                            PrintResult("<-----------------------------End---------------------------------->");

                        }
                    }
                    catch (Exception e)
                    {
                        PrintResult("Error : " + e);
                    }
                }
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            lbPW.Show();
            tBPW.Show();
            string passWord = tBPW.Text;

            if (passWord == "siix@admin" & bgWorkerWIP.IsBusy != true)
            {
                e.Cancel = false;
            }
            else
            {
                tBPW.Focus();
                e.Cancel = true;
            }
        }
    }
}