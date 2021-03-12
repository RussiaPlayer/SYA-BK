namespace Tastenabfrage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tastenabfrage IOW 28";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p1.Location = new System.Drawing.Point(70, 283);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(117, 100);
            this.p1.TabIndex = 2;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p2.Location = new System.Drawing.Point(214, 283);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(117, 100);
            this.p2.TabIndex = 3;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p3.Location = new System.Drawing.Point(357, 283);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(117, 100);
            this.p3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p3;
    }
}

