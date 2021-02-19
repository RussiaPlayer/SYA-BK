namespace TheKran
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
            this.pnlMast = new System.Windows.Forms.Panel();
            this.pnlFuss = new System.Windows.Forms.Panel();
            this.pnlArm = new System.Windows.Forms.Panel();
            this.pnlSeil = new System.Windows.Forms.Panel();
            this.btnEnde = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnHakenAuf = new System.Windows.Forms.Button();
            this.btnHakenAb = new System.Windows.Forms.Button();
            this.btnKranRunter = new System.Windows.Forms.Button();
            this.btnKranRauf = new System.Windows.Forms.Button();
            this.btnLoslassen = new System.Windows.Forms.Button();
            this.btnGreifen = new System.Windows.Forms.Button();
            this.trbSchritte = new System.Windows.Forms.TrackBar();
            this.pnlStein = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trbSchritte)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMast
            // 
            this.pnlMast.BackColor = System.Drawing.Color.Coral;
            this.pnlMast.Location = new System.Drawing.Point(400, 300);
            this.pnlMast.Name = "pnlMast";
            this.pnlMast.Size = new System.Drawing.Size(20, 200);
            this.pnlMast.TabIndex = 0;
            // 
            // pnlFuss
            // 
            this.pnlFuss.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFuss.Location = new System.Drawing.Point(335, 500);
            this.pnlFuss.Name = "pnlFuss";
            this.pnlFuss.Size = new System.Drawing.Size(150, 20);
            this.pnlFuss.TabIndex = 1;
            // 
            // pnlArm
            // 
            this.pnlArm.BackColor = System.Drawing.Color.Coral;
            this.pnlArm.Location = new System.Drawing.Point(400, 280);
            this.pnlArm.Name = "pnlArm";
            this.pnlArm.Size = new System.Drawing.Size(150, 20);
            this.pnlArm.TabIndex = 2;
            // 
            // pnlSeil
            // 
            this.pnlSeil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlSeil.Location = new System.Drawing.Point(545, 300);
            this.pnlSeil.Name = "pnlSeil";
            this.pnlSeil.Size = new System.Drawing.Size(4, 50);
            this.pnlSeil.TabIndex = 3;
            // 
            // btnEnde
            // 
            this.btnEnde.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEnde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnde.Location = new System.Drawing.Point(1000, 650);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(170, 40);
            this.btnEnde.TabIndex = 4;
            this.btnEnde.Text = "&Ende";
            this.btnEnde.UseVisualStyleBackColor = false;
            this.btnEnde.Click += new System.EventHandler(this.BtnEnde_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.LightGray;
            this.btnRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechts.Location = new System.Drawing.Point(1000, 130);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(170, 40);
            this.btnRechts.TabIndex = 5;
            this.btnRechts.Text = "&Rechts";
            this.btnRechts.UseVisualStyleBackColor = false;
            this.btnRechts.Click += new System.EventHandler(this.BtnRechts_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.LightGray;
            this.btnLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinks.Location = new System.Drawing.Point(1000, 190);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(170, 40);
            this.btnLinks.TabIndex = 6;
            this.btnLinks.Text = "&Links";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.BtnLinks_Click);
            // 
            // btnHakenAuf
            // 
            this.btnHakenAuf.BackColor = System.Drawing.Color.LightGray;
            this.btnHakenAuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHakenAuf.Location = new System.Drawing.Point(1000, 389);
            this.btnHakenAuf.Name = "btnHakenAuf";
            this.btnHakenAuf.Size = new System.Drawing.Size(170, 40);
            this.btnHakenAuf.TabIndex = 7;
            this.btnHakenAuf.Text = "Haken au&f";
            this.btnHakenAuf.UseVisualStyleBackColor = false;
            this.btnHakenAuf.Click += new System.EventHandler(this.BtnHakenAuf_Click);
            // 
            // btnHakenAb
            // 
            this.btnHakenAb.BackColor = System.Drawing.Color.LightGray;
            this.btnHakenAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHakenAb.Location = new System.Drawing.Point(1000, 449);
            this.btnHakenAb.Name = "btnHakenAb";
            this.btnHakenAb.Size = new System.Drawing.Size(170, 40);
            this.btnHakenAb.TabIndex = 8;
            this.btnHakenAb.Text = "Haken a&b";
            this.btnHakenAb.UseVisualStyleBackColor = false;
            this.btnHakenAb.Click += new System.EventHandler(this.BtnHakenAb_Click);
            // 
            // btnKranRunter
            // 
            this.btnKranRunter.BackColor = System.Drawing.Color.LightGray;
            this.btnKranRunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKranRunter.Location = new System.Drawing.Point(1000, 310);
            this.btnKranRunter.Name = "btnKranRunter";
            this.btnKranRunter.Size = new System.Drawing.Size(170, 40);
            this.btnKranRunter.TabIndex = 10;
            this.btnKranRunter.Text = "R&unter";
            this.btnKranRunter.UseVisualStyleBackColor = false;
            this.btnKranRunter.Click += new System.EventHandler(this.BtnKranRunter_Click);
            // 
            // btnKranRauf
            // 
            this.btnKranRauf.BackColor = System.Drawing.Color.LightGray;
            this.btnKranRauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKranRauf.Location = new System.Drawing.Point(1000, 250);
            this.btnKranRauf.Name = "btnKranRauf";
            this.btnKranRauf.Size = new System.Drawing.Size(170, 40);
            this.btnKranRauf.TabIndex = 9;
            this.btnKranRauf.Text = "R&auf";
            this.btnKranRauf.UseVisualStyleBackColor = false;
            this.btnKranRauf.Click += new System.EventHandler(this.BtnKranRauf_Click);
            // 
            // btnLoslassen
            // 
            this.btnLoslassen.BackColor = System.Drawing.Color.LightGray;
            this.btnLoslassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoslassen.Location = new System.Drawing.Point(1000, 569);
            this.btnLoslassen.Name = "btnLoslassen";
            this.btnLoslassen.Size = new System.Drawing.Size(170, 40);
            this.btnLoslassen.TabIndex = 12;
            this.btnLoslassen.Text = "L&oslassen";
            this.btnLoslassen.UseVisualStyleBackColor = false;
            this.btnLoslassen.Click += new System.EventHandler(this.BtnLoslassen_Click);
            // 
            // btnGreifen
            // 
            this.btnGreifen.BackColor = System.Drawing.Color.LightGray;
            this.btnGreifen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreifen.Location = new System.Drawing.Point(1000, 509);
            this.btnGreifen.Name = "btnGreifen";
            this.btnGreifen.Size = new System.Drawing.Size(170, 40);
            this.btnGreifen.TabIndex = 11;
            this.btnGreifen.Text = "&Zugreifen";
            this.btnGreifen.UseVisualStyleBackColor = false;
            this.btnGreifen.Click += new System.EventHandler(this.BtnGreifen_Click);
            // 
            // trbSchritte
            // 
            this.trbSchritte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.trbSchritte.Location = new System.Drawing.Point(1000, 35);
            this.trbSchritte.Maximum = 50;
            this.trbSchritte.Minimum = 1;
            this.trbSchritte.Name = "trbSchritte";
            this.trbSchritte.Size = new System.Drawing.Size(170, 45);
            this.trbSchritte.TabIndex = 14;
            this.trbSchritte.Value = 5;
            // 
            // pnlStein
            // 
            this.pnlStein.BackColor = System.Drawing.Color.Firebrick;
            this.pnlStein.Location = new System.Drawing.Point(740, 440);
            this.pnlStein.Name = "pnlStein";
            this.pnlStein.Size = new System.Drawing.Size(80, 30);
            this.pnlStein.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pnlStein);
            this.Controls.Add(this.trbSchritte);
            this.Controls.Add(this.btnLoslassen);
            this.Controls.Add(this.btnGreifen);
            this.Controls.Add(this.btnKranRunter);
            this.Controls.Add(this.btnKranRauf);
            this.Controls.Add(this.btnHakenAb);
            this.Controls.Add(this.btnHakenAuf);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.pnlSeil);
            this.Controls.Add(this.pnlArm);
            this.Controls.Add(this.pnlFuss);
            this.Controls.Add(this.pnlMast);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " TheKran";
            ((System.ComponentModel.ISupportInitialize)(this.trbSchritte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMast;
        private System.Windows.Forms.Panel pnlFuss;
        private System.Windows.Forms.Panel pnlArm;
        private System.Windows.Forms.Panel pnlSeil;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnHakenAuf;
        private System.Windows.Forms.Button btnHakenAb;
        private System.Windows.Forms.Button btnKranRunter;
        private System.Windows.Forms.Button btnKranRauf;
        private System.Windows.Forms.Button btnLoslassen;
        private System.Windows.Forms.Button btnGreifen;
        private System.Windows.Forms.TrackBar trbSchritte;
        private System.Windows.Forms.Panel pnlStein;
    }
}

