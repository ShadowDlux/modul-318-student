﻿namespace Transport_App
{
    partial class mainForm
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanelMidRight = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisableDestination = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.layoutPanelMidLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.layoutPanelTopRight = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.layoutPanelTopLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblDepart = new System.Windows.Forms.Label();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchConncections = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchMapDepart = new System.Windows.Forms.Button();
            this.btnSearchMapDestination = new System.Windows.Forms.Button();
            this.dataGridViewConnection = new System.Windows.Forms.DataGridView();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLayoutPanel.SuspendLayout();
            this.layoutPanelMidRight.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.layoutPanelMidLeft.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.layoutPanelTopRight.SuspendLayout();
            this.layoutPanelTopLeft.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Controls.Add(this.layoutPanelMidRight, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.layoutPanelMidLeft, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.layoutPanelTopRight, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.layoutPanelTopLeft, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(807, 150);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // layoutPanelMidRight
            // 
            this.layoutPanelMidRight.ColumnCount = 1;
            this.layoutPanelMidRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelMidRight.Controls.Add(this.lblDisableDestination, 0, 0);
            this.layoutPanelMidRight.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.layoutPanelMidRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMidRight.Location = new System.Drawing.Point(403, 60);
            this.layoutPanelMidRight.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanelMidRight.Name = "layoutPanelMidRight";
            this.layoutPanelMidRight.RowCount = 2;
            this.layoutPanelMidRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMidRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMidRight.Size = new System.Drawing.Size(404, 60);
            this.layoutPanelMidRight.TabIndex = 3;
            // 
            // lblDisableDestination
            // 
            this.lblDisableDestination.AutoSize = true;
            this.lblDisableDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisableDestination.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisableDestination.Location = new System.Drawing.Point(3, 0);
            this.lblDisableDestination.Name = "lblDisableDestination";
            this.lblDisableDestination.Size = new System.Drawing.Size(398, 30);
            this.lblDisableDestination.TabIndex = 1;
            this.lblDisableDestination.Text = "Disable Destination:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.rBtnYes, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rBtnNo, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(404, 30);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBtnYes.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnYes.Location = new System.Drawing.Point(3, 3);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(196, 24);
            this.rBtnYes.TabIndex = 5;
            this.rBtnYes.TabStop = true;
            this.rBtnYes.Text = "Yes";
            this.rBtnYes.UseVisualStyleBackColor = true;
            this.rBtnYes.CheckedChanged += new System.EventHandler(this.rBtnYes_CheckedChanged);
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Checked = true;
            this.rBtnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBtnNo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnNo.Location = new System.Drawing.Point(205, 3);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(196, 24);
            this.rBtnNo.TabIndex = 6;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "No";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // layoutPanelMidLeft
            // 
            this.layoutPanelMidLeft.ColumnCount = 1;
            this.layoutPanelMidLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanelMidLeft.Controls.Add(this.lblDateTime, 0, 0);
            this.layoutPanelMidLeft.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.layoutPanelMidLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMidLeft.Location = new System.Drawing.Point(0, 60);
            this.layoutPanelMidLeft.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanelMidLeft.Name = "layoutPanelMidLeft";
            this.layoutPanelMidLeft.RowCount = 2;
            this.layoutPanelMidLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMidLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelMidLeft.Size = new System.Drawing.Size(403, 60);
            this.layoutPanelMidLeft.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateTime.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(3, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(397, 30);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Date / Time:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.datePicker, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.timePicker, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(403, 30);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "";
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(3, 3);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(195, 24);
            this.datePicker.TabIndex = 3;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timePicker.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(204, 3);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(196, 24);
            this.timePicker.TabIndex = 4;
            // 
            // layoutPanelTopRight
            // 
            this.layoutPanelTopRight.ColumnCount = 1;
            this.layoutPanelTopRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelTopRight.Controls.Add(this.comboBoxDestination, 0, 1);
            this.layoutPanelTopRight.Controls.Add(this.lblDestination, 0, 0);
            this.layoutPanelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelTopRight.Location = new System.Drawing.Point(403, 0);
            this.layoutPanelTopRight.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanelTopRight.Name = "layoutPanelTopRight";
            this.layoutPanelTopRight.RowCount = 2;
            this.layoutPanelTopRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelTopRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelTopRight.Size = new System.Drawing.Size(404, 60);
            this.layoutPanelTopRight.TabIndex = 1;
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDestination.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(3, 33);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(398, 25);
            this.comboBoxDestination.TabIndex = 2;
            this.comboBoxDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxDestination_KeyDown);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDestination.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(3, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(398, 30);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination:";
            // 
            // layoutPanelTopLeft
            // 
            this.layoutPanelTopLeft.ColumnCount = 1;
            this.layoutPanelTopLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelTopLeft.Controls.Add(this.lblDepart, 0, 0);
            this.layoutPanelTopLeft.Controls.Add(this.comboBoxDepart, 0, 1);
            this.layoutPanelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.layoutPanelTopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanelTopLeft.Name = "layoutPanelTopLeft";
            this.layoutPanelTopLeft.RowCount = 2;
            this.layoutPanelTopLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelTopLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanelTopLeft.Size = new System.Drawing.Size(403, 60);
            this.layoutPanelTopLeft.TabIndex = 0;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepart.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(3, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(397, 30);
            this.lblDepart.TabIndex = 0;
            this.lblDepart.Text = "Depart:";
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDepart.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Location = new System.Drawing.Point(3, 33);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(397, 25);
            this.comboBoxDepart.TabIndex = 1;
            this.comboBoxDepart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxDepart_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearchConncections, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSwitch, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnSearchConncections
            // 
            this.btnSearchConncections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchConncections.Location = new System.Drawing.Point(201, 0);
            this.btnSearchConncections.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchConncections.Name = "btnSearchConncections";
            this.btnSearchConncections.Size = new System.Drawing.Size(202, 30);
            this.btnSearchConncections.TabIndex = 8;
            this.btnSearchConncections.Text = "Search Connections";
            this.btnSearchConncections.UseVisualStyleBackColor = true;
            this.btnSearchConncections.Click += new System.EventHandler(this.btnSearchConncections_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwitch.Location = new System.Drawing.Point(0, 0);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(201, 30);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.Text = "Switch Depart with Destination";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearchMapDepart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearchMapDestination, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 120);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 30);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSearchMapDepart
            // 
            this.btnSearchMapDepart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchMapDepart.Location = new System.Drawing.Point(0, 0);
            this.btnSearchMapDepart.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchMapDepart.Name = "btnSearchMapDepart";
            this.btnSearchMapDepart.Size = new System.Drawing.Size(202, 30);
            this.btnSearchMapDepart.TabIndex = 9;
            this.btnSearchMapDepart.Text = "Search Depart";
            this.btnSearchMapDepart.UseVisualStyleBackColor = true;
            this.btnSearchMapDepart.Click += new System.EventHandler(this.btnSearchMapDepart_Click);
            // 
            // btnSearchMapDestination
            // 
            this.btnSearchMapDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchMapDestination.Location = new System.Drawing.Point(202, 0);
            this.btnSearchMapDestination.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchMapDestination.Name = "btnSearchMapDestination";
            this.btnSearchMapDestination.Size = new System.Drawing.Size(202, 30);
            this.btnSearchMapDestination.TabIndex = 10;
            this.btnSearchMapDestination.Text = "Search Destination";
            this.btnSearchMapDestination.UseVisualStyleBackColor = true;
            this.btnSearchMapDestination.Click += new System.EventHandler(this.btnSearchMapDestination_Click);
            // 
            // dataGridViewConnection
            // 
            this.dataGridViewConnection.AllowUserToAddRows = false;
            this.dataGridViewConnection.AllowUserToDeleteRows = false;
            this.dataGridViewConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depart,
            this.vehicleName,
            this.TrackDepart,
            this.Destination,
            this.TrackDestination,
            this.Start,
            this.Arrival,
            this.Duration});
            this.dataGridViewConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConnection.Location = new System.Drawing.Point(0, 150);
            this.dataGridViewConnection.Name = "dataGridViewConnection";
            this.dataGridViewConnection.ReadOnly = true;
            this.dataGridViewConnection.Size = new System.Drawing.Size(807, 336);
            this.dataGridViewConnection.TabIndex = 0;
            this.dataGridViewConnection.TabStop = false;
            // 
            // Depart
            // 
            this.Depart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Depart.HeaderText = "Depart";
            this.Depart.MinimumWidth = 30;
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            // 
            // vehicleName
            // 
            this.vehicleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vehicleName.HeaderText = "Vehicle Name";
            this.vehicleName.Name = "vehicleName";
            this.vehicleName.ReadOnly = true;
            this.vehicleName.Width = 98;
            // 
            // TrackDepart
            // 
            this.TrackDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrackDepart.HeaderText = "Track";
            this.TrackDepart.Name = "TrackDepart";
            this.TrackDepart.ReadOnly = true;
            this.TrackDepart.Width = 60;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 30;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // TrackDestination
            // 
            this.TrackDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrackDestination.HeaderText = "Track";
            this.TrackDestination.Name = "TrackDestination";
            this.TrackDestination.ReadOnly = true;
            this.TrackDestination.Width = 60;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 54;
            // 
            // Arrival
            // 
            this.Arrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 61;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 72;
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnSearchConncections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 486);
            this.Controls.Add(this.dataGridViewConnection);
            this.Controls.Add(this.mainLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(660, 320);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transport App";
            this.mainLayoutPanel.ResumeLayout(false);
            this.layoutPanelMidRight.ResumeLayout(false);
            this.layoutPanelMidRight.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.layoutPanelMidLeft.ResumeLayout(false);
            this.layoutPanelMidLeft.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.layoutPanelTopRight.ResumeLayout(false);
            this.layoutPanelTopRight.PerformLayout();
            this.layoutPanelTopLeft.ResumeLayout(false);
            this.layoutPanelTopLeft.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanelMidRight;
        private System.Windows.Forms.Label lblDisableDestination;
        private System.Windows.Forms.TableLayoutPanel layoutPanelMidLeft;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TableLayoutPanel layoutPanelTopRight;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TableLayoutPanel layoutPanelTopLeft;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridView dataGridViewConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSearchConncections;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnSearchMapDestination;
        private System.Windows.Forms.Button btnSearchMapDepart;
    }
}

