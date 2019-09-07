namespace Bazen
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
            this.tbTim1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTim2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTim3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTim4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.btnBoja1 = new System.Windows.Forms.Button();
            this.btnBoja2 = new System.Windows.Forms.Button();
            this.btnBoja3 = new System.Windows.Forms.Button();
            this.btnBoja4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTim1
            // 
            this.tbTim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTim1.Location = new System.Drawing.Point(117, 63);
            this.tbTim1.Name = "tbTim1";
            this.tbTim1.Size = new System.Drawing.Size(187, 26);
            this.tbTim1.TabIndex = 0;
            this.tbTim1.Text = "Crveni Tim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIM 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timovi";
            // 
            // tbTim2
            // 
            this.tbTim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTim2.Location = new System.Drawing.Point(117, 95);
            this.tbTim2.Name = "tbTim2";
            this.tbTim2.Size = new System.Drawing.Size(187, 26);
            this.tbTim2.TabIndex = 0;
            this.tbTim2.Text = "Zuti Tim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TIM 2:";
            // 
            // tbTim3
            // 
            this.tbTim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTim3.Location = new System.Drawing.Point(117, 127);
            this.tbTim3.Name = "tbTim3";
            this.tbTim3.Size = new System.Drawing.Size(187, 26);
            this.tbTim3.TabIndex = 0;
            this.tbTim3.Text = "Zeleni Tim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TIM 3:";
            // 
            // tbTim4
            // 
            this.tbTim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTim4.Location = new System.Drawing.Point(117, 159);
            this.tbTim4.Name = "tbTim4";
            this.tbTim4.Size = new System.Drawing.Size(187, 26);
            this.tbTim4.TabIndex = 0;
            this.tbTim4.Text = "Ljubicasti Tim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TIM 4:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pokreni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBoja1
            // 
            this.btnBoja1.BackColor = System.Drawing.Color.Red;
            this.btnBoja1.Location = new System.Drawing.Point(310, 63);
            this.btnBoja1.Name = "btnBoja1";
            this.btnBoja1.Size = new System.Drawing.Size(26, 26);
            this.btnBoja1.TabIndex = 4;
            this.btnBoja1.UseVisualStyleBackColor = false;
            this.btnBoja1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoja2
            // 
            this.btnBoja2.BackColor = System.Drawing.Color.Yellow;
            this.btnBoja2.Location = new System.Drawing.Point(310, 95);
            this.btnBoja2.Name = "btnBoja2";
            this.btnBoja2.Size = new System.Drawing.Size(26, 26);
            this.btnBoja2.TabIndex = 4;
            this.btnBoja2.UseVisualStyleBackColor = false;
            this.btnBoja2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoja3
            // 
            this.btnBoja3.BackColor = System.Drawing.Color.Lime;
            this.btnBoja3.Location = new System.Drawing.Point(310, 127);
            this.btnBoja3.Name = "btnBoja3";
            this.btnBoja3.Size = new System.Drawing.Size(26, 26);
            this.btnBoja3.TabIndex = 4;
            this.btnBoja3.UseVisualStyleBackColor = false;
            this.btnBoja3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBoja4
            // 
            this.btnBoja4.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBoja4.Location = new System.Drawing.Point(310, 159);
            this.btnBoja4.Name = "btnBoja4";
            this.btnBoja4.Size = new System.Drawing.Size(26, 26);
            this.btnBoja4.TabIndex = 4;
            this.btnBoja4.UseVisualStyleBackColor = false;
            this.btnBoja4.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 283);
            this.Controls.Add(this.btnBoja4);
            this.Controls.Add(this.btnBoja3);
            this.Controls.Add(this.btnBoja2);
            this.Controls.Add(this.btnBoja1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTim4);
            this.Controls.Add(this.tbTim3);
            this.Controls.Add(this.tbTim2);
            this.Controls.Add(this.tbTim1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTim1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTim2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTim3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTim4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button btnBoja1;
        private System.Windows.Forms.Button btnBoja2;
        private System.Windows.Forms.Button btnBoja3;
        private System.Windows.Forms.Button btnBoja4;
    }
}

