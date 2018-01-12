namespace WIN.GUI.PRINT
{
    partial class FrmOpzioniStampaAnagraficaAzienda
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
            this.cmdAnnulla = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.checkBoxCompetenzeUltimoPagamento = new System.Windows.Forms.CheckBox();
            this.checkBoxElencoSediOperative = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdAnnulla
            // 
            this.cmdAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnulla.Location = new System.Drawing.Point(253, 55);
            this.cmdAnnulla.Name = "cmdAnnulla";
            this.cmdAnnulla.Size = new System.Drawing.Size(62, 27);
            this.cmdAnnulla.TabIndex = 6;
            this.cmdAnnulla.Text = "Annulla";
            this.cmdAnnulla.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(187, 55);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(60, 27);
            this.cmdOk.TabIndex = 5;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // checkBoxCompetenzeUltimoPagamento
            // 
            this.checkBoxCompetenzeUltimoPagamento.AutoSize = true;
            this.checkBoxCompetenzeUltimoPagamento.Location = new System.Drawing.Point(12, 35);
            this.checkBoxCompetenzeUltimoPagamento.Name = "checkBoxCompetenzeUltimoPagamento";
            this.checkBoxCompetenzeUltimoPagamento.Size = new System.Drawing.Size(204, 17);
            this.checkBoxCompetenzeUltimoPagamento.TabIndex = 9;
            this.checkBoxCompetenzeUltimoPagamento.Text = "Includi competenza ultimo pagamento";
            this.checkBoxCompetenzeUltimoPagamento.UseVisualStyleBackColor = true;
            // 
            // checkBoxElencoSediOperative
            // 
            this.checkBoxElencoSediOperative.AutoSize = true;
            this.checkBoxElencoSediOperative.Location = new System.Drawing.Point(12, 12);
            this.checkBoxElencoSediOperative.Name = "checkBoxElencoSediOperative";
            this.checkBoxElencoSediOperative.Size = new System.Drawing.Size(165, 17);
            this.checkBoxElencoSediOperative.TabIndex = 8;
            this.checkBoxElencoSediOperative.Text = "Includi elenco Sedi Operative";
            this.checkBoxElencoSediOperative.UseVisualStyleBackColor = true;
            // 
            // FrmOpzioniStampaAnagraficaAzienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 94);
            this.Controls.Add(this.checkBoxCompetenzeUltimoPagamento);
            this.Controls.Add(this.checkBoxElencoSediOperative);
            this.Controls.Add(this.cmdAnnulla);
            this.Controls.Add(this.cmdOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOpzioniStampaAnagraficaAzienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opzioni di stampa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAnnulla;
        internal System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.CheckBox checkBoxCompetenzeUltimoPagamento;
        private System.Windows.Forms.CheckBox checkBoxElencoSediOperative;
    }
}