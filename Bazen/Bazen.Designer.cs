﻿namespace Bazen
{
    partial class Bazen
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
            this.GamePanel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPauza = new System.Windows.Forms.Button();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTim1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTim2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTim3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTim4 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel.Location = new System.Drawing.Point(12, 95);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(300, 200);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 301);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(299, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnPauza
            // 
            this.btnPauza.Location = new System.Drawing.Point(12, 348);
            this.btnPauza.Name = "btnPauza";
            this.btnPauza.Size = new System.Drawing.Size(299, 41);
            this.btnPauza.TabIndex = 1;
            this.btnPauza.Text = "PAUZA";
            this.btnPauza.UseVisualStyleBackColor = true;
            this.btnPauza.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNastavi
            // 
            this.btnNastavi.Location = new System.Drawing.Point(12, 395);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(299, 41);
            this.btnNastavi.TabIndex = 1;
            this.btnNastavi.Text = "NASTAVI";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tim1:";
            // 
            // lblTim1
            // 
            this.lblTim1.AutoSize = true;
            this.lblTim1.Location = new System.Drawing.Point(67, 19);
            this.lblTim1.Name = "lblTim1";
            this.lblTim1.Size = new System.Drawing.Size(16, 13);
            this.lblTim1.TabIndex = 2;
            this.lblTim1.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tim2:";
            // 
            // lblTim2
            // 
            this.lblTim2.AutoSize = true;
            this.lblTim2.Location = new System.Drawing.Point(213, 19);
            this.lblTim2.Name = "lblTim2";
            this.lblTim2.Size = new System.Drawing.Size(16, 13);
            this.lblTim2.TabIndex = 2;
            this.lblTim2.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tim3:";
            // 
            // lblTim3
            // 
            this.lblTim3.AutoSize = true;
            this.lblTim3.Location = new System.Drawing.Point(67, 43);
            this.lblTim3.Name = "lblTim3";
            this.lblTim3.Size = new System.Drawing.Size(16, 13);
            this.lblTim3.TabIndex = 2;
            this.lblTim3.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tim4:";
            // 
            // lblTim4
            // 
            this.lblTim4.AutoSize = true;
            this.lblTim4.Location = new System.Drawing.Point(213, 43);
            this.lblTim4.Name = "lblTim4";
            this.lblTim4.Size = new System.Drawing.Size(16, 13);
            this.lblTim4.TabIndex = 2;
            this.lblTim4.Text = "---";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 40;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Bazen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 447);
            this.Controls.Add(this.lblTim4);
            this.Controls.Add(this.lblTim2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTim3);
            this.Controls.Add(this.lblTim1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.btnPauza);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.GamePanel);
            this.Name = "Bazen";
            this.Text = "Bazen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPauza;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTim1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTim2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTim3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTim4;
        private System.Windows.Forms.Timer GameTimer;
    }
}