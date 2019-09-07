namespace Bazen
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "PAUZA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "NASTAVI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GamePanel);
            this.Name = "Bazen";
            this.Text = "Bazen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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