namespace LOG_VNTEC_FCT
{
    partial class Main
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label3 = new System.Windows.Forms.Label();
            this.lbPW = new System.Windows.Forms.Label();
            this.tBPW = new System.Windows.Forms.TextBox();
            this.rBLast10Rows = new System.Windows.Forms.RadioButton();
            this.rBCurrent = new System.Windows.Forms.RadioButton();
            this.rBAll = new System.Windows.Forms.RadioButton();
            this.lbDate = new System.Windows.Forms.Label();
            this.bgWorkerWIP = new System.ComponentModel.BackgroundWorker();
            this.timerSQL = new System.Windows.Forms.Timer(this.components);
            this.lbRows = new System.Windows.Forms.Label();
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbServer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNamePath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Rows Count :";
            // 
            // lbPW
            // 
            this.lbPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPW.AutoSize = true;
            this.lbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPW.Location = new System.Drawing.Point(581, 8);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(51, 20);
            this.lbPW.TabIndex = 111;
            this.lbPW.Text = "P/W :";
            // 
            // tBPW
            // 
            this.tBPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPW.Location = new System.Drawing.Point(638, 8);
            this.tBPW.Name = "tBPW";
            this.tBPW.Size = new System.Drawing.Size(117, 20);
            this.tBPW.TabIndex = 110;
            // 
            // rBLast10Rows
            // 
            this.rBLast10Rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBLast10Rows.AutoSize = true;
            this.rBLast10Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBLast10Rows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rBLast10Rows.Location = new System.Drawing.Point(588, 168);
            this.rBLast10Rows.Name = "rBLast10Rows";
            this.rBLast10Rows.Size = new System.Drawing.Size(111, 20);
            this.rBLast10Rows.TabIndex = 109;
            this.rBLast10Rows.TabStop = true;
            this.rBLast10Rows.Text = "Last 10 rows";
            this.rBLast10Rows.UseVisualStyleBackColor = true;
            // 
            // rBCurrent
            // 
            this.rBCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBCurrent.AutoSize = true;
            this.rBCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBCurrent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rBCurrent.Location = new System.Drawing.Point(589, 142);
            this.rBCurrent.Name = "rBCurrent";
            this.rBCurrent.Size = new System.Drawing.Size(103, 20);
            this.rBCurrent.TabIndex = 108;
            this.rBCurrent.TabStop = true;
            this.rBCurrent.Text = "Last 5 rows";
            this.rBCurrent.UseVisualStyleBackColor = true;
            // 
            // rBAll
            // 
            this.rBAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rBAll.AutoSize = true;
            this.rBAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rBAll.Location = new System.Drawing.Point(588, 116);
            this.rBAll.Name = "rBAll";
            this.rBAll.Size = new System.Drawing.Size(69, 20);
            this.rBAll.TabIndex = 107;
            this.rBAll.TabStop = true;
            this.rBAll.Text = "All file";
            this.rBAll.UseVisualStyleBackColor = true;
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDate.Location = new System.Drawing.Point(585, 48);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(48, 20);
            this.lbDate.TabIndex = 106;
            this.lbDate.Text = "Date";
            // 
            // bgWorkerWIP
            // 
            this.bgWorkerWIP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerWIP_DoWork);
            this.bgWorkerWIP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerWIP_RunWorkerCompleted);
            // 
            // timerSQL
            // 
            this.timerSQL.Tick += new System.EventHandler(this.timerSQL_Tick);
            // 
            // lbRows
            // 
            this.lbRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRows.AutoSize = true;
            this.lbRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRows.Location = new System.Drawing.Point(100, 228);
            this.lbRows.Name = "lbRows";
            this.lbRows.Size = new System.Drawing.Size(14, 13);
            this.lbRows.TabIndex = 112;
            this.lbRows.Text = "0";
            // 
            // rTBResult
            // 
            this.rTBResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResult.Location = new System.Drawing.Point(14, 71);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.Size = new System.Drawing.Size(568, 154);
            this.rTBResult.TabIndex = 105;
            this.rTBResult.Text = "";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(541, 232);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(213, 9);
            label1.TabIndex = 103;
            label1.Text = "Copyright© 2019 SIIX EMS (Thailand) CO.,LTD.";
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.BackColor = System.Drawing.Color.Green;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStart.Location = new System.Drawing.Point(588, 71);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(80, 39);
            this.btStart.TabIndex = 101;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.BackColor = System.Drawing.Color.Red;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStop.Location = new System.Drawing.Point(674, 71);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(80, 39);
            this.btStop.TabIndex = 102;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Location = new System.Drawing.Point(588, 194);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(166, 31);
            this.btExit.TabIndex = 104;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbServer.Location = new System.Drawing.Point(87, 11);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(14, 17);
            this.lbServer.TabIndex = 100;
            this.lbServer.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "Server:";
            // 
            // lbNamePath
            // 
            this.lbNamePath.AutoSize = true;
            this.lbNamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNamePath.Location = new System.Drawing.Point(87, 28);
            this.lbNamePath.Name = "lbNamePath";
            this.lbNamePath.Size = new System.Drawing.Size(15, 20);
            this.lbNamePath.TabIndex = 98;
            this.lbNamePath.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(30, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Path:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbResult.Location = new System.Drawing.Point(83, 48);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(34, 20);
            this.lbResult.TabIndex = 95;
            this.lbResult.Text = ".....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Result:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(766, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.tBPW);
            this.Controls.Add(this.rBLast10Rows);
            this.Controls.Add(this.rBCurrent);
            this.Controls.Add(this.rBAll);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbRows);
            this.Controls.Add(this.rTBResult);
            this.Controls.Add(label1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNamePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "STBL Function VNTEC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.TextBox tBPW;
        private System.Windows.Forms.RadioButton rBLast10Rows;
        private System.Windows.Forms.RadioButton rBCurrent;
        private System.Windows.Forms.RadioButton rBAll;
        private System.Windows.Forms.Label lbDate;
        private System.ComponentModel.BackgroundWorker bgWorkerWIP;
        private System.Windows.Forms.Timer timerSQL;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.RichTextBox rTBResult;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNamePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label2;
    }
}

