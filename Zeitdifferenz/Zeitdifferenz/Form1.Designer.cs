namespace Zeitdifferenz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.h1 = new System.Windows.Forms.TextBox();
            this.min1 = new System.Windows.Forms.TextBox();
            this.s1 = new System.Windows.Forms.TextBox();
            this.h2 = new System.Windows.Forms.TextBox();
            this.min2 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.h3 = new System.Windows.Forms.TextBox();
            this.min3 = new System.Windows.Forms.TextBox();
            this.s3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // h1
            // 
            this.h1.Location = new System.Drawing.Point(204, 72);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(100, 20);
            this.h1.TabIndex = 2;
            this.h1.Text = "0";
            this.h1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // min1
            // 
            this.min1.Location = new System.Drawing.Point(310, 72);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(100, 20);
            this.min1.TabIndex = 3;
            this.min1.Text = "0";
            this.min1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(416, 72);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(100, 20);
            this.s1.TabIndex = 4;
            this.s1.Text = "0";
            this.s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberWithDecimal);
            // 
            // h2
            // 
            this.h2.Location = new System.Drawing.Point(204, 99);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(100, 20);
            this.h2.TabIndex = 5;
            this.h2.Text = "0";
            this.h2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // min2
            // 
            this.min2.Location = new System.Drawing.Point(310, 99);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(100, 20);
            this.min2.TabIndex = 6;
            this.min2.Text = "0";
            this.min2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(416, 99);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(100, 20);
            this.s2.TabIndex = 7;
            this.s2.Text = "0";
            this.s2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumberWithDecimal);
            // 
            // h3
            // 
            this.h3.Location = new System.Drawing.Point(204, 148);
            this.h3.Name = "h3";
            this.h3.ReadOnly = true;
            this.h3.Size = new System.Drawing.Size(100, 20);
            this.h3.TabIndex = 8;
            this.h3.Text = "0";
            // 
            // min3
            // 
            this.min3.Location = new System.Drawing.Point(310, 148);
            this.min3.Name = "min3";
            this.min3.ReadOnly = true;
            this.min3.Size = new System.Drawing.Size(100, 20);
            this.min3.TabIndex = 9;
            this.min3.Text = "0";
            // 
            // s3
            // 
            this.s3.Location = new System.Drawing.Point(416, 148);
            this.s3.Name = "s3";
            this.s3.ReadOnly = true;
            this.s3.Size = new System.Drawing.Size(100, 20);
            this.s3.TabIndex = 10;
            this.s3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zeitpunkt 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zeitpunkt 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Differenz 1-2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 251);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox h1;
        private System.Windows.Forms.TextBox min1;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox h2;
        private System.Windows.Forms.TextBox min2;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox h3;
        private System.Windows.Forms.TextBox min3;
        private System.Windows.Forms.TextBox s3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

