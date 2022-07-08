namespace Agenda.escolherHora.UC_HoraDisponivel
{
    partial class UcHoraDisponivel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.primeiraHoraLabel = new System.Windows.Forms.Label();
            this.segundaHoraLabel = new System.Windows.Forms.Label();
            this.labelDelimitador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // primeiraHoraLabel
            // 
            this.primeiraHoraLabel.AutoSize = true;
            this.primeiraHoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraHoraLabel.Location = new System.Drawing.Point(41, 2);
            this.primeiraHoraLabel.Name = "primeiraHoraLabel";
            this.primeiraHoraLabel.Size = new System.Drawing.Size(41, 29);
            this.primeiraHoraLabel.TabIndex = 1;
            this.primeiraHoraLabel.Text = "00";
            this.primeiraHoraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.primeiraHoraLabel.Click += new System.EventHandler(this.primeiraHoraLabel_Click);
            // 
            // segundaHoraLabel
            // 
            this.segundaHoraLabel.AutoSize = true;
            this.segundaHoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundaHoraLabel.Location = new System.Drawing.Point(112, 2);
            this.segundaHoraLabel.Name = "segundaHoraLabel";
            this.segundaHoraLabel.Size = new System.Drawing.Size(41, 29);
            this.segundaHoraLabel.TabIndex = 2;
            this.segundaHoraLabel.Text = "00";
            this.segundaHoraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.segundaHoraLabel.Click += new System.EventHandler(this.segundaHoraLabel_Click);
            // 
            // labelDelimitador
            // 
            this.labelDelimitador.AutoSize = true;
            this.labelDelimitador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelimitador.Location = new System.Drawing.Point(84, 0);
            this.labelDelimitador.Name = "labelDelimitador";
            this.labelDelimitador.Size = new System.Drawing.Size(22, 29);
            this.labelDelimitador.TabIndex = 3;
            this.labelDelimitador.Text = "-";
            this.labelDelimitador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDelimitador.Click += new System.EventHandler(this.labelDelimitador_Click);
            // 
            // UcHoraDisponivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelDelimitador);
            this.Controls.Add(this.segundaHoraLabel);
            this.Controls.Add(this.primeiraHoraLabel);
            this.Name = "UcHoraDisponivel";
            this.Size = new System.Drawing.Size(196, 31);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label primeiraHoraLabel;
        private System.Windows.Forms.Label labelDelimitador;

        private System.Windows.Forms.Label segundaHoraLabel;

        #endregion
    }
}
