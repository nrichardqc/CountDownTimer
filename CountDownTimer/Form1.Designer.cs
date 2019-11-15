namespace CountDownTimer
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.spnMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // spnMinutes
            // 
            this.spnMinutes.Location = new System.Drawing.Point(12, 12);
            this.spnMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMinutes.Name = "spnMinutes";
            this.spnMinutes.Size = new System.Drawing.Size(51, 20);
            this.spnMinutes.TabIndex = 0;
            this.spnMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(69, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start !";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(22, 38);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(200, 73);
            this.lblRemaining.TabIndex = 2;
            this.lblRemaining.Text = "00:00";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(150, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 107);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.spnMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count Down Timer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.spnMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spnMinutes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Button btnPause;
    }
}

