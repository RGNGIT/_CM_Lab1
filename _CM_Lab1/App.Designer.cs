namespace _CM_Lab1
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxBis = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxEpsilon = new System.Windows.Forms.ComboBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.listBoxNewton = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxChord = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxSimple = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxBis);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Метод биссекций";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxBis
            // 
            this.listBoxBis.FormattingEnabled = true;
            this.listBoxBis.Location = new System.Drawing.Point(6, 6);
            this.listBoxBis.Name = "listBoxBis";
            this.listBoxBis.Size = new System.Drawing.Size(406, 355);
            this.listBoxBis.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxNewton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Метод Ньютона";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(444, 34);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(420, 400);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // comboBoxEpsilon
            // 
            this.comboBoxEpsilon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEpsilon.FormattingEnabled = true;
            this.comboBoxEpsilon.Items.AddRange(new object[] {
            "0,001",
            "0,0001",
            "0,00001",
            "0,000001",
            "0,0000001",
            "0,00000001"});
            this.comboBoxEpsilon.Location = new System.Drawing.Point(12, 413);
            this.comboBoxEpsilon.Name = "comboBoxEpsilon";
            this.comboBoxEpsilon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEpsilon.TabIndex = 2;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(139, 414);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(245, 414);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(351, 412);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(87, 23);
            this.buttonAction.TabIndex = 5;
            this.buttonAction.Text = "Поехали";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // listBoxNewton
            // 
            this.listBoxNewton.FormattingEnabled = true;
            this.listBoxNewton.Location = new System.Drawing.Point(6, 6);
            this.listBoxNewton.Name = "listBoxNewton";
            this.listBoxNewton.Size = new System.Drawing.Size(406, 355);
            this.listBoxNewton.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxChord);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(418, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Метод Хорд";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxChord
            // 
            this.listBoxChord.FormattingEnabled = true;
            this.listBoxChord.Location = new System.Drawing.Point(6, 6);
            this.listBoxChord.Name = "listBoxChord";
            this.listBoxChord.Size = new System.Drawing.Size(406, 355);
            this.listBoxChord.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxSimple);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(418, 369);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Метод Простых Итераций";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxSimple
            // 
            this.listBoxSimple.FormattingEnabled = true;
            this.listBoxSimple.Location = new System.Drawing.Point(6, 6);
            this.listBoxSimple.Name = "listBoxSimple";
            this.listBoxSimple.Size = new System.Drawing.Size(406, 355);
            this.listBoxSimple.TabIndex = 3;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.comboBoxEpsilon);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "App";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public System.Windows.Forms.ComboBox comboBoxEpsilon;
        public System.Windows.Forms.TextBox textBoxA;
        public System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonAction;
        public System.Windows.Forms.ListBox listBoxBis;
        public System.Windows.Forms.ListBox listBoxNewton;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.ListBox listBoxChord;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.ListBox listBoxSimple;
    }
}

