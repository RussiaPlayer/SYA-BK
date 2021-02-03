namespace StopUhr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBT
            // 
            this.startBT.BackColor = System.Drawing.Color.Transparent;
            this.startBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBT.Location = new System.Drawing.Point(12, 124);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(146, 35);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = false;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.BackColor = System.Drawing.Color.Transparent;
            this.stopBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stopBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBT.Location = new System.Drawing.Point(164, 124);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(146, 35);
            this.stopBT.TabIndex = 1;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = false;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "00 Stunden, 00 Minuten, 00 Sekunden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stop Uhr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.Button stopBT;
        private System.Windows.Forms.Label label1;
    }
}

