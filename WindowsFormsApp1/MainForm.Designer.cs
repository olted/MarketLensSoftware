
namespace MarketLensSoftware
{
    partial class MainForm
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.DataTypeDropDownBox = new System.Windows.Forms.ComboBox();
            this.SymbolTextBox = new System.Windows.Forms.TextBox();
            this.StartDateTextBox = new System.Windows.Forms.TextBox();
            this.EndDateTextBox = new System.Windows.Forms.TextBox();
            this.ParameterSearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.DataTypeLabel = new System.Windows.Forms.Label();
            this.SymbolLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.YTDPBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NDPBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SDPBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TDPBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeriesSelectLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SeriesSelectDropDown = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.currenttimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cartesianChart1.Location = new System.Drawing.Point(425, 190);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1070, 651);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // DataTypeDropDownBox
            // 
            this.DataTypeDropDownBox.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTypeDropDownBox.FormattingEnabled = true;
            this.DataTypeDropDownBox.Items.AddRange(new object[] {
            "Open Prices",
            "Close Prices",
            "Daily Highs",
            "Daily Lows"});
            this.DataTypeDropDownBox.Location = new System.Drawing.Point(19, 267);
            this.DataTypeDropDownBox.Name = "DataTypeDropDownBox";
            this.DataTypeDropDownBox.Size = new System.Drawing.Size(207, 30);
            this.DataTypeDropDownBox.TabIndex = 2;
            this.DataTypeDropDownBox.SelectedIndexChanged += new System.EventHandler(this.DDBoxCat_SelectedIndexChanged);
            // 
            // SymbolTextBox
            // 
            this.SymbolTextBox.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolTextBox.Location = new System.Drawing.Point(19, 158);
            this.SymbolTextBox.MaximumSize = new System.Drawing.Size(500, 500);
            this.SymbolTextBox.Name = "SymbolTextBox";
            this.SymbolTextBox.Size = new System.Drawing.Size(207, 29);
            this.SymbolTextBox.TabIndex = 3;
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartDateTextBox.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.StartDateTextBox.Location = new System.Drawing.Point(19, 393);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.Size = new System.Drawing.Size(207, 29);
            this.StartDateTextBox.TabIndex = 4;
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.EndDateTextBox.Location = new System.Drawing.Point(19, 507);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.Size = new System.Drawing.Size(207, 29);
            this.EndDateTextBox.TabIndex = 5;
            // 
            // ParameterSearchButton
            // 
            this.ParameterSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ParameterSearchButton.Font = new System.Drawing.Font("Rockwell Nova", 18F);
            this.ParameterSearchButton.Location = new System.Drawing.Point(71, 641);
            this.ParameterSearchButton.Name = "ParameterSearchButton";
            this.ParameterSearchButton.Size = new System.Drawing.Size(127, 54);
            this.ParameterSearchButton.TabIndex = 6;
            this.ParameterSearchButton.Text = "Search";
            this.ParameterSearchButton.UseVisualStyleBackColor = false;
            this.ParameterSearchButton.Click += new System.EventHandler(this.GoButtonClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.EndDateLabel);
            this.panel1.Controls.Add(this.StartDateLabel);
            this.panel1.Controls.Add(this.DataTypeLabel);
            this.panel1.Controls.Add(this.SymbolLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EndDateTextBox);
            this.panel1.Controls.Add(this.DataTypeDropDownBox);
            this.panel1.Controls.Add(this.ParameterSearchButton);
            this.panel1.Controls.Add(this.SymbolTextBox);
            this.panel1.Controls.Add(this.StartDateTextBox);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1537, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 730);
            this.panel1.TabIndex = 7;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(14, 452);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(99, 25);
            this.EndDateLabel.TabIndex = 11;
            this.EndDateLabel.Text = "End Date";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(14, 343);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(104, 25);
            this.StartDateLabel.TabIndex = 10;
            this.StartDateLabel.Text = "Start Date";
            // 
            // DataTypeLabel
            // 
            this.DataTypeLabel.AutoSize = true;
            this.DataTypeLabel.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTypeLabel.Location = new System.Drawing.Point(14, 221);
            this.DataTypeLabel.Name = "DataTypeLabel";
            this.DataTypeLabel.Size = new System.Drawing.Size(133, 25);
            this.DataTypeLabel.TabIndex = 9;
            this.DataTypeLabel.Text = "Type of Data";
            // 
            // SymbolLabel
            // 
            this.SymbolLabel.AutoSize = true;
            this.SymbolLabel.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolLabel.Location = new System.Drawing.Point(14, 112);
            this.SymbolLabel.Name = "SymbolLabel";
            this.SymbolLabel.Size = new System.Drawing.Size(84, 25);
            this.SymbolLabel.TabIndex = 8;
            this.SymbolLabel.Text = "Symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 18F);
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parameter Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Nova", 48F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(752, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 86);
            this.label4.TabIndex = 12;
            this.label4.Text = "Market Lens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1163, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "TM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.YTDPBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.NDPBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.SDPBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TDPBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SeriesSelectLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.SeriesSelectDropDown);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(27, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 730);
            this.panel2.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Volatility";
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox8.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.textBox8.Location = new System.Drawing.Point(144, 608);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(104, 29);
            this.textBox8.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "YTD Perf";
            // 
            // YTDPBox
            // 
            this.YTDPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YTDPBox.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.YTDPBox.Location = new System.Drawing.Point(144, 548);
            this.YTDPBox.Name = "YTDPBox";
            this.YTDPBox.Size = new System.Drawing.Size(104, 29);
            this.YTDPBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "90-Day Perf";
            // 
            // NDPBox
            // 
            this.NDPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NDPBox.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.NDPBox.Location = new System.Drawing.Point(144, 477);
            this.NDPBox.Name = "NDPBox";
            this.NDPBox.Size = new System.Drawing.Size(104, 29);
            this.NDPBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "60-Day Perf";
            // 
            // SDPBox
            // 
            this.SDPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SDPBox.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.SDPBox.Location = new System.Drawing.Point(144, 408);
            this.SDPBox.Name = "SDPBox";
            this.SDPBox.Size = new System.Drawing.Size(104, 29);
            this.SDPBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "30-Day Perf";
            // 
            // TDPBox
            // 
            this.TDPBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TDPBox.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.TDPBox.Location = new System.Drawing.Point(144, 346);
            this.TDPBox.Name = "TDPBox";
            this.TDPBox.Size = new System.Drawing.Size(104, 29);
            this.TDPBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vol*Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Volume";
            // 
            // SeriesSelectLabel
            // 
            this.SeriesSelectLabel.AutoSize = true;
            this.SeriesSelectLabel.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesSelectLabel.Location = new System.Drawing.Point(3, 78);
            this.SeriesSelectLabel.Name = "SeriesSelectLabel";
            this.SeriesSelectLabel.Size = new System.Drawing.Size(135, 25);
            this.SeriesSelectLabel.TabIndex = 9;
            this.SeriesSelectLabel.Text = "Select Series";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Symbol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell Nova", 18F);
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "Current Display Data";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.textBox1.Location = new System.Drawing.Point(144, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 29);
            this.textBox1.TabIndex = 5;
            // 
            // SeriesSelectDropDown
            // 
            this.SeriesSelectDropDown.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesSelectDropDown.FormattingEnabled = true;
            this.SeriesSelectDropDown.Location = new System.Drawing.Point(144, 78);
            this.SeriesSelectDropDown.Name = "SeriesSelectDropDown";
            this.SeriesSelectDropDown.Size = new System.Drawing.Size(104, 30);
            this.SeriesSelectDropDown.TabIndex = 2;
            this.SeriesSelectDropDown.SelectedIndexChanged += new System.EventHandler(this.SeriesSelectDropDown_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(144, 145);
            this.textBox2.MaximumSize = new System.Drawing.Size(500, 500);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 29);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.textBox3.Location = new System.Drawing.Point(144, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 29);
            this.textBox3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(452, 873);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1013, 139);
            this.panel4.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell Nova", 18F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(349, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(354, 33);
            this.label13.TabIndex = 12;
            this.label13.Text = "Current Display Information";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Rockwell Nova", 20F);
            this.CurrentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(1625, 24);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(180, 36);
            this.CurrentTimeLabel.TabIndex = 16;
            this.CurrentTimeLabel.Text = "current time";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveButton.Font = new System.Drawing.Font("Rockwell Nova", 18F);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.Location = new System.Drawing.Point(108, 896);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 83);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Update";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.UpdateButton_click);
            // 
            // currenttimer
            // 
            this.currenttimer.Enabled = true;
            this.currenttimer.Tick += new System.EventHandler(this.currenttimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Rockwell Nova", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1576, 896);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 83);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1902, 1024);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cartesianChart1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart cartesianChart1;

        private System.Windows.Forms.ComboBox DataTypeDropDownBox;
        private System.Windows.Forms.TextBox SymbolTextBox;
        private System.Windows.Forms.TextBox StartDateTextBox;
        private System.Windows.Forms.TextBox EndDateTextBox;
        private System.Windows.Forms.Button ParameterSearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label DataTypeLabel;
        private System.Windows.Forms.Label SymbolLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SeriesSelectLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox SeriesSelectDropDown;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox YTDPBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NDPBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SDPBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TDPBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Timer currenttimer;
        private System.Windows.Forms.Button button1;
    }
}