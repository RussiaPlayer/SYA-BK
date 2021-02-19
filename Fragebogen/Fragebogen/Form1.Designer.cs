namespace Fragebogen
{
    partial class FragebogenFenster
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
            this.rbMännlich = new System.Windows.Forms.RadioButton();
            this.rbWeiblich = new System.Windows.Forms.RadioButton();
            this.cbCsharp = new System.Windows.Forms.CheckBox();
            this.cbCplus = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.Absenden = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fragebogen";
            // 
            // rbMännlich
            // 
            this.rbMännlich.AutoSize = true;
            this.rbMännlich.Location = new System.Drawing.Point(132, 65);
            this.rbMännlich.Name = "rbMännlich";
            this.rbMännlich.Size = new System.Drawing.Size(67, 18);
            this.rbMännlich.TabIndex = 1;
            this.rbMännlich.TabStop = true;
            this.rbMännlich.Text = "Männlich";
            this.rbMännlich.UseVisualStyleBackColor = true;
            // 
            // rbWeiblich
            // 
            this.rbWeiblich.AutoSize = true;
            this.rbWeiblich.Location = new System.Drawing.Point(132, 89);
            this.rbWeiblich.Name = "rbWeiblich";
            this.rbWeiblich.Size = new System.Drawing.Size(65, 18);
            this.rbWeiblich.TabIndex = 2;
            this.rbWeiblich.TabStop = true;
            this.rbWeiblich.Text = "Weiblich";
            this.rbWeiblich.UseVisualStyleBackColor = true;
            // 
            // cbCsharp
            // 
            this.cbCsharp.AutoSize = true;
            this.cbCsharp.BackColor = System.Drawing.Color.White;
            this.cbCsharp.Location = new System.Drawing.Point(112, 143);
            this.cbCsharp.Name = "cbCsharp";
            this.cbCsharp.Size = new System.Drawing.Size(103, 18);
            this.cbCsharp.TabIndex = 3;
            this.cbCsharp.Text = "C# - Kenntnisse";
            this.cbCsharp.UseVisualStyleBackColor = false;
            // 
            // cbCplus
            // 
            this.cbCplus.AutoSize = true;
            this.cbCplus.Location = new System.Drawing.Point(112, 168);
            this.cbCplus.Name = "cbCplus";
            this.cbCplus.Size = new System.Drawing.Size(109, 18);
            this.cbCplus.TabIndex = 4;
            this.cbCplus.Text = "C++ - Kenntnisse";
            this.cbCplus.UseVisualStyleBackColor = true;
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(112, 193);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(113, 18);
            this.cbJava.TabIndex = 5;
            this.cbJava.Text = "Java - Kenntnisse";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // Absenden
            // 
            this.Absenden.BackColor = System.Drawing.Color.Gainsboro;
            this.Absenden.FlatAppearance.BorderSize = 0;
            this.Absenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Absenden.Location = new System.Drawing.Point(132, 291);
            this.Absenden.Name = "Absenden";
            this.Absenden.Size = new System.Drawing.Size(75, 25);
            this.Absenden.TabIndex = 6;
            this.Absenden.Text = "Absenden";
            this.Absenden.UseVisualStyleBackColor = false;
            this.Absenden.Click += new System.EventHandler(this.Absenden_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Gainsboro;
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Location = new System.Drawing.Point(262, 447);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 25);
            this.Quit.TabIndex = 7;
            this.Quit.Text = "Beenden";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // FragebogenFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 485);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Absenden);
            this.Controls.Add(this.cbJava);
            this.Controls.Add(this.cbCplus);
            this.Controls.Add(this.cbCsharp);
            this.Controls.Add(this.rbWeiblich);
            this.Controls.Add(this.rbMännlich);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FragebogenFenster";
            this.Text = "Fragebogen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMännlich;
        private System.Windows.Forms.RadioButton rbWeiblich;
        private System.Windows.Forms.CheckBox cbCsharp;
        private System.Windows.Forms.CheckBox cbCplus;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.Button Absenden;
        private System.Windows.Forms.Button Quit;
    }
}

