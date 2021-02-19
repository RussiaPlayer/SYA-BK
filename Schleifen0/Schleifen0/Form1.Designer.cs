namespace Schleifen0
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
            this.kStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fStart = new System.Windows.Forms.Button();
            this.löschen = new System.Windows.Forms.Button();
            this.ende = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kStart
            // 
            this.kStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kStart.FlatAppearance.BorderSize = 0;
            this.kStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kStart.Location = new System.Drawing.Point(16, 59);
            this.kStart.Name = "kStart";
            this.kStart.Size = new System.Drawing.Size(75, 25);
            this.kStart.TabIndex = 3;
            this.kStart.Text = "Start";
            this.kStart.UseVisualStyleBackColor = false;
            this.kStart.Click += new System.EventHandler(this.KStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kopfgesteuerte Schleife";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fußgesteuerte Schleife";
            // 
            // fStart
            // 
            this.fStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fStart.FlatAppearance.BorderSize = 0;
            this.fStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fStart.Location = new System.Drawing.Point(16, 203);
            this.fStart.Name = "fStart";
            this.fStart.Size = new System.Drawing.Size(75, 25);
            this.fStart.TabIndex = 6;
            this.fStart.Text = "Start";
            this.fStart.UseVisualStyleBackColor = false;
            this.fStart.Click += new System.EventHandler(this.FStart_Click);
            // 
            // löschen
            // 
            this.löschen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.löschen.FlatAppearance.BorderSize = 0;
            this.löschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.löschen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.löschen.Location = new System.Drawing.Point(266, 378);
            this.löschen.Name = "löschen";
            this.löschen.Size = new System.Drawing.Size(75, 25);
            this.löschen.TabIndex = 7;
            this.löschen.Text = "Löschen";
            this.löschen.UseVisualStyleBackColor = false;
            this.löschen.Click += new System.EventHandler(this.Löschen_Click);
            // 
            // ende
            // 
            this.ende.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ende.FlatAppearance.BorderSize = 0;
            this.ende.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ende.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ende.Location = new System.Drawing.Point(443, 378);
            this.ende.Name = "ende";
            this.ende.Size = new System.Drawing.Size(75, 25);
            this.ende.TabIndex = 8;
            this.ende.Text = "Ende";
            this.ende.UseVisualStyleBackColor = false;
            this.ende.Click += new System.EventHandler(this.Ende_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(568, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 277);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ende);
            this.Controls.Add(this.löschen);
            this.Controls.Add(this.fStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fStart;
        private System.Windows.Forms.Button löschen;
        private System.Windows.Forms.Button ende;
        private System.Windows.Forms.ListBox listBox1;
    }
}

