namespace FürTest
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.undByte = new System.Windows.Forms.RadioButton();
            this.orByte = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 140);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "00000000";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 175);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "00000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Byte 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Byte 2";
            // 
            // undByte
            // 
            this.undByte.AutoSize = true;
            this.undByte.Location = new System.Drawing.Point(335, 141);
            this.undByte.Name = "undByte";
            this.undByte.Size = new System.Drawing.Size(69, 17);
            this.undByte.TabIndex = 4;
            this.undByte.TabStop = true;
            this.undByte.Text = "log. UND";
            this.undByte.UseVisualStyleBackColor = true;
            this.undByte.CheckedChanged += new System.EventHandler(this.undByte_CheckedChanged);
            // 
            // orByte
            // 
            this.orByte.AutoSize = true;
            this.orByte.Location = new System.Drawing.Point(335, 176);
            this.orByte.Name = "orByte";
            this.orByte.Size = new System.Drawing.Size(61, 17);
            this.orByte.TabIndex = 5;
            this.orByte.TabStop = true;
            this.orByte.Text = "log. OR";
            this.orByte.UseVisualStyleBackColor = true;
            this.orByte.CheckedChanged += new System.EventHandler(this.orByte_CheckedChanged);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(443, 160);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 13);
            this.exit.TabIndex = 6;
            this.exit.Text = "Ausgabe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 337);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.orByte);
            this.Controls.Add(this.undByte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton undByte;
        private System.Windows.Forms.RadioButton orByte;
        private System.Windows.Forms.Label exit;
    }
}

