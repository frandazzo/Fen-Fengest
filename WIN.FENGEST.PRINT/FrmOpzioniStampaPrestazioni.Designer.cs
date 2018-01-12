namespace WIN.GUI.PRINT
{
    partial class FrmOpzioniStampaPrestazioni
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
            this.checkBoxDettagliPrestazione = new System.Windows.Forms.CheckBox();
            this.checkBoxStampaElenco = new System.Windows.Forms.CheckBox();
            this.cmdAnnulla = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxDettagliPrestazione
            // 
            this.checkBoxDettagliPrestazione.AutoSize = true;
            this.checkBoxDettagliPrestazione.Location = new System.Drawing.Point(12, 35);
            this.checkBoxDettagliPrestazione.Name = "checkBoxDettagliPrestazione";
            this.checkBoxDettagliPrestazione.Size = new System.Drawing.Size(212, 17);
            this.checkBoxDettagliPrestazione.TabIndex = 13;
            this.checkBoxDettagliPrestazione.Text = "Stampa dettagli prestazione selezionata";
            this.checkBoxDettagliPrestazione.UseVisualStyleBackColor = true;
            // 
            // checkBoxStampaElenco
            // 
            this.checkBoxStampaElenco.AutoSize = true;
            this.checkBoxStampaElenco.Location = new System.Drawing.Point(12, 12);
            this.checkBoxStampaElenco.Name = "checkBoxStampaElenco";
            this.checkBoxStampaElenco.Size = new System.Drawing.Size(150, 17);
            this.checkBoxStampaElenco.TabIndex = 12;
            this.checkBoxStampaElenco.Text = "Stampa elenco perstazioni";
            this.checkBoxStampaElenco.UseVisualStyleBackColor = true;
            // 
            // cmdAnnulla
            // 
            this.cmdAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnulla.Location = new System.Drawing.Point(253, 55);
            this.cmdAnnulla.Name = "cmdAnnulla";
            this.cmdAnnulla.Size = new System.Drawing.Size(62, 27);
            this.cmdAnnulla.TabIndex = 11;
            this.cmdAnnulla.Text = "Annulla";
            this.cmdAnnulla.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(187, 55);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(60, 27);
            this.cmdOk.TabIndex = 10;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // FrmOpzioniStampaPrestazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 94);
            this.Controls.Add(this.checkBoxDettagliPrestazione);
            this.Controls.Add(this.checkBoxStampaElenco);
            this.Controls.Add(this.cmdAnnulla);
            this.Controls.Add(this.cmdOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpzioniStampaPrestazioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opzioni di stampa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDettagliPrestazione;
        private System.Windows.Forms.CheckBox checkBoxStampaElenco;
        internal System.Windows.Forms.Button cmdAnnulla;
        internal System.Windows.Forms.Button cmdOk;
    }
}