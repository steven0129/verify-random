﻿namespace verify_random
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.testCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.smallNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bigNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rndCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // testCount
            // 
            this.testCount.Location = new System.Drawing.Point(119, 16);
            this.testCount.Name = "testCount";
            this.testCount.Size = new System.Drawing.Size(100, 22);
            this.testCount.TabIndex = 0;
            this.testCount.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "單次產生亂數次數";
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(14, 86);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(436, 58);
            this.verifyBtn.TabIndex = 2;
            this.verifyBtn.Text = "開始驗證";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // smallNum
            // 
            this.smallNum.Location = new System.Drawing.Point(13, 58);
            this.smallNum.Name = "smallNum";
            this.smallNum.Size = new System.Drawing.Size(100, 22);
            this.smallNum.TabIndex = 4;
            this.smallNum.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "~";
            // 
            // bigNum
            // 
            this.bigNum.Location = new System.Drawing.Point(137, 58);
            this.bigNum.Name = "bigNum";
            this.bigNum.Size = new System.Drawing.Size(100, 22);
            this.bigNum.TabIndex = 6;
            this.bigNum.Text = "14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "之間產生";
            // 
            // rndCount
            // 
            this.rndCount.Location = new System.Drawing.Point(303, 58);
            this.rndCount.Name = "rndCount";
            this.rndCount.Size = new System.Drawing.Size(100, 22);
            this.rndCount.TabIndex = 8;
            this.rndCount.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "個亂數";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(6, 46);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(754, 116);
            this.flowLayoutPanel.TabIndex = 10;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.chart);
            this.groupBox.Controls.Add(this.total);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.flowLayoutPanel);
            this.groupBox.Location = new System.Drawing.Point(14, 150);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(766, 462);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "結果區";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "總次數:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(56, 18);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(25, 12);
            this.total.TabIndex = 12;
            this.total.Text = "total";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(8, 168);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(752, 288);
            this.chart.TabIndex = 13;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 624);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rndCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bigNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smallNum);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testCount);
            this.Name = "Form1";
            this.Text = "亂數驗證程式";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox smallNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bigNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rndCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}

