namespace WIN.GUI.PRINT
{
    partial class FrmOpzioniStampaVertenza
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxIncludiElencoEventi = new System.Windows.Forms.CheckBox();
            this.cmdAnnulla = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.checkBoxIncludiIstitutiContrattuali = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxIncludiElencoEventi
            // 
            this.checkBoxIncludiElencoEventi.AutoSize = true;
            this.checkBoxIncludiElencoEventi.Location = new System.Drawing.Point(12, 12);
            this.checkBoxIncludiElencoEventi.Name = "checkBoxIncludiElencoEventi";
            this.checkBoxIncludiElencoEventi.Size = new System.Drawing.Size(124, 17);
            this.checkBoxIncludiElencoEventi.TabIndex = 16;
            this.checkBoxIncludiElencoEventi.Text = "Includi elenco eventi";
            this.checkBoxIncludiElencoEventi.UseVisualStyleBackColor = true;
            // 
            // cmdAnnulla
            // 
            this.cmdAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnulla.Location = new System.Drawing.Point(253, 55);
            this.cmdAnnulla.Name = "cmdAnnulla";
            this.cmdAnnulla.Size = new System.Drawing.Size(62, 27);
            this.cmdAnnulla.TabIndex = 15;
            this.cmdAnnulla.Text = "Annulla";
            this.cmdAnnulla.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(187, 55);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(60, 27);
            this.cmdOk.TabIndex = 14;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // checkBoxIncludiIstitutiContrattuali
            // 
            this.checkBoxIncludiIstitutiContrattuali.AutoSize = true;
            this.checkBoxIncludiIstitutiContrattuali.Location = new System.Drawing.Point(12, 35);
            this.checkBoxIncludiIstitutiContrattuali.Name = "checkBoxIncludiIstitutiContrattuali";
            this.checkBoxIncludiIstitutiContrattuali.Size = new System.Drawing.Size(141, 17);
            this.checkBoxIncludiIstitutiContrattuali.TabIndex = 17;
            this.checkBoxIncludiIstitutiContrattuali.Text = "Includi istituti contrattuali";
            this.checkBoxIncludiIstitutiContrattuali.UseVisualStyleBackColor = true;
            // 
            // FrmOpzioniStampaVertenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 94);
            this.Controls.Add(this.checkBoxIncludiIstitutiContrattuali);
            this.Controls.Add(this.checkBoxIncludiElencoEventi);
            this.Controls.Add(this.cmdAnnulla);
            this.Controls.Add(this.cmdOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpzioniStampaVertenza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opzioni di stampa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIncludiElencoEventi;
        internal System.Windows.Forms.Button cmdAnnulla;
        internal System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.CheckBox checkBoxIncludiIstitutiContrattuali;
    }
}